namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class VENDOR_CREDIT
{
    public uint ID { get; set; }

    public uint? VENDOR_ID { get; set; }

    public decimal? AMOUNT { get; set; }

    public decimal? DISCOUNT { get; set; }

    public string? DISCOUNT_TYPE { get; set; }

    public decimal? ADJUSTMENT { get; set; }

    public string? CURRENCY_CODE { get; set; }

    public decimal? EXCHANGE_RATE { get; set; }

    public DateOnly? VENDOR_CREDIT_DATE { get; set; }

    public string? VENDOR_CREDIT_NUMBER { get; set; }

    public string? REFERENCE_NO { get; set; }

    public decimal? REFUNDED_AMOUNT { get; set; }

    public decimal? INVOICED_AMOUNT { get; set; }

    public string? NOTE { get; set; }

    public DateOnly? OPENED_AT { get; set; }

    public uint? USER_ID { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public uint? BRANCH_ID { get; set; }

    public uint? WAREHOUSE_ID { get; set; }

    public virtual BRANCH? BRANCH { get; set; }

    public virtual ICollection<REFUND_VENDOR_CREDIT_TRANSACTION> REFUND_VENDOR_CREDIT_TRANSACTIONs { get; set; } = new List<REFUND_VENDOR_CREDIT_TRANSACTION>();

    public virtual USER? USER { get; set; }

    public virtual CONTACT? VENDOR { get; set; }

    public virtual ICollection<VENDOR_CREDIT_APPLIED_BILL> VENDOR_CREDIT_APPLIED_BILLs { get; set; } = new List<VENDOR_CREDIT_APPLIED_BILL>();

    public virtual WAREHOUSE? WAREHOUSE { get; set; }
}
