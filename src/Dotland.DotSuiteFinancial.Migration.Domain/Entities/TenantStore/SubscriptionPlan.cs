namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantStore;

public class SubscriptionPlan
{
    public uint Id { get; set; }
    public string? Slug { get; set; }
    public string? Name { get; set; }
    public string? Desc { get; set; }
    public bool? Active { get; set; }
    public decimal? Price { get; set; }
    public string? Currency { get; set; }
    public decimal? TrialPeriod { get; set; }
    public string? TrialInterval { get; set; }
    public decimal? InvoicePeriod { get; set; }
    public string? InvoiceInterval { get; set; }
    public uint? Index { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string? LemonVariantId { get; set; }
    public virtual ICollection<SubscriptionPlanSubscription> SubscriptionPlanSubscriptions { get; set; } = new List<SubscriptionPlanSubscription>();
}
