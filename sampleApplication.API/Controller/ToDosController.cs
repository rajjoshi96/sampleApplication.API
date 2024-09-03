using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sampleApplication.API.Interface;
using sampleApplication.API.Model;
using sampleApplication.API.Repos;

namespace sampleApplication.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDosController : Controller
    {
        private readonly IToDoTaskInterface _tasks;

        public ToDosController(IToDoTaskInterface tasks)
        {
            _tasks = tasks;
        }

        // GET: api/Controller/ToDos
        [HttpGet("GetListToDos")]
        public IActionResult GetSampleModel()
        {

            var getReponse = _tasks.GetAllTasks();

            return Ok(getReponse);
            // return await _context.sampleModel.ToListAsync();
        }

        // GET: api/Controller/ToDos/5
        // [HttpGet("{id}")]
        // public async Task<ActionResult<ToDoTasks>> GetsampleModel(int id)
        // {
        //     var sampleModel = await _context.sampleModel.FindAsync(id);

        //     if (sampleModel == null)
        //     {
        //         return NotFound();
        //     }

        //     return sampleModel;
        // }

        // PUT: api/Controller/ToDos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        // [HttpPut("{id}")]
        // public async Task<IActionResult> PutsampleModel(int id, ToDoTasks sampleModel)
        // {


        //     _context.Entry(sampleModel).State = EntityState.Modified;

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         // if (!sampleModelExists(id))
        //         // {
        //         //     return NotFound();
        //         // }
        //         // else
        //         // {
        //         //     throw;
        //         // }
        //     }

        //     return NoContent();
        // }

        // POST: api/Controller/ToDos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        // [HttpPost("AddNewToDo")]
        // public async Task<ActionResult<ToDoTasks>> PostsampleModel(ToDoTaskDTO sampleModel)
        // {
        //     ToDoTasks newTask = new ToDoTasks
        //     {
        //         id = new Guid(),
        //         taskName = sampleModel.taskName,
        //         taskTime = sampleModel.taskTime,
        //         isComplete = sampleModel.isComplete
        //     };
        //     _context.sampleModel.Add(sampleModel);
        //     await _context.SaveChangesAsync();

        //     return CreatedAtAction("GetsampleModel", new { id = sampleModel.id }, sampleModel);
        // }

        // DELETE: api/Controller/ToDos/5
        // [HttpDelete("{id}")]
        // public async Task<IActionResult> DeletesampleModel(int id)
        // {
        //     var sampleModel = await _context.sampleModel.FindAsync(id);
        //     if (sampleModel == null)
        //     {
        //         return NotFound();
        //     }

        //     _context.sampleModel.Remove(sampleModel);
        //     await _context.SaveChangesAsync();

        //     return NoContent();
        // }



        // private bool sampleModelExists(int id)
        // {
        //     return _context.sampleModel.Any(e => e.id == id);
        // }
    }
}
