namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class CONTACT
{
    public uint ID { get; set; }

    public string? CONTACT_SERVICE { get; set; }

    public string? CONTACT_TYPE { get; set; }

    public decimal? BALANCE { get; set; }

    public string? CURRENCY_CODE { get; set; }

    public decimal? OPENING_BALANCE { get; set; }

    public DateOnly? OPENING_BALANCE_AT { get; set; }

    public decimal? OPENING_BALANCE_EXCHANGE_RATE { get; set; }

    public uint? OPENING_BALANCE_BRANCH_ID { get; set; }

    public string? SALUTATION { get; set; }

    public string? FIRST_NAME { get; set; }

    public string? LAST_NAME { get; set; }

    public string? COMPANY_NAME { get; set; }

    public string? DISPLAY_NAME { get; set; }

    public string? EMAIL { get; set; }

    public string? WORK_PHONE { get; set; }

    public string? PERSONAL_PHONE { get; set; }

    public string? WEBSITE { get; set; }

    public string? BILLING_ADDRESS1 { get; set; }

    public string? BILLING_ADDRESS2 { get; set; }

    public string? BILLING_ADDRESS_CITY { get; set; }

    public string? BILLING_ADDRESS_COUNTRY { get; set; }

    public string? BILLING_ADDRESS_EMAIL { get; set; }

    public string? BILLING_ADDRESS_POSTCODE { get; set; }

    public string? BILLING_ADDRESS_PHONE { get; set; }

    public string? BILLING_ADDRESS_STATE { get; set; }

    public string? SHIPPING_ADDRESS1 { get; set; }

    public string? SHIPPING_ADDRESS2 { get; set; }

    public string? SHIPPING_ADDRESS_CITY { get; set; }

    public string? SHIPPING_ADDRESS_COUNTRY { get; set; }

    public string? SHIPPING_ADDRESS_EMAIL { get; set; }

    public string? SHIPPING_ADDRESS_POSTCODE { get; set; }

    public string? SHIPPING_ADDRESS_PHONE { get; set; }

    public string? SHIPPING_ADDRESS_STATE { get; set; }

    public string? NOTE { get; set; }

    public bool? ACTIVE { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual ICollection<BILLS_PAYMENT> BILLS_PAYMENTs { get; set; } = new List<BILLS_PAYMENT>();

    public virtual ICollection<Bill> BILLs { get; set; } = new List<Bill>();

    public virtual ICollection<CREDIT_NOTE> CREDIT_NOTEs { get; set; } = new List<CREDIT_NOTE>();

    public virtual ICollection<EXPENSES_TRANSACTION> EXPENSES_TRANSACTIONs { get; set; } = new List<EXPENSES_TRANSACTION>();

    public virtual BRANCH? OPENING_BALANCE_BRANCH { get; set; }

    public virtual ICollection<PAYMENT_RECEIfe> PAYMENT_RECEIves { get; set; } = new List<PAYMENT_RECEIfe>();

    public virtual ICollection<SALES_ESTIMATE> SALES_ESTIMATEs { get; set; } = new List<SALES_ESTIMATE>();

    public virtual ICollection<SALES_INVOICE> SALES_INVOICEs { get; set; } = new List<SALES_INVOICE>();

    public virtual ICollection<SALES_RECEIPT> SALES_RECEIPTs { get; set; } = new List<SALES_RECEIPT>();

    public virtual ICollection<VENDOR_CREDIT> VENDOR_CREDITs { get; set; } = new List<VENDOR_CREDIT>();
}
