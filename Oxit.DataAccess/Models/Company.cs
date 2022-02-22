using Oxit.Common.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Domain.Models
{
    public class Company : BaseFullModel<int>
    {
        public string Name { get; set; }
    }
}
