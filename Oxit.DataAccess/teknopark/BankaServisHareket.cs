using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class BankaServisHareket
    {
        public int Id { get; set; }
        public string? Banka { get; set; }
        public DateTime? Tarih { get; set; }
        public double? Tutar { get; set; }
        public string? Aciklama { get; set; }
        public string? EvrakNo { get; set; }
        public string? TcKimlikNo { get; set; }
        public string? Vkn { get; set; }
        public string? HesapNo { get; set; }
        public string? MusteriNo { get; set; }
        public int? HataKodu { get; set; }
        public string? HataAciklamasi { get; set; }
        public string? BorcAlacak { get; set; }
        public string? IslemKodu { get; set; }
        public string? ParaBirimi { get; set; }
        public string? ServisHareketId { get; set; }
        public long? IntegrationId { get; set; }
        public long? AccountId { get; set; }
    }
}
