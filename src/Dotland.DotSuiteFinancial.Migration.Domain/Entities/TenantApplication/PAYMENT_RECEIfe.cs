namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class PAYMENT_RECEIfe
{
    public uint ID { get; set; }

    public uint? CUSTOMER_ID { get; set; }

    public DateOnly? PAYMENT_DATE { get; set; }

    public decimal? AMOUNT { get; set; }

    public string? CURRENCY_CODE { get; set; }

    public decimal? EXCHANGE_RATE { get; set; }

    public string? REFERENCE_NO { get; set; }

    public uint? DEPOSIT_ACCOUNT_ID { get; set; }

    public string? PAYMENT_RECEIVE_NO { get; set; }

    public string? STATEMENT { get; set; }

    public uint? USER_ID { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public uint? BRANCH_ID { get; set; }

    public string? STRIPE_PINTENT_ID { get; set; }

    public uint? PDF_TEMPLATE_ID { get; set; }

    public virtual BRANCH? BRANCH { get; set; }

    public virtual CONTACT? CUSTOMER { get; set; }

    public virtual Account? DEPOSIT_ACCOUNT { get; set; }

    public virtual ICollection<PAYMENT_RECEIVES_ENTRy> PAYMENT_RECEIVES_ENTRies { get; set; } = new List<PAYMENT_RECEIVES_ENTRy>();

    public virtual PDF_TEMPLATE? PDF_TEMPLATE { get; set; }
}
