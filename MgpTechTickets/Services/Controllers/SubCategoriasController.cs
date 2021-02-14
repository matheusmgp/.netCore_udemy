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
    public class SubCategoriasController : ControllerBase
    {
        private readonly DataContext _context;

        public SubCategoriasController(DataContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubCategorias>>> GetSubCategorias()
        {
            return await _context.SubCategorias.ToListAsync();
        }

       
        [HttpGet("{id}")]
        public async Task<ActionResult<SubCategorias>> GetSubCategorias(int id)
        {
            var subCategorias = await _context.SubCategorias.FindAsync(id);

            if (subCategorias == null)
            {
                return NotFound();
            }

            return subCategorias;
        }

       
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubCategorias(int id, SubCategorias subCategorias)
        {
            if (id != subCategorias.Id)
            {
                return BadRequest();
            }

            _context.Entry(subCategorias).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubCategoriasExists(id))
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

       
        [HttpPost]
        public async Task<ActionResult<SubCategorias>> PostSubCategorias(SubCategorias subCategorias)
        {
            _context.SubCategorias.Add(subCategorias);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubCategorias", new { id = subCategorias.Id }, subCategorias);
        }

       
    }
}
