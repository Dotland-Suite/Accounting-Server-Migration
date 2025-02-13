namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantStore;

public class ImportEntity
{
    public uint Id { get; set; }
    public string? Filename { get; set; }
    public string? ImportId { get; set; }
    public string? Resource { get; set; }
    public string? Columns { get; set; }
    public string? Mapping { get; set; }
    public string? Params { get; set; }
    public ulong? TenantId { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public virtual TenantStore? Tenant { get; set; }
}
