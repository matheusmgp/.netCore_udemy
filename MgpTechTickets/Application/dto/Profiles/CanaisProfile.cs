using AutoMapper;
using MgpTechTickets.Application.dto.DtoReponse;
using MgpTechTickets.Application.dto.DtoRequest;
using MgpTechTickets.Models;

namespace MgpTechTickets.Application.dto.Profiles
{
    public class CanaisProfile : Profile
    {
        public CanaisProfile()
        {
            CreateMap<CanaisComunicacao, CanaisComunicacaoDtoRequest>();
            CreateMap<CanaisComunicacaoDtoRequest, CanaisComunicacao>();
            CreateMap<CanaisComunicacao, CanaisComunicacaoDtoResponse>();
        }
    }
}
