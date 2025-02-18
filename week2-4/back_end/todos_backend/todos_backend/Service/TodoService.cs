using todos_backend.Data;
using todos_backend.Models;

namespace todos_backend.Service
{
    public class TodoService : ITodoService
    {

        private readonly TodosDBContext todosDBContext;

        public TodoService (TodosDBContext todosDBContext)
        {
            this.todosDBContext = todosDBContext;
        }

        public bool AddTodo(string name)
        {
            todosDBContext.Todos.Add(new Todo(name));
            todosDBContext.SaveChanges();
            return true;
        }

        public bool DeleteTodo(int id)
        {
            Todo todo = todosDBContext.Todos.Find(id);
            todosDBContext.Todos.Remove(todo);
            todosDBContext.SaveChanges();
            return true;
        }

        public List<Todo> GetTodos()
        {
            return todosDBContext.Todos.OrderByDescending(x => x.Id).ToList();
        }

        public bool UpdateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
