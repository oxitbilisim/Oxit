using Oxit.Common.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Common.Models
{
    public class Menu : BaseFullModel<int>
    {
        public Menu()
        {
        }


        public string Name { get; set; }
        public string Text { get; set; }
        public string? Icon { get; set; }
        public int? UstMenuId { get; set; }

        public virtual ICollection<Menu> AltMenuler { get; set; }
        public virtual Menu UstMenu { get; set; }

    }
}
