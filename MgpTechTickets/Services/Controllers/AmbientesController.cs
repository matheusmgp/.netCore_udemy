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
    public class AmbientesController : ControllerBase
    {
        private readonly DataContext _context;

        public AmbientesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Ambientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ambiente>>> GetAmbientes()
        {
            return await _context.Ambientes.ToListAsync();
        }

        // GET: api/Ambientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ambiente>> GetAmbiente(int id)
        {
            var ambiente = await _context.Ambientes.FindAsync(id);

            if (ambiente == null)
            {
                return NotFound();
            }

            return ambiente;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAmbiente(int id, Ambiente ambiente)
        {
            if (id != ambiente.Id)
            {
                return BadRequest();
            }

            _context.Entry(ambiente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmbienteExists(id))
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

        // POST: api/Ambientes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ambiente>> PostAmbiente(Ambiente ambiente)
        {
            _context.Ambientes.Add(ambiente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAmbiente", new { id = ambiente.Id }, ambiente);
        }

        // DELETE: api/Ambientes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ambiente>> DeleteAmbiente(int id)
        {
            var ambiente = await _context.Ambientes.FindAsync(id);
            if (ambiente == null)
            {
                return NotFound();
            }

            _context.Ambientes.Remove(ambiente);
            await _context.SaveChangesAsync();

            return ambiente;
        }

        private bool AmbienteExists(int id)
        {
            return _context.Ambientes.Any(e => e.Id == id);
        }
    }
}
