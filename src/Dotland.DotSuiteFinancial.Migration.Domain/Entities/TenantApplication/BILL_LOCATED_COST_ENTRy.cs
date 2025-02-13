namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class BILL_LOCATED_COST_ENTRy
{
    public uint ID { get; set; }

    public decimal? COST { get; set; }

    public uint? ENTRY_ID { get; set; }

    public uint? BILL_LOCATED_COST_ID { get; set; }
}
