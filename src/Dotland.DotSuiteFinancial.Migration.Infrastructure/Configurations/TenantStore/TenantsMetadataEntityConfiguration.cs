using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantStore;

public class TenantsMetadataEntityConfiguration : IEntityTypeConfiguration<TenantsMetadata>
{
    public void Configure(EntityTypeBuilder<TenantsMetadata> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity
            .ToTable("TENANTS_METADATA")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");

        entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");
        entity.Property(e => e.Address)
            .UseCollation("utf8mb4_bin")
            .HasCharSet("utf8mb4");
        entity.Property(e => e.BaseCurrency).HasMaxLength(255);
        entity.Property(e => e.DateFormat).HasMaxLength(255);
        entity.Property(e => e.FiscalYear).HasMaxLength(255);
        entity.Property(e => e.Industry).HasMaxLength(255);
        entity.Property(e => e.Language).HasMaxLength(255);
        entity.Property(e => e.Location).HasMaxLength(255);
        entity.Property(e => e.LogoKey).HasMaxLength(255);
        entity.Property(e => e.Name).HasMaxLength(255);
        entity.Property(e => e.PrimaryColor).HasMaxLength(255);
        entity.Property(e => e.TaxNumber).HasMaxLength(255);
        entity.Property(e => e.TenantId).HasColumnType("int(10) unsigned");
        entity.Property(e => e.Timezone).HasMaxLength(255);

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        entity.Property(e => e.Name).HasColumnName("NAME");
        entity.Property(e => e.Industry).HasColumnName("INDUSTRY");
        entity.Property(e => e.Location).HasColumnName("LOCATION");
        entity.Property(e => e.BaseCurrency).HasColumnName("BASE_CURRENCY");
        entity.Property(e => e.Language).HasColumnName("LANGUAGE");
        entity.Property(e => e.Timezone).HasColumnName("TIMEZONE");
        entity.Property(e => e.DateFormat).HasColumnName("DATE_FORMAT");
        entity.Property(e => e.FiscalYear).HasColumnName("FISCAL_YEAR");
        entity.Property(e => e.TaxNumber).HasColumnName("TAX_NUMBER");
        entity.Property(e => e.PrimaryColor).HasColumnName("PRIMARY_COLOR");
        entity.Property(e => e.LogoKey).HasColumnName("LOGO_KEY");
        entity.Property(e => e.Address).HasColumnName("ADDRESS");
    }
}