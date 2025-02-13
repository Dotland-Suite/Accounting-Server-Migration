namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class SALES_ESTIMATE
{
    public uint ID { get; set; }

    public decimal? AMOUNT { get; set; }

    public decimal? DISCOUNT { get; set; }

    public string? DISCOUNT_TYPE { get; set; }

    public decimal? ADJUSTMENT { get; set; }

    public string? CURRENCY_CODE { get; set; }

    public uint? CUSTOMER_ID { get; set; }

    public DateOnly? ESTIMATE_DATE { get; set; }

    public DateOnly? EXPIRATION_DATE { get; set; }

    public string? REFERENCE { get; set; }

    public string? ESTIMATE_NUMBER { get; set; }

    public string? NOTE { get; set; }

    public string? TERMS_CONDITIONS { get; set; }

    public string? SEND_TO_EMAIL { get; set; }

    public DateOnly? DELIVERED_AT { get; set; }

    public DateOnly? APPROVED_AT { get; set; }

    public DateOnly? REJECTED_AT { get; set; }

    public uint? USER_ID { get; set; }

    public uint? CONVERTED_TO_INVOICE_ID { get; set; }

    public DateOnly? CONVERTED_TO_INVOICE_AT { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public uint? WAREHOUSE_ID { get; set; }

    public uint? BRANCH_ID { get; set; }

    public decimal? EXCHANGE_RATE { get; set; }

    public uint? PDF_TEMPLATE_ID { get; set; }

    public virtual BRANCH? BRANCH { get; set; }

    public virtual CONTACT? CUSTOMER { get; set; }

    public virtual PDF_TEMPLATE? PDF_TEMPLATE { get; set; }

    public virtual WAREHOUSE? WAREHOUSE { get; set; }
}
