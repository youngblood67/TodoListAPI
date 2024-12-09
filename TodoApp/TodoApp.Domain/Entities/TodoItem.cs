using TodoApp.Domain.Enums;

namespace TodoApp.Domain.Entities
{
    public class TodoItem : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public PriorityLevel PriorityLevel { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsCompleted { get; set; }
        public bool OnPause { get; set; }

        // Foreign key to TodoApp
        public int TodoListId { get; set; }

    }
}
