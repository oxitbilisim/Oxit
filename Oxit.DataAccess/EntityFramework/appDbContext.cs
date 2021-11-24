using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Oxit.Common.DataAccess.EntityFramework;

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
    }
}

