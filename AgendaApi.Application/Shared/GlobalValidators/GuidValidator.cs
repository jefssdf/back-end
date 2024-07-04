namespace AgendaApi.Application.Shared.GlobalValidators
{
    public static class GuidValidator
    {
        public static bool BeValid(Guid guid) =>
            Guid.TryParse(guid.ToString(), out _);
    }
}
