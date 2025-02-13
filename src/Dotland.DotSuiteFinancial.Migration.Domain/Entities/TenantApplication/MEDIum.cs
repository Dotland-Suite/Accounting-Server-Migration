namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class MEDIum
{
    public uint ID { get; set; }

    public string? ATTACHMENT_FILE { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual ICollection<MEDIA_LINK> MEDIA_LINKs { get; set; } = new List<MEDIA_LINK>();
}
