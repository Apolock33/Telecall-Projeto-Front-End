import React from 'react';
import { createBrowserRouter } from 'react-router-dom';
import Home from '../pages/Home';
import Usuario from '../pages/Usuario';
import LogIn from '../Pages/LogIn';
import Registro from '../Pages/Registro';
import PaginaPrincipal from '../Pages/PaginaPrincipal';

const Router = createBrowserRouter([
    {
        path: '/',
        element: <PaginaPrincipal />
    },
    {
        path: '/login',
        element: <LogIn />
    },
    {
        path: '/registro',
        element: <Registro />
    },
    {
        path: '/home',
        element: <Home />
    },
    {
        path: '/usuarios',
        element: <Usuario/>
    }
]);

export default Router;