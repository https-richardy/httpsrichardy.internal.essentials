namespace HttpsRichardy.Internal.Essentials.Contracts;

#pragma warning disable CA1068

// https://learn.microsoft.com/en-us/ef/core/saving/transactions
public interface IUnitOfWork
{
    public Task TransactionAsync(
        CancellationToken cancellation,
        Func<CancellationToken, Task> action
    );

    public Task<TResult> TransactionAsync<TResult>(
        CancellationToken cancellation,
        Func<CancellationToken, Task<TResult>> action
    );
}