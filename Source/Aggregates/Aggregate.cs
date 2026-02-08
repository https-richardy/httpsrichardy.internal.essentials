namespace HttpsRichardy.Internal.Essentials.Aggregates;

public abstract class Aggregate
{
    public string Id { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public bool IsDeleted { get; set; }

    #pragma warning disable S2325

    // sonar suggests making these methods static based on a simplistic heuristic,
    // but these methods intentionally mutate the state of the aggregate and express domain behavior.

    // https://rules.sonarsource.com/csharp/RSPEC-2325/

    public void MarkAsDeleted() => IsDeleted = true;
    public void MarkAsUpdated() => UpdatedAt = DateTime.UtcNow;
}
    #pragma warning restore S2325