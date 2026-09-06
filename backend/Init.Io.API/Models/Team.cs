namespace Init.Io.API.Models;

public class Team : BaseEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? LogoUrl { get; set; }
    public required Guid OrganizationId { get; set; }
    public required Organization Organization { get; set; }
    public List<TeamUser> TeamUsers { get; set; } = [];
}
