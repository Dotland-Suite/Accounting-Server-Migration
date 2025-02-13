namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class ITEMS_WAREHOUSES_QUANTITY
{
    public uint? ITEM_ID { get; set; }

    public uint? WAREHOUSE_ID { get; set; }

    public int? QUANTITY_ON_HAND { get; set; }

    public virtual ITEM? ITEM { get; set; }

    public virtual WAREHOUSE? WAREHOUSE { get; set; }
}
