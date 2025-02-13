namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class INVENTORY_ADJUSTMENT
{
    public uint ID { get; set; }

    public DateOnly? DATE { get; set; }

    public string? TYPE { get; set; }

    public uint? ADJUSTMENT_ACCOUNT_ID { get; set; }

    public string? REASON { get; set; }

    public string? REFERENCE_NO { get; set; }

    public string? DESCRIPTION { get; set; }

    public uint? USER_ID { get; set; }

    public DateOnly? PUBLISHED_AT { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public uint? BRANCH_ID { get; set; }

    public uint? WAREHOUSE_ID { get; set; }

    public virtual Account? ADJUSTMENT_ACCOUNT { get; set; }

    public virtual BRANCH? BRANCH { get; set; }

    public virtual ICollection<INVENTORY_ADJUSTMENTS_ENTRy> INVENTORY_ADJUSTMENTS_ENTRies { get; set; } = new List<INVENTORY_ADJUSTMENTS_ENTRy>();

    public virtual WAREHOUSE? WAREHOUSE { get; set; }
}
