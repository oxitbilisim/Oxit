using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Common.ViewModels.Person
{
    public class PersonGetViewModel: BaseViewModel
    {
    
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? NationalId { get; set; }
        public string? Photo { get; set; }
    }
}
