using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantApplication;

public class BillsPaymentEntityConfiguration : IEntityTypeConfiguration<BILLS_PAYMENT>
{
    public void Configure(EntityTypeBuilder<BILLS_PAYMENT> entity)
    {
        entity
            .ToTable("BILLS_PAYMENTS")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");
        
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.Property(e => e.Amount).HasDefaultValueSql("'0.000'");
        entity.HasOne(d => d.Branch).WithMany(p => p.BILLS_PAYMENTs)
            .HasConstraintName("BILLS_PAYMENTS_BRANCH_ID_FOREIGN");
        entity.HasOne(d => d.PaymentAccount).WithMany(p => p.BillsPayments)
            .HasConstraintName("BILLS_PAYMENTS_PAYMENT_ACCOUNT_ID_FOREIGN");
        entity.HasOne(d => d.Vendor).WithMany(p => p.BILLS_PAYMENTs)
            .HasConstraintName("BILLS_PAYMENTS_VENDOR_ID_FOREIGN");
        
        entity.Property(e => e.Id)
            .HasColumnName("ID");
        
        entity.Property(e => e.VendorId)
            .HasColumnName("VENDOR_ID");
        
        entity.Property(e => e.Amount)
            .HasColumnName("AMOUNT");
        
        entity.Property(e => e.CurrencyCode)
            .HasColumnName("CURRENCY_CODE");
        
        entity.Property(e => e.ExchangeRate)
            .HasColumnName("EXCHANGE_RATE");
        
        entity.Property(e => e.PaymentAccountId)
            .HasColumnName("PAYMENT_ACCOUNT_ID");
        
        entity.Property(e => e.PaymentNumber)
            .HasColumnName("PAYMENT_NUMBER");
        
        entity.Property(e => e.PaymentDate)
            .HasColumnName("PAYMENT_DATE");
        
        entity.Property(e => e.PaymentMethod)
            .HasColumnName("PAYMENT_METHOD");
        
        entity.Property(e => e.Reference)
            .HasColumnName("REFERENCE");
        
        entity.Property(e => e.UserId)
            .HasColumnName("USER_ID");
        
        entity.Property(e => e.Statement)
            .HasColumnName("STATEMENT");
        
        entity.Property(e => e.CreatedAt)
            .HasColumnName("CREATED_AT");
        
        entity.Property(e => e.UpdatedAt)
            .HasColumnName("UPDATED_AT");
        
        entity.Property(e => e.BranchId)
            .HasColumnName("BRANCH_ID");
    }
}