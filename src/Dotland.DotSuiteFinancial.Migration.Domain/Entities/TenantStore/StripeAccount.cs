namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantStore;

public class StripeAccount
{
    public uint Id { get; set; }
    public string StripeAccountId { get; set; } = null!;
    public string TenantId { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
