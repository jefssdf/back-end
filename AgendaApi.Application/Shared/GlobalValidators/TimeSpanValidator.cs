namespace AgendaApi.Application.Shared.GlobalValidators
{
    public sealed class TimeSpanValidator
    {
        public static bool BeMultipleOf30Minutes(string timespan)
        {
            if (TimeSpan.TryParse(timespan, out TimeSpan parsedTimeSpan))
            {
                return parsedTimeSpan.TotalMinutes % 30 == 0;
            }
            return false;
        }
    }
}

