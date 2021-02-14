using AutoMapper;
using MgpTechTickets.Application.dto.DtoReponse;
using MgpTechTickets.Application.dto.DtoRequest;
using MgpTechTickets.Models;

namespace MgpTechTickets.Application.dto.Profiles
{
    public class CategoriaProfile : Profile
    {
        public CategoriaProfile()
        {
            CreateMap<Categoria, CategoriaDtoRequest>();
            CreateMap<CategoriaDtoRequest, Categoria>();
            CreateMap<Categoria, CategoriaDtoResponse>();
        }
    }
}
