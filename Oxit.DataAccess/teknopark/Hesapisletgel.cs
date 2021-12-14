using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class Hesapisletgel
    {
        public string Kod { get; set; } = null!;
        public string? Anakod { get; set; }
        public string? Aciklama { get; set; }
        public double? Kdvor { get; set; }
        public string? Stokkodu { get; set; }
        public string? Detay { get; set; }
        public string Gelorgid { get; set; } = null!;
        public double? Deg1 { get; set; }
        public double? Deg2 { get; set; }
        public double? Deg3 { get; set; }
        public double? Deg4 { get; set; }
        public string? BelgeTuru { get; set; }
        public string? SatisTuru { get; set; }
        public string? KayitTuru { get; set; }
        public string? KayitAltTuru { get; set; }
        public string? StopajKodu { get; set; }
        public double? StopajOrani { get; set; }
        public string? IstisnaKodu { get; set; }
        public double? IstisnaOrani { get; set; }
        public string? TevkifatKodu { get; set; }
        public string? TamIstisnaKodu { get; set; }
        public bool? KdvsizIslem { get; set; }
    }
}
