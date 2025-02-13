namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public class AccountsTransaction
{
    public uint Id { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Debit { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? ExchangeRate { get; set; }
    public string? TransactionType { get; set; }
    public string? ReferenceType { get; set; }
    public int? ReferenceId { get; set; }
    public uint? AccountId { get; set; }
    public string? ContactType { get; set; }
    public uint? ContactId { get; set; }
    public string? TransactionNumber { get; set; }
    public string? ReferenceNumber { get; set; }
    public uint? ItemId { get; set; }
    public uint? ItemQuantity { get; set; }
    public string? Note { get; set; }
    public uint? UserId { get; set; }
    public uint? IndexGroup { get; set; }
    public uint? Index { get; set; }
    public DateOnly? Date { get; set; }
    public DateTime? CreatedAt { get; set; }
    public bool? Costable { get; set; }
    public uint? BranchId { get; set; }
    public uint? ProjectId { get; set; }
    public uint? TaxRateId { get; set; }
    public decimal? TaxRate { get; set; }
    public virtual Account? Account { get; set; }
    public virtual BRANCH? Branch { get; set; }
    public virtual PROJECT? Project { get; set; }
    public virtual TAX_RATE? TaxRateNavigation { get; set; }
}
