namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantStore;

public class UserInvite
{
    public uint Id { get; set; }
    public string? Email { get; set; }
    public string? Token { get; set; }
    public ulong? TenantId { get; set; }
    public uint? UserId { get; set; }
    public DateTime? CreatedAt { get; set; }
    public virtual TenantStore? Tenant { get; set; }
    public virtual UserStore? User { get; set; }
}
