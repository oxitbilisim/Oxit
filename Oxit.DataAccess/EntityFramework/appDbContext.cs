using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Oxit.Common.DataAccess.EntityFramework;
using Oxit.Core.Enums;
using Oxit.Domain.Models;

namespace Oxit.DataAccess.EntityFramework
{

    public partial class appDbContext : CommonDbContext
    {
        public appDbContext()
             : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Fis> Fis { get; set; }
        public virtual DbSet<HesapPlani> HesapPlani { get; set; }
        public virtual DbSet<Kira> Kira { get; set; }
    }
}

