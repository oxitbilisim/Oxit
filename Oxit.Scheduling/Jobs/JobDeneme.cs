
using Oxit.DataAccess.EntityFramework;
using Oxit.Scheduling.Core;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Oxit.Scheduling.Jobs
{
    [DisallowConcurrentExecution, JobConfig("DenemeJob", JobPeriod.Minute, 1, true)]
    public class JobDeneme : IJob
    {
        private appDbContext appDbContext;
        public JobDeneme(
            appDbContext appDbContext
            )
        {
            this.appDbContext = appDbContext;

        }
        public Task Execute(IJobExecutionContext context)
        {

            Console.WriteLine("DenemeJob: done");
            return Task.CompletedTask;
        }
    }
}
