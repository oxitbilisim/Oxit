using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oxit.Common.Models.Base
{
    public class BaseSoftDeleteteModel<T> : IBaseSoftDeleteteModel<T>
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public Guid? CreatorId { get; set; }
        public DateTime? EditDate { get; set; }
        public Guid? EditorId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeleteDate { get; set; }
        public bool Active { get; set; } = true;
    }
}
