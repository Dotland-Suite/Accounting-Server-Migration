namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class WAREHOUSE
{
    public uint ID { get; set; }

    public string? NAME { get; set; }

    public string? CODE { get; set; }

    public string? ADDRESS { get; set; }

    public string? CITY { get; set; }

    public string? COUNTRY { get; set; }

    public string? PHONE_NUMBER { get; set; }

    public string? EMAIL { get; set; }

    public string? WEBSITE { get; set; }

    public bool? PRIMARY { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual ICollection<Bill> BILLs { get; set; } = new List<Bill>();

    public virtual ICollection<CREDIT_NOTE> CREDIT_NOTEs { get; set; } = new List<CREDIT_NOTE>();

    public virtual ICollection<INVENTORY_ADJUSTMENT> INVENTORY_ADJUSTMENTs { get; set; } = new List<INVENTORY_ADJUSTMENT>();

    public virtual ICollection<INVENTORY_COST_LOT_TRACKER> INVENTORY_COST_LOT_TRACKERs { get; set; } = new List<INVENTORY_COST_LOT_TRACKER>();

    public virtual ICollection<INVENTORY_TRANSACTION> INVENTORY_TRANSACTIONs { get; set; } = new List<INVENTORY_TRANSACTION>();

    public virtual ICollection<ITEMS_ENTRy> ITEMS_ENTRies { get; set; } = new List<ITEMS_ENTRy>();

    public virtual ICollection<SALES_ESTIMATE> SALES_ESTIMATEs { get; set; } = new List<SALES_ESTIMATE>();

    public virtual ICollection<SALES_INVOICE> SALES_INVOICEs { get; set; } = new List<SALES_INVOICE>();

    public virtual ICollection<SALES_RECEIPT> SALES_RECEIPTs { get; set; } = new List<SALES_RECEIPT>();

    public virtual ICollection<VENDOR_CREDIT> VENDOR_CREDITs { get; set; } = new List<VENDOR_CREDIT>();

    public virtual ICollection<WAREHOUSES_TRANSFER> WAREHOUSES_TRANSFERFROM_WAREHOUSEs { get; set; } = new List<WAREHOUSES_TRANSFER>();

    public virtual ICollection<WAREHOUSES_TRANSFER> WAREHOUSES_TRANSFERTO_WAREHOUSEs { get; set; } = new List<WAREHOUSES_TRANSFER>();
}
