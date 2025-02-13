namespace Dotland.DotSuiteFinancial.Migration.Domain.Entities.TenantStore;

public class UserStore
{
    public uint Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public bool? Active { get; set; }
    public string? Language { get; set; }
    public ulong? TenantId { get; set; }
    public DateTime? InviteAcceptedAt { get; set; }
    public DateTime? LastLoginAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string? VerifyToken { get; set; }
    public bool? Verified { get; set; }
    public virtual TenantStore? Tenant { get; set; }
    public virtual ICollection<UserInvite> UserInvites { get; set; } = new List<UserInvite>();
}
