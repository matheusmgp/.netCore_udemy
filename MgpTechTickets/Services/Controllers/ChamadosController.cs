﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MgpTechTickets.Data;
using MgpTechTickets.Models;

namespace MgpTechTickets.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChamadosController : ControllerBase
    {
        private readonly DataContext _context;

        public ChamadosController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Chamados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Chamado>>> GetChamados()
        {
            return await _context.Chamados.ToListAsync();
        }

        // GET: api/Chamados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Chamado>> GetChamado(int id)
        {
            var chamado = await _context.Chamados.FindAsync(id);

            if (chamado == null)
            {
                return NotFound();
            }

            return chamado;
        }

        // PUT: api/Chamados/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChamado(int id, Chamado chamado)
        {
            if (id != chamado.Id)
            {
                return BadRequest();
            }

            _context.Entry(chamado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChamadoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Chamados
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Chamado>> PostChamado(Chamado chamado)
        {
            _context.Chamados.Add(chamado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChamado", new { id = chamado.Id }, chamado);
        }

        // DELETE: api/Chamados/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Chamado>> DeleteChamado(int id)
        {
            var chamado = await _context.Chamados.FindAsync(id);
            if (chamado == null)
            {
                return NotFound();
            }

            _context.Chamados.Remove(chamado);
            await _context.SaveChangesAsync();

            return chamado;
        }

        private bool ChamadoExists(int id)
        {
            return _context.Chamados.Any(e => e.Id == id);
        }
    }
}
