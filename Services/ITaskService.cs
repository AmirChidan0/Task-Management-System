





namespace TaskManagerAPI.Services
{
    public interface ITaskService
    {
        void CreateTask(Models.Task task);
        void CreateTask(Models.Task task);
        void DeleteTask(int id);
        IEnumerable<Models.Task> GetAllTasks();
        Task<Models.Task> GetTaskById(int id);
        void UpdateTask(Models.Task task);
        void UpdateTask(Models.Task task);
    }
}