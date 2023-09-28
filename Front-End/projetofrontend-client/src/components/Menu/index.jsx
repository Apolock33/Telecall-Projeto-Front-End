import React from 'react';
import { Nav, Image, Navbar, Container } from 'react-bootstrap';
import { NavLink } from 'react-router-dom';
import imgLogo from '../../assets/img/Logo - Horizontal - Sem frase.png';
import { IconButton } from '@mui/material';
import { FiMenu } from 'react-icons/fi'
import { MdWbSunny } from 'react-icons/md';
import { HiUserCircle } from 'react-icons/hi'
import { Link } from 'react-router-dom';
import style from '../../assets/css/navBar.module.css'

const Menu = ({ onClick }) => {

    return (
        <React.Fragment>
            <Nav className={"navbar navbar-expand-lg navbar-dark bg-light m-4 rounded-5"} style={{ "boxShadow":"rgba(0, 0, 0, 0.15) 0px 5px 15px 0px" }}>
                <Container fluid className='d-flex justify-content-between align-items-center'>
                    <Nav.Link className={style.logo}>
                        <IconButton size='medium' onClick={onClick}>
                            <FiMenu size={30} />
                        </IconButton>
                        <div>
                            <Image src={imgLogo} width={150} />
                        </div>
                    </Nav.Link>
                    <Nav.Link>
                        <IconButton size='medium'>
                            <MdWbSunny size={30} />
                        </IconButton>
                        <NavLink to={'/login'}>
                            <IconButton size='medium'>
                                <HiUserCircle size={30} />
                            </IconButton>
                        </NavLink>
                    </Nav.Link>
                </Container>
            </Nav>
        </React.Fragment>
    );
}

export default Menu;