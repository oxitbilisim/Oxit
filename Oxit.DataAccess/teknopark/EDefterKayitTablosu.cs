using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class EDefterKayitTablosu
    {
        public int Sirano { get; set; }
        public string? DefterTuru { get; set; }
        public string? KontrolNumarasi { get; set; }
        public string? DosyaSiraNo { get; set; }
        public string? Donemi { get; set; }
        public DateTime? DefterBaslangicTarihi { get; set; }
        public DateTime? DefterBitisTarihi { get; set; }
        public string? DefterAciklamasi { get; set; }
        public string? OlusturanKisi { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public string? DefterDurumu { get; set; }
        public short? DonemAyi { get; set; }
        public string? KayitEdenKullanici { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public short? Silindimi { get; set; }
        public string? SilenKullanici { get; set; }
        public DateTime? SilinmeTarihi { get; set; }
        public string? XmlDosyaYeri { get; set; }
        public string? BeratDosyaYeri { get; set; }
        public string? PaketDosyaYeri { get; set; }
        public string? SubeliDefter { get; set; }
        public string? SubeAdi { get; set; }
        public string? SubeNo { get; set; }
        public int? BasYevno { get; set; }
        public int? BitYevno { get; set; }
        public string? ZamanDamgasiVar { get; set; }
    }
}
