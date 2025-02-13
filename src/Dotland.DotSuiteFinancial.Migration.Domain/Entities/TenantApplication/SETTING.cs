namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantApplication;

public partial class SETTING
{
    public uint ID { get; set; }

    public uint? USER_ID { get; set; }

    public string? GROUP { get; set; }

    public string? TYPE { get; set; }

    public string? KEY { get; set; }

    public string? VALUE { get; set; }
}
