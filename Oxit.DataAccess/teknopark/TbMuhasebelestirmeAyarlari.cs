using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class TbMuhasebelestirmeAyarlari
    {
        public int MuhasebelestirmeAyarlariId { get; set; }
        public int BelgeTuruId { get; set; }
        public string? Tasarim { get; set; }

        public virtual TbMuhasebelestirmeBelgeTuru BelgeTuru { get; set; } = null!;
    }
}
