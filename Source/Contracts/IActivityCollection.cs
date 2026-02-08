namespace HttpsRichardy.Internal.Essentials.Contracts;

public interface IActivityCollection : IAggregateCollection<Activity>
{
    public Task<IReadOnlyCollection<Activity>> GetActivitiesAsync(
        ActivityFilters filters,
        CancellationToken cancellation = default
    );

    public Task<long> CountAsync(
        ActivityFilters filters,
        CancellationToken cancellation = default
    );
}