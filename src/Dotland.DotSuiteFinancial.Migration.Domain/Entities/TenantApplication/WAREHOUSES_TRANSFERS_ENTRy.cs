namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class WAREHOUSES_TRANSFERS_ENTRy
{
    public uint ID { get; set; }

    public int? INDEX { get; set; }

    public uint? WAREHOUSE_TRANSFER_ID { get; set; }

    public uint? ITEM_ID { get; set; }

    public string? DESCRIPTION { get; set; }

    public int? QUANTITY { get; set; }

    public decimal? COST { get; set; }

    public virtual ITEM? ITEM { get; set; }

    public virtual WAREHOUSES_TRANSFER? WAREHOUSE_TRANSFER { get; set; }
}
