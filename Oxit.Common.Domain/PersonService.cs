using AutoMapper;
using Oxit.Common.DataAccess.EntityFramework;
using Oxit.Common.Domain.Base;
using Oxit.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxit.Common.Domain
{
    public class PersonService : BaseService<Person>
    {
        private readonly CommonDbContext db;
        private readonly IMapper mapper;

        public PersonService(CommonDbContext db, IMapper mapper) : base(db, mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public override IQueryable<Person> GetAll()
        {
            return base.GetAll();
        }

    }
}
