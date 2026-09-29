namespace Init.Io.API.Models.Entity;

public class OnboardingFlowEntity : BaseEntity
{
    public string Title { get; private set; } = null!;
    public string Description { get; private set; } = null!;
    public long TeamId { get; private set; }
    public TeamEntity Team { get; private set; } = null!;
    public ICollection<SectionEntity> Sections { get; private set; } = [];
}