﻿
using Oxit.DataAccess.EntityFramework;
using Oxit.DataAccess.teknopark;
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
        private readonly Teknopark2021Context db2021;
        private readonly Teknopark2021Context db2020;
        public JobGetDataFromZirve(
            appDbContext appDbContext,
            IConfiguration configuration

            )
        {
            this.appDbContext = appDbContext;
            this.configuration = configuration;
            var ss = configuration.GetSection("cn2021").Value;
            db2021 = new Teknopark2021Context(configuration.GetSection("cn2021").Value);
            // db2020 = new Teknopark2021Context(configuration.GetSection("cn2020").Value);
        }
        public Task Execute(IJobExecutionContext context)
        {

            //cari
            foreach (var cari in db2021.Hesplans.Where(c => c.Kod.StartsWith("120 ")).ToList())
            {

                if (!appDbContext.Cari.Any(c => c.DbKey == cari.Kod))
                {
                    appDbContext.Cari.Add(new Domain.Models.Cari
                    {
                        DbKey = cari.Kod,
                        Ad = cari.Aciklama,
                        Kod = cari.Kod,
                        Aktif = true,
                        SonCekilmeTarihi = DateTime.Now

                    });
                }
                else
                {
                    var cr = appDbContext.Cari.FirstOrDefault(c => c.DbKey == cari.Kod);

                    if (cr != null)
                    {
                        cr.DbKey = cari.Kod;
                        cr.Ad = cari.Aciklama;
                        cr.Kod = cari.Kod;
                        cr.Aktif = true;
                        cr.SonCekilmeTarihi = DateTime.Now;
                    }
                }

                appDbContext.SaveChanges();

            }
            Console.WriteLine("JobTestEveryMinute: done");
            return Task.CompletedTask;
        }
    }
}