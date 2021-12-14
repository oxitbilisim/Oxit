using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class Fisbil
    {
        public Fisbil()
        {
            Yevmiyes = new HashSet<Yevmiye>();
        }

        public DateTime? Fistar { get; set; }
        public string? Fistur { get; set; }
        public string? Fisno { get; set; }
        public int? Yevno { get; set; }
        public int Refno { get; set; }
        public string? Sube { get; set; }
        public double? Btop { get; set; }
        public double? Atop { get; set; }
        public string? Nereden { get; set; }
        public string? Ekaciklama { get; set; }
        public string? Ozkod { get; set; }
        public short? Islemtipi { get; set; }
        public int? Eynm { get; set; }
        public short? Eynmk { get; set; }
        public short? Cmiorbmi { get; set; }
        public string? Masrafmerkezi { get; set; }
        public string? Onaylimi { get; set; }
        public string? Fisekilit { get; set; }
        public DateTime? Kayittarihi { get; set; }
        public long? Kontrolno { get; set; }
        public short? Fissilmekodu { get; set; }
        public string? FisbilPid { get; set; }
        public Guid? FisGuid { get; set; }

        public virtual ICollection<Yevmiye> Yevmiyes { get; set; }
    }
}
