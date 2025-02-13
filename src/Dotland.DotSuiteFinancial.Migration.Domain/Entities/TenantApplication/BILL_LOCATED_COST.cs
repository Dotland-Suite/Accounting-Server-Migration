namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class BILL_LOCATED_COST
{
    public uint ID { get; set; }

    public decimal? AMOUNT { get; set; }

    public string? CURRENCY_CODE { get; set; }

    public decimal? EXCHANGE_RATE { get; set; }

    public uint? FROM_TRANSACTION_ID { get; set; }

    public string? FROM_TRANSACTION_TYPE { get; set; }

    public uint? FROM_TRANSACTION_ENTRY_ID { get; set; }

    public string? ALLOCATION_METHOD { get; set; }

    public uint? COST_ACCOUNT_ID { get; set; }

    public string? DESCRIPTION { get; set; }

    public uint? BILL_ID { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }
}
