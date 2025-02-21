using Microsoft.EntityFrameworkCore;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure.Data;

public partial class TenantApplicationDbContext : DbContext
{
    public TenantApplicationDbContext()
    {
    }

    public TenantApplicationDbContext(DbContextOptions<TenantApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountsTransaction> ACCOUNTS_TRANSACTIONs { get; set; }

    public virtual DbSet<BankRule> BANK_RULEs { get; set; }

    public virtual DbSet<BankRuleCondition> BANK_RULE_CONDITIONs { get; set; }

    public virtual DbSet<BigcapitalSeed> BIGCAPITAL_SEEDs { get; set; }

    public virtual DbSet<BigCapitalSeedsLock> BIGCAPITAL_SEEDS_LOCKs { get; set; }

    public virtual DbSet<Bill> BILLs { get; set; }

    public virtual DbSet<BILLS_PAYMENT> BILLS_PAYMENTs { get; set; }

    public virtual DbSet<BILLS_PAYMENTS_ENTRy> BILLS_PAYMENTS_ENTRIEs { get; set; }

    public virtual DbSet<BillLocatedCost> BILL_LOCATED_COSTs { get; set; }

    public virtual DbSet<BillLocatedCostEntry> BILL_LOCATED_COST_ENTRIEs { get; set; }

    public virtual DbSet<BRANCH> BRANCHEs { get; set; }

    public virtual DbSet<CASHFLOW_TRANSACTION> CASHFLOW_TRANSACTIONs { get; set; }

    public virtual DbSet<CASHFLOW_TRANSACTION_LINE> CASHFLOW_TRANSACTION_LINEs { get; set; }

    public virtual DbSet<CONTACT> CONTACTs { get; set; }

    public virtual DbSet<CREDIT_NOTE> CREDIT_NOTEs { get; set; }

    public virtual DbSet<CREDIT_NOTE_APPLIED_INVOICE> CREDIT_NOTE_APPLIED_INVOICEs { get; set; }

    public virtual DbSet<CURRENCy> CURRENCIEs { get; set; }

    public virtual DbSet<DOCUMENT> DOCUMENTs { get; set; }

    public virtual DbSet<DOCUMENT_LINK> DOCUMENT_LINKs { get; set; }

    public virtual DbSet<EXCHANGE_RATE> EXCHANGE_RATEs { get; set; }

    public virtual DbSet<EXPENSES_TRANSACTION> EXPENSES_TRANSACTIONs { get; set; }

    public virtual DbSet<EXPENSE_TRANSACTION_CATEGORy> EXPENSE_TRANSACTION_CATEGORIEs { get; set; }

    public virtual DbSet<INVENTORY_ADJUSTMENT> INVENTORY_ADJUSTMENTs { get; set; }

    public virtual DbSet<INVENTORY_ADJUSTMENTS_ENTRy> INVENTORY_ADJUSTMENTS_ENTRIEs { get; set; }

    public virtual DbSet<INVENTORY_COST_LOT_TRACKER> INVENTORY_COST_LOT_TRACKERs { get; set; }

    public virtual DbSet<INVENTORY_TRANSACTION> INVENTORY_TRANSACTIONs { get; set; }

    public virtual DbSet<INVENTORY_TRANSACTION_METum> INVENTORY_TRANSACTION_METAs { get; set; }

    public virtual DbSet<ITEM> ITEMs { get; set; }

    public virtual DbSet<ITEMS_CATEGORy> ITEMS_CATEGORIEs { get; set; }

    public virtual DbSet<ITEMS_ENTRy> ITEMS_ENTRIEs { get; set; }

    public virtual DbSet<ITEMS_WAREHOUSES_QUANTITY> ITEMS_WAREHOUSES_QUANTITies { get; set; }

    public virtual DbSet<MANUAL_JOURNAL> MANUAL_JOURNALs { get; set; }

    public virtual DbSet<MANUAL_JOURNALS_ENTRy> MANUAL_JOURNALS_ENTRIEs { get; set; }

    public virtual DbSet<MATCHED_BANK_TRANSACTION> MATCHED_BANK_TRANSACTIONs { get; set; }

    public virtual DbSet<MEDIA_LINK> MEDIA_LINKs { get; set; }

    public virtual DbSet<MEDIum> MEDIAs { get; set; }

    public virtual DbSet<PAYMENT_INTEGRATION> PAYMENT_INTEGRATIONs { get; set; }

    public virtual DbSet<PAYMENT_RECEIVES_ENTRy> PAYMENT_RECEIVES_ENTRIEs { get; set; }

    public virtual DbSet<PAYMENT_RECEIfe> PAYMENT_RECEIVEs { get; set; }

    public virtual DbSet<PDF_TEMPLATE> PDF_TEMPLATEs { get; set; }

    public virtual DbSet<PLAID_ITEM> PLAID_ITEMs { get; set; }

    public virtual DbSet<PROJECT> PROJECTs { get; set; }

    public virtual DbSet<RECOGNIZED_BANK_TRANSACTION> RECOGNIZED_BANK_TRANSACTIONs { get; set; }

    public virtual DbSet<REFUND_CREDIT_NOTE_TRANSACTION> REFUND_CREDIT_NOTE_TRANSACTIONs { get; set; }

    public virtual DbSet<REFUND_VENDOR_CREDIT_TRANSACTION> REFUND_VENDOR_CREDIT_TRANSACTIONs { get; set; }

    public virtual DbSet<ROLE> ROLEs { get; set; }

    public virtual DbSet<ROLE_PERMISSION> ROLE_PERMISSIONs { get; set; }

    public virtual DbSet<SALES_ESTIMATE> SALES_ESTIMATEs { get; set; }

    public virtual DbSet<SALES_INVOICE> SALES_INVOICEs { get; set; }

    public virtual DbSet<SALES_RECEIPT> SALES_RECEIPTs { get; set; }

    public virtual DbSet<SETTING> SETTINGs { get; set; }

    public virtual DbSet<TASK> TASKs { get; set; }

    public virtual DbSet<TAX_RATE> TAX_RATEs { get; set; }

    public virtual DbSet<TAX_RATE_TRANSACTION> TAX_RATE_TRANSACTIONs { get; set; }

    public virtual DbSet<TIME> TIMEs { get; set; }

    public virtual DbSet<TRANSACTIONS_PAYMENT_METHOD> TRANSACTIONS_PAYMENT_METHODs { get; set; }

    public virtual DbSet<UNCATEGORIZED_CASHFLOW_TRANSACTION> UNCATEGORIZED_CASHFLOW_TRANSACTIONs { get; set; }

    public virtual DbSet<USER> USERs { get; set; }

    public virtual DbSet<VENDOR_CREDIT> VENDOR_CREDITs { get; set; }

    public virtual DbSet<VENDOR_CREDIT_APPLIED_BILL> VENDOR_CREDIT_APPLIED_BILLs { get; set; }

    public virtual DbSet<VIEW> VIEWs { get; set; }

    public virtual DbSet<VIEW_HAS_COLUMN> VIEW_HAS_COLUMNs { get; set; }

    public virtual DbSet<VIEW_ROLE> VIEW_ROLEs { get; set; }

    public virtual DbSet<WAREHOUSE> WAREHOUSEs { get; set; }

    public virtual DbSet<WAREHOUSES_TRANSFER> WAREHOUSES_TRANSFERs { get; set; }

    public virtual DbSet<WAREHOUSES_TRANSFERS_ENTRy> WAREHOUSES_TRANSFERS_ENTRIEs { get; set; }

#if DEBUG
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString =
            "server=localhost;database=bigcapital_tenant_fwg6cgtvm6wgv1i0;user=bigcapital;password=bigcapital";
        optionsBuilder.UseMySql(
            connectionString,
            Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.2.44-mariadb"));
    }
#endif


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly,
            e => e.Namespace != null && e.Namespace.EndsWith("TenantApplication"));

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}