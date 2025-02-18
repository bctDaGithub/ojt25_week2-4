namespace todos_backend.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Boolean isComplete { get; set; }

        public Todo(string name)
        {
            this.Name = name;
        }

        public Todo()
        {

        }
    }
}
