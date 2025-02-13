namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class EXPENSES_TRANSACTION
{
    public uint ID { get; set; }

    public string? CURRENCY_CODE { get; set; }

    public decimal? EXCHANGE_RATE { get; set; }

    public string? DESCRIPTION { get; set; }

    public uint? PAYMENT_ACCOUNT_ID { get; set; }

    public uint? PAYEE_ID { get; set; }

    public string? REFERENCE_NO { get; set; }

    public decimal? TOTAL_AMOUNT { get; set; }

    public decimal? LANDED_COST_AMOUNT { get; set; }

    public decimal? ALLOCATED_COST_AMOUNT { get; set; }

    public DateOnly? PUBLISHED_AT { get; set; }

    public uint? USER_ID { get; set; }

    public uint? BRANCH_ID { get; set; }

    public DateOnly? PAYMENT_DATE { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public uint? PROJECT_ID { get; set; }

    public decimal? INVOICED_AMOUNT { get; set; }

    public virtual BRANCH? BRANCH { get; set; }

    public virtual ICollection<EXPENSE_TRANSACTION_CATEGORy> EXPENSE_TRANSACTION_CATEGORies { get; set; } = new List<EXPENSE_TRANSACTION_CATEGORy>();

    public virtual CONTACT? PAYEE { get; set; }

    public virtual Account? PAYMENT_ACCOUNT { get; set; }

    public virtual PROJECT? PROJECT { get; set; }
}
