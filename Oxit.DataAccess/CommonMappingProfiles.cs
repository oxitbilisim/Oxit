using AutoMapper;
using Oxit.Common.Automapper.MappingProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Common.Automapper
{
    public class CommonMappingProfiles
    {
        public static MapperConfiguration GetProfiles()
        {
            return new MapperConfiguration(x =>
            {
                x.AddProfile<PersonMappingProfile>();
            });
        }
    }
}
