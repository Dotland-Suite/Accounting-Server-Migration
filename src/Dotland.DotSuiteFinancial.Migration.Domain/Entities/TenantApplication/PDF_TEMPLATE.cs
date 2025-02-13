namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class PDF_TEMPLATE
{
    public uint ID { get; set; }

    public string? RESOURCE { get; set; }

    public string? TEMPLATE_NAME { get; set; }

    public string? ATTRIBUTES { get; set; }

    public bool? PREDEFINED { get; set; }

    public bool? DEFAULT { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual ICollection<CREDIT_NOTE> CREDIT_NOTEs { get; set; } = new List<CREDIT_NOTE>();

    public virtual ICollection<PAYMENT_RECEIfe> PAYMENT_RECEIves { get; set; } = new List<PAYMENT_RECEIfe>();

    public virtual ICollection<SALES_ESTIMATE> SALES_ESTIMATEs { get; set; } = new List<SALES_ESTIMATE>();

    public virtual ICollection<SALES_INVOICE> SALES_INVOICEs { get; set; } = new List<SALES_INVOICE>();

    public virtual ICollection<SALES_RECEIPT> SALES_RECEIPTs { get; set; } = new List<SALES_RECEIPT>();
}
