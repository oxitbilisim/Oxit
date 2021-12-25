using Oxit.Common.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Domain.Models
{
    public class Fis : BaseSimpleModel<int>
    {
        public string? DbKey { get; set; }
        public int HesapPlaniId { get; set; }
        public DateTime? Tarih { get; set; }
        public string? FisTur { get; set; }
        public string? FisNo { get; set; }
        public int? YevNo { get; set; }
        public string? Aciklama { get; set; }
        public Double? Borc { get; set; }
        public Double? Alacak { get; set; }
        public Double? GecikmeTutari { get; set; }
        public DateTime? SonHesaplananGecikmeTarihi { get; set; }
        public Double? ZamanindaOdenenTutar { get; set; }
        public DateTime? ZamanindaOdemeTarihi { get; set; }
        public Double? KalanTutar { get; set; }
        public FisTip? FisTip { get; set; }

        [ForeignKey("HesapPlaniId")]
        public virtual HesapPlani HesapPlani { get; set; }

    }
}
