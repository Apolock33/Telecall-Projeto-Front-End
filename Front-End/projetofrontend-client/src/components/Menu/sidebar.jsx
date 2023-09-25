import React, { useState } from 'react';
import { Button, Offcanvas, Nav } from 'react-bootstrap';
import { FiMenu } from 'react-icons/fi'
import { FaUser, FaFile } from 'react-icons/fa'
import { Dropdown } from 'bootstrap';

const SideBar = () => {
    const [show, setShow] = useState(false);

    const handleClose = () => setShow(false);
    const handleShow = () => setShow(true);

    return (
        <React.Fragment>
            <Button variant="white" onClick={handleShow}>
                <FiMenu size={30} color={"#0C4B77"} />
            </Button>

            <Offcanvas show={show} onHide={handleClose}>
                <Offcanvas.Header closeButton />
                <Offcanvas.Body>
                    <Nav.Link>
                        <FaUser />
                        <h6>Usuario</h6>
                    </Nav.Link>
                    <Nav.Link>
                        <FaFile />
                        <h6>Logs</h6>
                    </Nav.Link>
                </Offcanvas.Body>
            </Offcanvas>
        </React.Fragment>
    );
}

export default SideBar;