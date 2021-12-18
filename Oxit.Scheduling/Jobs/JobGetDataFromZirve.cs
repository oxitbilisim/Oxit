
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
    [DisallowConcurrentExecution, JobConfig("JobGetDataFromZirve", JobPeriod.Minute, 5, true)]
    public class JobGetDataFromZirve : IJob
    {
        private appDbContext appDbContext;
        private readonly IConfiguration configuration;
        private readonly TeknoparkContext db2021;

        public JobGetDataFromZirve(
            appDbContext appDbContext,
            IConfiguration configuration

            )
        {
            this.appDbContext = appDbContext;
            this.configuration = configuration;
            var ss = configuration.GetSection("cn2021").Value;
            db2021 = new TeknoparkContext(configuration.GetSection("cn2021").Value);
        }
        public Task Execute(IJobExecutionContext context)
        {

            //cari
            foreach (var cari in db2021.Hesplans.Where(c => c.Kod.StartsWith("120 ")).ToList())
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

            foreach (var yevmiye in db2021.Yevmiyes.Where(c => c.Gmkod == cari.Kod).ToList())
            {
                var fis = appDbContext.Fis.FirstOrDefault(c => c.Tarih == yevmiye.Fistar && c.FisTur == yevmiye.Fistur && c.YevNo == yevmiye.Yevno && c.FisNo == yevmiye.Fisno);
                if (fis == null)
                {
                    FisEkle(yevmiye, hesapplani);
                }
                else
                {
                    FisEkleGuncelle(yevmiye, hesapplani);
                }
            }
            appDbContext.SaveChanges();

            return hesapplani.Id;
        }
        private int FisEkle(Yevmiye yevmiye, HesapPlani hesapPlani)
        {


            var Fis = new Fis()
            {

            };
            appDbContext.Fis.Add(new Fis
            {
                Aciklama = yevmiye.Aciklama,
                FisTur = yevmiye.Fistur,
                Borc = yevmiye.Borclu,
                Alacak = yevmiye.Alacakli,
                FisNo= yevmiye.Fisno,
               Tarih= yevmiye.Fistar,
               YevNo= yevmiye.Yevno,

            });
            return default;
        }
        private int FisEkleGuncelle(Yevmiye yevmiye, HesapPlani hesapPlani)
        {
            return default;
        }
    }
}
