using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Oxit.Core.Enums;

namespace Oxit.DataAccess.EntityFramework
{

    public partial class baseAppDbContext : DbContext
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public baseAppDbContext(IHttpContextAccessor _contextAccessor, DbContextOptions<baseAppDbContext> options)
            : base(options)
        {
            this._contextAccessor = _contextAccessor;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                if (Settings.Database.Type == DatabaseTypes.SqlServer)
                {
                    optionsBuilder.UseSqlServer(Settings.Database.ConnectionString);
                }

                if (Settings.Database.Type == DatabaseTypes.PostgreSql)
                {
                    optionsBuilder.UseNpgsql(Settings.Database.ConnectionString);
                }


                optionsBuilder.UseLazyLoadingProxies();


#if DEBUG
                optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information).EnableDetailedErrors();
#endif
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            if (Settings.Database.Type == DatabaseTypes.SqlServer)
                builder.UseCollation("Turkish_CI_AS");

            //EnableSoftDelete(builder);
            // MapperHavaalani.Initialize(builder);

        }
        //protected void EnableSoftDelete(ModelBuilder builder)
        //{
        //    foreach (var type in builder.Model.GetEntityTypes().Where(t => typeof(IBaseFullModel).IsAssignableFrom(t.ClrType)))
        //    {
        //        var parameter = Expression.Parameter(type.ClrType);
        //        var propertyMethodInfo = typeof(EF).GetMethod("Property").MakeGenericMethod(typeof(bool));
        //        var isDeletedProperty = Expression.Call(propertyMethodInfo, parameter, Expression.Constant("IsDeleted"));
        //        BinaryExpression compareExpression = Expression.MakeBinary(ExpressionType.Equal, isDeletedProperty, Expression.Constant(false));
        //        var lambda = Expression.Lambda(compareExpression, parameter);
        //        builder.Entity(type.ClrType).HasQueryFilter(lambda);
        //    }
        //}
        //private IdentityUser getUser(HttpContext http)
        //{
        //    var token = http.GetToken();
        //    if (!string.IsNullOrEmpty(token) && this.Users.Any(c => c.SecurityStamp == token))
        //    {
        //        return this.Users.FirstOrDefault(c => c.SecurityStamp == token);
        //    }
        //    return null;
        //}
        //public override int SaveChanges()
        //{
        //    var IBaseEntitys = ChangeTracker.Entries().Where(e => e.Entity is IBaseFullModel || e.Entity is IBaseSimpleModel);
        //    foreach (var entityEntry in IBaseEntitys)
        //    {
        //        var user = getUser(_contextAccessor.HttpContext);
        //        if (entityEntry.State == EntityState.Added)
        //        {
        //            if (entityEntry.Entity is IBaseFullModel)
        //            {
        //                if (((IBaseFullModel)entityEntry.Entity).Id == Guid.Empty)
        //                    ((IBaseFullModel)entityEntry.Entity).Id = Guid.NewGuid();
        //                ((IBaseFullModel)entityEntry.Entity).CreateDate = DateTime.Now;
        //                if (user != null)
        //                    ((IBaseFullModel)entityEntry.Entity).CreatorId = Guid.Parse(user.Id);
        //            }
        //            if (entityEntry.Entity is IBaseSimpleModel)
        //            {
        //                if (((IBaseSimpleModel)entityEntry.Entity).Id == Guid.Empty)
        //                    ((IBaseSimpleModel)entityEntry.Entity).Id = Guid.NewGuid();
        //                ((IBaseSimpleModel)entityEntry.Entity).CreateDate = DateTime.Now;
        //            }
        //        }

        //        if (entityEntry.State == EntityState.Modified)
        //        {
        //            if (entityEntry.Entity is IBaseFullModel)
        //            {
        //                ((IBaseFullModel)entityEntry.Entity).EditDate = DateTime.Now;
        //                ((IBaseFullModel)entityEntry.Entity).CreateDate = DateTime.Now;
        //                entityEntry.Property("CreateDate").IsModified = false;
        //                if (user != null)
        //                    ((IBaseFullModel)entityEntry.Entity).EditorId = Guid.Parse(user.Id);
        //            }
        //            SaveAudite(entityEntry, user);
        //        }
        //        if (entityEntry.State == EntityState.Deleted)
        //        {
        //            SaveAudite(entityEntry, user);
        //        }

        //    }
        //    return base.SaveChanges();
        //}
        //private void SaveAudite(EntityEntry entityEntry, IdentityUser user)
        //{
        //    //save audite
        //    if (entityEntry.Metadata.ClrType.GetCustomAttribute<HasAudite>() != null)
        //    {
        //        Dictionary<string, object> vals = new Dictionary<string, object>();
        //        foreach (var property in entityEntry.Properties)
        //        {
        //            vals.Add(property.Metadata.Name, property.OriginalValue);
        //        }

        //        History.Add(new History()
        //        {
        //            Date = DateTime.Now,
        //            Key = entityEntry.Properties.FirstOrDefault(c => c.Metadata.IsPrimaryKey()).OriginalValue.ToString(),
        //            OldValue = System.Text.Json.JsonSerializer.Serialize(vals),
        //            Table = entityEntry.Metadata.GetTableName(),
        //            User = user != null ? $"{Kisi.FirstOrDefault(c => c.UserId == user.Id).Ad} {Kisi.FirstOrDefault(c => c.UserId == user.Id).Soyad}" : "",
        //            Operation = entityEntry.State == EntityState.Modified ? Entities.Enums.HistoryOperation.Update : Entities.Enums.HistoryOperation.Delete
        //        });
        //        vals = null;
        //    }
        //}
    }
}
