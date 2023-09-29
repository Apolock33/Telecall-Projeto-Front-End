import React from 'react';
import style from '../../assets/css/login.module.css'
import LoginForm from './loginForm.jsx'
import { Col, Row } from 'react-bootstrap';

const LogIn = () => {
    return (
        <React.Fragment>
            <LoginForm/>
        </React.Fragment >
    );
}

export default LogIn;