import React from 'react';
import { createBrowserRouter } from 'react-router-dom';
import Home from '../pages/Home';
import Usuario from '../pages/Usuario';
import LogIn from '../Pages/LogIn';

const Router = createBrowserRouter([
    {
        path: '/',
        element: <LogIn />
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