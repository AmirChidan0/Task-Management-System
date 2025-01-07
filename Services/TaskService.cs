using TaskManagerAPI.Models;
using TaskManagerAPI.Repositories;

namespace TaskManagerAPI.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public IEnumerable<Task> GetAllTasks()
        {
            return _taskRepository.GetAllTasks();
        }

        public Task<Task> GetTaskById(int id)
        {
            return _taskRepository.GetTaskById(id);
        }

        public void CreateTask(Task task)
        {
            _taskRepository.CreateTask(task);
            _taskRepository.Save();
        }

        public void UpdateTask(Task task)
        {
            _taskRepository.UpdateTask(task);
            _taskRepository.Save();
        }

        public void DeleteTask(int id)
        {
            _taskRepository.DeleteTask(id);
            _taskRepository.Save();
        }

        public void CreateTask(Models.Task task)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Models.Task> ITaskService.GetAllTasks()
        {
            throw new NotImplementedException();
        }

        Task<Models.Task> ITaskService.GetTaskById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTask(Models.Task task)
        {
            throw new NotImplementedException();
        }
    }
}
