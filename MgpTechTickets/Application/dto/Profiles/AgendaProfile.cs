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
            CreateMap<Agenda, AgendaDtoResponse>();
        }
    }
}
