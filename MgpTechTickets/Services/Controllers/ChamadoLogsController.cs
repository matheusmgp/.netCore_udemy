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
    public class ChamadoLogsController : ControllerBase
    {
        private readonly DataContext _context;

        public ChamadoLogsController(DataContext context)
        {
            _context = context;
        }

       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChamadoLog>>> GetChamadoLogs()
        {
            return await _context.ChamadoLogs.ToListAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<ChamadoLog>> GetChamadoLog(int id)
        {
            var chamadoLog = await _context.ChamadoLogs.FindAsync(id);

            if (chamadoLog == null)
            {
                return NotFound();
            }

            return chamadoLog;
        }

     
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChamadoLog(int id, ChamadoLog chamadoLog)
        {
            if (id != chamadoLog.Id)
            {
                return BadRequest();
            }

            _context.Entry(chamadoLog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChamadoLogExists(id))
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
        public async Task<ActionResult<ChamadoLog>> PostChamadoLog(ChamadoLog chamadoLog)
        {
            _context.ChamadoLogs.Add(chamadoLog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChamadoLog", new { id = chamadoLog.Id }, chamadoLog);
        }

       
    }
}
