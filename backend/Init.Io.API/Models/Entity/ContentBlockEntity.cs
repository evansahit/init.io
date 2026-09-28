using Init.Io.API.Models.Enums;

namespace Init.Io.API.Models.Entity;

public class ContentBlockEntity : BaseEntity
{
    public long SectionId { get; private set; }
    public int OrdinalPosition { get; private set; }
    public ContentBlockMediaTypeEnum Type { get; private set; }
    public string DataJson { get; private set; } = "{}";

}