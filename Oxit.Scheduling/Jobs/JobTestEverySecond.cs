
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
    [DisallowConcurrentExecution, JobConfig("JobTestEverySecond", "0/1 * * * * ?", false)]
    public class JobTestEverySecond : IJob
    {
        private appDbContext appDbContext;
        public JobTestEverySecond(
            appDbContext appDbContext
            )
        {
            this.appDbContext = appDbContext;

        }
        public Task Execute(IJobExecutionContext context)
        {

            Console.WriteLine("JobTestEverySecond: done");
            return Task.CompletedTask;
        }
    }
}
