namespace AgendaApi.Application.Shared.GlobalValidators
{
    public sealed class TimeSpanValidator
    {
        public static bool BeMultipleOf30Minutes(string timespan) =>
            TimeSpan.Parse(timespan).TotalMinutes % 30 == 0;
    }
}
