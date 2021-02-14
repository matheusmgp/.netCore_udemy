using AutoMapper;
using MgpTechTickets.Application.dto.DtoReponse;
using MgpTechTickets.Application.dto.DtoRequest;
using MgpTechTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Application.dto.Profiles
{
    public class AmbienteProfile : Profile
    {
        public AmbienteProfile()
        {
            CreateMap<Ambiente, AmbienteDtoRequest>();
            CreateMap<AmbienteDtoRequest, Ambiente>();
            CreateMap<Ambiente, AmbienteDtoResponse>();
        }
    }
}
