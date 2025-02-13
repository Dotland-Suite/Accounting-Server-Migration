namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class VIEW_HAS_COLUMN
{
    public uint ID { get; set; }

    public uint? VIEW_ID { get; set; }

    public string? FIELD_KEY { get; set; }

    public uint? INDEX { get; set; }

    public virtual VIEW? VIEW { get; set; }
}
