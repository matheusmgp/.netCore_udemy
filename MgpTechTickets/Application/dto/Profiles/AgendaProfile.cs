using AutoMapper;
using MgpTechTickets.Application.dto.DtoReponse;
using MgpTechTickets.Application.dto.DtoRequest;
using MgpTechTickets.Models;

namespace MgpTechTickets.Application.dto.Profiles
{
    public class AgendaProfile : Profile
    {
        public AgendaProfile()
        {
            CreateMap<Agenda, AgendaDtoRequest>();
            CreateMap<AgendaDtoRequest, Agenda>();
            CreateMap<Agenda, AgendaDtoResponse>();
        }

    }
}
