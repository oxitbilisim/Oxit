﻿using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class BankaServisToken
    {
        public int Id { get; set; }
        public DateTime? SorguTarih { get; set; }
        public string? RequestText { get; set; }
        public string? ResponseText { get; set; }
        public string? Banka { get; set; }
        public string? Sonuc { get; set; }
        public int? BankaEntegrasyonId { get; set; }
    }
}
