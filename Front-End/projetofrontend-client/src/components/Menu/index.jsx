import React from 'react';
import { Nav, Image, Container, Navbar } from 'react-bootstrap';
import { NavLink } from 'react-router-dom';
import imgLogo from '../../assets/img/Logo - Horizontal - Sem frase.png';
import { IconButton } from '@mui/material';
import { FiMenu } from 'react-icons/fi'
import { MdWbSunny } from 'react-icons/md';
import { HiUserCircle } from 'react-icons/hi'
import style from '../../assets/css/navBar.module.css'

const Menu = ({ onClick, hasSideBar }) => {

    return (
        <React.Fragment>
            <Navbar className={"navbar navbar-expand-lg lg-12 bg-light mx-4 rounded-4"} style={{ boxShadow: "rgba(0, 0, 0, 0.35) 0px 0px 10px", top: '1.5rem' }} fixed="top">
                <Container fluid >
                    <Nav.Link className={style.logo}>
                        {(hasSideBar) ?
                            <IconButton size='medium' onClick={onClick}>
                                <FiMenu size={30} color='#0C4B77' />
                            </IconButton>
                            :
                            null
                        }
                        <Navbar.Brand href={'/'}>
                            <Image src={imgLogo} width={150} />
                        </Navbar.Brand>
                    </Nav.Link>
                    <Nav>
                        <NavLink to={'/'}>
                            <IconButton size='medium'>
                                <MdWbSunny size={30} color='#0C4B77' />
                            </IconButton>
                        </NavLink>
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