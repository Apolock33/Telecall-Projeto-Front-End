import React from 'react';
import { Nav, Navbar, Container, Button } from 'react-bootstrap';
import logoColorida from '../../assets/img/logo-colorida.png';
import SideBar from './sidebar';

const Menu = () => {

    return (
        <React.Fragment>
            <Navbar expand="lg" className="bg-body-tertiary">
                <Container>
                    <div>
                    <SideBar />
                    <Navbar.Brand href="/">
                        <img src={logoColorida} width={120} />
                    </Navbar.Brand>
                    </div>
                    <Button>Usuario</Button>
                </Container>
            </Navbar>
        </React.Fragment>
    );
}

export default Menu;