namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class WAREHOUSES_TRANSFER
{
    public uint ID { get; set; }

    public DateOnly? DATE { get; set; }

    public uint? TO_WAREHOUSE_ID { get; set; }

    public uint? FROM_WAREHOUSE_ID { get; set; }

    public string? TRANSACTION_NUMBER { get; set; }

    public DateOnly? TRANSFER_INITIATED_AT { get; set; }

    public DateOnly? TRANSFER_DELIVERED_AT { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual WAREHOUSE? FROM_WAREHOUSE { get; set; }

    public virtual WAREHOUSE? TO_WAREHOUSE { get; set; }

    public virtual ICollection<WAREHOUSES_TRANSFERS_ENTRy> WAREHOUSES_TRANSFERS_ENTRies { get; set; } = new List<WAREHOUSES_TRANSFERS_ENTRy>();
}
