namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class ITEM
{
    public uint ID { get; set; }

    public string? NAME { get; set; }

    public string? TYPE { get; set; }

    public string? CODE { get; set; }

    public bool? SELLABLE { get; set; }

    public bool? PURCHASABLE { get; set; }

    public decimal? SELL_PRICE { get; set; }

    public decimal? COST_PRICE { get; set; }

    public string? PICTURE_URI { get; set; }

    public uint? COST_ACCOUNT_ID { get; set; }

    public uint? SELL_ACCOUNT_ID { get; set; }

    public uint? INVENTORY_ACCOUNT_ID { get; set; }

    public string? SELL_DESCRIPTION { get; set; }

    public string? PURCHASE_DESCRIPTION { get; set; }

    public decimal? QUANTITY_ON_HAND { get; set; }

    public bool? LANDED_COST { get; set; }

    public string? NOTE { get; set; }

    public bool? ACTIVE { get; set; }

    public uint? CATEGORY_ID { get; set; }

    public uint? USER_ID { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public uint? SELL_TAX_RATE_ID { get; set; }

    public uint? PURCHASE_TAX_RATE_ID { get; set; }

    public virtual ITEMS_CATEGORy? CATEGORY { get; set; }

    public virtual Account? COST_ACCOUNT { get; set; }

    public virtual Account? INVENTORY_ACCOUNT { get; set; }

    public virtual ICollection<INVENTORY_ADJUSTMENTS_ENTRy> INVENTORY_ADJUSTMENTS_ENTRies { get; set; } = new List<INVENTORY_ADJUSTMENTS_ENTRy>();

    public virtual ICollection<INVENTORY_TRANSACTION> INVENTORY_TRANSACTIONs { get; set; } = new List<INVENTORY_TRANSACTION>();

    public virtual ICollection<ITEMS_ENTRy> ITEMS_ENTRies { get; set; } = new List<ITEMS_ENTRy>();

    public virtual TAX_RATE? PURCHASE_TAX_RATE { get; set; }

    public virtual Account? SELL_ACCOUNT { get; set; }

    public virtual TAX_RATE? SELL_TAX_RATE { get; set; }

    public virtual ICollection<WAREHOUSES_TRANSFERS_ENTRy> WAREHOUSES_TRANSFERS_ENTRies { get; set; } = new List<WAREHOUSES_TRANSFERS_ENTRy>();
}
