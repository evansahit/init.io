namespace Init.Io.API.Models;

public class Organization : BaseEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? LogoUrl { get; set; }
    public List<User> Users { get; set; } = [];
    public List<Team> Teams { get; set; } = [];
}