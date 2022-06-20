using Oxit.Common.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Domain.Models
{
    public class FisAlacakDetay : BaseSimpleModel<int>
    {
        public int FisId { get; set; }
        public DateTime? Tarih { get; set; }
     
        public Double? OdemeTutari { get; set; }
        public Double? GecikmeTutari { get; set; }
      
        [ForeignKey("FisId")]
        public virtual Fis Fis { get; set; }

    }
}
