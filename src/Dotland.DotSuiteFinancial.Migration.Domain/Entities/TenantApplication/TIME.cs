namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class TIME
{
    /// <summary>
    /// Auto-generated id
    /// </summary>
    public uint ID { get; set; }

    public uint? DURATION { get; set; }

    public string? DESCRIPTION { get; set; }

    public DateOnly? DATE { get; set; }

    public uint? TASK_ID { get; set; }

    public uint? PROJECT_ID { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual PROJECT? PROJECT { get; set; }

    public virtual TASK? TASK { get; set; }
}
