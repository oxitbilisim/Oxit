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

    }
}
