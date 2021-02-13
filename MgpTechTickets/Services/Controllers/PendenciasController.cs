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
    public class PendenciasController : ControllerBase
    {
        private readonly DataContext _context;

        public PendenciasController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Pendencias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pendencia>>> GetPendencias()
        {
            return await _context.Pendencias.ToListAsync();
        }

        // GET: api/Pendencias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pendencia>> GetPendencia(int id)
        {
            var pendencia = await _context.Pendencias.FindAsync(id);

            if (pendencia == null)
            {
                return NotFound();
            }

            return pendencia;
        }

        // PUT: api/Pendencias/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPendencia(int id, Pendencia pendencia)
        {
            if (id != pendencia.Id)
            {
                return BadRequest();
            }

            _context.Entry(pendencia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PendenciaExists(id))
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

        // POST: api/Pendencias
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Pendencia>> PostPendencia(Pendencia pendencia)
        {
            _context.Pendencias.Add(pendencia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPendencia", new { id = pendencia.Id }, pendencia);
        }

        // DELETE: api/Pendencias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pendencia>> DeletePendencia(int id)
        {
            var pendencia = await _context.Pendencias.FindAsync(id);
            if (pendencia == null)
            {
                return NotFound();
            }

            _context.Pendencias.Remove(pendencia);
            await _context.SaveChangesAsync();

            return pendencia;
        }

        private bool PendenciaExists(int id)
        {
            return _context.Pendencias.Any(e => e.Id == id);
        }
    }
}
