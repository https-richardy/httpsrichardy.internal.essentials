namespace HttpsRichardy.Internal.Essentials.Concepts;

public sealed record AggregateReference(string Identifier) :
    IValueObject<AggregateReference>;