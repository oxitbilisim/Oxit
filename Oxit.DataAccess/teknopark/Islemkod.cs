using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class Islemkod
    {
        public int Ref { get; set; }
        public int Modulkodu { get; set; }
        public int Islemkodu { get; set; }
        public string? Aciklama { get; set; }
        public string? Sbtbilgisi { get; set; }
    }
}
