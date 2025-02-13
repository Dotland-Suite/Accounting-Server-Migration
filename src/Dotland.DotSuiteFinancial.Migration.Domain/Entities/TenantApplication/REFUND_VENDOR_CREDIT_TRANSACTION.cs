namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class REFUND_VENDOR_CREDIT_TRANSACTION
{
    public uint ID { get; set; }

    public DateOnly? DATE { get; set; }

    public uint? VENDOR_CREDIT_ID { get; set; }

    public decimal? AMOUNT { get; set; }

    public string? CURRENCY_CODE { get; set; }

    public decimal? EXCHANGE_RATE { get; set; }

    public string? REFERENCE_NO { get; set; }

    public uint? DEPOSIT_ACCOUNT_ID { get; set; }

    public string? DESCRIPTION { get; set; }

    public uint? BRANCH_ID { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual BRANCH? BRANCH { get; set; }

    public virtual Account? DEPOSIT_ACCOUNT { get; set; }

    public virtual VENDOR_CREDIT? VENDOR_CREDIT { get; set; }
}
