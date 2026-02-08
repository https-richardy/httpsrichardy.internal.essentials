namespace HttpsRichardy.Internal.Essentials.Patterns;

public sealed class FailFastPipeline<TContext>
{
    private readonly TContext? _context;
    private Error? _error;

    private FailFastPipeline(TContext? context)
    {
        _context = context;
    }

    public static FailFastPipeline<TContext> For(TContext? context)
        => new(context);

    public Error? FailureOrNull() => _error;
    public FailFastPipeline<TContext> FailWhen(Func<TContext, bool> predicate, Error error)
    {
        if (_error is not null)
            return this;

        if (_context is not null && predicate(_context))
            _error = error;

        return this;
    }
}
