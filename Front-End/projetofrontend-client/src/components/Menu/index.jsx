import React from 'react';
import { Nav, Image, Container, Navbar } from 'react-bootstrap';
import { NavLink } from 'react-router-dom';
import imgLogo from '../../assets/img/Logo - Horizontal - Sem frase.png';
import { IconButton } from '@mui/material';
import { HiUserCircle } from 'react-icons/hi';
import style from '../../assets/css/navBar.module.css';

const Menu = () => {

    return (
        <React.Fragment>
            <Navbar className={"navbar navbar-expand-lg bg-light mx-4 rounded-4"} style={{ boxShadow: "rgba(0, 0, 0, 0.35) 0px 0px 10px", top: '1.5rem' }} fixed="top">
                <Container fluid >
                    <Nav.Link className={style.logo}>
                        <Navbar.Brand onClick={() => window.location.href = '/'} className={style.icons}>
                            <Image src={imgLogo} width={150} />
                        </Navbar.Brand>
                    </Nav.Link>
                    <Nav>
                        <NavLink to={'/login'}>
                            <IconButton size='medium'>
                                <HiUserCircle size={30} color='#0C4B77' />
                            </IconButton>
                        </NavLink>
                    </Nav>
                </Container>
            </Navbar>
        </React.Fragment>
    );
}

export default Menu;