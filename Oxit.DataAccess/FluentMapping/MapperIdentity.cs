
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Oxit.Common.Models;
using System;
using System.Collections.Generic;

namespace Oxit.Common.DataAccess.FluentMapping
{
    public class MapperIdentity
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserToken<string>>(x =>
            {
                x.HasKey(c => new
                {
                    c.UserId,
                    c.Value
                });
            });
            modelBuilder.Entity<IdentityUserRole<string>>(x =>
            {
                x.HasKey(c => new { c.UserId, c.RoleId });
            });
            modelBuilder.Entity<IdentityUser>(x =>
            {
                x.HasKey(c => c.Id);
            });
            modelBuilder.Entity<IdentityRole>(x =>
            {
                x.HasKey(c => c.Id);
            });
            modelBuilder.Entity<IdentityUserLogin<string>>(x =>
            {
                x.HasKey(c => new { c.UserId, c.ProviderKey });
            });
            modelBuilder.Entity<IdentityUserClaim<string>>(x =>
            {
            });
            modelBuilder.Entity<IdentityRoleClaim<string>>(x =>
            {
            });
        }
    }
}
