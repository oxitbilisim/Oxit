using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Common.Domain.Base
{
    public interface IBaseService<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(int page);
        IEnumerable<M> GetAll<M>() where M : class;
        IEnumerable<M> GetAll<M>(int page) where M : class;
        T? Get(int id);
        T? Get(long id);
        T? Get(Guid id);
        M? Get<M>(int id) where M : class;
        M? Get<M>(long id) where M : class;
        M? Get<M>(Guid id) where M : class;


        int Add(T model);
        int Update(T model);


        int Delete(int id);
        int Delete(long id);
        int Delete(Guid id);


    }
}
