namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class TAX_RATE_TRANSACTION
{
    public uint ID { get; set; }

    public uint? TAX_RATE_ID { get; set; }

    public string? REFERENCE_TYPE { get; set; }

    public int? REFERENCE_ID { get; set; }

    public decimal? RATE { get; set; }

    public uint? TAX_ACCOUNT_ID { get; set; }

    public virtual TAX_RATE? TAX_RATE { get; set; }
}
