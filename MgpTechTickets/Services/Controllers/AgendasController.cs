using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MgpTechTickets.Data;
using MgpTechTickets.Models;
using MgpTechTickets.Application.service;
using MgpTechTickets.Services.interfaces;
using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Application.dto.DtoReponse;
using MgpTechTickets.Application.dto.DtoRequest;
using AutoMapper;

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
        public async Task<ActionResult<IEnumerable<Agenda>>> GetAgendas()
        {
            var agendas =  await _ibaseRepository.findAll().ConfigureAwait(true);

            return Ok(_mapper.Map<IEnumerable<AgendaDtoResponse>>(agendas));
           
        }

      
        [HttpGet("{id}")]
        public async Task<ActionResult<Agenda>> GetAgenda(int id)
        {
            var agenda = await _ibaseRepository.findById(id).ConfigureAwait(true);

            if (agenda == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<AgendaDtoResponse>(agenda));
        }

        [HttpPut("{id}")]
        public void PutAgenda(int id, AgendaDtoRequest agendaDtoRequest)
        {
            var agenda = _mapper.Map<Agenda>(agendaDtoRequest);
            if (id == agenda.Id)
            {
                _ibaseRepository.update(id,agenda);
            }
           
        }

        [HttpPost]
        public void PostAgenda(AgendaDtoRequest agendaDtoRequest)
        {
            var agenda = _mapper.Map<Agenda>(agendaDtoRequest);
            
             _ibaseRepository.create(agenda);
            
        }

        
      
    }
}
