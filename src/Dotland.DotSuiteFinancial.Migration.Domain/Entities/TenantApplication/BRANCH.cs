namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class BRANCH
{
    public uint ID { get; set; }

    public string? NAME { get; set; }

    public string? CODE { get; set; }

    public string? ADDRESS { get; set; }

    public string? CITY { get; set; }

    public string? COUNTRY { get; set; }

    public string? PHONE_NUMBER { get; set; }

    public string? EMAIL { get; set; }

    public string? WEBSITE { get; set; }

    public bool? PRIMARY { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual ICollection<AccountsTransaction> ACCOUNTS_TRANSACTIONs { get; set; } = new List<AccountsTransaction>();

    public virtual ICollection<BILLS_PAYMENT> BILLS_PAYMENTs { get; set; } = new List<BILLS_PAYMENT>();

    public virtual ICollection<Bill> BILLs { get; set; } = new List<Bill>();

    public virtual ICollection<CASHFLOW_TRANSACTION> CASHFLOW_TRANSACTIONs { get; set; } = new List<CASHFLOW_TRANSACTION>();

    public virtual ICollection<CONTACT> CONTACTs { get; set; } = new List<CONTACT>();

    public virtual ICollection<CREDIT_NOTE> CREDIT_NOTEs { get; set; } = new List<CREDIT_NOTE>();

    public virtual ICollection<EXPENSES_TRANSACTION> EXPENSES_TRANSACTIONs { get; set; } = new List<EXPENSES_TRANSACTION>();

    public virtual ICollection<INVENTORY_ADJUSTMENT> INVENTORY_ADJUSTMENTs { get; set; } = new List<INVENTORY_ADJUSTMENT>();

    public virtual ICollection<INVENTORY_COST_LOT_TRACKER> INVENTORY_COST_LOT_TRACKERs { get; set; } = new List<INVENTORY_COST_LOT_TRACKER>();

    public virtual ICollection<INVENTORY_TRANSACTION> INVENTORY_TRANSACTIONs { get; set; } = new List<INVENTORY_TRANSACTION>();

    public virtual ICollection<MANUAL_JOURNALS_ENTRy> MANUAL_JOURNALS_ENTRies { get; set; } = new List<MANUAL_JOURNALS_ENTRy>();

    public virtual ICollection<MANUAL_JOURNAL> MANUAL_JOURNALs { get; set; } = new List<MANUAL_JOURNAL>();

    public virtual ICollection<PAYMENT_RECEIfe> PAYMENT_RECEIves { get; set; } = new List<PAYMENT_RECEIfe>();

    public virtual ICollection<REFUND_CREDIT_NOTE_TRANSACTION> REFUND_CREDIT_NOTE_TRANSACTIONs { get; set; } = new List<REFUND_CREDIT_NOTE_TRANSACTION>();

    public virtual ICollection<REFUND_VENDOR_CREDIT_TRANSACTION> REFUND_VENDOR_CREDIT_TRANSACTIONs { get; set; } = new List<REFUND_VENDOR_CREDIT_TRANSACTION>();

    public virtual ICollection<SALES_ESTIMATE> SALES_ESTIMATEs { get; set; } = new List<SALES_ESTIMATE>();

    public virtual ICollection<SALES_INVOICE> SALES_INVOICEs { get; set; } = new List<SALES_INVOICE>();

    public virtual ICollection<SALES_RECEIPT> SALES_RECEIPTs { get; set; } = new List<SALES_RECEIPT>();

    public virtual ICollection<VENDOR_CREDIT> VENDOR_CREDITs { get; set; } = new List<VENDOR_CREDIT>();
}
