using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyTasksApi.DataAccessLayer;
using DailyTasksApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DailyTasksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TargetsController : Controller
    {
        private readonly TaskTargetContext _context;

        public TargetsController(TaskTargetContext context)
        {
            _context = context;
        }
        public IActionResult Get()
        {
            return Ok(_context.Items);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var taskitem = await _context.Items.FirstOrDefaultAsync(c => c.Id == id);

            if (taskitem == null)
            {
                return NotFound("Specified id not found");
            }

            return Ok(taskitem);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Item item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Item is not valid");
            }

            if (_context.Items.Any(c => c.Name == item.Name))
            {
                return BadRequest("Item is duplicate");
            }
            await _context.Items.AddAsync(item);
            await _context.SaveChangesAsync();

            return Created($"api/targets/{item.Id}", item);
        }
       
    }
}