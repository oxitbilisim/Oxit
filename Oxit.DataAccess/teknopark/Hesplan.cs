using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class Hesplan
    {
        public string Kod { get; set; } = null!;
        public string? Kod2 { get; set; }
        public string? Aciklama { get; set; }
        public string? Detay { get; set; }
        public double? Topb { get; set; }
        public double? Topa { get; set; }
        public string? Ba1 { get; set; }
        public string? Ba2 { get; set; }
        public string? Ba3 { get; set; }
        public string? Tckimlikno { get; set; }
        public string? Vergikimlikno { get; set; }
        public string? Kamuorozel { get; set; }
        public string? Yabanci { get; set; }
        public string? Stokkodu { get; set; }
        public string? Vergidairesi { get; set; }
        public string? Blerdekullan { get; set; }
        public string? Ulkekodu { get; set; }
        public string? Grup { get; set; }
        public string? Kurfarkindakullan { get; set; }
        public string? TevHesKodu { get; set; }
        public string? TevOrani { get; set; }
        public string? TevTurKodu { get; set; }
        public double? StopajOrani { get; set; }
        public string? StopajTurKodu { get; set; }
        public string? StopajHesKodu { get; set; }
        public int Arti { get; set; }
        public short? StopajEvrakTuru { get; set; }
        public string? IlaveEdilecekKdvmi { get; set; }
        public string? IadeKdvmi { get; set; }
        public string? KrediKartiSatisimi { get; set; }
        public string? Indirimmi { get; set; }
        public string? NormalKdvmi { get; set; }
        public string? KdvislemTuru { get; set; }
        public string? KdvislemTuru2 { get; set; }
        public string? KdvislemTuru3 { get; set; }
        public short? KdvislemTuruint { get; set; }
        public short? KdvislemTuruint2 { get; set; }
        public short? KdvislemTuruint3 { get; set; }
        public string? DigerEh { get; set; }
        public string? Diger2Eh { get; set; }
        public string? Diger3Eh { get; set; }
    }
}
