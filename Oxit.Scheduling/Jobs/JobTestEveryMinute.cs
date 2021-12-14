
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
    [DisallowConcurrentExecution, JobConfig("JobTestEveryMinute", JobPeriod.Minute, 1, false)]
    public class JobTestEveryMinute : IJob
    {
        private appDbContext appDbContext;
        public JobTestEveryMinute(
            appDbContext appDbContext
            )
        {
            this.appDbContext = appDbContext;

        }
        public Task Execute(IJobExecutionContext context)
        {

            Console.WriteLine("JobTestEveryMinute: done");
            return Task.CompletedTask;
        }
    }
}
