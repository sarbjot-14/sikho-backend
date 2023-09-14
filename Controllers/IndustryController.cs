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
    public class IndustryController : Controller
    {
        private readonly ILogger<IndustryController> _logger;
        private readonly APIDbContext _context;

        public IndustryController(ILogger<IndustryController> logger, APIDbContext context)
        {
            _logger = logger;
            _context = context;
        }

       // GET: api/Industry
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Industry>>> GetIndustry()
        {
            return await _context.Industries.ToListAsync();
        }

        // GET: api/Industry/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Industry>> GetIndustry(int id)
        {
            var industry = await _context.Industries.FindAsync(id);

            if (industry == null)
            {
                return NotFound();
            }

            return industry;
        }

        // PUT: api/Industry/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIndustry(int id, Industry industry)
        {
            if (id != industry.IndustryId)
            {
                return BadRequest();
            }

            _context.Entry(industry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IndustryExists(id))
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

        // POST: api/Industry
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Industry>> PostIndustry(Industry industry)
        {
            _context.Industries.Add(industry);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIndustry", new { id = industry.IndustryId }, industry);
        }

        // DELETE: api/Industry/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIndustry(int id)
        {
            var industry = await _context.Industries.FindAsync(id);
            if (industry == null)
            {
                return NotFound();
            }

            _context.Industries.Remove(industry);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [NonAction]
        internal bool IndustryExists(int id)
        {
            return _context.Industries.Any(e => e.IndustryId == id);
        }
    }
}