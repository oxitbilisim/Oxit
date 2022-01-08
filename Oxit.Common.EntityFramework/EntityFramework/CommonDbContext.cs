using Microsoft.EntityFrameworkCore;
using Oxit.Common.DataAccess.FluentMapping;
using Oxit.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Common.DataAccess.EntityFramework
{
    public class CommonDbContext : BaseAppDbContext
    {
        public CommonDbContext()
             : base()
        {

        }


        public CommonDbContext(DbContextOptions options)
           : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            MapperPerson.Initialize(builder);
            base.OnModelCreating(builder);
        }

        public virtual DbSet<Person> Person { get; set; }
    }
}
