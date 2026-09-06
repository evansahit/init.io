namespace Init.Io.API.Models;

public class TeamUser : BaseEntity
{
    public Guid TeamId { get; set; }
    public Guid UserId { get; set; }
    public required User User { get; set; }

    public required Team Team { get; set; }

    public DateTime AssignedAt { get; set; }

    public TeamUserRoleEnum Role { get; set; }

}