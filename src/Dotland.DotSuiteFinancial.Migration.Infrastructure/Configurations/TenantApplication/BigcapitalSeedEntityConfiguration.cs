using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantApplication;

public class BigcapitalSeedEntityConfiguration : IEntityTypeConfiguration<BigcapitalSeed>
{
    public void Configure(EntityTypeBuilder<BigcapitalSeed> entity)
    {
        entity
            .ToTable("BIGCAPITAL_SEEDS")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");
        
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Name).HasColumnName("NAME");
        entity.Property(e => e.Batch).HasColumnName("BATCH");
        entity.Property(e => e.MigrationTime).HasColumnName("MIGRATION_TIME");
    
        entity.Property(e => e.MigrationTime)
            .ValueGeneratedOnAddOrUpdate()
            .HasDefaultValueSql("current_timestamp()");
    }
}