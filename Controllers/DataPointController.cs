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
    public class DataPointController : Controller
    {
        private readonly ILogger<DataPoint> _logger;
        private readonly APIDbContext _context;


        public DataPointController(ILogger<DataPoint> logger, APIDbContext context)
        {
            _logger = logger;
            _context = context;
        }

    // GET: api/DataPoint
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DataPoint>>> GetDataPoint()
        {
          
            return  await _context.DataPoints.ToListAsync();
        }

        // GET: api/DataPoint/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DataPoint>> GetDataPoint(int id)
        {
            var dataPoint = await _context.DataPoints.FindAsync(id);

            if (dataPoint == null)
            {
                return NotFound();
            }

            return dataPoint;
        }

        // PUT: api/DataPoint/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDataPoint(int id, DataPoint dataPoint)
        {
            if (id != dataPoint.Id)
            {
                return BadRequest();
            }

            _context.Entry(dataPoint).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DataPointExists(id))
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

        // POST: api/DataPoint
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DataPoint>> PostDataPoint(DataPoint dataPoint)
        {
            _context.DataPoints.Add(dataPoint);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDataPoint", new { id = dataPoint.Id }, dataPoint);
        }

        // DELETE: api/DataPoint/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDataPoint(int id)
        {
            var dataPoint = await _context.DataPoints.FindAsync(id);
            if (dataPoint == null)
            {
                return NotFound();
            }

            _context.DataPoints.Remove(dataPoint);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [NonAction]
        internal bool DataPointExists(int id)
        {
            return _context.DataPoints.Any(e => e.Id == id);
        }
    }
}