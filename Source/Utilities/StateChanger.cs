namespace HttpsRichardy.Internal.Essentials.Utilities;

public static class StateChanger
{
    public static void WithChanges<TTarget>(TTarget target, Action<TTarget> action) where TTarget : class, new() =>
        action(target);
}
