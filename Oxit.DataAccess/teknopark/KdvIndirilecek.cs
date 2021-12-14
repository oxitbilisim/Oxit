using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class KdvIndirilecek
    {
        public short? Ayindex { get; set; }
        public int Arti { get; set; }
        public DateTime? FaturaTarihi { get; set; }
        public string? FaturaNo { get; set; }
        public string? Soyadi { get; set; }
        public string? Adi { get; set; }
        public string? Tckimlikno { get; set; }
        public string? Vergino { get; set; }
        public string? Cinsi { get; set; }
        public double? Miktar { get; set; }
        public double? Tutar { get; set; }
        public double? Kdv { get; set; }
    }
}
