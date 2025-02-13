namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class INVENTORY_ADJUSTMENTS_ENTRy
{
    public uint ID { get; set; }

    public uint? ADJUSTMENT_ID { get; set; }

    public uint? INDEX { get; set; }

    public uint? ITEM_ID { get; set; }

    public int? QUANTITY { get; set; }

    public decimal? COST { get; set; }

    public decimal? VALUE { get; set; }

    public virtual INVENTORY_ADJUSTMENT? ADJUSTMENT { get; set; }

    public virtual ITEM? ITEM { get; set; }
}
