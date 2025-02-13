using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantApplication;

public class BankRuleConditionEntityConfiguration : IEntityTypeConfiguration<BankRuleCondition>
{
    public void Configure(EntityTypeBuilder<BankRuleCondition> entity)
    {
        entity
            .ToTable("BANK_RULES")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");
        
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.HasOne(d => d.Rule).WithMany(p => p.BankRuleConditions).HasConstraintName("BANK_RULE_CONDITIONS_RULE_ID_FOREIGN");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.RuleId).HasColumnName("RULE_ID");
        entity.Property(e => e.Field).HasColumnName("FIELD");
        entity.Property(e => e.Comparator).HasColumnName("COMPARATOR");
        entity.Property(e => e.Value).HasColumnName("VALUE");
    }
}