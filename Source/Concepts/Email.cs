namespace HttpsRichardy.Internal.Essentials.Concepts;

public sealed record Email(string Address) : IValueObject<Email>
{
    public string Address { get; init; } = Address.Trim().ToLowerInvariant();
}
