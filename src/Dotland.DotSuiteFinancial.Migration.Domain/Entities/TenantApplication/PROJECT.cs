namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class PROJECT
{
    /// <summary>
    /// Auto-generated id
    /// </summary>
    public uint ID { get; set; }

    public string? NAME { get; set; }

    public uint? CONTACT_ID { get; set; }

    public DateOnly? DEADLINE { get; set; }

    public decimal? COST_ESTIMATE { get; set; }

    public string? STATUS { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual ICollection<AccountsTransaction> ACCOUNTS_TRANSACTIONs { get; set; } = new List<AccountsTransaction>();

    public virtual ICollection<Bill> BILLs { get; set; } = new List<Bill>();

    public virtual ICollection<EXPENSES_TRANSACTION> EXPENSES_TRANSACTIONs { get; set; } = new List<EXPENSES_TRANSACTION>();

    public virtual ICollection<EXPENSE_TRANSACTION_CATEGORy> EXPENSE_TRANSACTION_CATEGORies { get; set; } = new List<EXPENSE_TRANSACTION_CATEGORy>();

    public virtual ICollection<ITEMS_ENTRy> ITEMS_ENTRies { get; set; } = new List<ITEMS_ENTRy>();

    public virtual ICollection<MANUAL_JOURNALS_ENTRy> MANUAL_JOURNALS_ENTRies { get; set; } = new List<MANUAL_JOURNALS_ENTRy>();

    public virtual ICollection<SALES_INVOICE> SALES_INVOICEs { get; set; } = new List<SALES_INVOICE>();

    public virtual ICollection<TASK> TASKs { get; set; } = new List<TASK>();

    public virtual ICollection<TIME> TIMEs { get; set; } = new List<TIME>();
}
