namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantStore;

public class PasswordReset
{
    public uint Id { get; set; }
    public string? Email { get; set; }
    public string? Token { get; set; }
    public DateTime CreatedAt { get; set; }
}
