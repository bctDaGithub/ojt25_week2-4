using Microsoft.AspNetCore.Mvc;
using todos_backend.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace todos_backend.Controllers
{
    [Route("v1/api/todos")]
    [ApiController]
    public class ToDosController : ControllerBase
    {
        private readonly ITodoService _iTodoService;

        public ToDosController(ITodoService todoService)
        {
            _iTodoService = todoService;
        }

        // GET: api/<ToDosController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_iTodoService.GetTodos());
        }

        // GET api/<ToDosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ToDosController>
        [HttpPost("{name}")]
        public IActionResult Post(string name)
        {
            return Ok(_iTodoService.AddTodo(name));
        }

        // PUT api/<ToDosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ToDosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_iTodoService.DeleteTodo(id));
        }
    }
}
