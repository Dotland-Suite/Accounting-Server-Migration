namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class CREDIT_NOTE
{
    public uint ID { get; set; }

    public uint? CUSTOMER_ID { get; set; }

    public DateOnly? CREDIT_NOTE_DATE { get; set; }

    public string? CREDIT_NOTE_NUMBER { get; set; }

    public string? REFERENCE_NO { get; set; }

    public decimal? AMOUNT { get; set; }

    public decimal? REFUNDED_AMOUNT { get; set; }

    public decimal? INVOICES_AMOUNT { get; set; }

    public string? CURRENCY_CODE { get; set; }

    public decimal? EXCHANGE_RATE { get; set; }

    public decimal? DISCOUNT { get; set; }

    public string? DISCOUNT_TYPE { get; set; }

    public decimal? ADJUSTMENT { get; set; }

    public string? NOTE { get; set; }

    public string? TERMS_CONDITIONS { get; set; }

    public DateOnly? OPENED_AT { get; set; }

    public uint? USER_ID { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public uint? WAREHOUSE_ID { get; set; }

    public uint? BRANCH_ID { get; set; }

    public uint? PDF_TEMPLATE_ID { get; set; }

    public virtual BRANCH? BRANCH { get; set; }

    public virtual ICollection<CREDIT_NOTE_APPLIED_INVOICE> CREDIT_NOTE_APPLIED_INVOICEs { get; set; } = new List<CREDIT_NOTE_APPLIED_INVOICE>();

    public virtual CONTACT? CUSTOMER { get; set; }

    public virtual PDF_TEMPLATE? PDF_TEMPLATE { get; set; }

    public virtual ICollection<REFUND_CREDIT_NOTE_TRANSACTION> REFUND_CREDIT_NOTE_TRANSACTIONs { get; set; } = new List<REFUND_CREDIT_NOTE_TRANSACTION>();

    public virtual USER? USER { get; set; }

    public virtual WAREHOUSE? WAREHOUSE { get; set; }
}
