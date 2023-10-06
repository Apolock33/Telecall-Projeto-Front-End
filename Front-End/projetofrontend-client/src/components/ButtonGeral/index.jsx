import React from 'react';
import { Button } from 'react-bootstrap';

const ButtonGeral = ({ onClick, content, color, className, type }) => {
    return (
        <React.Fragment>
            <Button type={type} className={className} variant={color}>
                {content}
            </Button>
        </React.Fragment>
    );
}

export default ButtonGeral;