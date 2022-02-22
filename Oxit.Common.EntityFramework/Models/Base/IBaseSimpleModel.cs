using System;

namespace Oxit.Common.Models.Base
{
    public interface IBaseSimpleModel<T>
    {
        T Id { get; set; }
        DateTime? CreateDate { get; set; }
     
    }
}
