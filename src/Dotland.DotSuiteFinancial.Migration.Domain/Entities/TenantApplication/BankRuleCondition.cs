namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public class BankRuleCondition
{
    public uint Id { get; set; }
    public uint? RuleId { get; set; }
    public string? Field { get; set; }
    public string? Comparator { get; set; }
    public string? Value { get; set; }
    public virtual BankRule? Rule { get; set; }
}
