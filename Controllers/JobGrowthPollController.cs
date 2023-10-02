using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sikho_backend.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace sikho_backend.Controllers
{
        [Route("[controller]")]
    [ApiController]
    public class JobGrowthPollController :Controller
    {
        private readonly ILogger<JobGrowthPollController> _logger;
        private readonly APIDbContext _context;

        public JobGrowthPollController(ILogger<JobGrowthPollController> logger, APIDbContext context)
        {
            _logger = logger;
            _context = context;
        }

       // GET: api/JobGrowthPoll
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobGrowthPoll>>> GetJobGrowthPoll()
        {
          
            return  await _context.JobGrowthPolls.ToListAsync();
        }

        // GET: api/JobGrowthPoll/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JobGrowthPoll>> GetJobGrowthPoll(int id)
        {
            var jobGrowthPoll = await _context.JobGrowthPolls.FindAsync(id);

            if (jobGrowthPoll == null)
            {
                return NotFound();
            }

            return jobGrowthPoll;
        }

        // PUT: api/JobGrowthPoll/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJobGrowthPoll(int id, JobGrowthPoll jobGrowthPoll)
        {
            if (id != jobGrowthPoll.Id)
            {
                return BadRequest();
            }

            _context.Entry(jobGrowthPoll).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobGrowthPollExists(id))
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

        // POST: api/JobGrowthPoll
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<JobGrowthPoll>> PostJobGrowthPoll(JobGrowthPoll jobGrowthPoll)
        {
            _context.JobGrowthPolls.Add(jobGrowthPoll);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJobGrowthPoll", new { id = jobGrowthPoll.Id }, jobGrowthPoll);
        }

        // DELETE: api/JobGrowthPoll/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobGrowthPoll(int id)
        {
            var jobGrowthPoll = await _context.JobGrowthPolls.FindAsync(id);
            if (jobGrowthPoll == null)
            {
                return NotFound();
            }

            _context.JobGrowthPolls.Remove(jobGrowthPoll);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [NonAction]
        internal bool JobGrowthPollExists(int id)
        {
            return _context.JobGrowthPolls.Any(e => e.Id == id);
        }
    }
}