namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class MANUAL_JOURNAL
{
    public uint ID { get; set; }

    public string? JOURNAL_NUMBER { get; set; }

    public string? REFERENCE { get; set; }

    public string? JOURNAL_TYPE { get; set; }

    public decimal? AMOUNT { get; set; }

    public string? CURRENCY_CODE { get; set; }

    public decimal? EXCHANGE_RATE { get; set; }

    public DateOnly? DATE { get; set; }

    public string? DESCRIPTION { get; set; }

    public DateOnly? PUBLISHED_AT { get; set; }

    public string? ATTACHMENT_FILE { get; set; }

    public uint? USER_ID { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public uint? BRANCH_ID { get; set; }

    public virtual BRANCH? BRANCH { get; set; }

    public virtual ICollection<MANUAL_JOURNALS_ENTRy> MANUAL_JOURNALS_ENTRies { get; set; } = new List<MANUAL_JOURNALS_ENTRy>();
}
