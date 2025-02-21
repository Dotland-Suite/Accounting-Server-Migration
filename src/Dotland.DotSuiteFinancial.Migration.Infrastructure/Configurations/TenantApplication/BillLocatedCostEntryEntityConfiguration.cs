using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantApplication;

public class BillLocatedCostEntryEntityConfiguration : IEntityTypeConfiguration<BillLocatedCostEntry>
{
    public void Configure(EntityTypeBuilder<BillLocatedCostEntry> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.ToTable("BILL_LOCATED_COST_ENTRIES");

        entity.Property(e => e.Id)
            .HasColumnName("ID");
        
        entity.Property(e => e.Cost)
            .HasColumnName("COST");
        
        entity.Property(e => e.EntryId)
            .HasColumnName("ENTRY_ID");
        
        entity.Property(e => e.BillLocatedCostId)
            .HasColumnName("BILL_LOCATED_COST_ID");
    }
}