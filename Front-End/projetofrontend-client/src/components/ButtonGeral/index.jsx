import React from 'react';
import { Button } from 'react-bootstrap';

const ButtonGeral = ({ onClick, children, color, className, type }) => {
    return (
        <React.Fragment>
            <Button type={type} className={className} onClick={onClick} variant={color}>
                {children}
            </Button>
        </React.Fragment>
    );
}

export default ButtonGeral;