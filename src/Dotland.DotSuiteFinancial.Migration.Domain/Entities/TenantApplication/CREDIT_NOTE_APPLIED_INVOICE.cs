namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class CREDIT_NOTE_APPLIED_INVOICE
{
    public uint ID { get; set; }

    public decimal? AMOUNT { get; set; }

    public uint? CREDIT_NOTE_ID { get; set; }

    public uint? INVOICE_ID { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual CREDIT_NOTE? CREDIT_NOTE { get; set; }

    public virtual SALES_INVOICE? INVOICE { get; set; }
}
