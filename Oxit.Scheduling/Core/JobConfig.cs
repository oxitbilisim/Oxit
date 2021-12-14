using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oxit.Scheduling.Core
{
    public class JobConfig : Attribute
    {
        private JobPeriod jobPeriod;
        private int every;
        private string name;
        private string cron;
        private bool enable;
        public JobConfig(string name, JobPeriod jobPeriod, int every, bool enable = true)
        {
            this.jobPeriod = jobPeriod;
            this.every = every;
            this.name = name;
            this.enable = enable;
        }

        public JobConfig(string name, string cron, bool enable = true)
        {
            this.jobPeriod = JobPeriod.Cron;
            this.name = name;
            this.cron = cron;
            this.enable = enable;
        }

        public virtual JobPeriod JobPeriod
        {
            get { return jobPeriod; }
        }
        public virtual int Every
        {
            get { return every; }
        }
        public virtual string Name
        {
            get { return name; }
        }
        public virtual string Cron
        {
            get { return cron; }
        }
        public virtual bool Enable
        {
            get { return enable; }
        }
    }
}
