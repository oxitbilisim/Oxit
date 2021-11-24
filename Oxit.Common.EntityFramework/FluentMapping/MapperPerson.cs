
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
                    Id = Guid.Parse("c569ade6-116f-4e63-be5c-b38009299857"),
                    Name = "Ali",
                    Active = true,

                });

            });
        }
    }
}
