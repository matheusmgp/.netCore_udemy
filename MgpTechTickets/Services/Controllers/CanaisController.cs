using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MgpTechTickets.Data;
using MgpTechTickets.Models;
using MgpTechTickets.Services.interfaces;
using AutoMapper;
using MgpTechTickets.Application.dto.DtoReponse;
using MgpTechTickets.Application.dto.DtoRequest;

namespace MgpTechTickets.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CanaisController : ControllerBase
    {
        private readonly ICanaisService _icanaisService;
        private readonly IAmbienteService _iAmbienteRepository;
        private readonly IMapper _mapper;
        public CanaisController(ICanaisService icanaisServicet,
                                IAmbienteService iAmbienteRepository,
                                IMapper mapper)
        {
            _icanaisService = icanaisServicet;
            _iAmbienteRepository = iAmbienteRepository;
            _mapper = mapper;
        }
               
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CanaisComunicacao>>> Get()
        {
            var canais = await _icanaisService.FindAllAsync();

            return Ok(_mapper.Map<IEnumerable<CanaisComunicacaoDtoResponse>>(canais));
        }

      
        [HttpGet("{id}")]
        public async Task<ActionResult<CanaisComunicacao>> GetCanaisComunicacao(int id)
        {
            var canal = await _icanaisService.FindByIdAsync(id);

            if (canal == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CanaisComunicacaoDtoResponse>(canal));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CanaisComunicacaoDtoRequest canaisComunicacaoDtoRequest)
        {
            var canal = _mapper.Map<CanaisComunicacao>(canaisComunicacaoDtoRequest);
            _icanaisService.Update(id, canal);
            if (_icanaisService.SaveChanges())
            {
                return Ok(canal);
            }

            return BadRequest("Falha no procedimento");
        }

     
        [HttpPost]
        public async Task<ActionResult<CanaisComunicacao>> Post(CanaisComunicacaoDtoRequest canaisComunicacaoDtoRequest)
        {
            var canal = _mapper.Map<CanaisComunicacao>(canaisComunicacaoDtoRequest);

            var ambiente = await _iAmbienteRepository.FindByIdAsync(canal.AmbienteId);

            canal.Ambiente = ambiente;
            _icanaisService.Create(canal);
            if (_icanaisService.SaveChanges())
            {
                return Ok(canal);
            }

            return BadRequest("Falha no procedimento");
        }

       
    }
}
