namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class PAYMENT_INTEGRATION
{
    public uint ID { get; set; }

    public string? SERVICE { get; set; }

    public string? NAME { get; set; }

    public string? SLUG { get; set; }

    public bool? PAYMENT_ENABLED { get; set; }

    public bool? PAYOUT_ENABLED { get; set; }

    public string? ACCOUNT_ID { get; set; }

    public string? OPTIONS { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual ICollection<TRANSACTIONS_PAYMENT_METHOD> TRANSACTIONS_PAYMENT_METHODs { get; set; } = new List<TRANSACTIONS_PAYMENT_METHOD>();
}
