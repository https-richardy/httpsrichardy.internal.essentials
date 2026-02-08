namespace HttpsRichardy.Internal.Essentials.Filtering;

public sealed class ActivityFilters : Filters
{
    public string? Action { get; set; }
    public string? UserId { get; set; }
    public string? TenantId { get; set; }
    public string? ResourceId { get; set; }

    public static ActivityFiltersBuilder WithSpecifications() => new();
}