using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class ZRaporu
    {
        public int Id { get; set; }
        public DateTime? Tarih { get; set; }
        public int? BelgeSayisi { get; set; }
        public double? Tutar { get; set; }
    }
}
