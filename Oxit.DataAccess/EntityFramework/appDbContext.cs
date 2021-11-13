using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Oxit.DataAccess.EntityFramework
{

    public partial class appDbContext : baseAppDbContext
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public appDbContext(IHttpContextAccessor _contextAccessor, DbContextOptions<baseAppDbContext> options)
            : base(_contextAccessor, options)
        {
            this._contextAccessor = _contextAccessor;
        }

        //public virtual DbSet<d> Ds;
    }
}

