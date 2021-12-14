using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class ESmdlog
    {
        public int Id { get; set; }
        public DateTime? Tarih { get; set; }
        public string? RequestTxt { get; set; }
        public string? ResponseTxt { get; set; }
    }
}
