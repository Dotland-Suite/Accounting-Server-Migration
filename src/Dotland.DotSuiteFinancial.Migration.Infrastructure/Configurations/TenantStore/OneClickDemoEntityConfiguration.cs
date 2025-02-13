using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantStore;

public class OneClickDemoEntityConfiguration : IEntityTypeConfiguration<OneClickDemo>
{
    public void Configure(EntityTypeBuilder<OneClickDemo> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder
            .ToTable("ONECLICK_DEMOS")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");

        builder.Property(e => e.Id).HasColumnType("int(10) unsigned");
        builder.Property(e => e.CreatedAt).HasColumnType("datetime");
        builder.Property(e => e.Key).HasMaxLength(255);
        builder.Property(e => e.TenantId).HasColumnType("int(10) unsigned");
        builder.Property(e => e.UpdatedAt).HasColumnType("datetime");
        builder.Property(e => e.UserId).HasColumnType("int(10) unsigned");

        builder.Property(e => e.Id).HasColumnName("ID");
        builder.Property(e => e.Key).HasColumnName("KEY");
        builder.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        builder.Property(e => e.UserId).HasColumnName("USER_ID");
        builder.Property(e => e.CreatedAt).HasColumnName("CREATED_AT");
        builder.Property(e => e.UpdatedAt).HasColumnName("UPDATED_AT");
    }
}