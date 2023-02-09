using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaskManagement.Interfaces;
using TaskManagement.Models;

namespace TaskManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        public readonly ITask _task;
        public TaskController(ITask task)
        {
            _task= task;
        }
        [HttpPost("CreateTask")]
       public async Task<IActionResult> CreateTask(TaskModel model)
        {
           Response result=await _task.CreateTask(model);
           if(result.status)
            {
                return Ok(result);
            }
           return BadRequest(result);
           
        }
    }
}
