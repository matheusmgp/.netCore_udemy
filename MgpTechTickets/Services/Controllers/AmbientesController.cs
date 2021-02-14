
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

namespace MgpTechTickets.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmbientesController : ControllerBase
    {
        private readonly IBaseRepository<Ambiente> _ibaseRepository;
        private readonly IMapper _mapper;

        public AmbientesController(IBaseRepository<Ambiente> ibaseRepository, IMapper mapper)
        {
            _mapper = mapper;
            _ibaseRepository = ibaseRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ambiente>>> Get()
        {
            var ambientes = await _ibaseRepository.FindAllAsync();

            return Ok(_mapper.Map<IEnumerable<AmbienteDtoResponse>>(ambientes));

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ambiente>> GetById(int id)
        {
            var ambiente = await _ibaseRepository.FindByIdAsync(id);

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
            _ibaseRepository.Update(id, ambiente);
            if (_ibaseRepository.SaveChanges())
            {
                return Ok(ambiente);
            }

            return BadRequest("Falha no procedimento");

        }

        [HttpPost]
        public ActionResult Post(AmbienteDtoRequest ambienteDtoRequest)
        {
            var ambiente = _mapper.Map<Ambiente>(ambienteDtoRequest);

            _ibaseRepository.Create(ambiente);
            if (_ibaseRepository.SaveChanges())
            {
                return Ok(ambiente);
            }

            return BadRequest("Falha no procedimento");
        }



    }
}

