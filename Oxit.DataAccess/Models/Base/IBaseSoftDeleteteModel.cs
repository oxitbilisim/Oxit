using System;

namespace Oxit.Common.Models.Base
{
    public interface IBaseSoftDeleteteModel<T> : IBaseFullModel<T>
    {
        DateTime? DeleteDate { get; set; }
        bool IsDeleted { get; set; }
    }
}
