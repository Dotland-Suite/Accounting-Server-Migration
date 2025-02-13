using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Configurations.TenantStore;

public class PaymentLinkEntityConfiguration : IEntityTypeConfiguration<PaymentLink>
{
    public void Configure(EntityTypeBuilder<PaymentLink> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder
            .ToTable("PAYMENT_LINKS")
            .HasCharSet("utf8")
            .UseCollation("utf8_general_ci");

        builder.Property(e => e.Id).HasColumnType("int(10) unsigned");
        builder.Property(e => e.CreatedAt).HasColumnType("datetime");
        builder.Property(e => e.ExpiryAt).HasColumnType("datetime");
        builder.Property(e => e.LinkId).HasMaxLength(255);
        builder.Property(e => e.Publicity).HasMaxLength(255);
        builder.Property(e => e.ResourceId).HasColumnType("int(11)");
        builder.Property(e => e.ResourceType).HasColumnType("text");
        builder.Property(e => e.TenantId).HasColumnType("int(11)");
        builder.Property(e => e.UpdatedAt).HasColumnType("datetime");

        builder.Property(e => e.Id).HasColumnName("ID");
        builder.Property(e => e.TenantId).HasColumnName("TENANT_ID");
        builder.Property(e => e.ResourceId).HasColumnName("RESOURCE_ID");
        builder.Property(e => e.ResourceType).HasColumnName("RESOURCE_TYPE");
        builder.Property(e => e.LinkId).HasColumnName("LINK_ID");
        builder.Property(e => e.Publicity).HasColumnName("PUBLICITY");
        builder.Property(e => e.ExpiryAt).HasColumnName("EXPIRY_AT");
        builder.Property(e => e.CreatedAt).HasColumnName("CREATED_AT");
        builder.Property(e => e.UpdatedAt).HasColumnName("UPDATED_AT");
    }
}