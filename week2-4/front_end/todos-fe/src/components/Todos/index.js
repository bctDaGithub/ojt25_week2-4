import { useEffect, useRef, useState } from "react";
import { getTodosAPI } from "../../api/todo"
import { delTodosAPI } from "../../api/todo"
import { addTodosAPI } from "../../api/todo"
import "./index.css"
const Todos = () => {
  const data = [];

  const [todos, setTodos] = useState([]);

  const todoRef = useRef([]); 
  
  useEffect(() => {
    fetchData();
  }, []);

  const fetchData = async () => {
    setTodos(await getTodosAPI());
  }

  const deleteTodo = async (id) => {
    if (window.confirm("Nhiệm vụ không thể khôi phục. Bạn có chắc muốn xóa chứ?")) {
      await delTodosAPI(id);
      window.location.reload();
    };
  }

  const addOrEditTodo = async (event) => {
    event.preventDefault();
    const val = event.target[0].value;
    const id = event.target[1].value;
    console.log({
      val,
      id
    });
    if (id) {
      //Update
    } else {
      //Add
      await addTodosAPI(val);
      fetchData();
    }
  }

  const editTodo = (id) => {
    const inputName = document.getElementById("name");
    const inputId = document.getElementById("id");
    const todo = todos.find((todo) => todo.id === id);
  
    if (todoRef?.current[id].className === "fas fa-edit") {
      todoRef?.current[id].className = "fas fa-user-edit";
      inputName.value = todo.name;
      inputId.value = id;
    } else if (todoRef?.current[id].className === "fas fa-user-edit") {
      todoRef?.current[id].className = "fas fa-edit";
      inputName.value = "";
      inputId.value = null;
    }
  };
  

  return (
    <main id="todolist">
      <h1>
        Danh sách
        <span>Việc hôm nay không để ngày mai.</span>
      </h1>

      {todos ? (
        todos?.map((item, key) => (
          <li className={item.isComplete ? "done" : ""} key={key}>
            <span className="label">{item.name}</span>
            <div className="actions">
              <button className="btn-picto" type="button">
              onClick={() => editTodo(item.id)}
              <i className="fas fa-edit" 
                ref={el => todoRef.current[item.id]}
              />
              </button>
              <button
                className="btn-picto"
                type="button"
                aria-label="Delete"
                title="Delete"
                onClick={() => deleteTodo(item.id)}
              >
                <i className="fas fa-trash" />
              </button>
            </div>
          </li>
        ))) : (<p>Danh sách nhiệm vụ trống.</p>)
      }

      {/* <li className="done">
    <span className="label">123</span>
    <div className="actions">
      <button className="btn-picto" type="button">
        <i className="fas fa-edit" />
      </button>
      <button
        className="btn-picto"
        type="button"
        aria-label="Delete"
        title="Delete"
      >
        <i className="fas fa-trash" />
      </button>
    </div>
  </li>
  <li>
    <span className="label">123</span>
    <div className="actions">
      <button className="btn-picto" type="button">
        <i className="fas fa-user-edit" />
      </button>
      <button
        className="btn-picto"
        type="button"
        aria-label="Delete"
        title="Delete"
      >
        <i className="fas fa-trash" />
      </button>
    </div>
  </li> */}

      <form onSubmit={addOrEditTodo}>
        <label >Thêm nhiệm vụ mới</label>
        <input type="text" name="name" id="name" />
        <input type="text" name="id" id="id" />
        <button type="submit">Thêm mới</button>
      </form>
    </main>

  );
}

export default Todos;
