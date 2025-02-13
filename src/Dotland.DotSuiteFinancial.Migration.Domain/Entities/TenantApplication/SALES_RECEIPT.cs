namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class SALES_RECEIPT
{
    public uint ID { get; set; }

    public decimal? AMOUNT { get; set; }

    public decimal? DISCOUNT { get; set; }

    public string? DISCOUNT_TYPE { get; set; }

    public decimal? ADJUSTMENT { get; set; }

    public string? CURRENCY_CODE { get; set; }

    public decimal? EXCHANGE_RATE { get; set; }

    public uint? DEPOSIT_ACCOUNT_ID { get; set; }

    public uint? CUSTOMER_ID { get; set; }

    public DateOnly? RECEIPT_DATE { get; set; }

    public string? RECEIPT_NUMBER { get; set; }

    public string? REFERENCE_NO { get; set; }

    public string? SEND_TO_EMAIL { get; set; }

    public string? RECEIPT_MESSAGE { get; set; }

    public string? STATEMENT { get; set; }

    public DateOnly? CLOSED_AT { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public uint? WAREHOUSE_ID { get; set; }

    public uint? BRANCH_ID { get; set; }

    public uint? PDF_TEMPLATE_ID { get; set; }

    public virtual BRANCH? BRANCH { get; set; }

    public virtual CONTACT? CUSTOMER { get; set; }

    public virtual Account? DEPOSIT_ACCOUNT { get; set; }

    public virtual PDF_TEMPLATE? PDF_TEMPLATE { get; set; }

    public virtual WAREHOUSE? WAREHOUSE { get; set; }
}
