namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public class Bill
{
    public uint Id { get; set; }
    public uint? VendorId { get; set; }
    public string? BillNumber { get; set; }
    public DateOnly? BillDate { get; set; }
    public DateOnly? DueDate { get; set; }
    public string? ReferenceNo { get; set; }
    public string? Status { get; set; }
    public string? Note { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Discount { get; set; }
    public string? DiscountType { get; set; }
    public decimal? Adjustment { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? PaymentAmount { get; set; }
    public decimal? LandedCostAmount { get; set; }
    public decimal? AllocatedCostAmount { get; set; }
    public decimal? CreditedAmount { get; set; }
    public string? InvLotNumber { get; set; }
    public DateOnly? OpenedAt { get; set; }
    public uint? UserId { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public uint? WarehouseId { get; set; }
    public uint? BranchId { get; set; }
    public uint? ProjectId { get; set; }
    public decimal? InvoicedAmount { get; set; }
    public bool? IsInclusiveTax { get; set; }
    public decimal? TaxAmountWithheld { get; set; }
    public virtual ICollection<BILLS_PAYMENTS_ENTRy> BillsPaymentsEntRies { get; set; } = new List<BILLS_PAYMENTS_ENTRy>();
    public virtual BRANCH? Branch { get; set; }
    public virtual PROJECT? Project { get; set; }
    public virtual CONTACT? Vendor { get; set; }
    public virtual ICollection<VENDOR_CREDIT_APPLIED_BILL> VendorCreditAppliedBilLs { get; set; } = new List<VENDOR_CREDIT_APPLIED_BILL>();
    public virtual WAREHOUSE? Warehouse { get; set; }
}
