import React from 'react';
import { Offcanvas } from 'react-bootstrap'

const Sidebar = ({ show, close, action, children }) => {
    return (
        <React.Fragment>
            <Offcanvas show={show} onHide={close}>
                <Offcanvas.Header closeButton>
                    <Offcanvas.Title>
                        {action}
                    </Offcanvas.Title>
                </Offcanvas.Header>
                <Offcanvas.Body>
                    {children}
                </Offcanvas.Body>
            </Offcanvas>
        </React.Fragment>
    );
}

export default Sidebar;