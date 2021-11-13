
using Microsoft.EntityFrameworkCore;
using Oxit.Common.Models;
using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.FluentMapping.Common
{
    public class MapperPerson
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(x =>
            {
                x.HasData(new Person
                {
                    Id = Guid.Parse("c569ade6-116f-4e63-be5c-b38009299857"),
                    Name = "Ali",
                    Active = true,
                    IsDeleted = false,

                });
            });
        }
    }
}
