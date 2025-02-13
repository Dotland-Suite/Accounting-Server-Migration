namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantStore;

public class TenantsMetadata
{
    public ulong Id { get; set; }
    public uint? TenantId { get; set; }
    public string? Name { get; set; }
    public string? Industry { get; set; }
    public string? Location { get; set; }
    public string? BaseCurrency { get; set; }
    public string? Language { get; set; }
    public string? Timezone { get; set; }
    public string? DateFormat { get; set; }
    public string? FiscalYear { get; set; }
    public string? TaxNumber { get; set; }
    public string? PrimaryColor { get; set; }
    public string? LogoKey { get; set; }
    public string? Address { get; set; }
}
