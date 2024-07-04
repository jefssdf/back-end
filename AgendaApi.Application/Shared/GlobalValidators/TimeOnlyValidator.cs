using System.Globalization;

namespace AgendaApi.Application.Shared.GlobalValidators
{
    public static class TimeOnlyValidator
    {
        public static bool Format(TimeOnly time) =>
            TimeOnly.TryParseExact(time.ToString(CultureInfo.InvariantCulture), "HH:mm", out _);
    }
}
