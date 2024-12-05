﻿using TodoList.Domain.Enums;

namespace TodoList.Domain.Entities
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public PriorityLevel PriorityLevel { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsCompleted { get; set; }
        public bool OnPause { get; set; }

        // Foreign key to TodoList
        public int TodoListId { get; set; }

    }
}