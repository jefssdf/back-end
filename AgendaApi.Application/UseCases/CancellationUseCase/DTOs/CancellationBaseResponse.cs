using AgendaApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApi.Application.UseCases.CancellationUseCase.DTOs
{
    public abstract record CancellationBaseResponse
    {
        public Guid CancellationId { get; set; }
        public DateTime? CancellationTime { get; set; }
        public Guid Owner { get; set; }
        public Guid? SchedulingId { get; set; }
    }
}
