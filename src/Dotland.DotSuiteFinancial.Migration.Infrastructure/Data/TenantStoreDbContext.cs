using Microsoft.EntityFrameworkCore;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Data;

public partial class TenantStoreDbContext : DbContext
{
    public TenantStoreDbContext()
    {
    }

    public TenantStoreDbContext(DbContextOptions<TenantStoreDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ImportEntity> Imports { get; set; }

    public virtual DbSet<OneClickDemo> OneClickDemos { get; set; }

    public virtual DbSet<PasswordReset> PasswordResets { get; set; }

    public virtual DbSet<PaymentLink> PaymentLinks { get; set; }

    public virtual DbSet<PlaidItem> PlaidItems { get; set; }

    public virtual DbSet<StripeAccount> StripeAccounts { get; set; }

    public virtual DbSet<SubscriptionsPlan> SubscriptionsPlans { get; set; }

    public virtual DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }

    public virtual DbSet<SubscriptionPlanSubscription> SubscriptionPlanSubscriptions { get; set; }

    public virtual DbSet<TenantStore> Tenants { get; set; }

    public virtual DbSet<TenantsMetadata> TenantsMetadatas { get; set; }

    public virtual DbSet<UserStore> Users { get; set; }

    public virtual DbSet<UserInvite> UserInvites { get; set; }

#if DEBUG
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "server=localhost;database=bigcapital_system;user=bigcapital;password=bigcapital";
        optionsBuilder.UseMySql(connectionString, ServerVersion.Parse("10.2.44-mariadb"));
    }
#endif
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("latin1_swedish_ci")
            .HasCharSet("latin1");

        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly,
            e => e.Namespace != null && e.Namespace.EndsWith("TenantStore"));

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
