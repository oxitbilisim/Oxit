using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class ESmdbelgeGiderKalemleri
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
        public string? GiderKayitTuruKodu { get; set; }
        public string? GiderKayitAltTuruKodu { get; set; }
        public string? OdemeTuruKodu { get; set; }
        public string? HesaplamaYontemiKodu { get; set; }
        public string? AmortismanYontemiKodu { get; set; }
        public string? SabitKiymetTuruKodu { get; set; }
        public string? OzelKodKodu { get; set; }
        public string? Kodu { get; set; }
        public string? Adi { get; set; }
        public string? IktisadiKiymetKodu { get; set; }
        public int? Periyot { get; set; }
        public int? TevkifatDurumKodu { get; set; }
        public bool? Iade { get; set; }
        public string? AlisTuruKodu { get; set; }
        public string? DamgaVergisiKodu { get; set; }
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
        public bool? Donemsellik { get; set; }
        public string? DonemsellikParentGiderId { get; set; }
        public string? NaceKodu { get; set; }
    }
}
