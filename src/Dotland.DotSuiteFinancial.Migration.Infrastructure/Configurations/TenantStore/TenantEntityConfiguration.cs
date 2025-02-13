using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantStore;

public class TenantEntityConfiguration : IEntityTypeConfiguration<Domain.Entities.TenantStore.TenantStore>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.TenantStore.TenantStore> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity
            .ToTable("TENANTS")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");

        entity.HasIndex(e => e.OrganizationId, "TENANTS_ORGANIZATION_ID_INDEX");

        entity.Property(e => e.Id).HasColumnType("bigint(20) unsigned");
        entity.Property(e => e.BuildJobId).HasMaxLength(255);
        entity.Property(e => e.BuiltAt).HasColumnType("datetime");
        entity.Property(e => e.CreatedAt).HasColumnType("datetime");
        entity.Property(e => e.DatabaseBatch).HasColumnType("int(11)");
        entity.Property(e => e.InitializedAt).HasColumnType("datetime");
        entity.Property(e => e.SeededAt).HasColumnType("datetime");
        entity.Property(e => e.UnderMaintenanceSince).HasColumnType("datetime");
        entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        entity.Property(e => e.UpgradeJobId).HasMaxLength(255);
        
        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.OrganizationId).HasColumnName("ORGANIZATION_ID");
        entity.Property(e => e.UnderMaintenanceSince).HasColumnName("UNDER_MAINTENANCE_SINCE");
        entity.Property(e => e.InitializedAt).HasColumnName("INITIALIZED_AT");
        entity.Property(e => e.SeededAt).HasColumnName("SEEDED_AT");
        entity.Property(e => e.BuiltAt).HasColumnName("BUILT_AT");
        entity.Property(e => e.BuildJobId).HasColumnName("BUILD_JOB_ID");
        entity.Property(e => e.DatabaseBatch).HasColumnName("DATABASE_BATCH");
        entity.Property(e => e.UpgradeJobId).HasColumnName("UPGRADE_JOB_ID");
        entity.Property(e => e.CreatedAt).HasColumnName("CREATED_AT");
        entity.Property(e => e.UpdatedAt).HasColumnName("UPDATED_AT");
    }
}