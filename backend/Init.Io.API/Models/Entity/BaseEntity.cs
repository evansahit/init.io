namespace Init.Io.API.Models.Entity;

public abstract class BaseEntity()
{
    public long Id { get; private set; }
    public DateTime? CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }
    public long? CreatedById { get; private set; }
    public UserEntity? CreatedBy { get; private set; }
    public long? UpdatedById { get; private set; }
    public UserEntity? UpdatedBy { get; private set; }
}