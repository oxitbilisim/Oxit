using AutoMapper;
using AutoMapper.QueryableExtensions;
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
        private readonly IMapper mapper;
        public BaseService(CommonDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public T? Get(int id)
        {
            return db.Set<T>().Find(id);
        }
        public T? Get(long id)
        {
            return db.Set<T>().Find(id);
        }
        public T? Get(Guid id)
        {
            return db.Set<T>().Find(id);
        }
        public M? Get<M>(int id) where M : class
        {
            return mapper.Map<M>(db.Set<T>().Find(id));
        }
        public M? Get<M>(long id) where M : class
        {
            return mapper.Map<M>(db.Set<T>().Find(id));
        }
        public M? Get<M>(Guid id) where M : class
        {
            return mapper.Map<M>(db.Set<T>().Find(id));
        }
        public virtual IQueryable<T> GetAll()
        {

            return db.Set<T>();
        }
        public virtual IEnumerable<M> GetAll<M>() where M : class
        {

            return db.Set<T>().ProjectTo<M>(mapper.ConfigurationProvider);
        }
        public IQueryable<T> GetAll(int page)
        {
            return this.GetAll().Skip((page - 1) * page).Take(10);
        }
        public IEnumerable<M> GetAll<M>(int page) where M : class
        {
            return this.GetAll<M>().Skip((page - 1) * page).Take(10);
        }
    }
}
