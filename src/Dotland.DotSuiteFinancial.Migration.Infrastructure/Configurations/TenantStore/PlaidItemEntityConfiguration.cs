using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantStore;

public class PlaidItemEntityConfiguration : IEntityTypeConfiguration<PlaidItem>
{
    public void Configure(EntityTypeBuilder<PlaidItem> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder
            .ToTable("PLAID_ITEMS")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");

        builder.HasIndex(e => e.TenantId, "PLAID_ITEMS_TENANT_ID_INDEX");

        builder.Property(e => e.Id).HasColumnType("bigint(20) unsigned");
        builder.Property(e => e.CreatedAt).HasColumnType("datetime");
        builder.Property(e => e.PlaidItemId).HasMaxLength(255);
        builder.Property(e => e.TenantId).HasColumnType("bigint(20) unsigned");
        builder.Property(e => e.UpdatedAt).HasColumnType("datetime");

        builder.HasOne(d => d.Tenant).WithMany(p => p.PlaidItems)
            .HasForeignKey(d => d.TenantId)
            .HasConstraintName("PLAID_ITEMS_TENANT_ID_FOREIGN");

        builder.Property(e => e.Id).HasColumnName("ID");
        builder.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        builder.Property(e => e.PlaidItemId).HasColumnName("PLAID_ITEM_ID");
        builder.Property(e => e.CreatedAt).HasColumnName("CREATED_AT");
        builder.Property(e => e.UpdatedAt).HasColumnName("UPDATED_AT");
    }
}