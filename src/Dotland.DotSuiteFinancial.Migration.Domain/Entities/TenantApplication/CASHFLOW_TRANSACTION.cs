namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class CASHFLOW_TRANSACTION
{
    public uint ID { get; set; }

    public DateOnly? DATE { get; set; }

    public decimal? AMOUNT { get; set; }

    public string? CURRENCY_CODE { get; set; }

    public decimal? EXCHANGE_RATE { get; set; }

    public string? REFERENCE_NO { get; set; }

    public string? TRANSACTION_TYPE { get; set; }

    public string? TRANSACTION_NUMBER { get; set; }

    public string? DESCRIPTION { get; set; }

    public DateOnly? PUBLISHED_AT { get; set; }

    public uint? USER_ID { get; set; }

    public uint? BRANCH_ID { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public uint? CASHFLOW_ACCOUNT_ID { get; set; }

    public uint? CREDIT_ACCOUNT_ID { get; set; }

    public string? PLAID_TRANSACTION_ID { get; set; }

    public uint? UNCATEGORIZED_TRANSACTION_ID { get; set; }

    public virtual BRANCH? BRANCH { get; set; }

    public virtual Account? CASHFLOW_ACCOUNT { get; set; }

    public virtual Account? CREDIT_ACCOUNT { get; set; }

    public virtual UNCATEGORIZED_CASHFLOW_TRANSACTION? UNCATEGORIZED_TRANSACTION { get; set; }
}
