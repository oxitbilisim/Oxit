using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Oxit.DataAccess.EntityFramework
{

    public partial class appDbContext : baseAppDbContext
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

