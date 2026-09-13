namespace Init.Io.API.Models.Entity;

public class SectionEntity : BaseEntity
{
    public long OnboardingFlowId { get; private set; }
    public string Title { get; private set; } = null!;
    public int OrdinalPosition { get; private set; }
    public ICollection<ContentBlockEntity> ContentBlocks = [];
}