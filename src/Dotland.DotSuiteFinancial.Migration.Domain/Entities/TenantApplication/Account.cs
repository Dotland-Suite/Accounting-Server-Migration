namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public class Account
{
    public uint Id { get; set; }
    public string? Name { get; set; }
    public string? Slug { get; set; }
    public string? AccountType { get; set; }
    public uint? ParentAccountId { get; set; }
    public string? Code { get; set; }
    public string? Description { get; set; }
    public bool? Active { get; set; }
    public uint? Index { get; set; }
    public bool? Predefined { get; set; }
    public decimal? Amount { get; set; }
    public string? CurrencyCode { get; set; }
    public DateOnly? SeededAt { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string? PlaidAccountId { get; set; }
    public string? AccountMask { get; set; }
    public decimal? BankBalance { get; set; }
    public int? UncategorizedTransactions { get; set; }
    public bool? IsSystemAccount { get; set; }
    public bool? IsFeedsActive { get; set; }
    public bool? IsSyncingOwner { get; set; }
    public DateTime? LastFeedsUpdatedAt { get; set; }
    public string? PlaidItemId { get; set; }
    public virtual ICollection<AccountsTransaction> AccountsTransactions { get; set; } = new List<AccountsTransaction>();
    public virtual ICollection<BankRule> BankRuleApplyIfAccounts { get; set; } = new List<BankRule>();
    public virtual ICollection<BankRule> BankRuleassignAccounts { get; set; } = new List<BankRule>();
    public virtual ICollection<BILLS_PAYMENT> BillsPayments { get; set; } = new List<BILLS_PAYMENT>();
    public virtual ICollection<CASHFLOW_TRANSACTION> CashflowTransactioncashflowAccounts { get; set; } = new List<CASHFLOW_TRANSACTION>();
    public virtual ICollection<CASHFLOW_TRANSACTION> CashflowTransactioncreditAccounts { get; set; } = new List<CASHFLOW_TRANSACTION>();
    public virtual ICollection<CASHFLOW_TRANSACTION_LINE> CashflowTransactionLinecashflowAccounts { get; set; } = new List<CASHFLOW_TRANSACTION_LINE>();
    public virtual ICollection<CASHFLOW_TRANSACTION_LINE> CashflowTransactionLinecreditAccounts { get; set; } = new List<CASHFLOW_TRANSACTION_LINE>();
    public virtual ICollection<EXPENSES_TRANSACTION> ExpensesTransactions { get; set; } = new List<EXPENSES_TRANSACTION>();
    public virtual ICollection<EXPENSE_TRANSACTION_CATEGORy> ExpenseTransactionCategories { get; set; } = new List<EXPENSE_TRANSACTION_CATEGORy>();
    public virtual ICollection<INVENTORY_ADJUSTMENT> InventoryAdjustments { get; set; } = new List<INVENTORY_ADJUSTMENT>();
    public virtual ICollection<ITEM> ItemCostAccounts { get; set; } = new List<ITEM>();
    public virtual ICollection<ITEM> ItemInventoryAccounts { get; set; } = new List<ITEM>();
    public virtual ICollection<ITEM> ItemSellAccounts { get; set; } = new List<ITEM>();
    public virtual ICollection<ITEMS_CATEGORy> ItemsCategoryCostAccounts { get; set; } = new List<ITEMS_CATEGORy>();
    public virtual ICollection<ITEMS_CATEGORy> ItemsCategotyInventoryAccounts { get; set; } = new List<ITEMS_CATEGORy>();
    public virtual ICollection<ITEMS_CATEGORy> ItemsCategorySellAccounts { get; set; } = new List<ITEMS_CATEGORy>();
    public virtual ICollection<ITEMS_ENTRy> ItemsEntryCostAccounts { get; set; } = new List<ITEMS_ENTRy>();
    public virtual ICollection<ITEMS_ENTRy> ItemsEntrySellAccounts { get; set; } = new List<ITEMS_ENTRy>();
    public virtual ICollection<Account> InverseParentAccount { get; set; } = new List<Account>();
    public virtual ICollection<MANUAL_JOURNALS_ENTRy> ManualJournalsEntries { get; set; } = new List<MANUAL_JOURNALS_ENTRy>();
    public virtual Account? ParentAccount { get; set; }
    public virtual ICollection<PAYMENT_RECEIfe> PaymentReceives { get; set; } = new List<PAYMENT_RECEIfe>();
    public virtual ICollection<RECOGNIZED_BANK_TRANSACTION> RecognizedBankTransactions { get; set; } = new List<RECOGNIZED_BANK_TRANSACTION>();
    public virtual ICollection<REFUND_CREDIT_NOTE_TRANSACTION> RefundCreditNoteTransactions { get; set; } = new List<REFUND_CREDIT_NOTE_TRANSACTION>();
    public virtual ICollection<REFUND_VENDOR_CREDIT_TRANSACTION> RefundVendorCreditTransactions { get; set; } = new List<REFUND_VENDOR_CREDIT_TRANSACTION>();
    public virtual ICollection<SALES_INVOICE> SalesInvoices { get; set; } = new List<SALES_INVOICE>();
    public virtual ICollection<SALES_RECEIPT> SalesReceipts { get; set; } = new List<SALES_RECEIPT>();
    public virtual ICollection<UNCATEGORIZED_CASHFLOW_TRANSACTION> UncategorizedCashflowTransactions { get; set; } = new List<UNCATEGORIZED_CASHFLOW_TRANSACTION>();
}
