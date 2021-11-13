using System;

namespace Oxit.Common.Models.Base
{
    public interface IBaseFullModel<T>
    {
        T Id { get; set; }
        DateTime? CreateDate { get; set; }
        Guid? CreatorId { get; set; }
        DateTime? EditDate { get; set; }
        DateTime? DeleteDate { get; set; }
        Guid? EditorId { get; set; }
        bool IsDeleted { get; set; }
        bool Active { get; set; }
    }
}
