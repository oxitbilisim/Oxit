
using Oxit.DataAccess.EntityFramework;
using Oxit.DataAccess.teknopark;
using Oxit.Domain.Models;
using Oxit.Scheduling.Core;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Oxit.Domain;

namespace Oxit.Scheduling.Jobs
{
    [DisallowConcurrentExecution, JobConfig("JobGetDataFromZirve", JobPeriod.Hour, 8, true)]
    public class JobGetDataFromZirve : IJob
    {
        private appDbContext appDbContext;
        private readonly IConfiguration configuration;
        private readonly TeknoparkContext teknoparkContext;
        private readonly HesapPlaniService _hesapPlaniService;
        private DateTime? fisAktarilansonTarih;
        public JobGetDataFromZirve(
            appDbContext appDbContext,
            IConfiguration configuration,
            TeknoparkContext teknoparkContext,
            HesapPlaniService hesapPlaniService

            )
        {
            this.appDbContext = appDbContext;
            this.configuration = configuration;
            this.teknoparkContext = teknoparkContext;
            _hesapPlaniService= hesapPlaniService;
        }
        public Task Execute(IJobExecutionContext context)
        {
            //cari
            fisAktarilansonTarih = appDbContext.Fis?.OrderBy(x=> x.Tarih).LastOrDefault()?.Tarih;
            
            foreach (var cari in teknoparkContext.Hesplans.Where(c => c.Kod.StartsWith("120 ")).ToList())
            {
                if (!appDbContext.HesapPlani.Any(c => c.DbKey == cari.Kod))
                {
                    HesapplaniEkle(cari);
                }
                 else
                 {
                     HesapplaniGuncelle(cari);
                 }
                appDbContext.SaveChanges();
            }
            Console.WriteLine("Hesaplar Aktarıldı: done");
            
            if (appDbContext.Fis?.Where(x=> x.FisTur == "0").ToList().Count() <= 5)
            foreach (var yevmiye in teknoparkContext.Yevmiyes.Where(c => c.Fistar == new DateTime(2022,1,1)).ToList())
            {
                var cr = appDbContext.HesapPlani.Where(c => c.DbKey == yevmiye.Gmkod).FirstOrDefault();
            
                if (cr!= null )
                    FisEkle(yevmiye, cr);
            }
            
            Console.WriteLine("Acilis Fisi Aktarıldı: done");
            
            
            
            var lst = appDbContext.HesapPlani.Where(x=> x.Aktif).ToList();
            
            foreach (var item in lst)
            {
                var borc = appDbContext.Fis.Where(x=> x.HesapPlaniId == item.Id && x.Tarih <= new DateTime(2022,06,30) ).Sum(x=> x.Borc);
                var alacak = appDbContext.Fis.Where(x=> x.HesapPlaniId == item.Id && x.Tarih <= new DateTime(2022,06,30)).Sum(x=> x.Alacak);
                
                if (item != null ) 
                { 
                    if (!appDbContext.Fis.Where(x=> x.HesapPlaniId == item.Id && x.FisTur == "6").Any())
                    {  
                    var Fis = new Fis
                    {
                        Aciklama = "Yıl Sonu Bakiye",
                        FisTur = "6",
                        Borc = borc > alacak ? borc - alacak : 0,
                        Alacak = alacak > borc ? alacak: 0,
                        FisNo = "9999",
                        Tarih = new DateTime(2022,06,30) ,
                        YevNo = 9999,
                        HesapPlaniId = item.Id
                    };
                appDbContext.Fis.Add(Fis);
                appDbContext.SaveChanges();
                    }
                }
            }
            Console.WriteLine("Haziran Sonu Bakiye Bilgileri Aktarıldı : done");
            
            foreach (var cari in teknoparkContext.Hesplans.Where(c => c.Kod.StartsWith("120 ")).ToList())
            {
                _hesapPlaniService.GecikmeleriHesaplaBakiye(cari.Kod);
                _hesapPlaniService.GecikmeleriHesapla(cari.Kod);
            } 
            Console.WriteLine("Gecikmeler Hesaplandı.");
            
            
            
            
            return Task.CompletedTask;
        }
        private int HesapplaniGuncelle(Hesplan cari)
        {
            var cr = appDbContext.HesapPlani.FirstOrDefault(c => c.DbKey == cari.Kod);
            if (cr != null)
            {
                cr.DbKey = cari.Kod;
                cr.Ad = cari.Aciklama;
                cr.Kod = cari.Kod;
                cr.Aktif = true;
                cr.SonCekilmeTarihi = DateTime.Now;
            }
            appDbContext.SaveChanges();
            
            foreach (var yevmiye in teknoparkContext.Yevmiyes.Where(c => c.Gmkod == cari.Kod 
                                                                         && c.Fistur == "3"
                                                                         && c.Fistar >= fisAktarilansonTarih).ToList())
            {
                FisEkle(yevmiye, cr);
            }
            return cr.Id;
        }
        private int HesapplaniEkle(Hesplan cari)
        {
            var hesapplani = new Domain.Models.HesapPlani
            {
                DbKey = cari.Kod,
                Ad = cari.Aciklama,
                Kod = cari.Kod,
                Aktif = true,
                SonCekilmeTarihi = DateTime.Now
            };
            appDbContext.HesapPlani.Add(hesapplani);
            appDbContext.SaveChanges();
            
            foreach (var yevmiye in teknoparkContext.Yevmiyes.Where(c => c.Gmkod == cari.Kod 
                                                                         && c.Fistur == "3"
                                                                         && c.Fistar >= (fisAktarilansonTarih ?? DateTime.Now.AddYears(-2))
                                                                         ).ToList())
            {
                FisEkle(yevmiye, hesapplani);
            }
            return hesapplani.Id;
        }
        private int FisEkle(Yevmiye yevmiye, HesapPlani hesapPlani)
        {
            var Fis = new Fis
            {
                Aciklama = yevmiye.Aciklama,
                FisTur = yevmiye.Fistur,
                Borc = yevmiye.Borclu,
                Alacak = yevmiye.Alacakli,
                FisNo = yevmiye.Fisno,
                Tarih = yevmiye.Fistar,
                YevNo = yevmiye.Yevno,
                HesapPlaniId = hesapPlani.Id
            };
            appDbContext.Fis.Add(Fis);
            appDbContext.SaveChanges();
            return Fis.Id;
        }
        private int FisEkleGuncelle(Fis fis, Yevmiye yevmiye)
        {
            fis.FisTur = yevmiye.Fistur;
            fis.FisNo = yevmiye.Fisno;
            fis.FisTur = yevmiye.Fistur;
            fis.Alacak = yevmiye.Alacakli;
            fis.Borc = yevmiye.Borclu;
            fis.Tarih = yevmiye.Fistar;
            fis.YevNo = yevmiye.Yevno;

            appDbContext.SaveChanges();
            return fis.Id;
        }
    }
}
