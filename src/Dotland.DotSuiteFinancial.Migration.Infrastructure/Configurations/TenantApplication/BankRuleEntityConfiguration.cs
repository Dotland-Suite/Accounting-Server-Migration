using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantApplication;

public class BankRuleEntityConfiguration : IEntityTypeConfiguration<BankRule>
{
    public void Configure(EntityTypeBuilder<BankRule> entity)
    {
        entity
            .ToTable("BANK_RULES")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");
        
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity.HasOne(d => d.ApplyIfAccount).WithMany(p => p.BankRuleApplyIfAccounts)
            .HasConstraintName("BANK_RULES_APPLY_IF_ACCOUNT_ID_FOREIGN");

        entity.HasOne(d => d.AssignAccount).WithMany(p => p.BankRuleassignAccounts)
            .HasConstraintName("BANK_RULES_ASSIGN_ACCOUNT_ID_FOREIGN");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Name).HasColumnName("NAME");
        entity.Property(e => e.Order).HasColumnName("ORDER");
        entity.Property(e => e.ApplyIfAccountId).HasColumnName("APPLY_IF_ACCOUNT_ID");
        entity.Property(e => e.ApplyIfTransactionType).HasColumnName("APPLY_IF_TRANSACTION_TYPE");
        entity.Property(e => e.AssignCategory).HasColumnName("ASSIGN_CATEGORY");
        entity.Property(e => e.AssignAccountId).HasColumnName("ASSIGN_ACCOUNT_ID");
        entity.Property(e => e.AssignPayee).HasColumnName("ASSIGN_PAYEE");
        entity.Property(e => e.AssignMemo).HasColumnName("ASSIGN_MEMO");
        entity.Property(e => e.ConditionsType).HasColumnName("CONDITIONS_TYPE");
        entity.Property(e => e.CreatedAt).HasColumnName("CREATED_AT");
        entity.Property(e => e.UpdatedAt).HasColumnName("UPDATED_AT");
    }
}