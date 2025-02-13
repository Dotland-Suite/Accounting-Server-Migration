namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class INVENTORY_TRANSACTION
{
    public uint ID { get; set; }

    public DateOnly? DATE { get; set; }

    public string? DIRECTION { get; set; }

    public uint? ITEM_ID { get; set; }

    public decimal? QUANTITY { get; set; }

    public decimal? RATE { get; set; }

    public string? TRANSACTION_TYPE { get; set; }

    public uint? TRANSACTION_ID { get; set; }

    public uint? ENTRY_ID { get; set; }

    public uint? COST_ACCOUNT_ID { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public uint? WAREHOUSE_ID { get; set; }

    public uint? BRANCH_ID { get; set; }

    public virtual BRANCH? BRANCH { get; set; }

    public virtual ITEM? ITEM { get; set; }

    public virtual WAREHOUSE? WAREHOUSE { get; set; }
}
