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
    public class SetoresController : ControllerBase
    {
        private readonly DataContext _context;

        public SetoresController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Setores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Setores>>> GetSetores()
        {
            return await _context.Setores.ToListAsync();
        }

        // GET: api/Setores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Setores>> GetSetores(int id)
        {
            var setores = await _context.Setores.FindAsync(id);

            if (setores == null)
            {
                return NotFound();
            }

            return setores;
        }

        // PUT: api/Setores/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSetores(int id, Setores setores)
        {
            if (id != setores.Id)
            {
                return BadRequest();
            }

            _context.Entry(setores).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SetoresExists(id))
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

        // POST: api/Setores
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Setores>> PostSetores(Setores setores)
        {
            _context.Setores.Add(setores);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSetores", new { id = setores.Id }, setores);
        }

        // DELETE: api/Setores/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Setores>> DeleteSetores(int id)
        {
            var setores = await _context.Setores.FindAsync(id);
            if (setores == null)
            {
                return NotFound();
            }

            _context.Setores.Remove(setores);
            await _context.SaveChangesAsync();

            return setores;
        }

        private bool SetoresExists(int id)
        {
            return _context.Setores.Any(e => e.Id == id);
        }
    }
}
