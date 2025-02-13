namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class EXPENSE_TRANSACTION_CATEGORy
{
    public uint ID { get; set; }

    public uint? EXPENSE_ACCOUNT_ID { get; set; }

    public uint? INDEX { get; set; }

    public string? DESCRIPTION { get; set; }

    public decimal? AMOUNT { get; set; }

    public decimal? ALLOCATED_COST_AMOUNT { get; set; }

    public bool? LANDED_COST { get; set; }

    public uint? EXPENSE_ID { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public uint? PROJECT_ID { get; set; }

    public virtual EXPENSES_TRANSACTION? EXPENSE { get; set; }

    public virtual Account? EXPENSE_ACCOUNT { get; set; }

    public virtual PROJECT? PROJECT { get; set; }
}
