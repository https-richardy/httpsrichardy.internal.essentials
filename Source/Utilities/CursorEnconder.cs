namespace HttpsRichardy.Internal.Essentials.Utilities;

public static class CursorEncoder
{
    public static string Encode<TAggregate>(TAggregate aggregate)
        where TAggregate : Aggregate
    {
        return Convert.ToBase64String(Encoding.UTF8.GetBytes(aggregate.CreatedAt.ToString("O")));
    }

    public static DateTime Decode(string cursor)
    {
        var raw = Encoding.UTF8.GetString(Convert.FromBase64String(cursor));

        return DateTime.Parse(
            s: raw,
            provider: CultureInfo.InvariantCulture,
            styles: DateTimeStyles.RoundtripKind
        );
    }
}