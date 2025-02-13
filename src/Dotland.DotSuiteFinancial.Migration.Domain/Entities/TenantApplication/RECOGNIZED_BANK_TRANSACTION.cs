namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class RECOGNIZED_BANK_TRANSACTION
{
    public uint ID { get; set; }

    public uint? UNCATEGORIZED_TRANSACTION_ID { get; set; }

    public uint? BANK_RULE_ID { get; set; }

    public string? ASSIGNED_CATEGORY { get; set; }

    public uint? ASSIGNED_ACCOUNT_ID { get; set; }

    public string? ASSIGNED_PAYEE { get; set; }

    public string? ASSIGNED_MEMO { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual Account? ASSIGNED_ACCOUNT { get; set; }

    public virtual BankRule? BANK_RULE { get; set; }

    public virtual ICollection<UNCATEGORIZED_CASHFLOW_TRANSACTION> UNCATEGORIZED_CASHFLOW_TRANSACTIONs { get; set; } = new List<UNCATEGORIZED_CASHFLOW_TRANSACTION>();

    public virtual UNCATEGORIZED_CASHFLOW_TRANSACTION? UNCATEGORIZED_TRANSACTION { get; set; }
}
