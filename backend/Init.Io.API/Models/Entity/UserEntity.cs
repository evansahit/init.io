namespace Init.Io.API.Models.Entity;

public class UserEntity : BaseEntity
{
    public string Email { get; private set; } = null!;
    public string FirstName { get; private set; } = null!;
    public string LastName { get; private set; } = null!;
    public string ProfilePhotoUrl { get; private set; } = null!;
    public long OrganizationId { get; private set; }
    public long DepartmentId { get; private set; }
    public OrganizationEntity Organization { get; private set; } = null!;
    public DepartmentEntity Department { get; private set; } = null!;
    public ICollection<TeamUserEntity> TeamUsers { get; private set; } = [];
}
