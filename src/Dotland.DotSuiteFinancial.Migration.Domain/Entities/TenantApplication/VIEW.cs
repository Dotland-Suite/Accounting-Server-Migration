namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class VIEW
{
    public uint ID { get; set; }

    public string? NAME { get; set; }

    public string? SLUG { get; set; }

    public bool? PREDEFINED { get; set; }

    public string? RESOURCE_MODEL { get; set; }

    public bool? FAVOURITE { get; set; }

    public string? ROLES_LOGIC_EXPRESSION { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual ICollection<VIEW_HAS_COLUMN> VIEW_HAS_COLUMNs { get; set; } = new List<VIEW_HAS_COLUMN>();

    public virtual ICollection<VIEW_ROLE> VIEW_ROLEs { get; set; } = new List<VIEW_ROLE>();
}
