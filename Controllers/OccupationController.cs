using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using sikho_backend.Models;

namespace sikho_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OccupationController : Controller
    {
        private readonly ILogger<OccupationController> _logger;
        private readonly APIDbContext _context;

        public OccupationController(ILogger<OccupationController> logger, APIDbContext context)
        {
            _logger = logger;
            _context = context;
        }

       // GET: api/Occupation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Occupation>>> GetOccupation()
        {
          
            return  await _context.Occupations.ToListAsync();
        }

        // GET: api/Occupation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Occupation>> GetOccupation(int id)
        {
            var occupation = await _context.Occupations.FindAsync(id);

            if (occupation == null)
            {
                return NotFound();
            }

            return occupation;
        }

        // PUT: api/Occupation/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOccupation(int id, Occupation occupation)
        {
            if (id != occupation.Id)
            {
                return BadRequest();
            }

            _context.Entry(occupation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OccupationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent(); //204 No Content
        }

        // POST: api/Occupation
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Occupation>> PostOccupation(Occupation occupation)
        {
            _context.Occupations.Add(occupation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOccupation", new { id = occupation.Id }, occupation);
        }

        // DELETE: api/Occupation/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOccupation(int id)
        {
            var occupation = await _context.Occupations.FindAsync(id);
            if (occupation == null)
            {
                return NotFound();
            }

            _context.Occupations.Remove(occupation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [NonAction]
        internal bool OccupationExists(int id)
        {
            return _context.Occupations.Any(e => e.Id == id);
        }
    }
}