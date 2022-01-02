using Oxit.Common.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Domain.Models
{
    public class HesapPlani : BaseSimpleModel<int>
    {
        public HesapPlani()
        {
            this.Fis = new();
        }
        public string? Ad { get; set; }
        public string? Kod { get; set; }
        public string DbKey { get; set; }
        public bool Aktif { get; set; }
        public Double? GecikmeTutari  { get; set; }
        public DateTime SonCekilmeTarihi { get; set; }

        public virtual HashSet<Fis> Fis { get; set; }
    }
}
