namespace HttpsRichardy.Internal.Essentials.Concepts;

public sealed record User(string Identifier, string Username) : IValueObject<User>
{
    public string Identifier { get; init; } = Identifier;
    public string Username { get; init; } = Username;
}