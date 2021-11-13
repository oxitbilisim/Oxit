﻿using Oxit.Common.Models.Base;
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
        [StringLength(100)]
        public string Name { get; set; }
    }
}
