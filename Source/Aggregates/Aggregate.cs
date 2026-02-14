namespace HttpsRichardy.Internal.Essentials.Aggregates;

public abstract class Aggregate
{
    public string Id { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public bool IsDeleted { get; set; }

    public void MarkAsDeleted() => IsDeleted = true;
    public void MarkAsUpdated() => UpdatedAt = DateTime.UtcNow;
}
