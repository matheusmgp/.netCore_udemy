using System;
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
    public class CanaisController : ControllerBase
    {
        private readonly DataContext _context;

        public CanaisController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Canais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CanaisComunicacao>>> GetCanais()
        {
            return await _context.Canais.ToListAsync();
        }

        // GET: api/Canais/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CanaisComunicacao>> GetCanaisComunicacao(int id)
        {
            var canaisComunicacao = await _context.Canais.FindAsync(id);

            if (canaisComunicacao == null)
            {
                return NotFound();
            }

            return canaisComunicacao;
        }

        // PUT: api/Canais/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCanaisComunicacao(int id, CanaisComunicacao canaisComunicacao)
        {
            if (id != canaisComunicacao.Id)
            {
                return BadRequest();
            }

            _context.Entry(canaisComunicacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CanaisComunicacaoExists(id))
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

        // POST: api/Canais
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CanaisComunicacao>> PostCanaisComunicacao(CanaisComunicacao canaisComunicacao)
        {
            _context.Canais.Add(canaisComunicacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCanaisComunicacao", new { id = canaisComunicacao.Id }, canaisComunicacao);
        }

        // DELETE: api/Canais/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CanaisComunicacao>> DeleteCanaisComunicacao(int id)
        {
            var canaisComunicacao = await _context.Canais.FindAsync(id);
            if (canaisComunicacao == null)
            {
                return NotFound();
            }

            _context.Canais.Remove(canaisComunicacao);
            await _context.SaveChangesAsync();

            return canaisComunicacao;
        }

        private bool CanaisComunicacaoExists(int id)
        {
            return _context.Canais.Any(e => e.Id == id);
        }
    }
}
