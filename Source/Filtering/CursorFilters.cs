namespace HttpsRichardy.Internal.Essentials.Filtering;

public sealed record CursorFilters
{
    public string? Cursor { get; set; }
    public int Limit { get; set; } = 20;

    public static CursorFilters From(string? cursor = null, int? limit = null)
    {
        return new CursorFilters
        {
            Cursor = cursor,
            Limit = limit ?? 20
        };
    }
}