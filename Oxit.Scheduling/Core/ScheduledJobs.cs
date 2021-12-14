using Microsoft.Extensions.DependencyInjection;
using Quartz;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Oxit.Scheduling.Core
{
    public static class ScheduledJobs
    {
        public static IServiceCollection AddScheduledJobs(this IServiceCollection services)
        {

            QuartzHelper.CheckDatabase();
            services.AddQuartz(q =>
            {
                //var properties = new NameValueCollection
                //{
                //    ["quartz.jobStore.type"] = "Quartz.Impl.AdoJobStore.JobStoreTX, Quartz",
                //    ["quartz.jobStore.driverDelegateType"] = "Quartz.Impl.AdoJobStore.StdAdoDelegate, Quartz",
                //    ["quartz.jobStore.tablePrefix"] = "[quartz].",
                //    ["quartz.jobStore.dataSource"] = "default",
                //    ["quartz.dataSource.default.connectionString"] = Settings.Database.ConnectionString,
                //    ["quartz.dataSource.default.provider"] = "SqlServer",
                //    ["quartz.serializer.type"] = "json",
                //    ["quartz.jobStore.useProperties"] = "true"
                //};

                //for (int i = 0; i < properties.Count; i++)
                //{

                //    q.SetProperty(properties.AllKeys[i], properties.GetValues(i)[0]);
                //}

                q.UseMicrosoftDependencyInjectionJobFactory(options =>
                {
                    options.AllowDefaultConstructor = true;
                });

                q.UseMicrosoftDependencyInjectionScopedJobFactory();


                var joblist = Assembly.GetExecutingAssembly().GetTypes()
                      .Where(t => t.Namespace == "Altay.Jobs.Jobs" && t.GetInterfaces().Any(c => c.Name == "IJob"))
                      .ToList();

                foreach (Type job in joblist)
                {
                    var jobconfig = job.GetCustomAttribute<JobConfig>();
                    if (jobconfig.Enable)
                    {
                        var jobKey = new JobKey(jobconfig.Name);
                        var method = typeof(ServiceCollectionExtensions).GetMethods().Where(c => c.Name.Contains("AddJob")).ToList()[1];
                        var tt = method.GetParameters();
                        MethodInfo generic = method.MakeGenericMethod(job);
                        generic.Invoke(q, new object[] { q, jobKey, null });
                        q.AddTrigger(opts =>
                        {
                            if (jobconfig.JobPeriod != JobPeriod.Cron)
                            {
                                opts
                                  .ForJob(jobKey)
                                  .WithIdentity(jobKey + "-trigger").WithSimpleSchedule(x =>
                                  {
                                      switch (jobconfig.JobPeriod)
                                      {
                                          case JobPeriod.Second:
                                              x.WithIntervalInSeconds(jobconfig.Every).RepeatForever();
                                              break;
                                          case JobPeriod.Minute:
                                              x.WithIntervalInMinutes(jobconfig.Every).RepeatForever();
                                              break;
                                          case JobPeriod.Hour:
                                              x.WithIntervalInHours(jobconfig.Every).RepeatForever();
                                              break;
                                          case JobPeriod.Day:
                                              x.WithIntervalInHours(jobconfig.Every * 24).RepeatForever();
                                              break;
                                          case JobPeriod.Week:
                                              x.WithIntervalInHours(jobconfig.Every * 168).RepeatForever();
                                              break;
                                          case JobPeriod.Mounth:
                                              x.WithIntervalInHours(jobconfig.Every * 730).RepeatForever();
                                              break;
                                          case JobPeriod.Year:
                                              x.WithIntervalInHours(jobconfig.Every * 8760).RepeatForever();
                                              break;

                                      }
                                  });
                            }
                            else
                            {
                                ;
                                opts
                                     .ForJob(jobKey)
                                     .WithIdentity(jobKey + "-trigger").WithCronSchedule(jobconfig.Cron);

                            }


                        });
                    }

                }
            });
            services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);
            return services;
        }
    }
}
