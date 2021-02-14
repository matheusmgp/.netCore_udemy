
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
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AgendasController : ControllerBase
    {
        
        private readonly IAgendaService _iAgendaService = null;
        private readonly IAmbienteService _iAmbienteService = null;
        private readonly IMapper _mapper;
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agendaService"></param>
        /// <param name="iAmbienteService"></param>
        /// <param name="mapper"></param>
        public AgendasController(IAgendaService agendaService,
                                 IAmbienteService iAmbienteService,
                                 IMapper mapper)
        {
            _mapper = mapper;
            _iAmbienteService = iAmbienteService;
            _iAgendaService = agendaService;
            
        }

        /// <summary>
        /// Endpoint responsável por retornar todas as agendas do banco de dados.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Agenda>>> Get()
        {
            var agendas =  await _iAgendaService.FindAllAsync();
           
            return Ok(_mapper.Map<IEnumerable<AgendaDtoResponse>>(agendas));
           
        }
        /// <summary>
        /// Endpoint responsável por retornar um agenda com um ID especifico.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>           
        [HttpGet("{id}")]
        public async Task<ActionResult<Agenda>> GetById(int id)
        {
            var agenda = await _iAgendaService.FindByIdAsync(id);

            if (agenda == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<AgendaDtoResponse>(agenda));
        }
        /// <summary>
        /// Endpoint responsável por atualizar uma agenda no banco.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="agendaDtoRequest"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public ActionResult Put(int id, AgendaDtoRequest agendaDtoRequest)
        {
            var agenda = _mapper.Map<Agenda>(agendaDtoRequest);
            _iAgendaService.Update(id,agenda);
            if (_iAgendaService.SaveChanges())
            {
                return Ok(agenda);
            }

            return BadRequest("Falha no procedimento");

        }
        /// <summary>
        /// Endpoint responsável por crair uma agenda no banco.
        /// </summary>
        /// <param name="agendaDtoRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public  async Task<ActionResult> Post(AgendaDtoRequest agendaDtoRequest)
        {
            var agenda = _mapper.Map<Agenda>(agendaDtoRequest);

            var ambiente = await _iAmbienteService.FindByIdAsync(agenda.AmbienteId);

            agenda.Ambiente = ambiente;
            
            _iAgendaService.Create(agenda);
            if (_iAgendaService.SaveChanges())
            {
                return Ok(agenda);
            }

            return BadRequest("Falha no procedimento");
        }

        
      
    }
}
