namespace sampleApplication.API.Model
{
    public class ToDoTasks
    {
        public Guid id { get; set; }
        public required string taskName { get; set; }
        public DateTime taskTime { get; set; }
        public bool isComplete { get; set; }
    }
}