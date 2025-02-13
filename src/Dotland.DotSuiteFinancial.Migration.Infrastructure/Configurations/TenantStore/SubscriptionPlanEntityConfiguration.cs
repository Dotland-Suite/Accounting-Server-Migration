using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantStore;

public class SubscriptionPlanEntityConfiguration : IEntityTypeConfiguration<SubscriptionPlan>
{
    public void Configure(EntityTypeBuilder<SubscriptionPlan> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder
            .ToTable("SUBSCRIPTION_PLANS")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");

        builder.HasIndex(e => e.LemonVariantId, "SUBSCRIPTION_PLANS_LEMON_VARIANT_ID_INDEX");

        builder.Property(e => e.Id).HasColumnType("int(10) unsigned");
        builder.Property(e => e.CreatedAt).HasColumnType("datetime");
        builder.Property(e => e.Currency).HasMaxLength(3);
        builder.Property(e => e.Desc).HasMaxLength(255);
        builder.Property(e => e.Index).HasColumnType("int(10) unsigned");
        builder.Property(e => e.InvoiceInterval).HasMaxLength(255);
        builder.Property(e => e.InvoicePeriod).HasPrecision(8, 2);
        builder.Property(e => e.Name).HasMaxLength(255);
        builder.Property(e => e.Price).HasColumnType("decimal(8,2) unsigned");
        builder.Property(e => e.Slug).HasMaxLength(255);
        builder.Property(e => e.TrialInterval).HasMaxLength(255);
        builder.Property(e => e.TrialPeriod).HasPrecision(8, 2);
        builder.Property(e => e.UpdatedAt).HasColumnType("datetime");

        builder.Property(e => e.Id).HasColumnName("ID");
        builder.Property(e => e.Slug).HasColumnName("SLUG");
        builder.Property(e => e.Name).HasColumnName("NAME");
        builder.Property(e => e.Desc).HasColumnName("DESC");
        builder.Property(e => e.Active).HasColumnName("ACTIVE");
        builder.Property(e => e.Price).HasColumnName("PRICE");
        builder.Property(e => e.Currency).HasColumnName("CURRENCY");
        builder.Property(e => e.TrialPeriod).HasColumnName("TRIAL_PERIOD");
        builder.Property(e => e.TrialInterval).HasColumnName("TRIAL_INTERVAL");
        builder.Property(e => e.InvoicePeriod).HasColumnName("INVOICE_PERIOD");
        builder.Property(e => e.InvoiceInterval).HasColumnName("INVOICE_INTERVAL");
        builder.Property(e => e.Index).HasColumnName("INDEX");
        builder.Property(e => e.CreatedAt).HasColumnName("CREATED_AT");
        builder.Property(e => e.UpdatedAt).HasColumnName("UPDATED_AT");
        builder.Property(e => e.LemonVariantId).HasColumnName("LEMON_VARIANT_ID");
    }
}