using Init.Io.API.Models.Enums;

namespace Init.Io.API.Models.Entity;

public class TeamUserEntity : BaseEntity
{
    public long TeamId { get; private set; }
    public long UserId { get; private set; }
    public UserEntity User { get; private set; } = null!;

    public TeamEntity Team { get; private set; } = null!;

    public DateTime AssignedAt { get; private set; }

    public TeamUserRoleEnum Role { get; private set; }

}