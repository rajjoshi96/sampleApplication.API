using sampleApplication.API.Interface;
using sampleApplication.API.Model;

namespace sampleApplication.API.Repos
{
    public class ToDoTaskRepo : IToDoTaskInterface
    {
        public ToDoTasks GetAllTasks()
        {
            var response = new ToDoTasks
            {

                taskName = "Wash Clothes",
                taskTime = DateTime.Now,
                isComplete = false
            };
            return response;
        }
    }
}