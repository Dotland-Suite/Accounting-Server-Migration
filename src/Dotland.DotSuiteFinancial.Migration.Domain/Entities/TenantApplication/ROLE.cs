namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class ROLE
{
    public uint ID { get; set; }

    public string NAME { get; set; } = null!;

    public string? SLUG { get; set; }

    public string? DESCRIPTION { get; set; }

    public bool? PREDEFINED { get; set; }

    public virtual ICollection<ROLE_PERMISSION> ROLE_PERMISSIONs { get; set; } = new List<ROLE_PERMISSION>();

    public virtual ICollection<USER> USERs { get; set; } = new List<USER>();
}
