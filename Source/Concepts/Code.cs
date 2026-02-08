namespace HttpsRichardy.Internal.Essentials.Concepts;

public sealed record Code(string Identifier, DateTime Expires) : IValueObject<Code>
{
    public bool HasExpired => DateTime.UtcNow > Expires;
    public Code(string identifier, TimeSpan validity) : this(identifier, DateTime.UtcNow.Add(validity)) {   }
}