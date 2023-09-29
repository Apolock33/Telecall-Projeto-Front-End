import api from './api';

async function logInRequest({ userName, password }) {
    const { data } = await api.post("/Usuario/LogIn", { userName, password });
    return data;
}

export { logInRequest };