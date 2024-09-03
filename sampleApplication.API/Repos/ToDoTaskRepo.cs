using Microsoft.EntityFrameworkCore;
using sampleApplication.API.Interface;
using sampleApplication.API.Model;

namespace sampleApplication.API.Repos
{

    public class ToDoTaskRepo : IToDoTaskInterface
    {
        private readonly ApplicationDbContext _dbContext;
        public ToDoTaskRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ToDoTasks AddNewTask(ToDoTaskDTO taskDTO)
        {
            var newTask = new ToDoTasks
            {
                id = new Guid(),
                taskName = taskDTO.taskName,
                taskTime = taskDTO.taskTime,
                isComplete = taskDTO.isComplete
            };


            var blogs = _dbContext.sampleModel.Add(newTask);
            _dbContext.SaveChanges();

            return newTask;

        }

        public async Task<List<ToDoTasks>> GetAllTasks()
        {
            var response = await _dbContext.sampleModel.ToListAsync();
            Console.WriteLine(response[0].taskName);


            return response;
        }
    }
}