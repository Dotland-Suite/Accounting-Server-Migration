namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class MEDIA_LINK
{
    public uint ID { get; set; }

    public string? MODEL_NAME { get; set; }

    public uint? MEDIA_ID { get; set; }

    public uint? MODEL_ID { get; set; }

    public virtual MEDIum? MEDIA { get; set; }
}
