using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantApplication;

public class BillEntityConfiguration : IEntityTypeConfiguration<Bill>
{
    public void Configure(EntityTypeBuilder<Bill> entity)
    {
        entity
            .ToTable("BILL")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");
        
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        entity.Property(e => e.AllocatedCostAmount).HasDefaultValueSql("'0.000'");
        entity.Property(e => e.Amount).HasDefaultValueSql("'0.000'");
        entity.Property(e => e.CreditedAmount).HasDefaultValueSql("'0.000'");
        entity.Property(e => e.InvoicedAmount).HasDefaultValueSql("'0.00'");
        entity.Property(e => e.IsInclusiveTax).HasDefaultValueSql("'0'");
        entity.Property(e => e.LandedCostAmount).HasDefaultValueSql("'0.000'");
        entity.Property(e => e.PaymentAmount).HasDefaultValueSql("'0.000'");

        entity.Property(e => e.Id).HasColumnName("ID");
        entity.Property(e => e.VendorId).HasColumnName("VENDOR_ID");
        entity.Property(e => e.BillNumber).HasColumnName("BILL_NUMBER");
        entity.Property(e => e.BillDate).HasColumnName("BILL_DATE");
        entity.Property(e => e.DueDate).HasColumnName("DUE_DATE");
        entity.Property(e => e.ReferenceNo).HasColumnName("REFERENCE_NO");
        entity.Property(e => e.Status).HasColumnName("STATUS");
        entity.Property(e => e.Note ).HasColumnName("NOTE");
        entity.Property(e => e.Amount ).HasColumnName("AMOUNT");
        entity.Property(e => e.Discount ).HasColumnName("DISCOUNT");
        entity.Property(e => e.DiscountType ).HasColumnName("DISCOUNT_TYPE");
        entity.Property(e => e.Adjustment).HasColumnName("ADJUSTMENT");
        entity.Property(e => e.CurrencyCode ).HasColumnName("CURRENCY_CODE");
        entity.Property(e => e.ExchangeRate ).HasColumnName("EXCHANGE_RATE");
        entity.Property(e => e.PaymentAmount ).HasColumnName("PAYMENT_AMOUNT");
        entity.Property(e => e.LandedCostAmount).HasColumnName("LANDED_COST_AMOUNT");
        entity.Property(e => e.AllocatedCostAmount ).HasColumnName("ALLOCATED_COST_AMOUNT");
        entity.Property(e => e.CreditedAmount ).HasColumnName("CREDITED_AMOUNT");
        entity.Property(e => e.InvLotNumber ).HasColumnName("INV_LOT_NUMBER");
        entity.Property(e => e.OpenedAt ).HasColumnName("OPENED_AT");
        entity.Property(e => e.UserId ).HasColumnName("USER_ID");
        entity.Property(e => e.CreatedAt ).HasColumnName("CREATED_AT");
        entity.Property(e => e.UpdatedAt ).HasColumnName("UPDATED_AT");
        entity.Property(e => e.WarehouseId ).HasColumnName("WAREHOUSE_ID");
        entity.Property(e => e.BranchId ).HasColumnName("BRANCH_ID");
        entity.Property(e => e.ProjectId ).HasColumnName("PROJECT_ID");
        entity.Property(e => e.InvoicedAmount ).HasColumnName("INVOICED_AMOUNT");
        entity.Property(e => e.IsInclusiveTax ).HasColumnName("IS_INCLUSIVE_TAX");
        entity.Property(e => e.TaxAmountWithheld ).HasColumnName("TAX_AMOUNT_WITHHELD");
        
        entity.HasOne(d => d.Branch).WithMany(p => p.BILLs).HasConstraintName("BILLS_BRANCH_ID_FOREIGN");
        entity.HasOne(d => d.Project).WithMany(p => p.BILLs).HasConstraintName("BILLS_PROJECTID_FOREIGN");
        entity.HasOne(d => d.Vendor).WithMany(p => p.BILLs).HasConstraintName("BILLS_VENDOR_ID_FOREIGN");
        entity.HasOne(d => d.Warehouse).WithMany(p => p.BILLs).HasConstraintName("BILLS_WAREHOUSE_ID_FOREIGN");
    }
}