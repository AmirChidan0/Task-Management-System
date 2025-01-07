using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; } = false;
        public DateTime DueDate { get; set; }
        public int UserId { get; set; }
    }
}
