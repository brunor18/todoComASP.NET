namespace testeweb.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = "";
        public DateTime CreatedAt { get; set; }
        public DateOnly DeadLine { get; set; }
        public DateOnly? FinishedAt { get; set; }
    }
}
