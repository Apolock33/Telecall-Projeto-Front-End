import api from './api';

async function logInRequest(login, senha) {
    const { data } = await api.post(`/Usuario/LogIn?login=${login}&senha=${senha}` );
    return data;
}

export { logInRequest };