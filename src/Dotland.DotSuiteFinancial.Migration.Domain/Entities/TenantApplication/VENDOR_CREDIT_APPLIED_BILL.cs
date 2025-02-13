namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class VENDOR_CREDIT_APPLIED_BILL
{
    public uint ID { get; set; }

    public decimal? AMOUNT { get; set; }

    public uint? VENDOR_CREDIT_ID { get; set; }

    public uint? BILL_ID { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual Bill? BILL { get; set; }

    public virtual VENDOR_CREDIT? VENDOR_CREDIT { get; set; }
}
