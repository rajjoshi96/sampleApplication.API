namespace sampleApplication.API.Model
{
    public class ToDoTaskDTO
    {
        public required string taskName { get; set; }
        public DateTime taskTime { get; set; }
        public bool isComplete { get; set; }
    }
}