namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantStore;

public class TenantStore
{
    public ulong Id { get; set; }
    public string? OrganizationId { get; set; }
    public DateTime? UnderMaintenanceSince { get; set; }
    public DateTime? InitializedAt { get; set; }
    public DateTime? SeededAt { get; set; }
    public DateTime? BuiltAt { get; set; }
    public string? BuildJobId { get; set; }
    public int? DatabaseBatch { get; set; }
    public string? UpgradeJobId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ImportEntity> Imports { get; set; } = new List<ImportEntity>();

    public virtual ICollection<PlaidItem> PlaidItems { get; set; } = new List<PlaidItem>();

    public virtual ICollection<SubscriptionPlanSubscription> SubscriptionPlanSubscriptions { get; set; } = new List<SubscriptionPlanSubscription>();

    public virtual ICollection<UserInvite> UserInvites { get; set; } = new List<UserInvite>();

    public virtual ICollection<UserStore> Users { get; set; } = new List<UserStore>();
}
