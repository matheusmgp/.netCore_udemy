
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MgpTechTickets.Models;
using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Application.dto.DtoReponse;
using MgpTechTickets.Application.dto.DtoRequest;
using AutoMapper;
using System.Threading.Tasks;

namespace MgpTechTickets.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendasController : ControllerBase
    {
        
        private readonly IBaseRepository<Agenda> _ibaseRepository;
        private readonly IMapper _mapper;
       

        public AgendasController(IBaseRepository<Agenda> ibaseRepository, IMapper mapper)
        {
            _mapper = mapper;
            _ibaseRepository = ibaseRepository;           
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Agenda>>> Get()
        {
            var agendas =  await _ibaseRepository.FindAllAsync();
           
            return Ok(_mapper.Map<IEnumerable<AgendaDtoResponse>>(agendas));
           
        }
              
        [HttpGet("{id}")]
        public async Task<ActionResult<Agenda>> GetById(int id)
        {
            var agenda = await _ibaseRepository.FindByIdAsync(id);

            if (agenda == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<AgendaDtoResponse>(agenda));
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, AgendaDtoRequest agendaDtoRequest)
        {
            var agenda = _mapper.Map<Agenda>(agendaDtoRequest);
            _ibaseRepository.Update(id,agenda);
            if (_ibaseRepository.SaveChanges())
            {
                return Ok(agenda);
            }

            return BadRequest("Falha no procedimento");

        }

        [HttpPost]
        public  ActionResult Post(AgendaDtoRequest agendaDtoRequest)
        {
            var agenda = _mapper.Map<Agenda>(agendaDtoRequest);

            _ibaseRepository.Create(agenda);
            if (_ibaseRepository.SaveChanges())
            {
                return Ok(agenda);
            }

            return BadRequest("Falha no procedimento");
        }

        
      
    }
}
