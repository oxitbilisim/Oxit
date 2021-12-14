using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class TbEdefterKontrol
    {
        public TbEdefterKontrol()
        {
            TbEdefterKontrolDetays = new HashSet<TbEdefterKontrolDetay>();
        }

        public int EdefterKontrolId { get; set; }
        public int Ay { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public int HataSayisi { get; set; }
        public int UyariSayisi { get; set; }
        public int BasariSayisi { get; set; }

        public virtual ICollection<TbEdefterKontrolDetay> TbEdefterKontrolDetays { get; set; }
    }
}
