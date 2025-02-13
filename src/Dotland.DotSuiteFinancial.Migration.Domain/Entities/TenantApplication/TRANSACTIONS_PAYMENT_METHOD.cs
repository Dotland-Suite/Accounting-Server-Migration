namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class TRANSACTIONS_PAYMENT_METHOD
{
    public uint ID { get; set; }

    public uint? REFERENCE_ID { get; set; }

    public string? REFERENCE_TYPE { get; set; }

    public uint? PAYMENT_INTEGRATION_ID { get; set; }

    public bool? ENABLE { get; set; }

    public string? OPTIONS { get; set; }

    public virtual PAYMENT_INTEGRATION? PAYMENT_INTEGRATION { get; set; }
}
