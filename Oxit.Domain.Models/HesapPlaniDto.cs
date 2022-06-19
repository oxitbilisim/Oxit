using Oxit.Common.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Domain.Models
{
    public class HesapPlaniDto
    {
        public int Id  { get; set; }
        public string? Ad { get; set; }
        public string? Kod { get; set; }
        public Double GecikmeTutari  { get; set; }
        public Double ToplamGecikmeTutari  { get; set; }
        public Double ToplamAlacakTutari  { get; set; }
        public Double Bakiye { get; set; }
        public Double Borc { get; set; }
        public Double Alacak { get; set; }
        public Double ToplamBorcTutari  { get; set; }
        public bool Aktif { get; set; } 
        
    }
}
