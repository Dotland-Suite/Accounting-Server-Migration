namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class BILLS_PAYMENT
{
    public uint ID { get; set; }

    public uint? VENDOR_ID { get; set; }

    public decimal? AMOUNT { get; set; }

    public string? CURRENCY_CODE { get; set; }

    public decimal? EXCHANGE_RATE { get; set; }

    public uint? PAYMENT_ACCOUNT_ID { get; set; }

    public string? PAYMENT_NUMBER { get; set; }

    public DateOnly? PAYMENT_DATE { get; set; }

    public string? PAYMENT_METHOD { get; set; }

    public string? REFERENCE { get; set; }

    public uint? USER_ID { get; set; }

    public string? STATEMENT { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public uint? BRANCH_ID { get; set; }

    public virtual ICollection<BILLS_PAYMENTS_ENTRy> BILLS_PAYMENTS_ENTRies { get; set; } = new List<BILLS_PAYMENTS_ENTRy>();

    public virtual BRANCH? BRANCH { get; set; }

    public virtual Account? PAYMENT_ACCOUNT { get; set; }

    public virtual CONTACT? VENDOR { get; set; }
}
