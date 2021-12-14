using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class TbEdefterKontrolDetay
    {
        public TbEdefterKontrolDetay()
        {
            TbEdefterKontrolDetayFis = new HashSet<TbEdefterKontrolDetayFi>();
        }

        public int EdefterKontrolDetayId { get; set; }
        public int EdefterKontrolId { get; set; }
        public int KuralId { get; set; }
        public DateTime KayitTarihi { get; set; }
        public int FisSayisi { get; set; }
        public int? KuralSonucu { get; set; }

        public virtual TbEdefterKontrol EdefterKontrol { get; set; } = null!;
        public virtual ICollection<TbEdefterKontrolDetayFi> TbEdefterKontrolDetayFis { get; set; }
    }
}
