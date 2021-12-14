using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class TbEdefterKontrolDetayFisYevmiye
    {
        public int EdefterKontrolDetayFisYevmiyeId { get; set; }
        public int EdefterKontrolDetayFisId { get; set; }
        public int YevmiyeRefNo { get; set; }

        public virtual TbEdefterKontrolDetayFi EdefterKontrolDetayFis { get; set; } = null!;
    }
}
