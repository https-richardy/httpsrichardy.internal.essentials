namespace HttpsRichardy.Internal.Essentials.Filtering;

public sealed record SortFilters
{
    public string Field { get; set; } = nameof(Aggregate.CreatedAt);
    public SortDirection Direction { get; set; } = SortDirection.Descending;

    public static SortFilters From(string? field = null, SortDirection? direction = null) => new()
    {
        Field = field ?? nameof(Aggregate.CreatedAt),
        Direction = direction ?? SortDirection.Descending
    };
}
