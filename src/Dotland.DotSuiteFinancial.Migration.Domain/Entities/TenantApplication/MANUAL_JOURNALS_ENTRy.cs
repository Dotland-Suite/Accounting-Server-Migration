namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class MANUAL_JOURNALS_ENTRy
{
    public uint ID { get; set; }

    public decimal? CREDIT { get; set; }

    public decimal? DEBIT { get; set; }

    public uint? INDEX { get; set; }

    public uint? ACCOUNT_ID { get; set; }

    public uint? CONTACT_ID { get; set; }

    public string? NOTE { get; set; }

    public uint? MANUAL_JOURNAL_ID { get; set; }

    public uint? BRANCH_ID { get; set; }

    public uint? PROJECT_ID { get; set; }

    public virtual Account? ACCOUNT { get; set; }

    public virtual BRANCH? BRANCH { get; set; }

    public virtual MANUAL_JOURNAL? MANUAL_JOURNAL { get; set; }

    public virtual PROJECT? PROJECT { get; set; }
}
