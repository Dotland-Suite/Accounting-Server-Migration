namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class CURRENCy
{
    public uint ID { get; set; }

    public string? CURRENCY_NAME { get; set; }

    public string? CURRENCY_CODE { get; set; }

    public string? CURRENCY_SIGN { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }
}
