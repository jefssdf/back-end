namespace AgendaApi.Application.Shared.GlobalValidators
{
    public sealed class TimeSpanValidator
    {
        public static bool BeMultipleOf30Minutes(TimeSpan timespan) =>
            timespan.TotalMinutes % 30 == 0;
    }
}
