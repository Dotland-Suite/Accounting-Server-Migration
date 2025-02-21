namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public class BillLocatedCostEntry
{
    public uint Id { get; set; }
    public decimal? Cost { get; set; }
    public uint? EntryId { get; set; }
    public uint? BillLocatedCostId { get; set; }
}
