import React from 'react';
import { Button } from 'react-bootstrap';

const ButtonGeral = ({content, color, onSubmit, className}) => {
    return (
        <React.Fragment>
            <Button className={className} onSubmit={onSubmit} variant={color}>
                {content}
            </Button>
        </React.Fragment>
    );
}

export default ButtonGeral;