namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class SALES_INVOICE
{
    public uint ID { get; set; }

    public uint? CUSTOMER_ID { get; set; }

    public DateOnly? INVOICE_DATE { get; set; }

    public DateOnly? DUE_DATE { get; set; }

    public string? INVOICE_NO { get; set; }

    public string? REFERENCE_NO { get; set; }

    public string? INVOICE_MESSAGE { get; set; }

    public string? TERMS_CONDITIONS { get; set; }

    public decimal? BALANCE { get; set; }

    public decimal? PAYMENT_AMOUNT { get; set; }

    public string? CURRENCY_CODE { get; set; }

    public decimal? EXCHANGE_RATE { get; set; }

    public decimal? CREDITED_AMOUNT { get; set; }

    public decimal? DISCOUNT { get; set; }

    public string? DISCOUNT_TYPE { get; set; }

    public decimal? ADJUSTMENT { get; set; }

    public string? INV_LOT_NUMBER { get; set; }

    public DateOnly? DELIVERED_AT { get; set; }

    public uint? USER_ID { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public decimal? WRITTENOFF_AMOUNT { get; set; }

    public DateOnly? WRITTENOFF_AT { get; set; }

    public uint? WAREHOUSE_ID { get; set; }

    public uint? BRANCH_ID { get; set; }

    public uint? WRITTENOFF_EXPENSE_ACCOUNT_ID { get; set; }

    public uint? PROJECT_ID { get; set; }

    public bool? IS_INCLUSIVE_TAX { get; set; }

    public decimal? TAX_AMOUNT_WITHHELD { get; set; }

    public uint? PDF_TEMPLATE_ID { get; set; }

    public virtual BRANCH? BRANCH { get; set; }

    public virtual ICollection<CREDIT_NOTE_APPLIED_INVOICE> CREDIT_NOTE_APPLIED_INVOICEs { get; set; } = new List<CREDIT_NOTE_APPLIED_INVOICE>();

    public virtual CONTACT? CUSTOMER { get; set; }

    public virtual ICollection<PAYMENT_RECEIVES_ENTRy> PAYMENT_RECEIVES_ENTRies { get; set; } = new List<PAYMENT_RECEIVES_ENTRy>();

    public virtual PDF_TEMPLATE? PDF_TEMPLATE { get; set; }

    public virtual PROJECT? PROJECT { get; set; }

    public virtual WAREHOUSE? WAREHOUSE { get; set; }

    public virtual Account? WRITTENOFF_EXPENSE_ACCOUNT { get; set; }
}
