namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public class BankRule
{
    public uint Id { get; set; }
    public string? Name { get; set; }
    public uint? Order { get; set; }
    public uint? ApplyIfAccountId { get; set; }
    public string? ApplyIfTransactionType { get; set; }
    public string? AssignCategory { get; set; }
    public uint? AssignAccountId { get; set; }
    public string? AssignPayee { get; set; }
    public string? AssignMemo { get; set; }
    public string? ConditionsType { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public virtual Account? ApplyIfAccount { get; set; }
    public virtual Account? AssignAccount { get; set; }

    public virtual ICollection<BankRuleCondition> BankRuleConditions { get; set; } = new List<BankRuleCondition>();

    public virtual ICollection<RECOGNIZED_BANK_TRANSACTION> RecognizedBankTransactions { get; set; } = new List<RECOGNIZED_BANK_TRANSACTION>();
}
