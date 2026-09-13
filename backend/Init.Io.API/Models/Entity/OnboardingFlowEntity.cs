using Init.Io.API.Models.Domain;

namespace Init.Io.API.Models.Entity;

public class OnboardingFlowEntity : BaseEntity
{
    public string Title { get; private set; } = null!;
    public string Description { get; private set; } = null!;
    public ICollection<SectionEntity> Sections { get; private set; } = [];

}