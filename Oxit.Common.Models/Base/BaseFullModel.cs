using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oxit.Common.Models.Base
{
    public class BaseFullModel<T> : IBaseFullModel<T>
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public Guid? CreatorId { get; set; }
        public DateTime? EditDate { get; set; }
        public Guid? EditorId { get; set; }
        
    }
}
