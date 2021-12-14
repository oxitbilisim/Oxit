
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Oxit.Core.Utilities;
using Oxit.DataAccess.EntityFramework;
using Oxit.Scheduling.Core;
using Quartz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Oxit.Scheduling.Jobs
{
    //her aksam saat 23
    [DisallowConcurrentExecution, JobConfig("JobLogCleanup", "0 0 23 1/1 * ? *", false)]
    public class JobLogCleanup : IJob
    {
        private appDbContext appDbContext;

        public JobLogCleanup(
            appDbContext appDbContext
            )
        {
            this.appDbContext = appDbContext;

        }
        public Task Execute(IJobExecutionContext context)
        {
            try
            {
                int logDays = -5;

                Console.WriteLine("JobLogCleanup: Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine("JobLogCleanup: " + ex.GetInner());

            }


            return Task.CompletedTask;
        }
    }
}
