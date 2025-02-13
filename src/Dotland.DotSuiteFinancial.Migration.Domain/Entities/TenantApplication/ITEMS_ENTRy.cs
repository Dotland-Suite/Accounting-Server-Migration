namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class ITEMS_ENTRy
{
    public uint ID { get; set; }

    public string? REFERENCE_TYPE { get; set; }

    public string? REFERENCE_ID { get; set; }

    public uint? INDEX { get; set; }

    public uint? ITEM_ID { get; set; }

    public string? DESCRIPTION { get; set; }

    public uint? DISCOUNT { get; set; }

    public string? DISCOUNT_TYPE { get; set; }

    public decimal? QUANTITY { get; set; }

    public decimal? RATE { get; set; }

    public uint? SELL_ACCOUNT_ID { get; set; }

    public uint? COST_ACCOUNT_ID { get; set; }

    public bool? LANDED_COST { get; set; }

    public decimal? ALLOCATED_COST_AMOUNT { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public uint? WAREHOUSE_ID { get; set; }

    public uint? PROJECT_ID { get; set; }

    public uint? PROJECT_REF_ID { get; set; }

    public string? PROJECT_REF_TYPE { get; set; }

    public decimal? PROJECT_REF_INVOICED_AMOUNT { get; set; }

    public bool? IS_INCLUSIVE_TAX { get; set; }

    public uint? TAX_RATE_ID { get; set; }

    public decimal? TAX_RATE { get; set; }

    public virtual Account? COST_ACCOUNT { get; set; }

    public virtual ITEM? ITEM { get; set; }

    public virtual PROJECT? PROJECT { get; set; }

    public virtual Account? SELL_ACCOUNT { get; set; }

    public virtual TAX_RATE? TAX_RATENavigation { get; set; }

    public virtual WAREHOUSE? WAREHOUSE { get; set; }
}
