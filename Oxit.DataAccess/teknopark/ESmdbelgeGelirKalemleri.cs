using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class ESmdbelgeGelirKalemleri
    {
        public int Ref { get; set; }
        public int? AnaRef { get; set; }
        public string? ZrvKodu { get; set; }
        public Guid ZrvGuid { get; set; }
        public string? GibGuid { get; set; }
        public bool? Deleted { get; set; }
        public bool? Updated { get; set; }
        public string? Aciklama { get; set; }
        public double? Miktar { get; set; }
        public string? BirimKodu { get; set; }
        public double? BirimFiyat { get; set; }
        public double? Tutar { get; set; }
        public double? GercekTutar { get; set; }
        public double? Kdv { get; set; }
        public double? KdvOrani { get; set; }
        public string? KismiTevkifatKodu { get; set; }
        public double? KismiTevkifatOrani { get; set; }
        public string? StopajKodu { get; set; }
        public double? StopajOrani { get; set; }
        public double? StopajTutari { get; set; }
        public string? SatisTuruKodu { get; set; }
        public string? GelirKayitTuruKodu { get; set; }
        public string? GelirKayitAltTuruKodu { get; set; }
        public string? KismiIstisnaKodu { get; set; }
        public double? KismiIstisnaOrani { get; set; }
        public string? TamIstisnaKodu { get; set; }
        public double? TamIstisnaOrani { get; set; }
        public string? IhracKayitliTeslimKodu { get; set; }
        public double? IhracKayitliTeslimOrani { get; set; }
        public string? DigerIadeHakkiKodu { get; set; }
        public double? DigerIadeHakkiOrani { get; set; }
        public string? DigerIslemlerKodu { get; set; }
        public double? DigerIslemlerOrani { get; set; }
        public double? NetDefterDegeri { get; set; }
        public string? SabitKiymetId { get; set; }
        public string? IadeKismiTevkifatKodu { get; set; }
        public double? IadeKismiTevkifatOrani { get; set; }
        public int? IsletmeRef { get; set; }
        public bool? Silindi { get; set; }
        public long? ZrvArtan { get; set; }
        public byte[]? Artan { get; set; }
        /// <summary>
        /// -&quot;0&quot; Normal ilk gelen
        /// -&quot;1&quot; Değiştirilen Kayıt
        /// </summary>
        public int? DurumKodu { get; set; }
        public double? EskiTutar { get; set; }
        public string? EskiAciklama { get; set; }
        public string? EskiKod { get; set; }
        public bool? KdvsizIslem { get; set; }
        public string? NaceKodu { get; set; }
    }
}
