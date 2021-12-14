using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class ESmdgider
    {
        public int Ref { get; set; }
        public string? GibGuid { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? BelgeTarihi { get; set; }
        public string? BelgeSeriNo { get; set; }
        public string? BelgeSiraNo { get; set; }
        public string? VergiDairesiKodu { get; set; }
        public bool? VergiMukellefiMi { get; set; }
        public string? TcknVkn { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public bool? Iade { get; set; }
        public bool? AdresiGuncelleme { get; set; }
        public string? AdresBilgisi { get; set; }
        public string? MukellefId { get; set; }
        public int? SubeNo { get; set; }
        public int? Versiyon { get; set; }
        public bool? TopluKayit { get; set; }
        public string? GiderBelgeTuruKodu { get; set; }
        public int? BelgeAdedi { get; set; }
        public bool? Kilit { get; set; }
        public bool? Onaylandi { get; set; }
        public bool? Silindi { get; set; }
        public short? Durum { get; set; }
        public int? BelgeAyi { get; set; }
    }
}
