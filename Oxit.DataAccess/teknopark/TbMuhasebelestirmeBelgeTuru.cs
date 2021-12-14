using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class TbMuhasebelestirmeBelgeTuru
    {
        public TbMuhasebelestirmeBelgeTuru()
        {
            TbMuhasebelestirmeAyarlaris = new HashSet<TbMuhasebelestirmeAyarlari>();
        }

        public int BelgeTuruId { get; set; }
        public string Aciklama { get; set; } = null!;
        public int? Siralama { get; set; }

        public virtual ICollection<TbMuhasebelestirmeAyarlari> TbMuhasebelestirmeAyarlaris { get; set; }
    }
}
