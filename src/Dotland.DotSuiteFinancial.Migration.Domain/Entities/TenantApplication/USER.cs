namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class USER
{
    public uint ID { get; set; }

    public string? FIRST_NAME { get; set; }

    public string? LAST_NAME { get; set; }

    public string? EMAIL { get; set; }

    public bool? ACTIVE { get; set; }

    public uint? ROLE_ID { get; set; }

    public uint? SYSTEM_USER_ID { get; set; }

    public DateTime? INVITED_AT { get; set; }

    public DateTime? INVITE_ACCEPTED_AT { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual ICollection<CREDIT_NOTE> CREDIT_NOTEs { get; set; } = new List<CREDIT_NOTE>();

    public virtual ROLE? ROLE { get; set; }

    public virtual ICollection<VENDOR_CREDIT> VENDOR_CREDITs { get; set; } = new List<VENDOR_CREDIT>();
}
