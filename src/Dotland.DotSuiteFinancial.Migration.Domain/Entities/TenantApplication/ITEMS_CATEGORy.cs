namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class ITEMS_CATEGORy
{
    public uint ID { get; set; }

    public string? NAME { get; set; }

    public string? DESCRIPTION { get; set; }

    public uint? USER_ID { get; set; }

    public uint? COST_ACCOUNT_ID { get; set; }

    public uint? SELL_ACCOUNT_ID { get; set; }

    public uint? INVENTORY_ACCOUNT_ID { get; set; }

    public string? COST_METHOD { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual Account? COST_ACCOUNT { get; set; }

    public virtual Account? INVENTORY_ACCOUNT { get; set; }

    public virtual ICollection<ITEM> ITEMs { get; set; } = new List<ITEM>();

    public virtual Account? SELL_ACCOUNT { get; set; }
}
