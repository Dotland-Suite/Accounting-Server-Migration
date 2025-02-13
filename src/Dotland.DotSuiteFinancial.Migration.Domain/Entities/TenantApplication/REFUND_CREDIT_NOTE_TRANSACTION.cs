namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class REFUND_CREDIT_NOTE_TRANSACTION
{
    public uint ID { get; set; }

    public DateOnly? DATE { get; set; }

    public uint? CREDIT_NOTE_ID { get; set; }

    public decimal? AMOUNT { get; set; }

    public string? CURRENCY_CODE { get; set; }

    public decimal? EXCHANGE_RATE { get; set; }

    public string? REFERENCE_NO { get; set; }

    public uint? FROM_ACCOUNT_ID { get; set; }

    public string? DESCRIPTION { get; set; }

    public uint? BRANCH_ID { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual BRANCH? BRANCH { get; set; }

    public virtual CREDIT_NOTE? CREDIT_NOTE { get; set; }

    public virtual Account? FROM_ACCOUNT { get; set; }
}
