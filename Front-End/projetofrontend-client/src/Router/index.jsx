import React from 'react';
import { createBrowserRouter } from 'react-router-dom';
import Home from '../Pages/Home';
import Usuario from '../Pages/Usuario';
import LogIn from '../Pages/LogIn';
import Registro from '../Pages/Registro';
import PaginaPrincipal from '../Pages/paginaPrincipal';
import SmsProgramavel from '../Pages/paginaPrincipal/sidePages/smsProgramavel/smsProgramavel';
import TwoFactorAuthentication from '../pages/paginaPrincipal/sidePages/2fa/twoFactorAuth';
import NumeroMascara from '../pages/paginaPrincipal/sidePages/numeroMascara/numeroMascara';
import GoogleVerifiedCalls from '../pages/paginaPrincipal/sidePages/googleVerifiedCalls/googleVerifiedCalls';

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
        path: '/2fa',
        element: <TwoFactorAuthentication />
    },
    {
        path: '/sms-programavel',
        element: <SmsProgramavel />
    },
    {
        path: '/numero-mascara',
        element: <NumeroMascara />
    },
    {
        path: '/google-verified-calls',
        element: <GoogleVerifiedCalls />
    },
    {
        path: '/home',
        element: <Home />
    },
    {
        path: '/usuarios',
        element: <Usuario />
    }
]);

export default Router;