using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantStore;

public class UserStoreEntityConfiguration : IEntityTypeConfiguration<UserStore>
{
    public void Configure(EntityTypeBuilder<UserStore> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity
            .ToTable("USERS")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");

        entity.HasIndex(e => e.Active, "USERS_ACTIVE_INDEX");

        entity.HasIndex(e => e.DeletedAt, "USERS_DELETED_AT_INDEX");

        entity.HasIndex(e => e.Email, "USERS_EMAIL_INDEX");

        entity.HasIndex(e => e.InviteAcceptedAt, "USERS_INVITE_ACCEPTED_AT_INDEX");

        entity.HasIndex(e => e.LastLoginAt, "USERS_LAST_LOGIN_AT_INDEX");

        entity.HasIndex(e => e.TenantId, "USERS_TENANT_ID_INDEX");

        entity.Property(e => e.Id).HasColumnType("int(10) unsigned");
        entity.Property(e => e.CreatedAt).HasColumnType("datetime");
        entity.Property(e => e.DeletedAt).HasColumnType("datetime");
        entity.Property(e => e.FirstName).HasMaxLength(255);
        entity.Property(e => e.InviteAcceptedAt).HasColumnType("datetime");
        entity.Property(e => e.Language).HasMaxLength(255);
        entity.Property(e => e.LastLoginAt).HasColumnType("datetime");
        entity.Property(e => e.LastName).HasMaxLength(255);
        entity.Property(e => e.Password).HasMaxLength(255);
        entity.Property(e => e.TenantId).HasColumnType("bigint(20) unsigned");
        entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        entity.Property(e => e.Verified).HasDefaultValueSql("'0'");
        entity.Property(e => e.VerifyToken).HasMaxLength(255);

        entity.HasOne(d => d.Tenant).WithMany(p => p.Users)
            .HasForeignKey(d => d.TenantId)
            .HasConstraintName("USERS_TENANT_ID_FOREIGN");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.FirstName).HasColumnName("FIRST_NAME");
        entity.Property(e => e.LastName).HasColumnName("LAST_NAME");
        entity.Property(e => e.Email).HasColumnName("EMAIL");
        entity.Property(e => e.Password).HasColumnName("PASSWORD");
        entity.Property(e => e.Active).HasColumnName("ACTIVE");
        entity.Property(e => e.Language).HasColumnName("LANGUAGE");
        entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        entity.Property(e => e.InviteAcceptedAt).HasColumnName("INVITE_ACCEPTED_AT");
        entity.Property(e => e.LastLoginAt).HasColumnName("LAST_LOGIN_AT");
        entity.Property(e => e.DeletedAt).HasColumnName("DELETED_AT");
        entity.Property(e => e.CreatedAt).HasColumnName("CREATED_AT");
        entity.Property(e => e.UpdatedAt).HasColumnName("UPDATED_AT");
        entity.Property(e => e.VerifyToken).HasColumnName("VERIFY_TOKEN");
        entity.Property(e => e.Verified).HasColumnName("VERIFIED");
    }
}