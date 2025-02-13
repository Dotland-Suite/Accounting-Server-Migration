using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantStore;

public class SubscriptionPlanSubscriptionEntityConfiguration : IEntityTypeConfiguration<SubscriptionPlanSubscription>
{
    public void Configure(EntityTypeBuilder<SubscriptionPlanSubscription> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity
            .ToTable("SUBSCRIPTION_PLAN_SUBSCRIPTIONS")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");

        entity.HasIndex(e => e.PlanId, "SUBSCRIPTION_PLAN_SUBSCRIPTIONS_PLAN_ID_INDEX");

        entity.HasIndex(e => e.TenantId, "SUBSCRIPTION_PLAN_SUBSCRIPTIONS_TENANT_ID_INDEX");

        entity.Property(e => e.Id).HasColumnType("int(10) unsigned");
        entity.Property(e => e.CanceledAt).HasColumnType("datetime");
        entity.Property(e => e.CreatedAt).HasColumnType("datetime");
        entity.Property(e => e.EndsAt).HasColumnType("datetime");
        entity.Property(e => e.LemonSubscriptionId).HasMaxLength(255);
        entity.Property(e => e.PaymentStatus).HasMaxLength(255);
        entity.Property(e => e.PlanId).HasColumnType("int(10) unsigned");
        entity.Property(e => e.Slug).HasMaxLength(255);
        entity.Property(e => e.StartsAt).HasColumnType("datetime");
        entity.Property(e => e.TenantId).HasColumnType("bigint(20) unsigned");
        entity.Property(e => e.TrialEndsAt).HasColumnType("datetime");
        entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

        entity.HasOne(d => d.Plan).WithMany(p => p.SubscriptionPlanSubscriptions)
            .HasForeignKey(d => d.PlanId)
            .HasConstraintName("SUBSCRIPTION_PLAN_SUBSCRIPTIONS_PLAN_ID_FOREIGN");

        entity.HasOne(d => d.Tenant).WithMany(p => p.SubscriptionPlanSubscriptions)
            .HasForeignKey(d => d.TenantId)
            .HasConstraintName("SUBSCRIPTION_PLAN_SUBSCRIPTIONS_TENANT_ID_FOREIGN");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.Slug).HasColumnName("SLUG");
        entity.Property(e => e.PlanId).HasColumnName("PLAN_ID");
        entity.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        entity.Property(e => e.StartsAt).HasColumnName("STARTS_AT");
        entity.Property(e => e.EndsAt).HasColumnName("ENDS_AT");
        entity.Property(e => e.CanceledAt).HasColumnName("CANCELED_AT");
        entity.Property(e => e.CreatedAt).HasColumnName("CREATED_AT");
        entity.Property(e => e.UpdatedAt).HasColumnName("UPDATED_AT");
        entity.Property(e => e.LemonSubscriptionId).HasColumnName("LEMON_SUBSCRIPTION_ID");
        entity.Property(e => e.TrialEndsAt).HasColumnName("TRIAL_ENDS_AT");
        entity.Property(e => e.PaymentStatus).HasColumnName("PAYMENT_STATUS");
    }
}