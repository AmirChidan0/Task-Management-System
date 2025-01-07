using TaskManagerAPI.Data;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Task> GetAllTasks()
        {
            return _context.Tasks.ToList();
        }

        public Task<Task> GetTaskById(int id)
        {
            return _context.Tasks.FindAsync(id).AsTask();
        }

        public void CreateTask(Task task)
        {
            _context.Tasks.Add(task);
        }

        public void UpdateTask(Task task)
        {
            _context.Tasks.Update(task);
        }

        public void DeleteTask(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void CreateTask(Models.Task task)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Models.Task> ITaskRepository.GetAllTasks()
        {
            throw new NotImplementedException();
        }

        Task<Models.Task> ITaskRepository.GetTaskById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTask(Models.Task task)
        {
            throw new NotImplementedException();
        }
    }
}
