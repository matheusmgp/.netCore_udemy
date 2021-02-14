
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MgpTechTickets.Data;
using MgpTechTickets.Models;
using AutoMapper;
using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Application.dto.DtoReponse;
using MgpTechTickets.Application.dto.DtoRequest;
using MgpTechTickets.Services.interfaces;

namespace MgpTechTickets.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmbientesController : ControllerBase
    {
        private readonly IAmbienteService _iAmbienteService;
        private readonly IMapper _mapper;

        public AmbientesController(IAmbienteService iAmbienteService, IMapper mapper)
        {
            _mapper = mapper;
            _iAmbienteService = iAmbienteService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ambiente>>> Get()
        {
            var ambientes = await _iAmbienteService.FindAllAsync();

            return Ok(_mapper.Map<IEnumerable<AmbienteDtoResponse>>(ambientes));

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ambiente>> GetById(int id)
        {
            var ambiente = await _iAmbienteService.FindByIdAsync(id);

            if (ambiente == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<AmbienteDtoResponse>(ambiente));
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, AmbienteDtoRequest ambienteDtoRequest)
        {
            var ambiente = _mapper.Map<Ambiente>(ambienteDtoRequest);
            _iAmbienteService.Update(id, ambiente);
            if (_iAmbienteService.SaveChanges())
            {
                return Ok(ambiente);
            }

            return BadRequest("Falha no procedimento");

        }

        [HttpPost]
        public ActionResult Post(AmbienteDtoRequest ambienteDtoRequest)
        {
            var ambiente = _mapper.Map<Ambiente>(ambienteDtoRequest);

            _iAmbienteService.Create(ambiente);
            if (_iAmbienteService.SaveChanges())
            {
                return Ok(ambiente);
            }

            return BadRequest("Falha no procedimento");
        }



    }
}

