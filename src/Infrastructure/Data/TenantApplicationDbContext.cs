using System;
using System.Collections.Generic;
using Dotland.DotSuiteFinancial.Migration.Infrastructure.Migrations.TenantApplication;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Dotland.DotSuiteFinancial.Migration.Infrastructure;

public partial class TenantApplicationDbContext : DbContext
{
    public TenantApplicationDbContext()
    {
    }

    public TenantApplicationDbContext(DbContextOptions<TenantApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }

    public virtual DbSet<ACCOUNTS_TRANSACTION> ACCOUNTS_TRANSACTIONs { get; set; }

    public virtual DbSet<BANK_RULE> BANK_RULEs { get; set; }

    public virtual DbSet<BANK_RULE_CONDITION> BANK_RULE_CONDITIONs { get; set; }

    public virtual DbSet<BIGCAPITAL_SEED> BIGCAPITAL_SEEDs { get; set; }

    public virtual DbSet<BIGCAPITAL_SEEDS_LOCK> BIGCAPITAL_SEEDS_LOCKs { get; set; }

    public virtual DbSet<BILL> BILLs { get; set; }

    public virtual DbSet<BILLS_PAYMENT> BILLS_PAYMENTs { get; set; }

    public virtual DbSet<BILLS_PAYMENTS_ENTRy> BILLS_PAYMENTS_ENTRIEs { get; set; }

    public virtual DbSet<BILL_LOCATED_COST> BILL_LOCATED_COSTs { get; set; }

    public virtual DbSet<BILL_LOCATED_COST_ENTRy> BILL_LOCATED_COST_ENTRIEs { get; set; }

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

    public virtual DbSet<knex_migration> knex_migrations { get; set; }

    public virtual DbSet<knex_migrations_lock> knex_migrations_locks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=bigcapital_tenant_fwg6cgtvm6wgv1i0;user=bigcapital;password=bigcapital", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.2.44-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<ACCOUNT>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("ACCOUNTS");

            entity.HasIndex(e => e.ACCOUNT_TYPE, "ACCOUNTS_ACCOUNT_TYPE_INDEX");

            entity.HasIndex(e => e.ACTIVE, "ACCOUNTS_ACTIVE_INDEX");

            entity.HasIndex(e => e.CODE, "ACCOUNTS_CODE_INDEX");

            entity.HasIndex(e => e.CURRENCY_CODE, "ACCOUNTS_CURRENCY_CODE_INDEX");

            entity.HasIndex(e => e.NAME, "ACCOUNTS_NAME_INDEX");

            entity.HasIndex(e => e.PARENT_ACCOUNT_ID, "ACCOUNTS_PARENT_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.PREDEFINED, "ACCOUNTS_PREDEFINED_INDEX");

            entity.Property(e => e.ID)
                .HasComment("Auto-generated id")
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.ACCOUNT_MASK).HasMaxLength(255);
            entity.Property(e => e.ACTIVE).HasDefaultValueSql("'1'");
            entity.Property(e => e.AMOUNT).HasPrecision(15, 5);
            entity.Property(e => e.BANK_BALANCE).HasPrecision(15, 5);
            entity.Property(e => e.CODE).HasMaxLength(10);
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(3);
            entity.Property(e => e.DESCRIPTION).HasColumnType("text");
            entity.Property(e => e.INDEX).HasColumnType("int(10) unsigned");
            entity.Property(e => e.IS_FEEDS_ACTIVE).HasDefaultValueSql("'0'");
            entity.Property(e => e.IS_SYNCING_OWNER).HasDefaultValueSql("'0'");
            entity.Property(e => e.IS_SYSTEM_ACCOUNT).HasDefaultValueSql("'1'");
            entity.Property(e => e.LAST_FEEDS_UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.PARENT_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.PLAID_ACCOUNT_ID).HasMaxLength(255);
            entity.Property(e => e.PLAID_ITEM_ID).HasMaxLength(255);
            entity.Property(e => e.PREDEFINED).HasDefaultValueSql("'0'");
            entity.Property(e => e.SLUG).HasMaxLength(255);
            entity.Property(e => e.UNCATEGORIZED_TRANSACTIONS)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");

            entity.HasOne(d => d.PARENT_ACCOUNT).WithMany(p => p.InversePARENT_ACCOUNT)
                .HasForeignKey(d => d.PARENT_ACCOUNT_ID)
                .HasConstraintName("ACCOUNTS_PARENT_ACCOUNT_ID_FOREIGN");
        });

        modelBuilder.Entity<ACCOUNTS_TRANSACTION>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("ACCOUNTS_TRANSACTIONS");

            entity.HasIndex(e => e.ACCOUNT_ID, "ACCOUNTS_TRANSACTIONS_ACCOUNT_ID_INDEX");

            entity.HasIndex(e => e.BRANCH_ID, "ACCOUNTS_TRANSACTIONS_BRANCH_ID_FOREIGN");

            entity.HasIndex(e => e.CONTACT_ID, "ACCOUNTS_TRANSACTIONS_CONTACT_ID_INDEX");

            entity.HasIndex(e => e.CONTACT_TYPE, "ACCOUNTS_TRANSACTIONS_CONTACT_TYPE_INDEX");

            entity.HasIndex(e => e.CREATED_AT, "ACCOUNTS_TRANSACTIONS_CREATED_AT_INDEX");

            entity.HasIndex(e => e.DATE, "ACCOUNTS_TRANSACTIONS_DATE_INDEX");

            entity.HasIndex(e => e.INDEX_GROUP, "ACCOUNTS_TRANSACTIONS_INDEX_GROUP_INDEX");

            entity.HasIndex(e => e.INDEX, "ACCOUNTS_TRANSACTIONS_INDEX_INDEX");

            entity.HasIndex(e => e.ITEM_ID, "ACCOUNTS_TRANSACTIONS_ITEM_ID_INDEX");

            entity.HasIndex(e => e.ITEM_QUANTITY, "ACCOUNTS_TRANSACTIONS_ITEM_QUANTITY_INDEX");

            entity.HasIndex(e => e.PROJECT_ID, "ACCOUNTS_TRANSACTIONS_PROJECTID_FOREIGN");

            entity.HasIndex(e => e.REFERENCE_ID, "ACCOUNTS_TRANSACTIONS_REFERENCE_ID_INDEX");

            entity.HasIndex(e => e.REFERENCE_NUMBER, "ACCOUNTS_TRANSACTIONS_REFERENCE_NUMBER_INDEX");

            entity.HasIndex(e => e.REFERENCE_TYPE, "ACCOUNTS_TRANSACTIONS_REFERENCE_TYPE_INDEX");

            entity.HasIndex(e => e.TAX_RATE_ID, "ACCOUNTS_TRANSACTIONS_TAX_RATE_ID_FOREIGN");

            entity.HasIndex(e => e.TRANSACTION_NUMBER, "ACCOUNTS_TRANSACTIONS_TRANSACTION_NUMBER_INDEX");

            entity.HasIndex(e => e.TRANSACTION_TYPE, "ACCOUNTS_TRANSACTIONS_TRANSACTION_TYPE_INDEX");

            entity.HasIndex(e => e.USER_ID, "ACCOUNTS_TRANSACTIONS_USER_ID_INDEX");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.BRANCH_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CONTACT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CREDIT).HasPrecision(13, 3);
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(3);
            entity.Property(e => e.DEBIT).HasPrecision(13, 3);
            entity.Property(e => e.EXCHANGE_RATE).HasPrecision(13, 9);
            entity.Property(e => e.INDEX).HasColumnType("int(10) unsigned");
            entity.Property(e => e.INDEX_GROUP).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ITEM_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ITEM_QUANTITY).HasColumnType("int(10) unsigned");
            entity.Property(e => e.NOTE).HasMaxLength(255);
            entity.Property(e => e.PROJECT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.REFERENCE_ID).HasColumnType("int(11)");
            entity.Property(e => e.TAX_RATE).HasColumnType("decimal(8,2) unsigned");
            entity.Property(e => e.TAX_RATE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.USER_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.ACCOUNT).WithMany(p => p.ACCOUNTS_TRANSACTIONs)
                .HasForeignKey(d => d.ACCOUNT_ID)
                .HasConstraintName("ACCOUNTS_TRANSACTIONS_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.ACCOUNTS_TRANSACTIONs)
                .HasForeignKey(d => d.BRANCH_ID)
                .HasConstraintName("ACCOUNTS_TRANSACTIONS_BRANCH_ID_FOREIGN");

            entity.HasOne(d => d.PROJECT).WithMany(p => p.ACCOUNTS_TRANSACTIONs)
                .HasForeignKey(d => d.PROJECT_ID)
                .HasConstraintName("ACCOUNTS_TRANSACTIONS_PROJECTID_FOREIGN");

            entity.HasOne(d => d.TAX_RATENavigation).WithMany(p => p.ACCOUNTS_TRANSACTIONs)
                .HasForeignKey(d => d.TAX_RATE_ID)
                .HasConstraintName("ACCOUNTS_TRANSACTIONS_TAX_RATE_ID_FOREIGN");
        });

        modelBuilder.Entity<BANK_RULE>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("BANK_RULES");

            entity.HasIndex(e => e.APPLY_IF_ACCOUNT_ID, "BANK_RULES_APPLY_IF_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.ASSIGN_ACCOUNT_ID, "BANK_RULES_ASSIGN_ACCOUNT_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.APPLY_IF_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.APPLY_IF_TRANSACTION_TYPE).HasMaxLength(255);
            entity.Property(e => e.ASSIGN_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ASSIGN_CATEGORY).HasMaxLength(255);
            entity.Property(e => e.ASSIGN_MEMO).HasMaxLength(255);
            entity.Property(e => e.ASSIGN_PAYEE).HasMaxLength(255);
            entity.Property(e => e.CONDITIONS_TYPE).HasMaxLength(255);
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.NAME).HasMaxLength(255);
            entity.Property(e => e.ORDER).HasColumnType("int(10) unsigned");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");

            entity.HasOne(d => d.APPLY_IF_ACCOUNT).WithMany(p => p.BANK_RULEAPPLY_IF_ACCOUNTs)
                .HasForeignKey(d => d.APPLY_IF_ACCOUNT_ID)
                .HasConstraintName("BANK_RULES_APPLY_IF_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.ASSIGN_ACCOUNT).WithMany(p => p.BANK_RULEASSIGN_ACCOUNTs)
                .HasForeignKey(d => d.ASSIGN_ACCOUNT_ID)
                .HasConstraintName("BANK_RULES_ASSIGN_ACCOUNT_ID_FOREIGN");
        });

        modelBuilder.Entity<BANK_RULE_CONDITION>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("BANK_RULE_CONDITIONS");

            entity.HasIndex(e => e.RULE_ID, "BANK_RULE_CONDITIONS_RULE_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.COMPARATOR).HasMaxLength(255);
            entity.Property(e => e.FIELD).HasMaxLength(255);
            entity.Property(e => e.RULE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.VALUE).HasMaxLength(255);

            entity.HasOne(d => d.RULE).WithMany(p => p.BANK_RULE_CONDITIONs)
                .HasForeignKey(d => d.RULE_ID)
                .HasConstraintName("BANK_RULE_CONDITIONS_RULE_ID_FOREIGN");
        });

        modelBuilder.Entity<BIGCAPITAL_SEED>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("BIGCAPITAL_SEEDS");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.BATCH).HasColumnType("int(11)");
            entity.Property(e => e.MIGRATION_TIME)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.NAME).HasMaxLength(255);
        });

        modelBuilder.Entity<BIGCAPITAL_SEEDS_LOCK>(entity =>
        {
            entity.HasKey(e => e.INDEX).HasName("PRIMARY");

            entity.ToTable("BIGCAPITAL_SEEDS_LOCK");

            entity.Property(e => e.INDEX).HasColumnType("int(10) unsigned");
            entity.Property(e => e.IS_LOCKED).HasColumnType("int(11)");
        });

        modelBuilder.Entity<BILL>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("BILLS");

            entity.HasIndex(e => e.BILL_DATE, "BILLS_BILL_DATE_INDEX");

            entity.HasIndex(e => e.BRANCH_ID, "BILLS_BRANCH_ID_FOREIGN");

            entity.HasIndex(e => e.DUE_DATE, "BILLS_DUE_DATE_INDEX");

            entity.HasIndex(e => e.INV_LOT_NUMBER, "BILLS_INV_LOT_NUMBER_INDEX");

            entity.HasIndex(e => e.OPENED_AT, "BILLS_OPENED_AT_INDEX");

            entity.HasIndex(e => e.PROJECT_ID, "BILLS_PROJECTID_FOREIGN");

            entity.HasIndex(e => e.REFERENCE_NO, "BILLS_REFERENCE_NO_INDEX");

            entity.HasIndex(e => e.STATUS, "BILLS_STATUS_INDEX");

            entity.HasIndex(e => e.VENDOR_ID, "BILLS_VENDOR_ID_INDEX");

            entity.HasIndex(e => e.WAREHOUSE_ID, "BILLS_WAREHOUSE_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ADJUSTMENT).HasPrecision(10, 2);
            entity.Property(e => e.ALLOCATED_COST_AMOUNT)
                .HasPrecision(13, 3)
                .HasDefaultValueSql("'0.000'");
            entity.Property(e => e.AMOUNT)
                .HasPrecision(13, 3)
                .HasDefaultValueSql("'0.000'");
            entity.Property(e => e.BILL_NUMBER).HasMaxLength(255);
            entity.Property(e => e.BRANCH_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CREDITED_AMOUNT)
                .HasPrecision(13, 3)
                .HasDefaultValueSql("'0.000'");
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(255);
            entity.Property(e => e.DISCOUNT).HasPrecision(10, 2);
            entity.Property(e => e.DISCOUNT_TYPE).HasMaxLength(255);
            entity.Property(e => e.EXCHANGE_RATE).HasPrecision(13, 9);
            entity.Property(e => e.INVOICED_AMOUNT)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("decimal(8,2) unsigned");
            entity.Property(e => e.IS_INCLUSIVE_TAX).HasDefaultValueSql("'0'");
            entity.Property(e => e.LANDED_COST_AMOUNT)
                .HasPrecision(13, 3)
                .HasDefaultValueSql("'0.000'");
            entity.Property(e => e.NOTE).HasColumnType("text");
            entity.Property(e => e.PAYMENT_AMOUNT)
                .HasPrecision(13, 3)
                .HasDefaultValueSql("'0.000'");
            entity.Property(e => e.PROJECT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.TAX_AMOUNT_WITHHELD).HasPrecision(13, 2);
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.USER_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.VENDOR_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.WAREHOUSE_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.BILLs)
                .HasForeignKey(d => d.BRANCH_ID)
                .HasConstraintName("BILLS_BRANCH_ID_FOREIGN");

            entity.HasOne(d => d.PROJECT).WithMany(p => p.BILLs)
                .HasForeignKey(d => d.PROJECT_ID)
                .HasConstraintName("BILLS_PROJECTID_FOREIGN");

            entity.HasOne(d => d.VENDOR).WithMany(p => p.BILLs)
                .HasForeignKey(d => d.VENDOR_ID)
                .HasConstraintName("BILLS_VENDOR_ID_FOREIGN");

            entity.HasOne(d => d.WAREHOUSE).WithMany(p => p.BILLs)
                .HasForeignKey(d => d.WAREHOUSE_ID)
                .HasConstraintName("BILLS_WAREHOUSE_ID_FOREIGN");
        });

        modelBuilder.Entity<BILLS_PAYMENT>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("BILLS_PAYMENTS");

            entity.HasIndex(e => e.BRANCH_ID, "BILLS_PAYMENTS_BRANCH_ID_FOREIGN");

            entity.HasIndex(e => e.PAYMENT_ACCOUNT_ID, "BILLS_PAYMENTS_PAYMENT_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.PAYMENT_DATE, "BILLS_PAYMENTS_PAYMENT_DATE_INDEX");

            entity.HasIndex(e => e.PAYMENT_NUMBER, "BILLS_PAYMENTS_PAYMENT_NUMBER_INDEX");

            entity.HasIndex(e => e.USER_ID, "BILLS_PAYMENTS_USER_ID_INDEX");

            entity.HasIndex(e => e.VENDOR_ID, "BILLS_PAYMENTS_VENDOR_ID_INDEX");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.AMOUNT)
                .HasPrecision(13, 3)
                .HasDefaultValueSql("'0.000'");
            entity.Property(e => e.BRANCH_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(255);
            entity.Property(e => e.EXCHANGE_RATE).HasPrecision(13, 9);
            entity.Property(e => e.PAYMENT_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.PAYMENT_METHOD).HasMaxLength(255);
            entity.Property(e => e.REFERENCE).HasMaxLength(255);
            entity.Property(e => e.STATEMENT).HasColumnType("text");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.USER_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.VENDOR_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.BILLS_PAYMENTs)
                .HasForeignKey(d => d.BRANCH_ID)
                .HasConstraintName("BILLS_PAYMENTS_BRANCH_ID_FOREIGN");

            entity.HasOne(d => d.PAYMENT_ACCOUNT).WithMany(p => p.BILLS_PAYMENTs)
                .HasForeignKey(d => d.PAYMENT_ACCOUNT_ID)
                .HasConstraintName("BILLS_PAYMENTS_PAYMENT_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.VENDOR).WithMany(p => p.BILLS_PAYMENTs)
                .HasForeignKey(d => d.VENDOR_ID)
                .HasConstraintName("BILLS_PAYMENTS_VENDOR_ID_FOREIGN");
        });

        modelBuilder.Entity<BILLS_PAYMENTS_ENTRy>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("BILLS_PAYMENTS_ENTRIES");

            entity.HasIndex(e => e.BILL_ID, "BILLS_PAYMENTS_ENTRIES_BILL_ID_INDEX");

            entity.HasIndex(e => e.BILL_PAYMENT_ID, "BILLS_PAYMENTS_ENTRIES_BILL_PAYMENT_ID_INDEX");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.BILL_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.BILL_PAYMENT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.INDEX).HasColumnType("int(10) unsigned");
            entity.Property(e => e.PAYMENT_AMOUNT).HasColumnType("decimal(13,3) unsigned");

            entity.HasOne(d => d.BILL).WithMany(p => p.BILLS_PAYMENTS_ENTRies)
                .HasForeignKey(d => d.BILL_ID)
                .HasConstraintName("BILLS_PAYMENTS_ENTRIES_BILL_ID_FOREIGN");

            entity.HasOne(d => d.BILL_PAYMENT).WithMany(p => p.BILLS_PAYMENTS_ENTRies)
                .HasForeignKey(d => d.BILL_PAYMENT_ID)
                .HasConstraintName("BILLS_PAYMENTS_ENTRIES_BILL_PAYMENT_ID_FOREIGN");
        });

        modelBuilder.Entity<BILL_LOCATED_COST>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("BILL_LOCATED_COSTS");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ALLOCATION_METHOD).HasMaxLength(255);
            entity.Property(e => e.AMOUNT).HasColumnType("decimal(13,3) unsigned");
            entity.Property(e => e.BILL_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.COST_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(3);
            entity.Property(e => e.DESCRIPTION).HasColumnType("text");
            entity.Property(e => e.EXCHANGE_RATE).HasPrecision(13, 9);
            entity.Property(e => e.FROM_TRANSACTION_ENTRY_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.FROM_TRANSACTION_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.FROM_TRANSACTION_TYPE).HasMaxLength(255);
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
        });

        modelBuilder.Entity<BILL_LOCATED_COST_ENTRy>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("BILL_LOCATED_COST_ENTRIES");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.BILL_LOCATED_COST_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.COST).HasColumnType("decimal(13,3) unsigned");
            entity.Property(e => e.ENTRY_ID).HasColumnType("int(10) unsigned");
        });

        modelBuilder.Entity<BRANCH>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("BRANCHES");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ADDRESS).HasMaxLength(255);
            entity.Property(e => e.CITY).HasMaxLength(255);
            entity.Property(e => e.CODE).HasMaxLength(255);
            entity.Property(e => e.COUNTRY).HasMaxLength(255);
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.EMAIL).HasMaxLength(255);
            entity.Property(e => e.NAME).HasMaxLength(255);
            entity.Property(e => e.PHONE_NUMBER).HasMaxLength(255);
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.WEBSITE).HasMaxLength(255);
        });

        modelBuilder.Entity<CASHFLOW_TRANSACTION>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("CASHFLOW_TRANSACTIONS");

            entity.HasIndex(e => e.BRANCH_ID, "CASHFLOW_TRANSACTIONS_BRANCH_ID_FOREIGN");

            entity.HasIndex(e => e.CASHFLOW_ACCOUNT_ID, "CASHFLOW_TRANSACTIONS_CASHFLOW_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.CREDIT_ACCOUNT_ID, "CASHFLOW_TRANSACTIONS_CREDIT_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.DATE, "CASHFLOW_TRANSACTIONS_DATE_INDEX");

            entity.HasIndex(e => e.PUBLISHED_AT, "CASHFLOW_TRANSACTIONS_PUBLISHED_AT_INDEX");

            entity.HasIndex(e => e.REFERENCE_NO, "CASHFLOW_TRANSACTIONS_REFERENCE_NO_INDEX");

            entity.HasIndex(e => e.TRANSACTION_NUMBER, "CASHFLOW_TRANSACTIONS_TRANSACTION_NUMBER_INDEX");

            entity.HasIndex(e => e.TRANSACTION_TYPE, "CASHFLOW_TRANSACTIONS_TRANSACTION_TYPE_INDEX");

            entity.HasIndex(e => e.UNCATEGORIZED_TRANSACTION_ID, "CASHFLOW_TRANSACTIONS_UNCATEGORIZED_TRANSACTION_ID_FOREIGN");

            entity.HasIndex(e => e.USER_ID, "CASHFLOW_TRANSACTIONS_USER_ID_INDEX");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.AMOUNT).HasPrecision(13, 3);
            entity.Property(e => e.BRANCH_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CASHFLOW_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CREDIT_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(3);
            entity.Property(e => e.DESCRIPTION).HasMaxLength(255);
            entity.Property(e => e.EXCHANGE_RATE).HasPrecision(13, 9);
            entity.Property(e => e.PLAID_TRANSACTION_ID).HasMaxLength(255);
            entity.Property(e => e.UNCATEGORIZED_TRANSACTION_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.USER_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.CASHFLOW_TRANSACTIONs)
                .HasForeignKey(d => d.BRANCH_ID)
                .HasConstraintName("CASHFLOW_TRANSACTIONS_BRANCH_ID_FOREIGN");

            entity.HasOne(d => d.CASHFLOW_ACCOUNT).WithMany(p => p.CASHFLOW_TRANSACTIONCASHFLOW_ACCOUNTs)
                .HasForeignKey(d => d.CASHFLOW_ACCOUNT_ID)
                .HasConstraintName("CASHFLOW_TRANSACTIONS_CASHFLOW_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.CREDIT_ACCOUNT).WithMany(p => p.CASHFLOW_TRANSACTIONCREDIT_ACCOUNTs)
                .HasForeignKey(d => d.CREDIT_ACCOUNT_ID)
                .HasConstraintName("CASHFLOW_TRANSACTIONS_CREDIT_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.UNCATEGORIZED_TRANSACTION).WithMany(p => p.CASHFLOW_TRANSACTIONs)
                .HasForeignKey(d => d.UNCATEGORIZED_TRANSACTION_ID)
                .HasConstraintName("CASHFLOW_TRANSACTIONS_UNCATEGORIZED_TRANSACTION_ID_FOREIGN");
        });

        modelBuilder.Entity<CASHFLOW_TRANSACTION_LINE>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("CASHFLOW_TRANSACTION_LINES");

            entity.HasIndex(e => e.CASHFLOW_ACCOUNT_ID, "CASHFLOW_TRANSACTION_LINES_CASHFLOW_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.CREDIT_ACCOUNT_ID, "CASHFLOW_TRANSACTION_LINES_CREDIT_ACCOUNT_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.AMOUNT).HasPrecision(13, 3);
            entity.Property(e => e.CASHFLOW_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CASHFLOW_TRANSACTION_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CREDIT_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.INDEX).HasColumnType("int(10) unsigned");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");

            entity.HasOne(d => d.CASHFLOW_ACCOUNT).WithMany(p => p.CASHFLOW_TRANSACTION_LINECASHFLOW_ACCOUNTs)
                .HasForeignKey(d => d.CASHFLOW_ACCOUNT_ID)
                .HasConstraintName("CASHFLOW_TRANSACTION_LINES_CASHFLOW_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.CREDIT_ACCOUNT).WithMany(p => p.CASHFLOW_TRANSACTION_LINECREDIT_ACCOUNTs)
                .HasForeignKey(d => d.CREDIT_ACCOUNT_ID)
                .HasConstraintName("CASHFLOW_TRANSACTION_LINES_CREDIT_ACCOUNT_ID_FOREIGN");
        });

        modelBuilder.Entity<CONTACT>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("CONTACTS");

            entity.HasIndex(e => e.OPENING_BALANCE_BRANCH_ID, "CONTACTS_OPENING_BALANCE_BRANCH_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ACTIVE).HasDefaultValueSql("'1'");
            entity.Property(e => e.BALANCE)
                .HasPrecision(13, 3)
                .HasDefaultValueSql("'0.000'");
            entity.Property(e => e.BILLING_ADDRESS1).HasMaxLength(255);
            entity.Property(e => e.BILLING_ADDRESS2).HasMaxLength(255);
            entity.Property(e => e.BILLING_ADDRESS_CITY).HasMaxLength(255);
            entity.Property(e => e.BILLING_ADDRESS_COUNTRY).HasMaxLength(255);
            entity.Property(e => e.BILLING_ADDRESS_EMAIL).HasMaxLength(255);
            entity.Property(e => e.BILLING_ADDRESS_PHONE).HasMaxLength(255);
            entity.Property(e => e.BILLING_ADDRESS_POSTCODE).HasMaxLength(255);
            entity.Property(e => e.BILLING_ADDRESS_STATE).HasMaxLength(255);
            entity.Property(e => e.COMPANY_NAME).HasMaxLength(255);
            entity.Property(e => e.CONTACT_SERVICE).HasMaxLength(255);
            entity.Property(e => e.CONTACT_TYPE).HasMaxLength(255);
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(3);
            entity.Property(e => e.DISPLAY_NAME).HasMaxLength(255);
            entity.Property(e => e.EMAIL).HasMaxLength(255);
            entity.Property(e => e.FIRST_NAME).HasMaxLength(255);
            entity.Property(e => e.LAST_NAME).HasMaxLength(255);
            entity.Property(e => e.NOTE).HasColumnType("text");
            entity.Property(e => e.OPENING_BALANCE)
                .HasPrecision(13, 3)
                .HasDefaultValueSql("'0.000'");
            entity.Property(e => e.OPENING_BALANCE_BRANCH_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.OPENING_BALANCE_EXCHANGE_RATE).HasPrecision(13, 9);
            entity.Property(e => e.PERSONAL_PHONE).HasMaxLength(255);
            entity.Property(e => e.SALUTATION).HasMaxLength(255);
            entity.Property(e => e.SHIPPING_ADDRESS1).HasMaxLength(255);
            entity.Property(e => e.SHIPPING_ADDRESS2).HasMaxLength(255);
            entity.Property(e => e.SHIPPING_ADDRESS_CITY).HasMaxLength(255);
            entity.Property(e => e.SHIPPING_ADDRESS_COUNTRY).HasMaxLength(255);
            entity.Property(e => e.SHIPPING_ADDRESS_EMAIL).HasMaxLength(255);
            entity.Property(e => e.SHIPPING_ADDRESS_PHONE).HasMaxLength(255);
            entity.Property(e => e.SHIPPING_ADDRESS_POSTCODE).HasMaxLength(255);
            entity.Property(e => e.SHIPPING_ADDRESS_STATE).HasMaxLength(255);
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.WEBSITE).HasMaxLength(255);
            entity.Property(e => e.WORK_PHONE).HasMaxLength(255);

            entity.HasOne(d => d.OPENING_BALANCE_BRANCH).WithMany(p => p.CONTACTs)
                .HasForeignKey(d => d.OPENING_BALANCE_BRANCH_ID)
                .HasConstraintName("CONTACTS_OPENING_BALANCE_BRANCH_ID_FOREIGN");
        });

        modelBuilder.Entity<CREDIT_NOTE>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("CREDIT_NOTES");

            entity.HasIndex(e => e.BRANCH_ID, "CREDIT_NOTES_BRANCH_ID_FOREIGN");

            entity.HasIndex(e => e.CUSTOMER_ID, "CREDIT_NOTES_CUSTOMER_ID_FOREIGN");

            entity.HasIndex(e => e.OPENED_AT, "CREDIT_NOTES_OPENED_AT_INDEX");

            entity.HasIndex(e => e.PDF_TEMPLATE_ID, "CREDIT_NOTES_PDF_TEMPLATE_ID_FOREIGN");

            entity.HasIndex(e => e.USER_ID, "CREDIT_NOTES_USER_ID_FOREIGN");

            entity.HasIndex(e => e.WAREHOUSE_ID, "CREDIT_NOTES_WAREHOUSE_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ADJUSTMENT).HasPrecision(10, 2);
            entity.Property(e => e.AMOUNT).HasPrecision(13, 3);
            entity.Property(e => e.BRANCH_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CREDIT_NOTE_NUMBER).HasMaxLength(255);
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(3);
            entity.Property(e => e.CUSTOMER_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.DISCOUNT).HasPrecision(10, 2);
            entity.Property(e => e.DISCOUNT_TYPE).HasMaxLength(255);
            entity.Property(e => e.EXCHANGE_RATE).HasPrecision(13, 9);
            entity.Property(e => e.INVOICES_AMOUNT)
                .HasPrecision(13, 3)
                .HasDefaultValueSql("'0.000'");
            entity.Property(e => e.NOTE).HasColumnType("text");
            entity.Property(e => e.PDF_TEMPLATE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.REFERENCE_NO).HasMaxLength(255);
            entity.Property(e => e.REFUNDED_AMOUNT)
                .HasPrecision(13, 3)
                .HasDefaultValueSql("'0.000'");
            entity.Property(e => e.TERMS_CONDITIONS).HasColumnType("text");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.USER_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.WAREHOUSE_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.CREDIT_NOTEs)
                .HasForeignKey(d => d.BRANCH_ID)
                .HasConstraintName("CREDIT_NOTES_BRANCH_ID_FOREIGN");

            entity.HasOne(d => d.CUSTOMER).WithMany(p => p.CREDIT_NOTEs)
                .HasForeignKey(d => d.CUSTOMER_ID)
                .HasConstraintName("CREDIT_NOTES_CUSTOMER_ID_FOREIGN");

            entity.HasOne(d => d.PDF_TEMPLATE).WithMany(p => p.CREDIT_NOTEs)
                .HasForeignKey(d => d.PDF_TEMPLATE_ID)
                .HasConstraintName("CREDIT_NOTES_PDF_TEMPLATE_ID_FOREIGN");

            entity.HasOne(d => d.USER).WithMany(p => p.CREDIT_NOTEs)
                .HasForeignKey(d => d.USER_ID)
                .HasConstraintName("CREDIT_NOTES_USER_ID_FOREIGN");

            entity.HasOne(d => d.WAREHOUSE).WithMany(p => p.CREDIT_NOTEs)
                .HasForeignKey(d => d.WAREHOUSE_ID)
                .HasConstraintName("CREDIT_NOTES_WAREHOUSE_ID_FOREIGN");
        });

        modelBuilder.Entity<CREDIT_NOTE_APPLIED_INVOICE>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("CREDIT_NOTE_APPLIED_INVOICE");

            entity.HasIndex(e => e.CREDIT_NOTE_ID, "CREDIT_NOTE_APPLIED_INVOICE_CREDIT_NOTE_ID_FOREIGN");

            entity.HasIndex(e => e.INVOICE_ID, "CREDIT_NOTE_APPLIED_INVOICE_INVOICE_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.AMOUNT).HasPrecision(13, 3);
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CREDIT_NOTE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.INVOICE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");

            entity.HasOne(d => d.CREDIT_NOTE).WithMany(p => p.CREDIT_NOTE_APPLIED_INVOICEs)
                .HasForeignKey(d => d.CREDIT_NOTE_ID)
                .HasConstraintName("CREDIT_NOTE_APPLIED_INVOICE_CREDIT_NOTE_ID_FOREIGN");

            entity.HasOne(d => d.INVOICE).WithMany(p => p.CREDIT_NOTE_APPLIED_INVOICEs)
                .HasForeignKey(d => d.INVOICE_ID)
                .HasConstraintName("CREDIT_NOTE_APPLIED_INVOICE_INVOICE_ID_FOREIGN");
        });

        modelBuilder.Entity<CURRENCy>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("CURRENCIES");

            entity.HasIndex(e => e.CURRENCY_CODE, "CURRENCIES_CURRENCY_CODE_INDEX");

            entity.HasIndex(e => e.CURRENCY_NAME, "CURRENCIES_CURRENCY_NAME_INDEX");

            entity.HasIndex(e => e.CURRENCY_SIGN, "CURRENCIES_CURRENCY_SIGN_INDEX");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(4);
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
        });

        modelBuilder.Entity<DOCUMENT>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("DOCUMENTS");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.KEY).HasMaxLength(255);
            entity.Property(e => e.MIME_TYPE).HasMaxLength(255);
            entity.Property(e => e.ORIGIN_NAME).HasMaxLength(255);
            entity.Property(e => e.SIZE).HasColumnType("int(10) unsigned");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
        });

        modelBuilder.Entity<DOCUMENT_LINK>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("DOCUMENT_LINKS");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.DOCUMENT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.EXPIRES_AT).HasColumnType("datetime");
            entity.Property(e => e.MODEL_ID).HasMaxLength(255);
            entity.Property(e => e.MODEL_REF).HasMaxLength(255);
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
        });

        modelBuilder.Entity<EXCHANGE_RATE>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("EXCHANGE_RATES");

            entity.HasIndex(e => e.CURRENCY_CODE, "EXCHANGE_RATES_CURRENCY_CODE_INDEX");

            entity.HasIndex(e => e.DATE, "EXCHANGE_RATES_DATE_INDEX");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(4);
            entity.Property(e => e.EXCHANGE_RATE1)
                .HasPrecision(8, 2)
                .HasColumnName("EXCHANGE_RATE");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
        });

        modelBuilder.Entity<EXPENSES_TRANSACTION>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("EXPENSES_TRANSACTIONS");

            entity.HasIndex(e => e.BRANCH_ID, "EXPENSES_TRANSACTIONS_BRANCH_ID_FOREIGN");

            entity.HasIndex(e => e.PAYEE_ID, "EXPENSES_TRANSACTIONS_PAYEE_ID_FOREIGN");

            entity.HasIndex(e => e.PAYMENT_ACCOUNT_ID, "EXPENSES_TRANSACTIONS_PAYMENT_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.PAYMENT_DATE, "EXPENSES_TRANSACTIONS_PAYMENT_DATE_INDEX");

            entity.HasIndex(e => e.PROJECT_ID, "EXPENSES_TRANSACTIONS_PROJECTID_FOREIGN");

            entity.HasIndex(e => e.PUBLISHED_AT, "EXPENSES_TRANSACTIONS_PUBLISHED_AT_INDEX");

            entity.HasIndex(e => e.USER_ID, "EXPENSES_TRANSACTIONS_USER_ID_INDEX");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ALLOCATED_COST_AMOUNT)
                .HasPrecision(13, 3)
                .HasDefaultValueSql("'0.000'");
            entity.Property(e => e.BRANCH_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(3);
            entity.Property(e => e.DESCRIPTION).HasColumnType("text");
            entity.Property(e => e.EXCHANGE_RATE).HasPrecision(13, 9);
            entity.Property(e => e.INVOICED_AMOUNT)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("decimal(8,2) unsigned");
            entity.Property(e => e.LANDED_COST_AMOUNT)
                .HasPrecision(13, 3)
                .HasDefaultValueSql("'0.000'");
            entity.Property(e => e.PAYEE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.PAYMENT_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.PROJECT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.REFERENCE_NO).HasMaxLength(255);
            entity.Property(e => e.TOTAL_AMOUNT).HasPrecision(13, 3);
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.USER_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.EXPENSES_TRANSACTIONs)
                .HasForeignKey(d => d.BRANCH_ID)
                .HasConstraintName("EXPENSES_TRANSACTIONS_BRANCH_ID_FOREIGN");

            entity.HasOne(d => d.PAYEE).WithMany(p => p.EXPENSES_TRANSACTIONs)
                .HasForeignKey(d => d.PAYEE_ID)
                .HasConstraintName("EXPENSES_TRANSACTIONS_PAYEE_ID_FOREIGN");

            entity.HasOne(d => d.PAYMENT_ACCOUNT).WithMany(p => p.EXPENSES_TRANSACTIONs)
                .HasForeignKey(d => d.PAYMENT_ACCOUNT_ID)
                .HasConstraintName("EXPENSES_TRANSACTIONS_PAYMENT_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.PROJECT).WithMany(p => p.EXPENSES_TRANSACTIONs)
                .HasForeignKey(d => d.PROJECT_ID)
                .HasConstraintName("EXPENSES_TRANSACTIONS_PROJECTID_FOREIGN");
        });

        modelBuilder.Entity<EXPENSE_TRANSACTION_CATEGORy>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("EXPENSE_TRANSACTION_CATEGORIES");

            entity.HasIndex(e => e.EXPENSE_ACCOUNT_ID, "EXPENSE_TRANSACTION_CATEGORIES_EXPENSE_ACCOUNT_ID_INDEX");

            entity.HasIndex(e => e.EXPENSE_ID, "EXPENSE_TRANSACTION_CATEGORIES_EXPENSE_ID_INDEX");

            entity.HasIndex(e => e.PROJECT_ID, "EXPENSE_TRANSACTION_CATEGORIES_PROJECTID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ALLOCATED_COST_AMOUNT)
                .HasPrecision(13, 3)
                .HasDefaultValueSql("'0.000'");
            entity.Property(e => e.AMOUNT).HasPrecision(13, 3);
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.DESCRIPTION).HasColumnType("text");
            entity.Property(e => e.EXPENSE_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.EXPENSE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.INDEX).HasColumnType("int(10) unsigned");
            entity.Property(e => e.LANDED_COST).HasDefaultValueSql("'0'");
            entity.Property(e => e.PROJECT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");

            entity.HasOne(d => d.EXPENSE_ACCOUNT).WithMany(p => p.EXPENSE_TRANSACTION_CATEGORies)
                .HasForeignKey(d => d.EXPENSE_ACCOUNT_ID)
                .HasConstraintName("EXPENSE_TRANSACTION_CATEGORIES_EXPENSE_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.EXPENSE).WithMany(p => p.EXPENSE_TRANSACTION_CATEGORies)
                .HasForeignKey(d => d.EXPENSE_ID)
                .HasConstraintName("EXPENSE_TRANSACTION_CATEGORIES_EXPENSE_ID_FOREIGN");

            entity.HasOne(d => d.PROJECT).WithMany(p => p.EXPENSE_TRANSACTION_CATEGORies)
                .HasForeignKey(d => d.PROJECT_ID)
                .HasConstraintName("EXPENSE_TRANSACTION_CATEGORIES_PROJECTID_FOREIGN");
        });

        modelBuilder.Entity<INVENTORY_ADJUSTMENT>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("INVENTORY_ADJUSTMENTS");

            entity.HasIndex(e => e.ADJUSTMENT_ACCOUNT_ID, "INVENTORY_ADJUSTMENTS_ADJUSTMENT_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.BRANCH_ID, "INVENTORY_ADJUSTMENTS_BRANCH_ID_FOREIGN");

            entity.HasIndex(e => e.DATE, "INVENTORY_ADJUSTMENTS_DATE_INDEX");

            entity.HasIndex(e => e.REFERENCE_NO, "INVENTORY_ADJUSTMENTS_REFERENCE_NO_INDEX");

            entity.HasIndex(e => e.TYPE, "INVENTORY_ADJUSTMENTS_TYPE_INDEX");

            entity.HasIndex(e => e.WAREHOUSE_ID, "INVENTORY_ADJUSTMENTS_WAREHOUSE_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ADJUSTMENT_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.BRANCH_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.DESCRIPTION).HasMaxLength(255);
            entity.Property(e => e.REASON).HasMaxLength(255);
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.USER_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.WAREHOUSE_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.ADJUSTMENT_ACCOUNT).WithMany(p => p.INVENTORY_ADJUSTMENTs)
                .HasForeignKey(d => d.ADJUSTMENT_ACCOUNT_ID)
                .HasConstraintName("INVENTORY_ADJUSTMENTS_ADJUSTMENT_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.INVENTORY_ADJUSTMENTs)
                .HasForeignKey(d => d.BRANCH_ID)
                .HasConstraintName("INVENTORY_ADJUSTMENTS_BRANCH_ID_FOREIGN");

            entity.HasOne(d => d.WAREHOUSE).WithMany(p => p.INVENTORY_ADJUSTMENTs)
                .HasForeignKey(d => d.WAREHOUSE_ID)
                .HasConstraintName("INVENTORY_ADJUSTMENTS_WAREHOUSE_ID_FOREIGN");
        });

        modelBuilder.Entity<INVENTORY_ADJUSTMENTS_ENTRy>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("INVENTORY_ADJUSTMENTS_ENTRIES");

            entity.HasIndex(e => e.ADJUSTMENT_ID, "INVENTORY_ADJUSTMENTS_ENTRIES_ADJUSTMENT_ID_INDEX");

            entity.HasIndex(e => e.ITEM_ID, "INVENTORY_ADJUSTMENTS_ENTRIES_ITEM_ID_INDEX");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ADJUSTMENT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.COST).HasColumnType("decimal(13,3) unsigned");
            entity.Property(e => e.INDEX).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ITEM_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.QUANTITY).HasColumnType("int(11)");
            entity.Property(e => e.VALUE).HasColumnType("decimal(13,3) unsigned");

            entity.HasOne(d => d.ADJUSTMENT).WithMany(p => p.INVENTORY_ADJUSTMENTS_ENTRies)
                .HasForeignKey(d => d.ADJUSTMENT_ID)
                .HasConstraintName("INVENTORY_ADJUSTMENTS_ENTRIES_ADJUSTMENT_ID_FOREIGN");

            entity.HasOne(d => d.ITEM).WithMany(p => p.INVENTORY_ADJUSTMENTS_ENTRies)
                .HasForeignKey(d => d.ITEM_ID)
                .HasConstraintName("INVENTORY_ADJUSTMENTS_ENTRIES_ITEM_ID_FOREIGN");
        });

        modelBuilder.Entity<INVENTORY_COST_LOT_TRACKER>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("INVENTORY_COST_LOT_TRACKER");

            entity.HasIndex(e => e.BRANCH_ID, "INVENTORY_COST_LOT_TRACKER_BRANCH_ID_FOREIGN");

            entity.HasIndex(e => e.CREATED_AT, "INVENTORY_COST_LOT_TRACKER_CREATED_AT_INDEX");

            entity.HasIndex(e => e.DATE, "INVENTORY_COST_LOT_TRACKER_DATE_INDEX");

            entity.HasIndex(e => e.DIRECTION, "INVENTORY_COST_LOT_TRACKER_DIRECTION_INDEX");

            entity.HasIndex(e => e.ENTRY_ID, "INVENTORY_COST_LOT_TRACKER_ENTRY_ID_INDEX");

            entity.HasIndex(e => e.INVENTORY_TRANSACTION_ID, "INVENTORY_COST_LOT_TRACKER_INVENTORY_TRANSACTION_ID_INDEX");

            entity.HasIndex(e => e.ITEM_ID, "INVENTORY_COST_LOT_TRACKER_ITEM_ID_INDEX");

            entity.HasIndex(e => e.QUANTITY, "INVENTORY_COST_LOT_TRACKER_QUANTITY_INDEX");

            entity.HasIndex(e => e.TRANSACTION_ID, "INVENTORY_COST_LOT_TRACKER_TRANSACTION_ID_INDEX");

            entity.HasIndex(e => e.TRANSACTION_TYPE, "INVENTORY_COST_LOT_TRACKER_TRANSACTION_TYPE_INDEX");

            entity.HasIndex(e => e.WAREHOUSE_ID, "INVENTORY_COST_LOT_TRACKER_WAREHOUSE_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.BRANCH_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.COST).HasPrecision(13, 3);
            entity.Property(e => e.COST_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.ENTRY_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.INVENTORY_TRANSACTION_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ITEM_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.QUANTITY).HasPrecision(13, 3);
            entity.Property(e => e.RATE).HasPrecision(13, 3);
            entity.Property(e => e.REMAINING).HasColumnType("int(11)");
            entity.Property(e => e.TRANSACTION_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.WAREHOUSE_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.INVENTORY_COST_LOT_TRACKERs)
                .HasForeignKey(d => d.BRANCH_ID)
                .HasConstraintName("INVENTORY_COST_LOT_TRACKER_BRANCH_ID_FOREIGN");

            entity.HasOne(d => d.WAREHOUSE).WithMany(p => p.INVENTORY_COST_LOT_TRACKERs)
                .HasForeignKey(d => d.WAREHOUSE_ID)
                .HasConstraintName("INVENTORY_COST_LOT_TRACKER_WAREHOUSE_ID_FOREIGN");
        });

        modelBuilder.Entity<INVENTORY_TRANSACTION>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("INVENTORY_TRANSACTIONS");

            entity.HasIndex(e => e.BRANCH_ID, "INVENTORY_TRANSACTIONS_BRANCH_ID_FOREIGN");

            entity.HasIndex(e => e.DATE, "INVENTORY_TRANSACTIONS_DATE_INDEX");

            entity.HasIndex(e => e.DIRECTION, "INVENTORY_TRANSACTIONS_DIRECTION_INDEX");

            entity.HasIndex(e => e.ENTRY_ID, "INVENTORY_TRANSACTIONS_ENTRY_ID_INDEX");

            entity.HasIndex(e => e.ITEM_ID, "INVENTORY_TRANSACTIONS_ITEM_ID_INDEX");

            entity.HasIndex(e => e.TRANSACTION_ID, "INVENTORY_TRANSACTIONS_TRANSACTION_ID_INDEX");

            entity.HasIndex(e => e.TRANSACTION_TYPE, "INVENTORY_TRANSACTIONS_TRANSACTION_TYPE_INDEX");

            entity.HasIndex(e => e.WAREHOUSE_ID, "INVENTORY_TRANSACTIONS_WAREHOUSE_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.BRANCH_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.COST_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.ENTRY_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ITEM_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.QUANTITY).HasPrecision(13, 3);
            entity.Property(e => e.RATE).HasColumnType("decimal(13,3) unsigned");
            entity.Property(e => e.TRANSACTION_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.WAREHOUSE_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.INVENTORY_TRANSACTIONs)
                .HasForeignKey(d => d.BRANCH_ID)
                .HasConstraintName("INVENTORY_TRANSACTIONS_BRANCH_ID_FOREIGN");

            entity.HasOne(d => d.ITEM).WithMany(p => p.INVENTORY_TRANSACTIONs)
                .HasForeignKey(d => d.ITEM_ID)
                .HasConstraintName("INVENTORY_TRANSACTIONS_ITEM_ID_FOREIGN");

            entity.HasOne(d => d.WAREHOUSE).WithMany(p => p.INVENTORY_TRANSACTIONs)
                .HasForeignKey(d => d.WAREHOUSE_ID)
                .HasConstraintName("INVENTORY_TRANSACTIONS_WAREHOUSE_ID_FOREIGN");
        });

        modelBuilder.Entity<INVENTORY_TRANSACTION_METum>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("INVENTORY_TRANSACTION_META");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.DESCRIPTION).HasColumnType("text");
            entity.Property(e => e.INVENTORY_TRANSACTION_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.TRANSACTION_NUMBER).HasMaxLength(255);
        });

        modelBuilder.Entity<ITEM>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("ITEMS");

            entity.HasIndex(e => e.CATEGORY_ID, "ITEMS_CATEGORY_ID_INDEX");

            entity.HasIndex(e => e.COST_ACCOUNT_ID, "ITEMS_COST_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.INVENTORY_ACCOUNT_ID, "ITEMS_INVENTORY_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.NAME, "ITEMS_NAME_INDEX");

            entity.HasIndex(e => e.PURCHASABLE, "ITEMS_PURCHASABLE_INDEX");

            entity.HasIndex(e => e.PURCHASE_TAX_RATE_ID, "ITEMS_PURCHASE_TAX_RATE_ID_FOREIGN");

            entity.HasIndex(e => e.SELLABLE, "ITEMS_SELLABLE_INDEX");

            entity.HasIndex(e => e.SELL_ACCOUNT_ID, "ITEMS_SELL_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.SELL_TAX_RATE_ID, "ITEMS_SELL_TAX_RATE_ID_FOREIGN");

            entity.HasIndex(e => e.TYPE, "ITEMS_TYPE_INDEX");

            entity.HasIndex(e => e.USER_ID, "ITEMS_USER_ID_INDEX");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CATEGORY_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CODE).HasMaxLength(255);
            entity.Property(e => e.COST_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.COST_PRICE).HasColumnType("decimal(13,3) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.INVENTORY_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.NOTE).HasColumnType("text");
            entity.Property(e => e.PICTURE_URI).HasMaxLength(255);
            entity.Property(e => e.PURCHASE_DESCRIPTION).HasColumnType("text");
            entity.Property(e => e.PURCHASE_TAX_RATE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.QUANTITY_ON_HAND).HasPrecision(13, 3);
            entity.Property(e => e.SELL_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.SELL_DESCRIPTION).HasColumnType("text");
            entity.Property(e => e.SELL_PRICE).HasColumnType("decimal(13,3) unsigned");
            entity.Property(e => e.SELL_TAX_RATE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.USER_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.CATEGORY).WithMany(p => p.ITEMs)
                .HasForeignKey(d => d.CATEGORY_ID)
                .HasConstraintName("ITEMS_CATEGORY_ID_FOREIGN");

            entity.HasOne(d => d.COST_ACCOUNT).WithMany(p => p.ITEMCOST_ACCOUNTs)
                .HasForeignKey(d => d.COST_ACCOUNT_ID)
                .HasConstraintName("ITEMS_COST_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.INVENTORY_ACCOUNT).WithMany(p => p.ITEMINVENTORY_ACCOUNTs)
                .HasForeignKey(d => d.INVENTORY_ACCOUNT_ID)
                .HasConstraintName("ITEMS_INVENTORY_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.PURCHASE_TAX_RATE).WithMany(p => p.ITEMPURCHASE_TAX_RATEs)
                .HasForeignKey(d => d.PURCHASE_TAX_RATE_ID)
                .HasConstraintName("ITEMS_PURCHASE_TAX_RATE_ID_FOREIGN");

            entity.HasOne(d => d.SELL_ACCOUNT).WithMany(p => p.ITEMSELL_ACCOUNTs)
                .HasForeignKey(d => d.SELL_ACCOUNT_ID)
                .HasConstraintName("ITEMS_SELL_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.SELL_TAX_RATE).WithMany(p => p.ITEMSELL_TAX_RATEs)
                .HasForeignKey(d => d.SELL_TAX_RATE_ID)
                .HasConstraintName("ITEMS_SELL_TAX_RATE_ID_FOREIGN");
        });

        modelBuilder.Entity<ITEMS_CATEGORy>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("ITEMS_CATEGORIES");

            entity.HasIndex(e => e.COST_ACCOUNT_ID, "ITEMS_CATEGORIES_COST_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.INVENTORY_ACCOUNT_ID, "ITEMS_CATEGORIES_INVENTORY_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.NAME, "ITEMS_CATEGORIES_NAME_INDEX");

            entity.HasIndex(e => e.SELL_ACCOUNT_ID, "ITEMS_CATEGORIES_SELL_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.USER_ID, "ITEMS_CATEGORIES_USER_ID_INDEX");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.COST_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.COST_METHOD).HasMaxLength(255);
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.DESCRIPTION).HasColumnType("text");
            entity.Property(e => e.INVENTORY_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.SELL_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.USER_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.COST_ACCOUNT).WithMany(p => p.ITEMS_CATEGORyCOST_ACCOUNTs)
                .HasForeignKey(d => d.COST_ACCOUNT_ID)
                .HasConstraintName("ITEMS_CATEGORIES_COST_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.INVENTORY_ACCOUNT).WithMany(p => p.ITEMS_CATEGORyINVENTORY_ACCOUNTs)
                .HasForeignKey(d => d.INVENTORY_ACCOUNT_ID)
                .HasConstraintName("ITEMS_CATEGORIES_INVENTORY_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.SELL_ACCOUNT).WithMany(p => p.ITEMS_CATEGORySELL_ACCOUNTs)
                .HasForeignKey(d => d.SELL_ACCOUNT_ID)
                .HasConstraintName("ITEMS_CATEGORIES_SELL_ACCOUNT_ID_FOREIGN");
        });

        modelBuilder.Entity<ITEMS_ENTRy>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("ITEMS_ENTRIES");

            entity.HasIndex(e => e.COST_ACCOUNT_ID, "ITEMS_ENTRIES_COST_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.ITEM_ID, "ITEMS_ENTRIES_ITEM_ID_INDEX");

            entity.HasIndex(e => e.PROJECT_ID, "ITEMS_ENTRIES_PROJECTID_FOREIGN");

            entity.HasIndex(e => e.REFERENCE_ID, "ITEMS_ENTRIES_REFERENCE_ID_INDEX");

            entity.HasIndex(e => e.REFERENCE_TYPE, "ITEMS_ENTRIES_REFERENCE_TYPE_INDEX");

            entity.HasIndex(e => e.SELL_ACCOUNT_ID, "ITEMS_ENTRIES_SELL_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.TAX_RATE_ID, "ITEMS_ENTRIES_TAX_RATE_ID_FOREIGN");

            entity.HasIndex(e => e.WAREHOUSE_ID, "ITEMS_ENTRIES_WAREHOUSE_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ALLOCATED_COST_AMOUNT)
                .HasPrecision(13, 3)
                .HasDefaultValueSql("'0.000'");
            entity.Property(e => e.COST_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.DESCRIPTION).HasColumnType("text");
            entity.Property(e => e.DISCOUNT).HasColumnType("int(10) unsigned");
            entity.Property(e => e.DISCOUNT_TYPE)
                .HasMaxLength(255)
                .HasDefaultValueSql("'percentage'");
            entity.Property(e => e.INDEX).HasColumnType("int(10) unsigned");
            entity.Property(e => e.IS_INCLUSIVE_TAX).HasDefaultValueSql("'0'");
            entity.Property(e => e.ITEM_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.LANDED_COST).HasDefaultValueSql("'0'");
            entity.Property(e => e.PROJECT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.PROJECT_REF_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.PROJECT_REF_INVOICED_AMOUNT)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("decimal(8,2) unsigned");
            entity.Property(e => e.PROJECT_REF_TYPE).HasMaxLength(255);
            entity.Property(e => e.QUANTITY).HasPrecision(13, 3);
            entity.Property(e => e.RATE).HasPrecision(15, 5);
            entity.Property(e => e.SELL_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.TAX_RATE).HasColumnType("decimal(8,2) unsigned");
            entity.Property(e => e.TAX_RATE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.WAREHOUSE_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.COST_ACCOUNT).WithMany(p => p.ITEMS_ENTRyCOST_ACCOUNTs)
                .HasForeignKey(d => d.COST_ACCOUNT_ID)
                .HasConstraintName("ITEMS_ENTRIES_COST_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.ITEM).WithMany(p => p.ITEMS_ENTRies)
                .HasForeignKey(d => d.ITEM_ID)
                .HasConstraintName("ITEMS_ENTRIES_ITEM_ID_FOREIGN");

            entity.HasOne(d => d.PROJECT).WithMany(p => p.ITEMS_ENTRies)
                .HasForeignKey(d => d.PROJECT_ID)
                .HasConstraintName("ITEMS_ENTRIES_PROJECTID_FOREIGN");

            entity.HasOne(d => d.SELL_ACCOUNT).WithMany(p => p.ITEMS_ENTRySELL_ACCOUNTs)
                .HasForeignKey(d => d.SELL_ACCOUNT_ID)
                .HasConstraintName("ITEMS_ENTRIES_SELL_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.TAX_RATENavigation).WithMany(p => p.ITEMS_ENTRies)
                .HasForeignKey(d => d.TAX_RATE_ID)
                .HasConstraintName("ITEMS_ENTRIES_TAX_RATE_ID_FOREIGN");

            entity.HasOne(d => d.WAREHOUSE).WithMany(p => p.ITEMS_ENTRies)
                .HasForeignKey(d => d.WAREHOUSE_ID)
                .HasConstraintName("ITEMS_ENTRIES_WAREHOUSE_ID_FOREIGN");
        });

        modelBuilder.Entity<ITEMS_WAREHOUSES_QUANTITY>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ITEMS_WAREHOUSES_QUANTITY");

            entity.HasIndex(e => e.ITEM_ID, "ITEMS_WAREHOUSES_QUANTITY_ITEM_ID_FOREIGN");

            entity.HasIndex(e => e.WAREHOUSE_ID, "ITEMS_WAREHOUSES_QUANTITY_WAREHOUSE_ID_FOREIGN");

            entity.Property(e => e.ITEM_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.QUANTITY_ON_HAND).HasColumnType("int(11)");
            entity.Property(e => e.WAREHOUSE_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.ITEM).WithMany()
                .HasForeignKey(d => d.ITEM_ID)
                .HasConstraintName("ITEMS_WAREHOUSES_QUANTITY_ITEM_ID_FOREIGN");

            entity.HasOne(d => d.WAREHOUSE).WithMany()
                .HasForeignKey(d => d.WAREHOUSE_ID)
                .HasConstraintName("ITEMS_WAREHOUSES_QUANTITY_WAREHOUSE_ID_FOREIGN");
        });

        modelBuilder.Entity<MANUAL_JOURNAL>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("MANUAL_JOURNALS");

            entity.HasIndex(e => e.BRANCH_ID, "MANUAL_JOURNALS_BRANCH_ID_FOREIGN");

            entity.HasIndex(e => e.DATE, "MANUAL_JOURNALS_DATE_INDEX");

            entity.HasIndex(e => e.JOURNAL_NUMBER, "MANUAL_JOURNALS_JOURNAL_NUMBER_INDEX");

            entity.HasIndex(e => e.JOURNAL_TYPE, "MANUAL_JOURNALS_JOURNAL_TYPE_INDEX");

            entity.HasIndex(e => e.PUBLISHED_AT, "MANUAL_JOURNALS_PUBLISHED_AT_INDEX");

            entity.HasIndex(e => e.REFERENCE, "MANUAL_JOURNALS_REFERENCE_INDEX");

            entity.HasIndex(e => e.USER_ID, "MANUAL_JOURNALS_USER_ID_INDEX");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.AMOUNT).HasPrecision(13, 3);
            entity.Property(e => e.ATTACHMENT_FILE).HasMaxLength(255);
            entity.Property(e => e.BRANCH_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(3);
            entity.Property(e => e.DESCRIPTION).HasMaxLength(255);
            entity.Property(e => e.EXCHANGE_RATE).HasPrecision(13, 9);
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.USER_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.MANUAL_JOURNALs)
                .HasForeignKey(d => d.BRANCH_ID)
                .HasConstraintName("MANUAL_JOURNALS_BRANCH_ID_FOREIGN");
        });

        modelBuilder.Entity<MANUAL_JOURNALS_ENTRy>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("MANUAL_JOURNALS_ENTRIES");

            entity.HasIndex(e => e.ACCOUNT_ID, "MANUAL_JOURNALS_ENTRIES_ACCOUNT_ID_INDEX");

            entity.HasIndex(e => e.BRANCH_ID, "MANUAL_JOURNALS_ENTRIES_BRANCH_ID_FOREIGN");

            entity.HasIndex(e => e.CONTACT_ID, "MANUAL_JOURNALS_ENTRIES_CONTACT_ID_INDEX");

            entity.HasIndex(e => e.MANUAL_JOURNAL_ID, "MANUAL_JOURNALS_ENTRIES_MANUAL_JOURNAL_ID_INDEX");

            entity.HasIndex(e => e.PROJECT_ID, "MANUAL_JOURNALS_ENTRIES_PROJECTID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.BRANCH_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CONTACT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREDIT).HasPrecision(13, 3);
            entity.Property(e => e.DEBIT).HasPrecision(13, 3);
            entity.Property(e => e.INDEX).HasColumnType("int(10) unsigned");
            entity.Property(e => e.MANUAL_JOURNAL_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.NOTE).HasMaxLength(255);
            entity.Property(e => e.PROJECT_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.ACCOUNT).WithMany(p => p.MANUAL_JOURNALS_ENTRies)
                .HasForeignKey(d => d.ACCOUNT_ID)
                .HasConstraintName("MANUAL_JOURNALS_ENTRIES_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.MANUAL_JOURNALS_ENTRies)
                .HasForeignKey(d => d.BRANCH_ID)
                .HasConstraintName("MANUAL_JOURNALS_ENTRIES_BRANCH_ID_FOREIGN");

            entity.HasOne(d => d.MANUAL_JOURNAL).WithMany(p => p.MANUAL_JOURNALS_ENTRies)
                .HasForeignKey(d => d.MANUAL_JOURNAL_ID)
                .HasConstraintName("MANUAL_JOURNALS_ENTRIES_MANUAL_JOURNAL_ID_FOREIGN");

            entity.HasOne(d => d.PROJECT).WithMany(p => p.MANUAL_JOURNALS_ENTRies)
                .HasForeignKey(d => d.PROJECT_ID)
                .HasConstraintName("MANUAL_JOURNALS_ENTRIES_PROJECTID_FOREIGN");
        });

        modelBuilder.Entity<MATCHED_BANK_TRANSACTION>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("MATCHED_BANK_TRANSACTIONS");

            entity.HasIndex(e => e.UNCATEGORIZED_TRANSACTION_ID, "MATCHED_BANK_TRANSACTIONS_UNCATEGORIZED_TRANSACTION_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.AMOUNT).HasPrecision(8, 2);
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.REFERENCE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.REFERENCE_TYPE).HasMaxLength(255);
            entity.Property(e => e.UNCATEGORIZED_TRANSACTION_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");

            entity.HasOne(d => d.UNCATEGORIZED_TRANSACTION).WithMany(p => p.MATCHED_BANK_TRANSACTIONs)
                .HasForeignKey(d => d.UNCATEGORIZED_TRANSACTION_ID)
                .HasConstraintName("MATCHED_BANK_TRANSACTIONS_UNCATEGORIZED_TRANSACTION_ID_FOREIGN");
        });

        modelBuilder.Entity<MEDIA_LINK>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("MEDIA_LINKS");

            entity.HasIndex(e => e.MEDIA_ID, "MEDIA_LINKS_MEDIA_ID_FOREIGN");

            entity.HasIndex(e => e.MODEL_ID, "MEDIA_LINKS_MODEL_ID_INDEX");

            entity.HasIndex(e => e.MODEL_NAME, "MEDIA_LINKS_MODEL_NAME_INDEX");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.MEDIA_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.MODEL_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.MEDIA).WithMany(p => p.MEDIA_LINKs)
                .HasForeignKey(d => d.MEDIA_ID)
                .HasConstraintName("MEDIA_LINKS_MEDIA_ID_FOREIGN");
        });

        modelBuilder.Entity<MEDIum>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("MEDIA");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ATTACHMENT_FILE).HasMaxLength(255);
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
        });

        modelBuilder.Entity<PAYMENT_INTEGRATION>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("PAYMENT_INTEGRATIONS");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ACCOUNT_ID).HasMaxLength(255);
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.NAME).HasMaxLength(255);
            entity.Property(e => e.OPTIONS)
                .UseCollation("utf8mb4_bin")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.PAYMENT_ENABLED).HasDefaultValueSql("'0'");
            entity.Property(e => e.PAYOUT_ENABLED).HasDefaultValueSql("'0'");
            entity.Property(e => e.SERVICE).HasMaxLength(255);
            entity.Property(e => e.SLUG).HasMaxLength(255);
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
        });

        modelBuilder.Entity<PAYMENT_RECEIVES_ENTRy>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("PAYMENT_RECEIVES_ENTRIES");

            entity.HasIndex(e => e.INVOICE_ID, "PAYMENT_RECEIVES_ENTRIES_INVOICE_ID_INDEX");

            entity.HasIndex(e => e.PAYMENT_RECEIVE_ID, "PAYMENT_RECEIVES_ENTRIES_PAYMENT_RECEIVE_ID_INDEX");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.INDEX).HasColumnType("int(10) unsigned");
            entity.Property(e => e.INVOICE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.PAYMENT_AMOUNT).HasColumnType("decimal(13,3) unsigned");
            entity.Property(e => e.PAYMENT_RECEIVE_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.INVOICE).WithMany(p => p.PAYMENT_RECEIVES_ENTRies)
                .HasForeignKey(d => d.INVOICE_ID)
                .HasConstraintName("PAYMENT_RECEIVES_ENTRIES_INVOICE_ID_FOREIGN");

            entity.HasOne(d => d.PAYMENT_RECEIVE).WithMany(p => p.PAYMENT_RECEIVES_ENTRies)
                .HasForeignKey(d => d.PAYMENT_RECEIVE_ID)
                .HasConstraintName("PAYMENT_RECEIVES_ENTRIES_PAYMENT_RECEIVE_ID_FOREIGN");
        });

        modelBuilder.Entity<PAYMENT_RECEIfe>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("PAYMENT_RECEIVES");

            entity.HasIndex(e => e.BRANCH_ID, "PAYMENT_RECEIVES_BRANCH_ID_FOREIGN");

            entity.HasIndex(e => e.CUSTOMER_ID, "PAYMENT_RECEIVES_CUSTOMER_ID_INDEX");

            entity.HasIndex(e => e.DEPOSIT_ACCOUNT_ID, "PAYMENT_RECEIVES_DEPOSIT_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.PAYMENT_DATE, "PAYMENT_RECEIVES_PAYMENT_DATE_INDEX");

            entity.HasIndex(e => e.PDF_TEMPLATE_ID, "PAYMENT_RECEIVES_PDF_TEMPLATE_ID_FOREIGN");

            entity.HasIndex(e => e.REFERENCE_NO, "PAYMENT_RECEIVES_REFERENCE_NO_INDEX");

            entity.HasIndex(e => e.USER_ID, "PAYMENT_RECEIVES_USER_ID_INDEX");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.AMOUNT)
                .HasPrecision(13, 3)
                .HasDefaultValueSql("'0.000'");
            entity.Property(e => e.BRANCH_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(3);
            entity.Property(e => e.CUSTOMER_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.DEPOSIT_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.EXCHANGE_RATE).HasPrecision(13, 9);
            entity.Property(e => e.PAYMENT_RECEIVE_NO).HasMaxLength(255);
            entity.Property(e => e.PDF_TEMPLATE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.STATEMENT).HasColumnType("text");
            entity.Property(e => e.STRIPE_PINTENT_ID).HasMaxLength(255);
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.USER_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.PAYMENT_RECEIves)
                .HasForeignKey(d => d.BRANCH_ID)
                .HasConstraintName("PAYMENT_RECEIVES_BRANCH_ID_FOREIGN");

            entity.HasOne(d => d.CUSTOMER).WithMany(p => p.PAYMENT_RECEIves)
                .HasForeignKey(d => d.CUSTOMER_ID)
                .HasConstraintName("PAYMENT_RECEIVES_CUSTOMER_ID_FOREIGN");

            entity.HasOne(d => d.DEPOSIT_ACCOUNT).WithMany(p => p.PAYMENT_RECEIves)
                .HasForeignKey(d => d.DEPOSIT_ACCOUNT_ID)
                .HasConstraintName("PAYMENT_RECEIVES_DEPOSIT_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.PDF_TEMPLATE).WithMany(p => p.PAYMENT_RECEIves)
                .HasForeignKey(d => d.PDF_TEMPLATE_ID)
                .HasConstraintName("PAYMENT_RECEIVES_PDF_TEMPLATE_ID_FOREIGN");
        });

        modelBuilder.Entity<PDF_TEMPLATE>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("PDF_TEMPLATES");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ATTRIBUTES)
                .UseCollation("utf8mb4_bin")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.DEFAULT).HasDefaultValueSql("'0'");
            entity.Property(e => e.PREDEFINED).HasDefaultValueSql("'0'");
            entity.Property(e => e.RESOURCE).HasColumnType("text");
            entity.Property(e => e.TEMPLATE_NAME).HasColumnType("text");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
        });

        modelBuilder.Entity<PLAID_ITEM>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("PLAID_ITEMS");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.LAST_CURSOR).HasMaxLength(255);
            entity.Property(e => e.PAUSED_AT).HasColumnType("datetime");
            entity.Property(e => e.PLAID_ACCESS_TOKEN).HasMaxLength(255);
            entity.Property(e => e.PLAID_INSTITUTION_ID).HasMaxLength(255);
            entity.Property(e => e.PLAID_ITEM_ID).HasMaxLength(255);
            entity.Property(e => e.STATUS).HasMaxLength(255);
            entity.Property(e => e.TENANT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
        });

        modelBuilder.Entity<PROJECT>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("PROJECTS");

            entity.Property(e => e.ID)
                .HasComment("Auto-generated id")
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.CONTACT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.COST_ESTIMATE).HasPrecision(8, 2);
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.NAME).HasMaxLength(255);
            entity.Property(e => e.STATUS).HasMaxLength(255);
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
        });

        modelBuilder.Entity<RECOGNIZED_BANK_TRANSACTION>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("RECOGNIZED_BANK_TRANSACTIONS");

            entity.HasIndex(e => e.ASSIGNED_ACCOUNT_ID, "RECOGNIZED_BANK_TRANSACTIONS_ASSIGNED_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.BANK_RULE_ID, "RECOGNIZED_BANK_TRANSACTIONS_BANK_RULE_ID_FOREIGN");

            entity.HasIndex(e => e.UNCATEGORIZED_TRANSACTION_ID, "RECOGNIZED_BANK_TRANSACTIONS_UNCATEGORIZED_TRANS_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ASSIGNED_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ASSIGNED_CATEGORY).HasMaxLength(255);
            entity.Property(e => e.ASSIGNED_MEMO).HasMaxLength(255);
            entity.Property(e => e.ASSIGNED_PAYEE).HasMaxLength(255);
            entity.Property(e => e.BANK_RULE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.UNCATEGORIZED_TRANSACTION_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");

            entity.HasOne(d => d.ASSIGNED_ACCOUNT).WithMany(p => p.RECOGNIZED_BANK_TRANSACTIONs)
                .HasForeignKey(d => d.ASSIGNED_ACCOUNT_ID)
                .HasConstraintName("RECOGNIZED_BANK_TRANSACTIONS_ASSIGNED_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.BANK_RULE).WithMany(p => p.RECOGNIZED_BANK_TRANSACTIONs)
                .HasForeignKey(d => d.BANK_RULE_ID)
                .HasConstraintName("RECOGNIZED_BANK_TRANSACTIONS_BANK_RULE_ID_FOREIGN");

            entity.HasOne(d => d.UNCATEGORIZED_TRANSACTION).WithMany(p => p.RECOGNIZED_BANK_TRANSACTIONs)
                .HasForeignKey(d => d.UNCATEGORIZED_TRANSACTION_ID)
                .HasConstraintName("RECOGNIZED_BANK_TRANSACTIONS_UNCATEGORIZED_TRANS_ID_FOREIGN");
        });

        modelBuilder.Entity<REFUND_CREDIT_NOTE_TRANSACTION>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("REFUND_CREDIT_NOTE_TRANSACTIONS");

            entity.HasIndex(e => e.BRANCH_ID, "REFUND_CREDIT_NOTE_TRANSACTIONS_BRANCH_ID_FOREIGN");

            entity.HasIndex(e => e.CREDIT_NOTE_ID, "REFUND_CREDIT_NOTE_TRANSACTIONS_CREDIT_NOTE_ID_FOREIGN");

            entity.HasIndex(e => e.FROM_ACCOUNT_ID, "REFUND_CREDIT_NOTE_TRANSACTIONS_FROM_ACCOUNT_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.AMOUNT).HasPrecision(13, 3);
            entity.Property(e => e.BRANCH_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CREDIT_NOTE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(3);
            entity.Property(e => e.DESCRIPTION).HasColumnType("text");
            entity.Property(e => e.EXCHANGE_RATE).HasPrecision(13, 9);
            entity.Property(e => e.FROM_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.REFERENCE_NO).HasMaxLength(255);
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.REFUND_CREDIT_NOTE_TRANSACTIONs)
                .HasForeignKey(d => d.BRANCH_ID)
                .HasConstraintName("REFUND_CREDIT_NOTE_TRANSACTIONS_BRANCH_ID_FOREIGN");

            entity.HasOne(d => d.CREDIT_NOTE).WithMany(p => p.REFUND_CREDIT_NOTE_TRANSACTIONs)
                .HasForeignKey(d => d.CREDIT_NOTE_ID)
                .HasConstraintName("REFUND_CREDIT_NOTE_TRANSACTIONS_CREDIT_NOTE_ID_FOREIGN");

            entity.HasOne(d => d.FROM_ACCOUNT).WithMany(p => p.REFUND_CREDIT_NOTE_TRANSACTIONs)
                .HasForeignKey(d => d.FROM_ACCOUNT_ID)
                .HasConstraintName("REFUND_CREDIT_NOTE_TRANSACTIONS_FROM_ACCOUNT_ID_FOREIGN");
        });

        modelBuilder.Entity<REFUND_VENDOR_CREDIT_TRANSACTION>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("REFUND_VENDOR_CREDIT_TRANSACTIONS");

            entity.HasIndex(e => e.BRANCH_ID, "REFUND_VENDOR_CREDIT_TRANSACTIONS_BRANCH_ID_FOREIGN");

            entity.HasIndex(e => e.DEPOSIT_ACCOUNT_ID, "REFUND_VENDOR_CREDIT_TRANSACTIONS_DEPOSIT_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.VENDOR_CREDIT_ID, "REFUND_VENDOR_CREDIT_TRANSACTIONS_VENDOR_CREDIT_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.AMOUNT).HasPrecision(13, 3);
            entity.Property(e => e.BRANCH_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(3);
            entity.Property(e => e.DEPOSIT_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.DESCRIPTION).HasColumnType("text");
            entity.Property(e => e.EXCHANGE_RATE).HasPrecision(13, 9);
            entity.Property(e => e.REFERENCE_NO).HasMaxLength(255);
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.VENDOR_CREDIT_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.REFUND_VENDOR_CREDIT_TRANSACTIONs)
                .HasForeignKey(d => d.BRANCH_ID)
                .HasConstraintName("REFUND_VENDOR_CREDIT_TRANSACTIONS_BRANCH_ID_FOREIGN");

            entity.HasOne(d => d.DEPOSIT_ACCOUNT).WithMany(p => p.REFUND_VENDOR_CREDIT_TRANSACTIONs)
                .HasForeignKey(d => d.DEPOSIT_ACCOUNT_ID)
                .HasConstraintName("REFUND_VENDOR_CREDIT_TRANSACTIONS_DEPOSIT_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.VENDOR_CREDIT).WithMany(p => p.REFUND_VENDOR_CREDIT_TRANSACTIONs)
                .HasForeignKey(d => d.VENDOR_CREDIT_ID)
                .HasConstraintName("REFUND_VENDOR_CREDIT_TRANSACTIONS_VENDOR_CREDIT_ID_FOREIGN");
        });

        modelBuilder.Entity<ROLE>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("ROLES");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.DESCRIPTION).HasColumnType("text");
            entity.Property(e => e.NAME).HasMaxLength(255);
            entity.Property(e => e.SLUG).HasMaxLength(255);
        });

        modelBuilder.Entity<ROLE_PERMISSION>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("ROLE_PERMISSIONS");

            entity.HasIndex(e => e.ROLE_ID, "ROLE_PERMISSIONS_ROLE_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ABILITY).HasMaxLength(255);
            entity.Property(e => e.ROLE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.SUBJECT).HasMaxLength(255);

            entity.HasOne(d => d.ROLE).WithMany(p => p.ROLE_PERMISSIONs)
                .HasForeignKey(d => d.ROLE_ID)
                .HasConstraintName("ROLE_PERMISSIONS_ROLE_ID_FOREIGN");
        });

        modelBuilder.Entity<SALES_ESTIMATE>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("SALES_ESTIMATES");

            entity.HasIndex(e => e.APPROVED_AT, "SALES_ESTIMATES_APPROVED_AT_INDEX");

            entity.HasIndex(e => e.BRANCH_ID, "SALES_ESTIMATES_BRANCH_ID_FOREIGN");

            entity.HasIndex(e => e.CUSTOMER_ID, "SALES_ESTIMATES_CUSTOMER_ID_INDEX");

            entity.HasIndex(e => e.DELIVERED_AT, "SALES_ESTIMATES_DELIVERED_AT_INDEX");

            entity.HasIndex(e => e.ESTIMATE_DATE, "SALES_ESTIMATES_ESTIMATE_DATE_INDEX");

            entity.HasIndex(e => e.ESTIMATE_NUMBER, "SALES_ESTIMATES_ESTIMATE_NUMBER_INDEX");

            entity.HasIndex(e => e.EXPIRATION_DATE, "SALES_ESTIMATES_EXPIRATION_DATE_INDEX");

            entity.HasIndex(e => e.PDF_TEMPLATE_ID, "SALES_ESTIMATES_PDF_TEMPLATE_ID_FOREIGN");

            entity.HasIndex(e => e.REJECTED_AT, "SALES_ESTIMATES_REJECTED_AT_INDEX");

            entity.HasIndex(e => e.USER_ID, "SALES_ESTIMATES_USER_ID_INDEX");

            entity.HasIndex(e => e.WAREHOUSE_ID, "SALES_ESTIMATES_WAREHOUSE_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ADJUSTMENT).HasPrecision(10, 2);
            entity.Property(e => e.AMOUNT).HasPrecision(13, 3);
            entity.Property(e => e.BRANCH_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CONVERTED_TO_INVOICE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(3);
            entity.Property(e => e.CUSTOMER_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.DISCOUNT).HasPrecision(10, 2);
            entity.Property(e => e.DISCOUNT_TYPE).HasMaxLength(255);
            entity.Property(e => e.EXCHANGE_RATE).HasPrecision(13, 9);
            entity.Property(e => e.NOTE).HasColumnType("text");
            entity.Property(e => e.PDF_TEMPLATE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.REFERENCE).HasMaxLength(255);
            entity.Property(e => e.SEND_TO_EMAIL).HasColumnType("text");
            entity.Property(e => e.TERMS_CONDITIONS).HasColumnType("text");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.USER_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.WAREHOUSE_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.SALES_ESTIMATEs)
                .HasForeignKey(d => d.BRANCH_ID)
                .HasConstraintName("SALES_ESTIMATES_BRANCH_ID_FOREIGN");

            entity.HasOne(d => d.CUSTOMER).WithMany(p => p.SALES_ESTIMATEs)
                .HasForeignKey(d => d.CUSTOMER_ID)
                .HasConstraintName("SALES_ESTIMATES_CUSTOMER_ID_FOREIGN");

            entity.HasOne(d => d.PDF_TEMPLATE).WithMany(p => p.SALES_ESTIMATEs)
                .HasForeignKey(d => d.PDF_TEMPLATE_ID)
                .HasConstraintName("SALES_ESTIMATES_PDF_TEMPLATE_ID_FOREIGN");

            entity.HasOne(d => d.WAREHOUSE).WithMany(p => p.SALES_ESTIMATEs)
                .HasForeignKey(d => d.WAREHOUSE_ID)
                .HasConstraintName("SALES_ESTIMATES_WAREHOUSE_ID_FOREIGN");
        });

        modelBuilder.Entity<SALES_INVOICE>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("SALES_INVOICES");

            entity.HasIndex(e => e.BRANCH_ID, "SALES_INVOICES_BRANCH_ID_FOREIGN");

            entity.HasIndex(e => e.CUSTOMER_ID, "SALES_INVOICES_CUSTOMER_ID_INDEX");

            entity.HasIndex(e => e.DELIVERED_AT, "SALES_INVOICES_DELIVERED_AT_INDEX");

            entity.HasIndex(e => e.INVOICE_DATE, "SALES_INVOICES_INVOICE_DATE_INDEX");

            entity.HasIndex(e => e.INVOICE_NO, "SALES_INVOICES_INVOICE_NO_INDEX");

            entity.HasIndex(e => e.INV_LOT_NUMBER, "SALES_INVOICES_INV_LOT_NUMBER_INDEX");

            entity.HasIndex(e => e.PDF_TEMPLATE_ID, "SALES_INVOICES_PDF_TEMPLATE_ID_FOREIGN");

            entity.HasIndex(e => e.PROJECT_ID, "SALES_INVOICES_PROJECTID_FOREIGN");

            entity.HasIndex(e => e.WAREHOUSE_ID, "SALES_INVOICES_WAREHOUSE_ID_FOREIGN");

            entity.HasIndex(e => e.WRITTENOFF_AT, "SALES_INVOICES_WRITTENOFF_AT_INDEX");

            entity.HasIndex(e => e.WRITTENOFF_EXPENSE_ACCOUNT_ID, "SALES_INVOICES_WRITTENOFF_EXPENSE_ACCOUNT_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ADJUSTMENT).HasPrecision(10, 2);
            entity.Property(e => e.BALANCE).HasPrecision(13, 3);
            entity.Property(e => e.BRANCH_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CREDITED_AMOUNT)
                .HasPrecision(13, 3)
                .HasDefaultValueSql("'0.000'");
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(3);
            entity.Property(e => e.CUSTOMER_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.DISCOUNT).HasPrecision(10, 2);
            entity.Property(e => e.DISCOUNT_TYPE).HasMaxLength(255);
            entity.Property(e => e.EXCHANGE_RATE).HasPrecision(13, 9);
            entity.Property(e => e.INVOICE_MESSAGE).HasColumnType("text");
            entity.Property(e => e.IS_INCLUSIVE_TAX).HasDefaultValueSql("'0'");
            entity.Property(e => e.PAYMENT_AMOUNT).HasPrecision(13, 3);
            entity.Property(e => e.PDF_TEMPLATE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.PROJECT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.REFERENCE_NO).HasMaxLength(255);
            entity.Property(e => e.TAX_AMOUNT_WITHHELD).HasPrecision(13, 2);
            entity.Property(e => e.TERMS_CONDITIONS).HasColumnType("text");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.USER_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.WAREHOUSE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.WRITTENOFF_AMOUNT).HasPrecision(13, 3);
            entity.Property(e => e.WRITTENOFF_EXPENSE_ACCOUNT_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.SALES_INVOICEs)
                .HasForeignKey(d => d.BRANCH_ID)
                .HasConstraintName("SALES_INVOICES_BRANCH_ID_FOREIGN");

            entity.HasOne(d => d.CUSTOMER).WithMany(p => p.SALES_INVOICEs)
                .HasForeignKey(d => d.CUSTOMER_ID)
                .HasConstraintName("SALES_INVOICES_CUSTOMER_ID_FOREIGN");

            entity.HasOne(d => d.PDF_TEMPLATE).WithMany(p => p.SALES_INVOICEs)
                .HasForeignKey(d => d.PDF_TEMPLATE_ID)
                .HasConstraintName("SALES_INVOICES_PDF_TEMPLATE_ID_FOREIGN");

            entity.HasOne(d => d.PROJECT).WithMany(p => p.SALES_INVOICEs)
                .HasForeignKey(d => d.PROJECT_ID)
                .HasConstraintName("SALES_INVOICES_PROJECTID_FOREIGN");

            entity.HasOne(d => d.WAREHOUSE).WithMany(p => p.SALES_INVOICEs)
                .HasForeignKey(d => d.WAREHOUSE_ID)
                .HasConstraintName("SALES_INVOICES_WAREHOUSE_ID_FOREIGN");

            entity.HasOne(d => d.WRITTENOFF_EXPENSE_ACCOUNT).WithMany(p => p.SALES_INVOICEs)
                .HasForeignKey(d => d.WRITTENOFF_EXPENSE_ACCOUNT_ID)
                .HasConstraintName("SALES_INVOICES_WRITTENOFF_EXPENSE_ACCOUNT_ID_FOREIGN");
        });

        modelBuilder.Entity<SALES_RECEIPT>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("SALES_RECEIPTS");

            entity.HasIndex(e => e.BRANCH_ID, "SALES_RECEIPTS_BRANCH_ID_FOREIGN");

            entity.HasIndex(e => e.CLOSED_AT, "SALES_RECEIPTS_CLOSED_AT_INDEX");

            entity.HasIndex(e => e.CUSTOMER_ID, "SALES_RECEIPTS_CUSTOMER_ID_INDEX");

            entity.HasIndex(e => e.DEPOSIT_ACCOUNT_ID, "SALES_RECEIPTS_DEPOSIT_ACCOUNT_ID_INDEX");

            entity.HasIndex(e => e.PDF_TEMPLATE_ID, "SALES_RECEIPTS_PDF_TEMPLATE_ID_FOREIGN");

            entity.HasIndex(e => e.RECEIPT_DATE, "SALES_RECEIPTS_RECEIPT_DATE_INDEX");

            entity.HasIndex(e => e.RECEIPT_NUMBER, "SALES_RECEIPTS_RECEIPT_NUMBER_INDEX");

            entity.HasIndex(e => e.REFERENCE_NO, "SALES_RECEIPTS_REFERENCE_NO_INDEX");

            entity.HasIndex(e => e.WAREHOUSE_ID, "SALES_RECEIPTS_WAREHOUSE_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ADJUSTMENT).HasPrecision(10, 2);
            entity.Property(e => e.AMOUNT).HasPrecision(13, 3);
            entity.Property(e => e.BRANCH_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(3);
            entity.Property(e => e.CUSTOMER_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.DEPOSIT_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.DISCOUNT).HasPrecision(10, 2);
            entity.Property(e => e.DISCOUNT_TYPE).HasMaxLength(255);
            entity.Property(e => e.EXCHANGE_RATE).HasPrecision(13, 9);
            entity.Property(e => e.PDF_TEMPLATE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.RECEIPT_MESSAGE).HasColumnType("text");
            entity.Property(e => e.SEND_TO_EMAIL).HasMaxLength(255);
            entity.Property(e => e.STATEMENT).HasColumnType("text");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.WAREHOUSE_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.SALES_RECEIPTs)
                .HasForeignKey(d => d.BRANCH_ID)
                .HasConstraintName("SALES_RECEIPTS_BRANCH_ID_FOREIGN");

            entity.HasOne(d => d.CUSTOMER).WithMany(p => p.SALES_RECEIPTs)
                .HasForeignKey(d => d.CUSTOMER_ID)
                .HasConstraintName("SALES_RECEIPTS_CUSTOMER_ID_FOREIGN");

            entity.HasOne(d => d.DEPOSIT_ACCOUNT).WithMany(p => p.SALES_RECEIPTs)
                .HasForeignKey(d => d.DEPOSIT_ACCOUNT_ID)
                .HasConstraintName("SALES_RECEIPTS_DEPOSIT_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.PDF_TEMPLATE).WithMany(p => p.SALES_RECEIPTs)
                .HasForeignKey(d => d.PDF_TEMPLATE_ID)
                .HasConstraintName("SALES_RECEIPTS_PDF_TEMPLATE_ID_FOREIGN");

            entity.HasOne(d => d.WAREHOUSE).WithMany(p => p.SALES_RECEIPTs)
                .HasForeignKey(d => d.WAREHOUSE_ID)
                .HasConstraintName("SALES_RECEIPTS_WAREHOUSE_ID_FOREIGN");
        });

        modelBuilder.Entity<SETTING>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("SETTINGS");

            entity.HasIndex(e => e.GROUP, "SETTINGS_GROUP_INDEX");

            entity.HasIndex(e => e.KEY, "SETTINGS_KEY_INDEX");

            entity.HasIndex(e => e.USER_ID, "SETTINGS_USER_ID_INDEX");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.TYPE).HasMaxLength(255);
            entity.Property(e => e.USER_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.VALUE).HasColumnType("text");
        });

        modelBuilder.Entity<TASK>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("TASKS");

            entity.HasIndex(e => e.PROJECT_ID, "TASKS_PROJECT_ID_FOREIGN");

            entity.Property(e => e.ID)
                .HasComment("Auto-generated id")
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.ACTUAL_HOURS).HasColumnType("decimal(8,2) unsigned");
            entity.Property(e => e.CHARGE_TYPE).HasMaxLength(255);
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.ESTIMATE_HOURS).HasColumnType("decimal(8,2) unsigned");
            entity.Property(e => e.INVOICED_HOURS)
                .HasDefaultValueSql("'0.00'")
                .HasColumnType("decimal(8,2) unsigned");
            entity.Property(e => e.NAME).HasMaxLength(255);
            entity.Property(e => e.PROJECT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.RATE).HasPrecision(8, 2);
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");

            entity.HasOne(d => d.PROJECT).WithMany(p => p.TASKs)
                .HasForeignKey(d => d.PROJECT_ID)
                .HasConstraintName("TASKS_PROJECT_ID_FOREIGN");
        });

        modelBuilder.Entity<TAX_RATE>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("TAX_RATES");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ACTIVE).HasDefaultValueSql("'0'");
            entity.Property(e => e.CODE).HasMaxLength(255);
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.DESCRIPTION).HasMaxLength(255);
            entity.Property(e => e.IS_COMPOUND).HasDefaultValueSql("'0'");
            entity.Property(e => e.IS_NON_RECOVERABLE).HasDefaultValueSql("'0'");
            entity.Property(e => e.NAME).HasMaxLength(255);
            entity.Property(e => e.RATE).HasPrecision(8, 2);
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
        });

        modelBuilder.Entity<TAX_RATE_TRANSACTION>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("TAX_RATE_TRANSACTIONS");

            entity.HasIndex(e => e.TAX_RATE_ID, "TAX_RATE_TRANSACTIONS_TAX_RATE_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.RATE).HasColumnType("decimal(8,2) unsigned");
            entity.Property(e => e.REFERENCE_ID).HasColumnType("int(11)");
            entity.Property(e => e.REFERENCE_TYPE).HasMaxLength(255);
            entity.Property(e => e.TAX_ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.TAX_RATE_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.TAX_RATE).WithMany(p => p.TAX_RATE_TRANSACTIONs)
                .HasForeignKey(d => d.TAX_RATE_ID)
                .HasConstraintName("TAX_RATE_TRANSACTIONS_TAX_RATE_ID_FOREIGN");
        });

        modelBuilder.Entity<TIME>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("TIMES");

            entity.HasIndex(e => e.PROJECT_ID, "TIMES_PROJECT_ID_FOREIGN");

            entity.HasIndex(e => e.TASK_ID, "TIMES_TASKID_FOREIGN");

            entity.Property(e => e.ID)
                .HasComment("Auto-generated id")
                .HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.DESCRIPTION).HasMaxLength(255);
            entity.Property(e => e.DURATION).HasColumnType("int(10) unsigned");
            entity.Property(e => e.PROJECT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.TASK_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");

            entity.HasOne(d => d.PROJECT).WithMany(p => p.TIMEs)
                .HasForeignKey(d => d.PROJECT_ID)
                .HasConstraintName("TIMES_PROJECT_ID_FOREIGN");

            entity.HasOne(d => d.TASK).WithMany(p => p.TIMEs)
                .HasForeignKey(d => d.TASK_ID)
                .HasConstraintName("TIMES_TASKID_FOREIGN");
        });

        modelBuilder.Entity<TRANSACTIONS_PAYMENT_METHOD>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("TRANSACTIONS_PAYMENT_METHODS");

            entity.HasIndex(e => e.PAYMENT_INTEGRATION_ID, "TRANSACTIONS_PAYMENT_METHODS_PAYMENT_INTEGRATION_ID_INDEX");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ENABLE).HasDefaultValueSql("'0'");
            entity.Property(e => e.OPTIONS)
                .UseCollation("utf8mb4_bin")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.PAYMENT_INTEGRATION_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.REFERENCE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.REFERENCE_TYPE).HasMaxLength(255);

            entity.HasOne(d => d.PAYMENT_INTEGRATION).WithMany(p => p.TRANSACTIONS_PAYMENT_METHODs)
                .HasForeignKey(d => d.PAYMENT_INTEGRATION_ID)
                .HasConstraintName("TRANSACTIONS_PAYMENT_METHODS_PAYMENT_INTEGRATION_ID_FOREIGN");
        });

        modelBuilder.Entity<UNCATEGORIZED_CASHFLOW_TRANSACTION>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("UNCATEGORIZED_CASHFLOW_TRANSACTIONS");

            entity.HasIndex(e => e.ACCOUNT_ID, "UNCATEGORIZED_CASHFLOW_TRANSACTIONS_ACCOUNT_ID_FOREIGN");

            entity.HasIndex(e => e.DATE, "UNCATEGORIZED_CASHFLOW_TRANSACTIONS_DATE_INDEX");

            entity.HasIndex(e => e.REFERENCE_NO, "UNCATEGORIZED_CASHFLOW_TRANSACTIONS_REFERENCE_NO_INDEX");

            entity.HasIndex(e => e.RECOGNIZED_TRANSACTION_ID, "UNCATEGORIZED_CASHFLOW_TRANS_RECOGNIZED_TRAN_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ACCOUNT_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.AMOUNT).HasPrecision(8, 2);
            entity.Property(e => e.BATCH).HasMaxLength(255);
            entity.Property(e => e.CATEGORIZED).HasDefaultValueSql("'0'");
            entity.Property(e => e.CATEGORIZE_REF_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CATEGORIZE_REF_TYPE).HasMaxLength(255);
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(255);
            entity.Property(e => e.DESCRIPTION).HasMaxLength(255);
            entity.Property(e => e.EXCLUDED_AT).HasColumnType("datetime");
            entity.Property(e => e.PAYEE).HasMaxLength(255);
            entity.Property(e => e.PENDING).HasDefaultValueSql("'0'");
            entity.Property(e => e.PENDING_PLAID_TRANSACTION_ID).HasMaxLength(255);
            entity.Property(e => e.PLAID_TRANSACTION_ID).HasMaxLength(255);
            entity.Property(e => e.RECOGNIZED_TRANSACTION_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");

            entity.HasOne(d => d.ACCOUNT).WithMany(p => p.UNCATEGORIZED_CASHFLOW_TRANSACTIONs)
                .HasForeignKey(d => d.ACCOUNT_ID)
                .HasConstraintName("UNCATEGORIZED_CASHFLOW_TRANSACTIONS_ACCOUNT_ID_FOREIGN");

            entity.HasOne(d => d.RECOGNIZED_TRANSACTION).WithMany(p => p.UNCATEGORIZED_CASHFLOW_TRANSACTIONs)
                .HasForeignKey(d => d.RECOGNIZED_TRANSACTION_ID)
                .HasConstraintName("UNCATEGORIZED_CASHFLOW_TRANS_RECOGNIZED_TRAN_ID_FOREIGN");
        });

        modelBuilder.Entity<USER>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("USERS");

            entity.HasIndex(e => e.ACTIVE, "USERS_ACTIVE_INDEX");

            entity.HasIndex(e => e.EMAIL, "USERS_EMAIL_INDEX");

            entity.HasIndex(e => e.INVITED_AT, "USERS_INVITED_AT_INDEX");

            entity.HasIndex(e => e.INVITE_ACCEPTED_AT, "USERS_INVITE_ACCEPTED_AT_INDEX");

            entity.HasIndex(e => e.ROLE_ID, "USERS_ROLE_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.FIRST_NAME).HasMaxLength(255);
            entity.Property(e => e.INVITED_AT).HasColumnType("datetime");
            entity.Property(e => e.INVITE_ACCEPTED_AT).HasColumnType("datetime");
            entity.Property(e => e.LAST_NAME).HasMaxLength(255);
            entity.Property(e => e.ROLE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.SYSTEM_USER_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");

            entity.HasOne(d => d.ROLE).WithMany(p => p.USERs)
                .HasForeignKey(d => d.ROLE_ID)
                .HasConstraintName("USERS_ROLE_ID_FOREIGN");
        });

        modelBuilder.Entity<VENDOR_CREDIT>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("VENDOR_CREDITS");

            entity.HasIndex(e => e.BRANCH_ID, "VENDOR_CREDITS_BRANCH_ID_FOREIGN");

            entity.HasIndex(e => e.OPENED_AT, "VENDOR_CREDITS_OPENED_AT_INDEX");

            entity.HasIndex(e => e.USER_ID, "VENDOR_CREDITS_USER_ID_FOREIGN");

            entity.HasIndex(e => e.VENDOR_ID, "VENDOR_CREDITS_VENDOR_ID_FOREIGN");

            entity.HasIndex(e => e.WAREHOUSE_ID, "VENDOR_CREDITS_WAREHOUSE_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ADJUSTMENT).HasPrecision(10, 2);
            entity.Property(e => e.AMOUNT).HasPrecision(13, 3);
            entity.Property(e => e.BRANCH_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.CURRENCY_CODE).HasMaxLength(3);
            entity.Property(e => e.DISCOUNT).HasPrecision(10, 2);
            entity.Property(e => e.DISCOUNT_TYPE).HasMaxLength(255);
            entity.Property(e => e.EXCHANGE_RATE).HasPrecision(13, 9);
            entity.Property(e => e.INVOICED_AMOUNT)
                .HasPrecision(13, 3)
                .HasDefaultValueSql("'0.000'");
            entity.Property(e => e.NOTE).HasColumnType("text");
            entity.Property(e => e.REFERENCE_NO).HasMaxLength(255);
            entity.Property(e => e.REFUNDED_AMOUNT)
                .HasPrecision(13, 3)
                .HasDefaultValueSql("'0.000'");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.USER_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.VENDOR_CREDIT_NUMBER).HasMaxLength(255);
            entity.Property(e => e.VENDOR_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.WAREHOUSE_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.BRANCH).WithMany(p => p.VENDOR_CREDITs)
                .HasForeignKey(d => d.BRANCH_ID)
                .HasConstraintName("VENDOR_CREDITS_BRANCH_ID_FOREIGN");

            entity.HasOne(d => d.USER).WithMany(p => p.VENDOR_CREDITs)
                .HasForeignKey(d => d.USER_ID)
                .HasConstraintName("VENDOR_CREDITS_USER_ID_FOREIGN");

            entity.HasOne(d => d.VENDOR).WithMany(p => p.VENDOR_CREDITs)
                .HasForeignKey(d => d.VENDOR_ID)
                .HasConstraintName("VENDOR_CREDITS_VENDOR_ID_FOREIGN");

            entity.HasOne(d => d.WAREHOUSE).WithMany(p => p.VENDOR_CREDITs)
                .HasForeignKey(d => d.WAREHOUSE_ID)
                .HasConstraintName("VENDOR_CREDITS_WAREHOUSE_ID_FOREIGN");
        });

        modelBuilder.Entity<VENDOR_CREDIT_APPLIED_BILL>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("VENDOR_CREDIT_APPLIED_BILL");

            entity.HasIndex(e => e.BILL_ID, "VENDOR_CREDIT_APPLIED_BILL_BILL_ID_FOREIGN");

            entity.HasIndex(e => e.VENDOR_CREDIT_ID, "VENDOR_CREDIT_APPLIED_BILL_VENDOR_CREDIT_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.AMOUNT).HasPrecision(13, 3);
            entity.Property(e => e.BILL_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.VENDOR_CREDIT_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.BILL).WithMany(p => p.VENDOR_CREDIT_APPLIED_BILLs)
                .HasForeignKey(d => d.BILL_ID)
                .HasConstraintName("VENDOR_CREDIT_APPLIED_BILL_BILL_ID_FOREIGN");

            entity.HasOne(d => d.VENDOR_CREDIT).WithMany(p => p.VENDOR_CREDIT_APPLIED_BILLs)
                .HasForeignKey(d => d.VENDOR_CREDIT_ID)
                .HasConstraintName("VENDOR_CREDIT_APPLIED_BILL_VENDOR_CREDIT_ID_FOREIGN");
        });

        modelBuilder.Entity<VIEW>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("VIEWS");

            entity.HasIndex(e => e.NAME, "VIEWS_NAME_INDEX");

            entity.HasIndex(e => e.RESOURCE_MODEL, "VIEWS_RESOURCE_MODEL_INDEX");

            entity.HasIndex(e => e.SLUG, "VIEWS_SLUG_INDEX");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.ROLES_LOGIC_EXPRESSION).HasMaxLength(255);
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
        });

        modelBuilder.Entity<VIEW_HAS_COLUMN>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("VIEW_HAS_COLUMNS");

            entity.HasIndex(e => e.VIEW_ID, "VIEW_HAS_COLUMNS_VIEW_ID_INDEX");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.FIELD_KEY).HasMaxLength(255);
            entity.Property(e => e.INDEX).HasColumnType("int(10) unsigned");
            entity.Property(e => e.VIEW_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.VIEW).WithMany(p => p.VIEW_HAS_COLUMNs)
                .HasForeignKey(d => d.VIEW_ID)
                .HasConstraintName("VIEW_HAS_COLUMNS_VIEW_ID_FOREIGN");
        });

        modelBuilder.Entity<VIEW_ROLE>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("VIEW_ROLES");

            entity.HasIndex(e => e.FIELD_KEY, "VIEW_ROLES_FIELD_KEY_INDEX");

            entity.HasIndex(e => e.VIEW_ID, "VIEW_ROLES_VIEW_ID_INDEX");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.COMPARATOR).HasMaxLength(255);
            entity.Property(e => e.INDEX).HasColumnType("int(11)");
            entity.Property(e => e.VALUE).HasMaxLength(255);
            entity.Property(e => e.VIEW_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.VIEW).WithMany(p => p.VIEW_ROLEs)
                .HasForeignKey(d => d.VIEW_ID)
                .HasConstraintName("VIEW_ROLES_VIEW_ID_FOREIGN");
        });

        modelBuilder.Entity<WAREHOUSE>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("WAREHOUSES");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.ADDRESS).HasMaxLength(255);
            entity.Property(e => e.CITY).HasMaxLength(255);
            entity.Property(e => e.CODE).HasMaxLength(255);
            entity.Property(e => e.COUNTRY).HasMaxLength(255);
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.EMAIL).HasMaxLength(255);
            entity.Property(e => e.NAME).HasMaxLength(255);
            entity.Property(e => e.PHONE_NUMBER).HasMaxLength(255);
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");
            entity.Property(e => e.WEBSITE).HasMaxLength(255);
        });

        modelBuilder.Entity<WAREHOUSES_TRANSFER>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("WAREHOUSES_TRANSFERS");

            entity.HasIndex(e => e.FROM_WAREHOUSE_ID, "WAREHOUSES_TRANSFERS_FROM_WAREHOUSE_ID_FOREIGN");

            entity.HasIndex(e => e.TO_WAREHOUSE_ID, "WAREHOUSES_TRANSFERS_TO_WAREHOUSE_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.CREATED_AT).HasColumnType("datetime");
            entity.Property(e => e.FROM_WAREHOUSE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.TO_WAREHOUSE_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.TRANSACTION_NUMBER).HasMaxLength(255);
            entity.Property(e => e.UPDATED_AT).HasColumnType("datetime");

            entity.HasOne(d => d.FROM_WAREHOUSE).WithMany(p => p.WAREHOUSES_TRANSFERFROM_WAREHOUSEs)
                .HasForeignKey(d => d.FROM_WAREHOUSE_ID)
                .HasConstraintName("WAREHOUSES_TRANSFERS_FROM_WAREHOUSE_ID_FOREIGN");

            entity.HasOne(d => d.TO_WAREHOUSE).WithMany(p => p.WAREHOUSES_TRANSFERTO_WAREHOUSEs)
                .HasForeignKey(d => d.TO_WAREHOUSE_ID)
                .HasConstraintName("WAREHOUSES_TRANSFERS_TO_WAREHOUSE_ID_FOREIGN");
        });

        modelBuilder.Entity<WAREHOUSES_TRANSFERS_ENTRy>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY");

            entity.ToTable("WAREHOUSES_TRANSFERS_ENTRIES");

            entity.HasIndex(e => e.ITEM_ID, "WAREHOUSES_TRANSFERS_ENTRIES_ITEM_ID_FOREIGN");

            entity.HasIndex(e => e.WAREHOUSE_TRANSFER_ID, "WAREHOUSES_TRANSFERS_ENTRIES_WAREHOUSE_TRANSFER_ID_FOREIGN");

            entity.Property(e => e.ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.COST).HasPrecision(8, 2);
            entity.Property(e => e.DESCRIPTION).HasMaxLength(255);
            entity.Property(e => e.INDEX).HasColumnType("int(11)");
            entity.Property(e => e.ITEM_ID).HasColumnType("int(10) unsigned");
            entity.Property(e => e.QUANTITY).HasColumnType("int(11)");
            entity.Property(e => e.WAREHOUSE_TRANSFER_ID).HasColumnType("int(10) unsigned");

            entity.HasOne(d => d.ITEM).WithMany(p => p.WAREHOUSES_TRANSFERS_ENTRies)
                .HasForeignKey(d => d.ITEM_ID)
                .HasConstraintName("WAREHOUSES_TRANSFERS_ENTRIES_ITEM_ID_FOREIGN");

            entity.HasOne(d => d.WAREHOUSE_TRANSFER).WithMany(p => p.WAREHOUSES_TRANSFERS_ENTRies)
                .HasForeignKey(d => d.WAREHOUSE_TRANSFER_ID)
                .HasConstraintName("WAREHOUSES_TRANSFERS_ENTRIES_WAREHOUSE_TRANSFER_ID_FOREIGN");
        });

        modelBuilder.Entity<knex_migration>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PRIMARY");

            entity.Property(e => e.id).HasColumnType("int(10) unsigned");
            entity.Property(e => e.batch).HasColumnType("int(11)");
            entity.Property(e => e.migration_time)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.name).HasMaxLength(255);
        });

        modelBuilder.Entity<knex_migrations_lock>(entity =>
        {
            entity.HasKey(e => e.index).HasName("PRIMARY");

            entity.ToTable("knex_migrations_lock");

            entity.Property(e => e.index).HasColumnType("int(10) unsigned");
            entity.Property(e => e.is_locked).HasColumnType("int(11)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
