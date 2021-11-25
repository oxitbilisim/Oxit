﻿using Oxit.Common.DataAccess.EntityFramework;
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
        public PersonService(CommonDbContext db) : base(db)
        {
            this.db = db;
        }

        public override IQueryable<Person> GetAll()
        {
            return base.GetAll();
        }
    }
}
