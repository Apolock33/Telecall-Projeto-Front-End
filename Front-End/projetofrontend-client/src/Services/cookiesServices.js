function verifyLogin(cookieIsLogged) {
    if (!cookieIsLogged) {
        window.location.href = '/login';
    }
}

export { verifyLogin };