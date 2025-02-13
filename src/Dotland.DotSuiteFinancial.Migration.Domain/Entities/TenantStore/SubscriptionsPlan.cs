namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantStore;

public class SubscriptionsPlan
{
    public uint Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
    public string? Currency { get; set; }
    public int? TrialPeriod { get; set; }
    public string? TrialInterval { get; set; }
    public int? InvoicePeriod { get; set; }
    public string? InvoiceInterval { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
