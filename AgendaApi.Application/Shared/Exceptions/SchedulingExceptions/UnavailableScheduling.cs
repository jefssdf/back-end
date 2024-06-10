namespace AgendaApi.Application.Shared.Exceptions.SchedulingExceptions
{
    public class UnavailableScheduling : Exception
    {
        public UnavailableScheduling(string message) : base(message) { }
    }
}
