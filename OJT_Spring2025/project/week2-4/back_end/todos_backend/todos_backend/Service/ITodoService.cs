using todos_backend.Models;

namespace todos_backend.Service
{
    public interface ITodoService
    {
        List<Todo> GetTodos();
        Boolean AddTodo(string name);
        Boolean DeleteTodo(int id);
        Boolean UpdateTodo(Todo todo);
    }
}
