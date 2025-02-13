namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantStore;

public class OneClickDemo
{
    public uint Id { get; set; }
    public string? Key { get; set; }
    public uint? TenantId { get; set; }
    public uint? UserId { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
