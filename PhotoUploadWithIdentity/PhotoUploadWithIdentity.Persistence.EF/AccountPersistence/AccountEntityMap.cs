using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhotoUploadWithIdentity.Entities.Accounts;

namespace PhotoUploadWithIdentity.Persistence.EF.AccountPersistence {
    public class AccountEntityMap : IEntityTypeConfiguration<Account> {
        public void Configure(EntityTypeBuilder<Account> builder) {

            builder.ToTable("Accounts");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Fullname).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Username).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.Mobile).HasMaxLength(14).IsRequired();

            builder.HasOne(x => x.Role)
                .WithMany(x => x.Accounts)
                .HasForeignKey(x => x.RoleId);
        }
    }
}
