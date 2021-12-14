using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class TbHesapPlaniCache
    {
        public string Kod { get; set; } = null!;
        public string? Aciklama { get; set; }
        public double? Btop { get; set; }
        public double? Atop { get; set; }
        public string? Detay { get; set; }
        public string? UpperKod { get; set; }
        public string? UpperAciklama { get; set; }
    }
}
