namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class ROLE_PERMISSION
{
    public uint ID { get; set; }

    public uint? ROLE_ID { get; set; }

    public string? SUBJECT { get; set; }

    public string? ABILITY { get; set; }

    public bool? VALUE { get; set; }

    public virtual ROLE? ROLE { get; set; }
}
