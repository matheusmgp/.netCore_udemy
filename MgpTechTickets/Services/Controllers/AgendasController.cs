
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MgpTechTickets.Models;
using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Application.dto.DtoReponse;
using MgpTechTickets.Application.dto.DtoRequest;
using AutoMapper;
using System.Threading.Tasks;
using MgpTechTickets.Services.interfaces;

namespace MgpTechTickets.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendasController : ControllerBase
    {
        
        private readonly IAgendaService _iAgendaRepository = null;
        private readonly IAmbienteService _iAmbienteRepository = null;
        private readonly IMapper _mapper;
       

        public AgendasController(IAgendaService agendaRepository,
                                 IAmbienteService iAmbienteRepository,
                                 IMapper mapper)
        {
            _mapper = mapper;
            _iAmbienteRepository = iAmbienteRepository;
            _iAgendaRepository = agendaRepository;
            
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Agenda>>> Get()
        {
            var agendas =  await _iAgendaRepository.FindAllAsync();
           
            return Ok(_mapper.Map<IEnumerable<AgendaDtoResponse>>(agendas));
           
        }
              
        [HttpGet("{id}")]
        public async Task<ActionResult<Agenda>> GetById(int id)
        {
            var agenda = await _iAgendaRepository.FindByIdAsync(id);

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
            _iAgendaRepository.Update(id,agenda);
            if (_iAgendaRepository.SaveChanges())
            {
                return Ok(agenda);
            }

            return BadRequest("Falha no procedimento");

        }

        [HttpPost]
        public  async Task<ActionResult> Post(AgendaDtoRequest agendaDtoRequest)
        {
            var agenda = _mapper.Map<Agenda>(agendaDtoRequest);

            var ambiente = await _iAmbienteRepository.FindByIdAsync(agenda.AmbienteId);

            agenda.Ambiente = ambiente;
            

            _iAgendaRepository.Create(agenda);
            if (_iAgendaRepository.SaveChanges())
            {
                return Ok(agenda);
            }

            return BadRequest("Falha no procedimento");
        }

        
      
    }
}
