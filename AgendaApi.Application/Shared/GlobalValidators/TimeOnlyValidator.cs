namespace AgendaApi.Application.Shared.GlobalValidators
{
    public sealed class TimeOnlyValidator
    {
        public static bool Format(TimeOnly time) =>
            TimeOnly.TryParseExact(time.ToString(), "HH:mm", out _);
    }
}
