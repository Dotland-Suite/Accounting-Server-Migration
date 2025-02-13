using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantApplication;

public class AccountsTransactionEntityConfiguration : IEntityTypeConfiguration<AccountsTransaction>
{
    public void Configure(EntityTypeBuilder<AccountsTransaction> entity)
    {
        entity
            .ToTable("ACCOUNTS_TRANSACTIONS")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");
        
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity.HasOne(d => d.Account).WithMany(p => p.AccountsTransactions)
            .HasConstraintName("ACCOUNTS_TRANSACTIONS_ACCOUNT_ID_FOREIGN");

        entity.HasOne(d => d.Branch).WithMany(p => p.ACCOUNTS_TRANSACTIONs)
            .HasConstraintName("ACCOUNTS_TRANSACTIONS_BRANCH_ID_FOREIGN");

        entity.HasOne(d => d.Project).WithMany(p => p.ACCOUNTS_TRANSACTIONs)
            .HasConstraintName("ACCOUNTS_TRANSACTIONS_PROJECTID_FOREIGN");

        entity.HasOne(d => d.TaxRateNavigation).WithMany(p => p.ACCOUNTS_TRANSACTIONs)
            .HasConstraintName("ACCOUNTS_TRANSACTIONS_TAX_RATE_ID_FOREIGN");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Credit).HasColumnName("CREDIT");
        entity.Property(e => e.Debit).HasColumnName("DEBIT");
        entity.Property(e => e.CurrencyCode).HasColumnName("CURRENCY_CODE");
        entity.Property(e => e.ExchangeRate).HasColumnName("EXCHANGE_RATE");
        entity.Property(e => e.TransactionType).HasColumnName("TRANSACTION_TYPE");
        entity.Property(e => e.ReferenceType).HasColumnName("REFERENCE_TYPE");
        entity.Property(e => e.ReferenceId).HasColumnName("REFERENCE_ID");
        entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
        entity.Property(e => e.ContactType).HasColumnName("CONTACT_TYPE");
        entity.Property(e => e.ContactId).HasColumnName("CONTACT_ID");
        entity.Property(e => e.TransactionNumber).HasColumnName("TRANSACTION_NUMBER");
        entity.Property(e => e.ReferenceNumber).HasColumnName("REFERENCE_NUMBER");
        entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");
        entity.Property(e => e.ItemQuantity).HasColumnName("ITEM_QUANTITY");
        entity.Property(e => e.Note).HasColumnName("NOTE");
        entity.Property(e => e.UserId).HasColumnName("USER_ID");
        entity.Property(e => e.IndexGroup).HasColumnName("INDEX_GROUP");
        entity.Property(e => e.Index).HasColumnName("INDEX");
        entity.Property(e => e.Date).HasColumnName("DATE");
        entity.Property(e => e.CreatedAt).HasColumnName("CREATED_AT");
        entity.Property(e => e.Costable).HasColumnName("COSTABLE");
        entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");
        entity.Property(e => e.ProjectId).HasColumnName("PROJECT_ID");
        entity.Property(e => e.TaxRateId).HasColumnName("TAX_RATE_ID");
        entity.Property(e => e.TaxRate).HasColumnName("TAX_RATE");
    }
}