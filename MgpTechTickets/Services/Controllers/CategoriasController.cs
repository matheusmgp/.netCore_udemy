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
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;
        private readonly IAmbienteService _iAmbienteRepository;
        private readonly IMapper _mapper;
        public CategoriasController(ICategoriaService categoriaService,
                                    IMapper mapper,
                                    IAmbienteService iAmbienteRepository)
        {
            _categoriaService = categoriaService;
            _mapper = mapper;
            _iAmbienteRepository = iAmbienteRepository;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaDtoResponse>>> GetCategorias()
        {
            var categorias = await _categoriaService.FindAllAsync();

            return Ok(_mapper.Map<IEnumerable<CategoriaDtoResponse>>(categorias));
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriaDtoResponse>> GetCategoria(int id)
        {
            var categoria = await _categoriaService.FindByIdAsync(id);

            if (categoria == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CategoriaDtoResponse>(categoria));
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategoria(int id, CategoriaDtoRequest categoriaDtoRequest)
        {
            var categoria = _mapper.Map<Categoria>(categoriaDtoRequest);
            _categoriaService.Update(id, categoria);
            if (_categoriaService.SaveChanges())
            {
                return Ok(categoria);
            }

            return BadRequest("Falha no procedimento");
        }

       
        [HttpPost]
        public async Task<ActionResult<Categoria>> PostCategoria(CategoriaDtoRequest categoriaDtoRequest)
        {
            var categoria = _mapper.Map<Categoria>(categoriaDtoRequest);

            var ambiente = await _iAmbienteRepository.FindByIdAsync(categoria.AmbienteId);

            categoria.Ambiente = ambiente;
            _categoriaService.Create(categoria);
            if (_categoriaService.SaveChanges())
            {
                return Ok(categoria);
            }

            return BadRequest("Falha no procedimento");
        }

        
       
    }
}
