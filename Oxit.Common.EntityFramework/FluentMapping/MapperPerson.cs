
using Microsoft.EntityFrameworkCore;
using Oxit.Common.Models;
using System;
using System.Collections.Generic;

namespace Oxit.Common.DataAccess.FluentMapping
{
    public class MapperPerson
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(x =>
            {
                x.Property(v => v.Name).IsRequired();
                x.HasData(new Person
                {
                    Id = Guid.Parse("1569ade6-116f-4e63-b15c-b38009211857"),
                    Name = "Ali",
                });

            });
        }
    }
}
