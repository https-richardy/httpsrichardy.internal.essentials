namespace HttpsRichardy.Internal.Essentials.Contracts;

public interface IAggregateCollection<TAggregate> where TAggregate : Aggregate
{
    public Task<TAggregate> InsertAsync(
        TAggregate aggregate,
        InsertionBehavior behavior = InsertionBehavior.FailIfExists,
        CancellationToken cancellation = default
    );

    public Task InsertManyAsync(
        IEnumerable<TAggregate> aggregates,
        InsertionBehavior behavior = InsertionBehavior.FailIfExists,
        CancellationToken cancellation = default
    );

    public Task<TAggregate> UpdateAsync(
        TAggregate aggregate,
        CancellationToken cancellation = default
    );

    public Task<bool> DeleteAsync(
        TAggregate aggregate,
        DeletionBehavior behavior = DeletionBehavior.Soft,
        CancellationToken cancellation = default
    );
}