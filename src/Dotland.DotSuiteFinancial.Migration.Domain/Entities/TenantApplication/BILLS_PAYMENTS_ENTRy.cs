namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class BILLS_PAYMENTS_ENTRy
{
    public uint ID { get; set; }

    public uint? BILL_PAYMENT_ID { get; set; }

    public uint? BILL_ID { get; set; }

    public decimal? PAYMENT_AMOUNT { get; set; }

    public uint? INDEX { get; set; }

    public virtual Bill? BILL { get; set; }

    public virtual BILLS_PAYMENT? BILL_PAYMENT { get; set; }
}
