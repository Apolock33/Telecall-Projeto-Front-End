import React from 'react';
import { Nav, Image, Navbar, Container } from 'react-bootstrap';
import imgLogo from '../../assets/img/logo-colorida.png';
import { IconButton } from '@mui/material';
import { FiMenu, FiUsers, FiSun } from 'react-icons/fi'

const Menu = ({ children, bgColor, onClick, colorIcon, hasSideBar }) => {

    return (
        <React.Fragment>
            <Navbar bg={bgColor} expand={'lg'}>
                <Container fluid>
                    <Nav.Link>
                        {(hasSideBar) ?
                            <IconButton size={'large'} onClick={onClick}>
                                <FiMenu size={30} color={colorIcon} />
                            </IconButton>
                            : null
                        }
                        <Navbar.Brand href="/">
                            <Image src={imgLogo} width={150} />
                        </Navbar.Brand>
                    </Nav.Link>
                    <Nav.Link>
                        <IconButton size={'large'}>
                            <FiSun size={30} color={colorIcon} />
                        </IconButton>
                        <IconButton size={'large'}>
                            <FiUsers size={30} color={colorIcon} />
                        </IconButton>
                    </Nav.Link>
                </Container>
            </Navbar>
            {children}
        </React.Fragment>
    );
}

export default Menu;