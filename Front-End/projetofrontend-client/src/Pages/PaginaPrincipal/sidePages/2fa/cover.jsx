import React from 'react';
import style from '../../../../assets/css/2fa.module.css';

const Cover = () => {
    return (
        <React.Fragment>
            <div className={style.tfaCover}>
                <h1>Autenticação de <br/>Dois Fatores</h1>
            </div>
        </React.Fragment>
    );
}

export default Cover;