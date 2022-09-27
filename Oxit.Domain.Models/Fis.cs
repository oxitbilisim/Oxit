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
         public int FisBorcId { get; set; }
        public DateTime? Tarih { get; set; }
        public string? FisTur { get; set; }
        public string? FisNo { get; set; }
        public int? YevNo { get; set; }
        public string? Aciklama { get; set; }
        public Double? Borc { get; set; }
        public Double? Alacak { get; set; }
        public Double? GecikmeTutari { get; set; }
        public int  GecikmeGunu { get; set; }
        public bool Odendi { get; set; }
        public Double? GeciktirilenTutar { get; set; }
        public Double? GeciktirilenAnaFaizTutar { get; set; }
        public DateTime? SonHesaplananGecikmeTarihi { get; set; }
        public Double? ZamanindaOdenenTutar { get; set; }
        public DateTime? ZamanindaOdemeTarihi { get; set; }
        public Double? KalanTutar { get; set; }
        public FisTip? FisTip { get; set; }
        public int? GecikmeFisId { get; set; }
        public int? RefNo { get; set; }
        public string? EkAciklama { get; set; }
        public int? RefNo2 { get; set; }
        public Double? OdenenBorcTutar { get; set; }
        public Double? OdenenGecikmeTutar { get; set; }
        public Double? KalanAlacakTutar { get; set; }
        public Double? KalanGecikmeTutar { get; set; }
        public Double? KalanBorcTutar { get; set; }

        [ForeignKey("HesapPlaniId")]
        public virtual HesapPlani HesapPlani { get; set; }

    }
}
