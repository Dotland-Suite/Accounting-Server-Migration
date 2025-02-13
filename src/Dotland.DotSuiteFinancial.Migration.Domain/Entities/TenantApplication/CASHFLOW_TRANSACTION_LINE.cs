namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class CASHFLOW_TRANSACTION_LINE
{
    public uint ID { get; set; }

    public uint? CASHFLOW_TRANSACTION_ID { get; set; }

    public uint? CASHFLOW_ACCOUNT_ID { get; set; }

    public uint? CREDIT_ACCOUNT_ID { get; set; }

    public decimal? AMOUNT { get; set; }

    public uint? INDEX { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual Account? CASHFLOW_ACCOUNT { get; set; }

    public virtual Account? CREDIT_ACCOUNT { get; set; }
}
