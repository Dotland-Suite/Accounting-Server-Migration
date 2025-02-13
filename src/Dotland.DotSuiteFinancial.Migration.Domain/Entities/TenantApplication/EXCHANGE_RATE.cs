namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class EXCHANGE_RATE
{
    public uint ID { get; set; }

    public string? CURRENCY_CODE { get; set; }

    public decimal? EXCHANGE_RATE1 { get; set; }

    public DateOnly? DATE { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }
}
