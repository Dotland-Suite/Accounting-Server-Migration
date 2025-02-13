namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class PLAID_ITEM
{
    public uint ID { get; set; }

    public uint? TENANT_ID { get; set; }

    public string? PLAID_ITEM_ID { get; set; }

    public string? PLAID_INSTITUTION_ID { get; set; }

    public string? PLAID_ACCESS_TOKEN { get; set; }

    public string? LAST_CURSOR { get; set; }

    public string? STATUS { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public DateTime? PAUSED_AT { get; set; }
}
