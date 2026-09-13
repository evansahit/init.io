namespace Init.Io.API.Models.Entity;

public class TeamEntity : BaseEntity
{
    public string Name { get; private set; } = null!;
    public string Description { get; private set; } = null!;
    public string? LogoUrl { get; private set; }
    public long OrganizationId { get; private set; }
    public OrganizationEntity Organization { get; private set; } = null!;
    public ICollection<TeamUserEntity> TeamUsers { get; private set; } = [];
}
