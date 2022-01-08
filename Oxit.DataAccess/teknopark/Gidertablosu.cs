using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class Gidertablosu
    {
        public DateTime? Faturatarihi { get; set; }
        public int Sirano { get; set; }
        public double? Miktar { get; set; }
        public string? Faturano { get; set; }
        public string? Aciklama { get; set; }
        public double? Masraflar { get; set; }
        public double? Indirilebilecekkdv { get; set; }
        public double? Toplam { get; set; }
        public double? Kdvorani { get; set; }
        public string? Dahilharic { get; set; }
        public string? Stokkodu { get; set; }
        public short? Ay { get; set; }
        public string? Kod { get; set; }
        public DateTime? Islemetarihi { get; set; }
        public string? Heskod { get; set; }
        public int? Kayitno { get; set; }
        public int? Eynmk { get; set; }
        public int? Cmiorbmi { get; set; }
        public short? Esno { get; set; }
        public short? Sino { get; set; }
        public string? Torani { get; set; }
        public string? Vergino { get; set; }
        public double? Stopajtutari { get; set; }
        public short? Onay { get; set; }
        public Guid? RefGuid { get; set; }
        public Guid? GibGuid { get; set; }
        public byte[]? Artan { get; set; }
        public string? GibRef { get; set; }
        public string? BelgeTuru { get; set; }
        public string? SatisTuru { get; set; }
        public string? KayitTuru { get; set; }
        public string? KayitAltTuru { get; set; }
        public string? StopajKodu { get; set; }
        public double? StopajOrani { get; set; }
        public string? IstisnaKodu { get; set; }
        public double? IstisnaOrani { get; set; }
        public string? TevkifatKodu { get; set; }
        public bool? DefterBeyanGuncelle { get; set; }
        public DateTime? DbKayitTarihi { get; set; }
        public string? TamIstisnaKodu { get; set; }
        public bool? KdvsizIslem { get; set; }
        public string? NaceKodu { get; set; }
        public int? BaglantiSirano { get; set; }
        public string? Kullanici { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public double? TevkifatTutar { get; set; }
        public string? UlkeKodu { get; set; }
        public string? OdemeTuruKodu { get; set; }
        public string? GumrukBeyannameNo { get; set; }
        public double? Kdvm { get; set; }
        public double? EkOdemeler { get; set; }
        public double? MalHizmetBedeli { get; set; }
        public double? BeyanEdilecekKdv { get; set; }
    }
}
