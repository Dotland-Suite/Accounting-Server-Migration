namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public class BILLS_PAYMENT
{
    public uint Id { get; set; }
    public uint? VendorId { get; set; }
    public decimal? Amount { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? ExchangeRate { get; set; }
    public uint? PaymentAccountId { get; set; }
    public string? PaymentNumber { get; set; }
    public DateOnly? PaymentDate { get; set; }
    public string? PaymentMethod { get; set; }
    public string? Reference { get; set; }
    public uint? UserId { get; set; }
    public string? Statement { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public uint? BranchId { get; set; }
    public virtual ICollection<BILLS_PAYMENTS_ENTRy> BillsPaymentsEntRies { get; set; } = new List<BILLS_PAYMENTS_ENTRy>();
    public virtual BRANCH? Branch { get; set; }
    public virtual Account? PaymentAccount { get; set; }
    public virtual CONTACT? Vendor { get; set; }
}
