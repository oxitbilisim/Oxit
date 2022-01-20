
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

namespace Oxit.Scheduling.Jobs
{
    [DisallowConcurrentExecution, JobConfig("JobGetDataFromZirve", JobPeriod.Hour, 1, true)]
    public class JobGetDataFromZirve : IJob
    {
        private appDbContext appDbContext;
        private readonly IConfiguration configuration;
        private readonly TeknoparkContext teknoparkContext;
        public JobGetDataFromZirve(
            appDbContext appDbContext,
            IConfiguration configuration,
            TeknoparkContext teknoparkContext

            )
        {
            this.appDbContext = appDbContext;
            this.configuration = configuration;
            this.teknoparkContext = teknoparkContext;
        }
        public Task Execute(IJobExecutionContext context)
        {
            //cari
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
            Console.WriteLine("JobTestEveryMinute: done");
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
            foreach (var yevmiye in teknoparkContext.Yevmiyes.Where(c => c.Gmkod == cari.Kod).ToList())
            {
                var fis = appDbContext.Fis.FirstOrDefault(c => c.Tarih == yevmiye.Fistar && c.FisTur == yevmiye.Fistur && c.YevNo == yevmiye.Yevno && c.FisNo == yevmiye.Fisno);
                if (fis == null)
                {
                    FisEkle(yevmiye, cr);
                }
                else
                {
                    FisEkleGuncelle(fis, yevmiye);
                }
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
            foreach (var yevmiye in teknoparkContext.Yevmiyes.Where(c => c.Gmkod == cari.Kod).ToList())
            {
                var fis = appDbContext.Fis.FirstOrDefault(c => c.Tarih == yevmiye.Fistar && c.FisTur == yevmiye.Fistur && c.YevNo == yevmiye.Yevno && c.FisNo == yevmiye.Fisno);
                if (fis == null)
                {
                    FisEkle(yevmiye, hesapplani);
                }
                else
                {
                    FisEkleGuncelle(fis, yevmiye);
                }
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
