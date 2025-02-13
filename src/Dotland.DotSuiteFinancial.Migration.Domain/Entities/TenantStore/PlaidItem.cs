namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantStore;

public class PlaidItem
{
    public ulong Id { get; set; }
    public ulong? TenantId { get; set; }
    public string? PlaidItemId { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public virtual TenantStore? Tenant { get; set; }
}
