namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class VIEW_ROLE
{
    public uint ID { get; set; }

    public int? INDEX { get; set; }

    public string? FIELD_KEY { get; set; }

    public string? COMPARATOR { get; set; }

    public string? VALUE { get; set; }

    public uint? VIEW_ID { get; set; }

    public virtual VIEW? VIEW { get; set; }
}
