using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class TbVeriTabaniSurumu
    {
        public int VeriTabaniSurumuId { get; set; }
        public int? ZirvePaketId { get; set; }
        public int? SonSorguId { get; set; }
        public DateTime? CalismaZamani { get; set; }
        public int? HataVerenSorguId { get; set; }
        public string? HataMesaji { get; set; }
        public bool EskiSurumCalissinmi { get; set; }
    }
}
