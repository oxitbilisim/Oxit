using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class Stopajlar
    {
        public string? Soyadi { get; set; }
        public string? Adi { get; set; }
        public string? Vkn { get; set; }
        public string? Tk { get; set; }
        public double? Gst { get; set; }
        public double? Kt { get; set; }
        public string? Adres { get; set; }
        public DateTime? Tarbas { get; set; }
        public DateTime? Tarbit { get; set; }
        public short? Sube { get; set; }
        public short Sirano { get; set; }
        public string? Tckimlikno { get; set; }
        public string? Ehust { get; set; }
        public string? Ehalt { get; set; }
        public string? Evrakno { get; set; }
        public short? KdvTevkifatKodu { get; set; }
        public short? Belgeturu { get; set; }
    }
}
