using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class Stokgenm
    {
        public string Stk { get; set; } = null!;
        public int Ref { get; set; }
        public string? Sta { get; set; }
        public string? Stb { get; set; }
        public double? Stgm { get; set; }
        public double? Stgt { get; set; }
        public double? Stcm { get; set; }
        public double? Stct { get; set; }
        public double? Kar { get; set; }
        public string? Ticari { get; set; }
        public string? Eyontemi { get; set; }
    }
}
