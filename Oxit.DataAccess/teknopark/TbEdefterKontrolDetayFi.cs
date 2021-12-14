using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class TbEdefterKontrolDetayFi
    {
        public TbEdefterKontrolDetayFi()
        {
            TbEdefterKontrolDetayFisYevmiyes = new HashSet<TbEdefterKontrolDetayFisYevmiye>();
        }

        public int EdefterKontrolDetayFisId { get; set; }
        public int EdefterKontrolDetayId { get; set; }
        public int FisRefNo { get; set; }

        public virtual TbEdefterKontrolDetay EdefterKontrolDetay { get; set; } = null!;
        public virtual ICollection<TbEdefterKontrolDetayFisYevmiye> TbEdefterKontrolDetayFisYevmiyes { get; set; }
    }
}
