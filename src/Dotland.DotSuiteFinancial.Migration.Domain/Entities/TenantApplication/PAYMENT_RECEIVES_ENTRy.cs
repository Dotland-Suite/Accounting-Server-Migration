namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class PAYMENT_RECEIVES_ENTRy
{
    public uint ID { get; set; }

    public uint? PAYMENT_RECEIVE_ID { get; set; }

    public uint? INVOICE_ID { get; set; }

    public decimal? PAYMENT_AMOUNT { get; set; }

    public uint? INDEX { get; set; }

    public virtual SALES_INVOICE? INVOICE { get; set; }

    public virtual PAYMENT_RECEIfe? PAYMENT_RECEIVE { get; set; }
}
