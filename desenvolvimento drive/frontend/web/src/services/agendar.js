import axios from 'axios'

const api = axios.create(
    { baseURL : "http://localhost:5000/Agendamento" }
)

export const CadastrarAgendamento = (dados) => {
    api.post("/", dados);
}