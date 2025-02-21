using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantApplication;

public class BillLocatedCostEntityConfiguration : IEntityTypeConfiguration<BillLocatedCost>
{
    public void Configure(EntityTypeBuilder<BillLocatedCost> entity)
    {
        entity
            .ToTable("BILL_LOCATED_COSTS")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");
        
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Amount).HasColumnName("AMOUNT");
        entity.Property(e => e.CurrencyCode).HasColumnName("CURRENCY_CODE");
        entity.Property(e => e.ExchangeRate).HasColumnName("EXCHANGE_RATE");
        entity.Property(e => e.FromTransactionId).HasColumnName("FROM_TRANSACTION_ID");
        entity.Property(e => e.FromTransactionType).HasColumnName("FROM_TRANSACTION_TYPE");
        entity.Property(e => e.FromTransactionEntryId).HasColumnName("FROM_TRANSACTION_ENTRY_ID");
        entity.Property(e => e.AllocationMethod).HasColumnName("ALLOCATION_METHOD");
        entity.Property(e => e.CostAccountId).HasColumnName("COST_ACCOUNT_ID");
        entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
        entity.Property(e => e.BillId).HasColumnName("BILL_ID");
        entity.Property(e => e.CreatedAt).HasColumnName("CREATED_AT");
        entity.Property(e => e.UpdatedAt).HasColumnName("UPDATED_AT");
    }
}