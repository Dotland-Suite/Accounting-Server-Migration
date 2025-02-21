namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public class BillLocatedCost
{
    public uint Id { get; set; }
    public decimal? Amount { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? ExchangeRate { get; set; }
    public uint? FromTransactionId { get; set; }
    public string? FromTransactionType { get; set; }
    public uint? FromTransactionEntryId { get; set; }
    public string? AllocationMethod { get; set; }
    public uint? CostAccountId { get; set; }
    public string? Description { get; set; }
    public uint? BillId { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
