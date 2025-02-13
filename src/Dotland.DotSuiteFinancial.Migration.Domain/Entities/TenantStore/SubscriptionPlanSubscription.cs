namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantStore;

public class SubscriptionPlanSubscription
{
    public uint Id { get; set; }
    public string? Slug { get; set; }
    public uint? PlanId { get; set; }
    public ulong? TenantId { get; set; }
    public DateTime? StartsAt { get; set; }
    public DateTime? EndsAt { get; set; }
    public DateTime? CanceledAt { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string? LemonSubscriptionId { get; set; }
    public DateTime? TrialEndsAt { get; set; }
    public string? PaymentStatus { get; set; }
    public virtual SubscriptionPlan? Plan { get; set; }
    public virtual TenantStore? Tenant { get; set; }
}
