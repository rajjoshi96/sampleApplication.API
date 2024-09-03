using sampleApplication.API.Model;

namespace sampleApplication.API.Interface
{
    public interface IToDoTaskInterface
    {
        public Task<List<ToDoTasks>> GetAllTasks();

        public ToDoTasks AddNewTask(ToDoTaskDTO taskDTO);
    }
}