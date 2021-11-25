﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Oxit.Common.DataAccess.FluentMapping;
using Oxit.Common.Models;
using Oxit.Common.Models.Base;
using Oxit.Core;
using Oxit.Core.Enums;


namespace Oxit.Common.DataAccess.EntityFramework
{

    public partial class BaseAppDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public BaseAppDbContext()
            : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (Settings.Database.Type == DatabaseTypes.SqlServer)
                optionsBuilder.UseSqlServer(Settings.Database.ConnectionString);

            if (Settings.Database.Type == DatabaseTypes.PostgreSql)
            {
                optionsBuilder.UseNpgsql(Settings.Database.ConnectionString);
                AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
                AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
            }
            optionsBuilder.UseLazyLoadingProxies();
#if DEBUG
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information).EnableDetailedErrors();
#endif
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            if (Settings.Database.Type == DatabaseTypes.SqlServer)
                builder.UseCollation("Turkish_CI_AS");
            MapperPerson.Initialize(builder);
            #region Identity
            builder.Entity<IdentityUserToken<string>>(x =>
            {
            
                x.HasKey(c => new
                {
                    c.UserId,
                    c.Value
                });
            });
            builder.Entity<IdentityUserRole<string>>(x =>
            {
                x.HasKey(c => new { c.UserId, c.RoleId });
            });
            builder.Entity<IdentityUser>(x =>
            {
                x.HasKey(c => c.Id);
            });
            builder.Entity<IdentityRole>(x =>
            {
                x.HasKey(c => c.Id);
            });
            builder.Entity<IdentityUserLogin<string>>(x =>
            {
                x.HasKey(c => new { c.UserId, c.ProviderKey });
            });
            builder.Entity<IdentityUserClaim<string>>(x =>
            {
            });
            builder.Entity<IdentityRoleClaim<string>>(x =>
            {
            });
            #endregion
        }

        public virtual DbSet<Person> Person { get; set; }
        public override int SaveChanges()
        {
            var IBaseEntitys = ChangeTracker.Entries().Where(e => e.Entity is IBaseFullModel<Guid> || e.Entity is IBaseSimpleModel<Guid>);
            foreach (var entityEntry in IBaseEntitys)
            {

                if (entityEntry.State == EntityState.Added)
                {
                    if (entityEntry.Entity is IBaseFullModel<Guid>)
                    {
                        if (((IBaseFullModel<Guid>)entityEntry.Entity).Id == Guid.Empty)
                            ((IBaseFullModel<Guid>)entityEntry.Entity).Id = Guid.NewGuid();
                        ((IBaseFullModel<Guid>)entityEntry.Entity).CreateDate = DateTime.Now;
                        //if (user != null)
                        //    ((IBaseFullModel<Guid>)entityEntry.Entity).CreatorId = Guid.Parse(user.Id);
                    }
                    if (entityEntry.Entity is IBaseSimpleModel<Guid>)
                    {
                        if (((IBaseSimpleModel<Guid>)entityEntry.Entity).Id == Guid.Empty)
                            ((IBaseSimpleModel<Guid>)entityEntry.Entity).Id = Guid.NewGuid();
                        ((IBaseSimpleModel<Guid>)entityEntry.Entity).CreateDate = DateTime.Now;
                    }
                }

                if (entityEntry.State == EntityState.Modified)
                {
                    if (entityEntry.Entity is IBaseFullModel<Guid>)
                    {
                        ((IBaseFullModel<Guid>)entityEntry.Entity).EditDate = DateTime.Now;
                        ((IBaseFullModel<Guid>)entityEntry.Entity).CreateDate = DateTime.Now;
                        entityEntry.Property("CreateDate").IsModified = false;
                        //if (user != null)
                        //    ((IBaseFullModel<Guid>)entityEntry.Entity).EditorId = Guid.Parse(user.Id);
                    }
                    //SaveAudite(entityEntry, user);
                }
                if (entityEntry.State == EntityState.Deleted)
                {
                    //SaveAudite(entityEntry, user);
                }

            }
            return base.SaveChanges();
        }

    }
}
