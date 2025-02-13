namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class INVENTORY_TRANSACTION_METum
{
    public uint ID { get; set; }

    public string? TRANSACTION_NUMBER { get; set; }

    public string? DESCRIPTION { get; set; }

    public uint? INVENTORY_TRANSACTION_ID { get; set; }
}
