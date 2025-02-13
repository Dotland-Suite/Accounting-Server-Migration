using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantStore;

public class ImportEntityConfiguration : IEntityTypeConfiguration<ImportEntity>
{
    public void Configure(EntityTypeBuilder<ImportEntity> builder)
    {
        builder.Property(e => e.Id).HasColumnName("ID");
        builder.Property(e => e.Filename).HasColumnName("FILENAME");
        builder.Property(e => e.ImportId).HasColumnName("IMPORT_ID");
        builder.Property(e => e.Resource).HasColumnName("RESOURCE");
        builder.Property(e => e.Columns).HasColumnName("COLUMNS");
        builder.Property(e => e.Mapping).HasColumnName("MAPPING");
        builder.Property(e => e.Params).HasColumnName("PARAMS");
        builder.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        builder.Property(e => e.CreatedAt).HasColumnName("CREATED_AT");
        builder.Property(e => e.UpdatedAt).HasColumnName("UPDATED_AT");

        builder.HasKey(e => e.Id).HasName("PRIMARY");
        builder
            .ToTable("IMPORTS")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");

        builder.HasIndex(e => e.TenantId, "IMPORTS_TENANT_ID_INDEX");

        builder.Property(e => e.Id).HasColumnType("int(10) unsigned");
        builder.Property(e => e.Columns)
            .UseCollation("utf8mb4_bin")
            .HasCharSet("utf8mb4");
        
        builder.Property(e => e.CreatedAt).HasColumnType("datetime");
        builder.Property(e => e.Filename).HasMaxLength(255);
        builder.Property(e => e.ImportId).HasMaxLength(255);
        builder.Property(e => e.Mapping)
            .UseCollation("utf8mb4_bin")
            .HasCharSet("utf8mb4");
        
        builder.Property(e => e.Params)
            .UseCollation("utf8mb4_bin")
            .HasCharSet("utf8mb4");
        
        builder.Property(e => e.Resource).HasMaxLength(255);
        builder.Property(e => e.TenantId).HasColumnType("bigint(20) unsigned");
        builder.Property(e => e.UpdatedAt).HasColumnType("datetime");

        builder.HasOne(d => d.Tenant).WithMany(p => p.Imports)
            .HasForeignKey(d => d.TenantId)
            .HasConstraintName("IMPORTS_TENANT_ID_FOREIGN");
    }
}