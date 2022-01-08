using Microsoft.AspNetCore.Http;
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
        public BaseAppDbContext(DbContextOptions options)
     : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
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
            }
            if (Settings.Database.Type == DatabaseTypes.PostgreSql)
            {
                AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
                AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
            }

#if DEBUG
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information).EnableDetailedErrors();
#endif
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            if (Settings.Database.Type == DatabaseTypes.SqlServer)
                builder.UseCollation("Turkish_CI_AS");
            if (Settings.Database.Type == DatabaseTypes.PostgreSql)
            {
                builder.HasCollation("turkish_collection", locale: "tr_TR.UTF-8", provider: "icu", deterministic: false);
                builder.UseDefaultColumnCollation("turkish_collection");
            }

            MapperIdentity.Initialize(builder);

        }


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
