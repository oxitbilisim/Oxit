using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class Yevmiye
    {
        public int Refno { get; set; }
        public string? Tip { get; set; }
        public string? Gmkod { get; set; }
        public int Refno2 { get; set; }
        public short? Sube { get; set; }
        public DateTime? Fistar { get; set; }
        public string? Fistur { get; set; }
        public string? Fisno { get; set; }
        public int? Yevno { get; set; }
        public short? Dovizadi { get; set; }
        public string? Aciklama { get; set; }
        public double? Miktar { get; set; }
        public double? Doviz { get; set; }
        public double? Borclu { get; set; }
        public double? Alacakli { get; set; }
        public string? Stk { get; set; }
        public short? Islemtipi { get; set; }
        public string? Masrafmerkezi { get; set; }
        public DateTime? Evraktarihi { get; set; }
        public string? Evrakno { get; set; }
        public int? FInt { get; set; }
        public string? FStr { get; set; }
        public int? FIslemkodu { get; set; }
        public string? Vergino { get; set; }
        public string? FisbilPid { get; set; }
        public string? Serino { get; set; }
        public Guid? FisGuid { get; set; }
        public short? BelgeTuru { get; set; }
        public short? OdemeSekli { get; set; }
        public string? BelgeTuruAciklamasi { get; set; }
        public DateTime? VadeTarihi { get; set; }
        public byte? IsDegisti { get; set; }
        public string? SpId { get; set; }

        public virtual Fisbil RefnoNavigation { get; set; } = null!;
    }
}
