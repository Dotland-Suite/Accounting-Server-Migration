namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class TASK
{
    /// <summary>
    /// Auto-generated id
    /// </summary>
    public uint ID { get; set; }

    public string? NAME { get; set; }

    public string? CHARGE_TYPE { get; set; }

    public decimal? RATE { get; set; }

    public decimal? ESTIMATE_HOURS { get; set; }

    public decimal? ACTUAL_HOURS { get; set; }

    public decimal? INVOICED_HOURS { get; set; }

    public uint? PROJECT_ID { get; set; }

    public DateTime? CREATED_AT { get; set; }

    public DateTime? UPDATED_AT { get; set; }

    public virtual PROJECT? PROJECT { get; set; }

    public virtual ICollection<TIME> TIMEs { get; set; } = new List<TIME>();
}
