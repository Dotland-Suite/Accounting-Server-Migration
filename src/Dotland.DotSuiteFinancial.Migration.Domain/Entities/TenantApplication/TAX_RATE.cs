namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class TAX_RATE
{
    public uint ID { get; set; }

    public string? NAME { get; set; }

    public string? CODE { get; set; }

    public decimal? RATE { get; set; }

    public string? DESCRIPTION { get; set; }

    public bool? IS_NON_RECOVERABLE { get; set; }

    public bool? IS_COMPOUND { get; set; }

    public bool? ACTIVE { get; set; }

    public DateOnly? DELETED_AT { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual ICollection<AccountsTransaction> ACCOUNTS_TRANSACTIONs { get; set; } = new List<AccountsTransaction>();

    public virtual ICollection<ITEM> ITEMPURCHASE_TAX_RATEs { get; set; } = new List<ITEM>();

    public virtual ICollection<ITEM> ITEMSELL_TAX_RATEs { get; set; } = new List<ITEM>();

    public virtual ICollection<ITEMS_ENTRy> ITEMS_ENTRies { get; set; } = new List<ITEMS_ENTRy>();

    public virtual ICollection<TAX_RATE_TRANSACTION> TAX_RATE_TRANSACTIONs { get; set; } = new List<TAX_RATE_TRANSACTION>();
}
