using AutoMapper;
using Oxit.Common.Automapper.MappingProfiles;
using Oxit.Infrastructure.MappingProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Infrastructure
{
    public class AutomapperProfiles
    {
        public static MapperConfiguration GetProfiles()
        {
            return new MapperConfiguration(x =>
            {
                x.AddProfile<PersonMappingProfile>();
            x.AddProfile<KiraMappingProfile>();
            });
        }
    }
}
