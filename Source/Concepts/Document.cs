namespace HttpsRichardy.Internal.Essentials.Concepts;

public sealed record Document(string Identifier) : IValueObject<Document>
{
    public string Identifier { get; init; } = Identifier.Trim();
}
