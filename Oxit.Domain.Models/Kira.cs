using Oxit.Common.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Domain.Models
{
    public class Kira : BaseSimpleModel<int>
    {
        public Kira()
        { }

        public string? FirmaAdi { get; set; }
        public DateOnly? BaslamaTarihi { get; set; }
        public DateOnly? BitisTarihi { get; set; }
        public double? Metrekare { get; set; }
        public double? MetrekareFiyati { get; set; }
        public double? ToplamFiyat { get; set; }

    }
}
