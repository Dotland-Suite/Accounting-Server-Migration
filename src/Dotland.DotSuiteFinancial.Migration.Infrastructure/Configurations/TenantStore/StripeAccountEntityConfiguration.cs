using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantStore;

public class StripeAccountEntityConfiguration : IEntityTypeConfiguration<StripeAccount>
{
    public void Configure(EntityTypeBuilder<StripeAccount> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder
            .ToTable("STRIPE_ACCOUNTS")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");

        builder.Property(e => e.Id).HasColumnType("int(10) unsigned");
        builder.Property(e => e.CreatedAt)
            .HasDefaultValueSql("current_timestamp()")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.StripeAccountId).HasMaxLength(255);
        builder.Property(e => e.TenantId).HasMaxLength(255);
        builder.Property(e => e.UpdatedAt)
            .HasDefaultValueSql("current_timestamp()")
            .HasColumnType("timestamp");

        builder.Property(e => e.Id).HasColumnName("ID");
        builder.Property(e => e.StripeAccountId).HasColumnName("STRIPE_ACCOUNT_ID");
        builder.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        builder.Property(e => e.CreatedAt).HasColumnName("CREATED_AT");
        builder.Property(e => e.UpdatedAt).HasColumnName("UPDATED_AT");
    }
}