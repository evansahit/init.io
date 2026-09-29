namespace Init.Io.API.Models.Entity;

public class OrganizationEntity : BaseEntity
{
    public string Name { get; private set; } = null!;
    public string Description { get; private set; } = null!;
    public string LogoUrl { get; private set; } = null!;
    public ICollection<UserEntity> Users { get; private set; } = [];
    public ICollection<TeamEntity> Teams { get; private set; } = [];
    public ICollection<DepartmentEntity> Departments { get; private set; } = [];
}