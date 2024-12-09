namespace TodoApp.Domain.Entities
{
    public class TodoList : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Tags { get; set; } = new();
    }
}
