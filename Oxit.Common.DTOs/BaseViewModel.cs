using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Common.ViewModels
{
    public class BaseViewModel : IBaseViewModel
    {
        public Guid Id { get; set; }
    }
}
