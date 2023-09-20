namespace  ToDoAPI.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string? Task { get; set; }
        public bool Done { get; set; }
    }
}