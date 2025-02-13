using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantStore;

public class PasswordResetEntityConfiguration : IEntityTypeConfiguration<PasswordReset>
{
    public void Configure(EntityTypeBuilder<PasswordReset> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder
            .ToTable("PASSWORD_RESETS")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");

        builder.HasIndex(e => e.Email, "PASSWORD_RESETS_EMAIL_INDEX");

        builder.HasIndex(e => e.Token, "PASSWORD_RESETS_TOKEN_INDEX");

        builder.Property(e => e.Id).HasColumnType("int(10) unsigned");
        builder.Property(e => e.CreatedAt)
            .ValueGeneratedOnAddOrUpdate()
            .HasDefaultValueSql("current_timestamp()")
            .HasColumnType("timestamp");

        builder.Property(e => e.Id).HasColumnName("ID");
        builder.Property(e => e.Email).HasColumnName("EMAIL");
        builder.Property(e => e.Token).HasColumnName("TOKEN");
        builder.Property(e => e.CreatedAt).HasColumnName("CREATED_AT");
    }
}