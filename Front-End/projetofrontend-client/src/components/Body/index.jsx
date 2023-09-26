import React from 'react';
import { Container } from 'react-bootstrap';

const Body = ({ children }) => {
    return (
        <React.Fragment>
            {children}
        </React.Fragment>
    );
}

export default Body;