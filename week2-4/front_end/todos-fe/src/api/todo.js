import axiosClient from "./axiosClient";

const END_POINT ={
    TODOS: "todos"
}
export const getTodosAPI = () => {
    return axiosClient.get(`${END_POINT.TODOS}`);
}

export const delTodosAPI = (id) => {
    return axiosClient.delete(`${END_POINT.TODOS}/${id}`);
}

export const addTodosAPI = (name) => {
    return axiosClient.post(`${END_POINT.TODOS}/${name}`);
  };
  