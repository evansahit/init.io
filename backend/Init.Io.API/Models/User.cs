namespace Init.Io.API.Models;

public class User : BaseEntity
{
    public string? Email { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? ProfilePhotoUrl { get; set; }
    public Guid OrganizationId { get; set; }
    public required Organization Organization { get; set; }
    public List<TeamUser> TeamUsers { get; set; } = [];
}
