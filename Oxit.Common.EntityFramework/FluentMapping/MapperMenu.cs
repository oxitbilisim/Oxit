
using Microsoft.EntityFrameworkCore;
using Oxit.Common.Models;
using System;
using System.Collections.Generic;

namespace Oxit.Common.DataAccess.FluentMapping
{
    public class MapperMenu
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>(x =>
            {
                x.Property(v => v.Name).IsRequired();
                x.Property(v => v.Text).IsRequired();

                x.HasData(new List<Menu>() {
                new Menu
                {
                    Id = 1,
                    Name = "Home",
                    Text = "Anasayfa",
                    Icon = "fa fa-home"
                }
                });

            });
        }
    }
}
