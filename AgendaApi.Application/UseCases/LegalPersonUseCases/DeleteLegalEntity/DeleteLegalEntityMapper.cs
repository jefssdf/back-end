using AgendaApi.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.DeleteLegalEntity
{
    public sealed class DeleteLegalEntityMapper : Profile
    {
        public DeleteLegalEntityMapper() 
        {
            CreateMap<DeleteLegalEntityRequest, LegalEntity>();
            CreateMap<LegalEntity, DeleteLegalEntityResponse>();
        }
    }
}
