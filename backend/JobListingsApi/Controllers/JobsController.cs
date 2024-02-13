using JobListingsApi.Data;
using JobListingsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobListingsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public JobsController(ApiDbContext context)
        {
            _context = context;
        }
        [HttpGet(Name = "GetAllJobs")]
        public async Task<IActionResult> Get()
        {
            

            var allJobs = await _context.Jobs.ToListAsync();

            return Ok(allJobs);
        }
    }
}
