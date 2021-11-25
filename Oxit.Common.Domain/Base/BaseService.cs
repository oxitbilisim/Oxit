using Oxit.Common.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Common.Domain.Base
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly CommonDbContext db;

        public BaseService(CommonDbContext db)
        {
            this.db = db;
        }

        public virtual IQueryable<T> GetAll()
        {
            return db.Set<T>();
        }
    }
}
