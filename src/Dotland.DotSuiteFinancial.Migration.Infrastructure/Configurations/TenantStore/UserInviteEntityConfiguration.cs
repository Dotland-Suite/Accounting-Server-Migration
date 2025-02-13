using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantStore;

public class UserInviteEntityConfiguration : IEntityTypeConfiguration<UserInvite>
{
    public void Configure(EntityTypeBuilder<UserInvite> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity
            .ToTable("USER_INVITES")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");

        entity.HasIndex(e => e.Email, "USER_INVITES_EMAIL_INDEX");

        entity.HasIndex(e => e.TenantId, "USER_INVITES_TENANT_ID_INDEX");

        entity.HasIndex(e => e.Token, "USER_INVITES_TOKEN_INDEX").IsUnique();

        entity.HasIndex(e => e.UserId, "USER_INVITES_USER_ID_INDEX");

        entity.Property(e => e.Id).HasColumnType("int(10) unsigned");
        entity.Property(e => e.CreatedAt).HasColumnType("datetime");
        entity.Property(e => e.TenantId).HasColumnType("bigint(20) unsigned");
        entity.Property(e => e.UserId).HasColumnType("int(10) unsigned");

        entity.HasOne(d => d.Tenant).WithMany(p => p.UserInvites)
            .HasForeignKey(d => d.TenantId)
            .HasConstraintName("USER_INVITES_TENANT_ID_FOREIGN");

        entity.HasOne(d => d.User).WithMany(p => p.UserInvites)
            .HasForeignKey(d => d.UserId)
            .HasConstraintName("USER_INVITES_USER_ID_FOREIGN");
        
        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Email).HasColumnName("EMAIL");
        entity.Property(e => e.Token).HasColumnName("TOKEN");
        entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        entity.Property(e => e.UserId).HasColumnName("USER_ID");
        entity.Property(e => e.CreatedAt).HasColumnName("CREATED_AT");
    }
}