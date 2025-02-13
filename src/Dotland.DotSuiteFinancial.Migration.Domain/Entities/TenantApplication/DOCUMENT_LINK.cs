namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class DOCUMENT_LINK
{
    public uint ID { get; set; }

    public string MODEL_REF { get; set; } = null!;

    public string MODEL_ID { get; set; } = null!;

    public uint? DOCUMENT_ID { get; set; }

    public DateTime? EXPIRES_AT { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }
}
