using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantApplication;

public class BigCapitalSeedsLockEntityConfiguration : IEntityTypeConfiguration<BigCapitalSeedsLock>
{
    public void Configure(EntityTypeBuilder<BigCapitalSeedsLock> entity)
    {
        entity
            .ToTable("BIGCAPITAL_SEEDS_LOCK")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");
        
        entity.HasKey(e => e.Index).HasName("PRIMARY");

        entity.Property(e => e.Index).HasColumnName("INDEX");
        entity.Property(e => e.IsLocked).HasColumnName("IS_LOCKED");
    }
}