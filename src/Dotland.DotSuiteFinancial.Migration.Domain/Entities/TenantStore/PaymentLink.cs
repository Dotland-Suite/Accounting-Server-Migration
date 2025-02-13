namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantStore;

public class PaymentLink
{
    public uint Id { get; set; }
    public int? TenantId { get; set; }
    public int? ResourceId { get; set; }
    public string? ResourceType { get; set; }
    public string? LinkId { get; set; }
    public string? Publicity { get; set; }
    public DateTime? ExpiryAt { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
