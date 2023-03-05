using Microsoft.EntityFrameworkCore;
using PhotoUploadWithIdentity.Entities.Accounts;
using PhotoUploadWithIdentity.Entities.Pictures;
using PhotoUploadWithIdentity.Entities.Roles;
using PhotoUploadWithIdentity.Persistence.EF.RolePersistence;

namespace PhotoUploadWithIdentity.Persistence.EF {
    public class EFDataContext : DbContext {

        public DbSet<Account> Account { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Picture> pictures { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly
                (typeof(RoleEntityMap).Assembly);
        }
    }
}
