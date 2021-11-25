using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Oxit.Common.Models;
using Oxit.Common.ViewModels.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Common.Automapper.MappingProfiles
{
    public class PersonMappingProfile : Profile
    {
        public PersonMappingProfile()
        {
            CreateMap<Person, PersonGetViewModel>();
            CreateMap<Person, PersonGetAllViewModel>();
            
        }
    }
}
