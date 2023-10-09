function verifyLogin({ cookieIsLogged }) {
    if (cookieIsLogged == false) {
        setTimeout(() => {
            console.log('Usuario não Logado');
        }, 3000)
    }
}


export { verifyLogin };