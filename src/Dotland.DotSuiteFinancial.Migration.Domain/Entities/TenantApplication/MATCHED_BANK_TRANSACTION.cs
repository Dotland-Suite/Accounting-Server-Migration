namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class MATCHED_BANK_TRANSACTION
{
    public uint ID { get; set; }

    public uint? UNCATEGORIZED_TRANSACTION_ID { get; set; }

    public string? REFERENCE_TYPE { get; set; }

    public uint? REFERENCE_ID { get; set; }

    public decimal? AMOUNT { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual UNCATEGORIZED_CASHFLOW_TRANSACTION? UNCATEGORIZED_TRANSACTION { get; set; }
}
