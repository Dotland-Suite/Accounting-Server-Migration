using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantApplication;

public class AccountEntityConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> entity)
    {
        entity
            .ToTable("ACCOUNTS")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");
        
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity.Property(e => e.Id).HasComment("Auto-generated id");
        entity.Property(e => e.Active).HasDefaultValueSql("'1'");
        entity.Property(e => e.IsFeedsActive).HasDefaultValueSql("'0'");
        entity.Property(e => e.IsSyncingOwner).HasDefaultValueSql("'0'");
        entity.Property(e => e.IsSystemAccount).HasDefaultValueSql("'1'");
        entity.Property(e => e.Predefined).HasDefaultValueSql("'0'");
        entity.Property(e => e.UncategorizedTransactions).HasDefaultValueSql("'0'");

        entity.HasOne(d => d.ParentAccount).WithMany(p => p.InverseParentAccount)
            .HasConstraintName("ACCOUNTS_PARENT_ACCOUNT_ID_FOREIGN");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Name).HasColumnName("NAME");
        entity.Property(e => e.Slug).HasColumnName("SLUG");
        entity.Property(e => e.AccountType).HasColumnName("ACCOUNT_TYPE");
        entity.Property(e => e.ParentAccountId).HasColumnName("PARENT_ACCOUNT_ID");
        entity.Property(e => e.Code).HasColumnName("CODE");
        entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
        entity.Property(e => e.Active).HasColumnName("ACTIVE");
        entity.Property(e => e.Index).HasColumnName("INDEX");
        entity.Property(e => e.Predefined).HasColumnName("PREDEFINED");
        entity.Property(e => e.Amount).HasColumnName("AMOUNT");
        entity.Property(e => e.CurrencyCode).HasColumnName("CURRENCY_CODE");
        entity.Property(e => e.SeededAt).HasColumnName("SEEDED_AT");
        entity.Property(e => e.CreatedAt).HasColumnName("CREATED_AT");
        entity.Property(e => e.UpdatedAt).HasColumnName("UPDATED_AT");
        entity.Property(e => e.PlaidAccountId).HasColumnName("PLAID_ACCOUNT_ID");
        entity.Property(e => e.AccountMask).HasColumnName("ACCOUNT_MASK");
        entity.Property(e => e.BankBalance).HasColumnName("BANK_BALANCE");
        entity.Property(e => e.UncategorizedTransactions).HasColumnName("UNCATEGORIZED_TRANSACTIONS");
        entity.Property(e => e.IsSystemAccount).HasColumnName("IS_SYSTEM_ACCOUNT");
        entity.Property(e => e.IsFeedsActive).HasColumnName("IS_FEEDS_ACTIVE");
        entity.Property(e => e.IsSyncingOwner).HasColumnName("IS_SYNCING_OWNER");
        entity.Property(e => e.LastFeedsUpdatedAt).HasColumnName("LAST_FEEDS_UPDATED_AT");
        entity.Property(e => e.PlaidItemId).HasColumnName("PLAID_ITEM_ID");
    }
}