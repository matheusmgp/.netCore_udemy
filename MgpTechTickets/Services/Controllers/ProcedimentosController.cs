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
    public class ProcedimentosController : ControllerBase
    {
        private readonly DataContext _context;

        public ProcedimentosController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Procedimentos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Procedimentos>>> GetProcedimentos()
        {
            return await _context.Procedimentos.ToListAsync();
        }

        // GET: api/Procedimentos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Procedimentos>> GetProcedimentos(int id)
        {
            var procedimentos = await _context.Procedimentos.FindAsync(id);

            if (procedimentos == null)
            {
                return NotFound();
            }

            return procedimentos;
        }

        // PUT: api/Procedimentos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProcedimentos(int id, Procedimentos procedimentos)
        {
            if (id != procedimentos.Id)
            {
                return BadRequest();
            }

            _context.Entry(procedimentos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProcedimentosExists(id))
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

        // POST: api/Procedimentos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Procedimentos>> PostProcedimentos(Procedimentos procedimentos)
        {
            _context.Procedimentos.Add(procedimentos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProcedimentos", new { id = procedimentos.Id }, procedimentos);
        }

        // DELETE: api/Procedimentos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Procedimentos>> DeleteProcedimentos(int id)
        {
            var procedimentos = await _context.Procedimentos.FindAsync(id);
            if (procedimentos == null)
            {
                return NotFound();
            }

            _context.Procedimentos.Remove(procedimentos);
            await _context.SaveChangesAsync();

            return procedimentos;
        }

        private bool ProcedimentosExists(int id)
        {
            return _context.Procedimentos.Any(e => e.Id == id);
        }
    }
}
