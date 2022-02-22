using Oxit.Common.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Common.Models
{
    public class Person : BaseFullModel<Guid>
    {
        public Person()
        {

        }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? NationalId { get; set; }
        public string? Photo { get; set; }
    }
}
