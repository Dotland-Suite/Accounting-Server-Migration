namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class UNCATEGORIZED_CASHFLOW_TRANSACTION
{
    public uint ID { get; set; }

    public DateOnly? DATE { get; set; }

    public decimal? AMOUNT { get; set; }

    public string? CURRENCY_CODE { get; set; }

    public string? REFERENCE_NO { get; set; }

    public string? PAYEE { get; set; }

    public uint? ACCOUNT_ID { get; set; }

    public string? DESCRIPTION { get; set; }

    public string? CATEGORIZE_REF_TYPE { get; set; }

    public uint? CATEGORIZE_REF_ID { get; set; }

    public bool? CATEGORIZED { get; set; }

    public string? PLAID_TRANSACTION_ID { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public uint? RECOGNIZED_TRANSACTION_ID { get; set; }

    public DateTime? EXCLUDED_AT { get; set; }

    public string? BATCH { get; set; }

    public bool? PENDING { get; set; }

    public string? PENDING_PLAID_TRANSACTION_ID { get; set; }

    public virtual Account? ACCOUNT { get; set; }

    public virtual ICollection<CASHFLOW_TRANSACTION> CASHFLOW_TRANSACTIONs { get; set; } = new List<CASHFLOW_TRANSACTION>();

    public virtual ICollection<MATCHED_BANK_TRANSACTION> MATCHED_BANK_TRANSACTIONs { get; set; } = new List<MATCHED_BANK_TRANSACTION>();

    public virtual ICollection<RECOGNIZED_BANK_TRANSACTION> RECOGNIZED_BANK_TRANSACTIONs { get; set; } = new List<RECOGNIZED_BANK_TRANSACTION>();

    public virtual RECOGNIZED_BANK_TRANSACTION? RECOGNIZED_TRANSACTION { get; set; }
}
