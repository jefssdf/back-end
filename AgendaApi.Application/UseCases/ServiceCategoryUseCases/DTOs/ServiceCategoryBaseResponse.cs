using AgendaApi.Domain.Entities;

namespace AgendaApi.Application.UseCases.ServiceCategoryUseCase.DTOs
{
    public abstract record ServiceCategoryBaseResponse
    {
        Guid Id { get; set; }
        string? Name { get; set; }
        ICollection<Service>? Services { get; set; }
    }
}
