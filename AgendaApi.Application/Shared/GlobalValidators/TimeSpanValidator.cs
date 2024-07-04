using System.Globalization;

namespace AgendaApi.Application.Shared.GlobalValidators
{
    public static class TimeSpanValidator
    {
        public static bool BeMultipleOf30Minutes(string timespan) =>
            TimeSpan.ParseExact(timespan.ToString(), "HH:mm:ss", CultureInfo.InvariantCulture).TotalMinutes % 30 == 0;
    }
}
