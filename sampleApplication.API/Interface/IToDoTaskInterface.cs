using sampleApplication.API.Model;

namespace sampleApplication.API.Interface
{
    public interface IToDoTaskInterface
    {
        public ToDoTasks GetAllTasks();
    }
}