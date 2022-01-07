using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Oxit.Common.Models;
using Oxit.Common.ViewModels.Person;
using Oxit.Domain.Models;
using Oxit.Domain.ViewModels.Company;
using Oxit.Domain.ViewModels.Kira;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Infrastructure.MappingProfiles
{
    public class KiraMappingProfile : Profile
    {
        public KiraMappingProfile()
        {

            CreateMap<KiraExcel, Kira>()
        
                ;
      

        }
    }
}
