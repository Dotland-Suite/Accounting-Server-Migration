using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantStore;

public class SubscriptionsPlanEntityConfiguration : IEntityTypeConfiguration<SubscriptionsPlan>
{
    public void Configure(EntityTypeBuilder<SubscriptionsPlan> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity
            .ToTable("SUBSCRIPTIONS_PLANS")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");

        entity.Property(e => e.Id).HasColumnType("int(10) unsigned");
        entity.Property(e => e.CreatedAt).HasColumnType("datetime");
        entity.Property(e => e.Currency).HasMaxLength(3);
        entity.Property(e => e.Description).HasMaxLength(255);
        entity.Property(e => e.InvoiceInterval).HasMaxLength(255);
        entity.Property(e => e.InvoicePeriod).HasColumnType("int(11)");
        entity.Property(e => e.Name).HasMaxLength(255);
        entity.Property(e => e.Price).HasPrecision(8, 2);
        entity.Property(e => e.TrialInterval).HasMaxLength(255);
        entity.Property(e => e.TrialPeriod).HasColumnType("int(11)");
        entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Name).HasColumnName("NAME");
        entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
        entity.Property(e => e.Price).HasColumnName("PRICE");
        entity.Property(e => e.Currency).HasColumnName("CURRENCY");
        entity.Property(e => e.TrialPeriod).HasColumnName("TRIAL_PERIOD");
        entity.Property(e => e.TrialInterval).HasColumnName("TRIAL_INTERVAL");
        entity.Property(e => e.InvoicePeriod).HasColumnName("INVOICE_PERIOD");
        entity.Property(e => e.InvoiceInterval).HasColumnName("INVOICE_INTERVAL");
        entity.Property(e => e.CreatedAt).HasColumnName("CREATED_AT");
        entity.Property(e => e.UpdatedAt).HasColumnName("UPDATED_AT");
    }
}