namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class DOCUMENT
{
    public uint ID { get; set; }

    public string KEY { get; set; } = null!;

    public string MIME_TYPE { get; set; } = null!;

    public uint? SIZE { get; set; }

    public string? ORIGIN_NAME { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }
}
