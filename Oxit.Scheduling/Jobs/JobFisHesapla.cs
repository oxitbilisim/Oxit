
using Oxit.DataAccess.EntityFramework;
using Oxit.DataAccess.teknopark;
using Oxit.Domain;
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
    [DisallowConcurrentExecution, JobConfig("JobFisHesapla", JobPeriod.Hour, 1, true)]

    public class JobFisHesapla : IJob
    {
        private appDbContext appDbContext;
        private readonly IConfiguration configuration;
        private readonly TeknoparkContext teknoparkContext;
        private readonly HesapPlaniService _hesapPlaniService;
        public JobFisHesapla(
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
            // foreach (var cari in teknoparkContext.Hesplans.Where(c => c.Kod.StartsWith("120 ")).ToList())
            // {
            //  _hesapPlaniService.AlacaksizGecikmeHesapla(cari.Kod);
            //  _hesapPlaniService.GecikmeleriHesapla(cari.Kod);
            // }
            return Task.CompletedTask;
        }
        
    }
}
