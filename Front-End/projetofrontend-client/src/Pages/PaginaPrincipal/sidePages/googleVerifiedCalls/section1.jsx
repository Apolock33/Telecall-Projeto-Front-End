import React from 'react';
import style from '../../../../assets/css/gfc.module.css';

const Section1 = () => {
    return (
        <React.Fragment>
            <div className={style.section1}>
                <h1>O que é?</h1>
                <h3>Chamadas Verificadas</h3>
                <p>
                    Esse novo recurso do Google, exclusivo para telefones Android, permite que empresas exibam para o cliente na hora da chamada sua marca, logotipo e até mesmo o motivo da chamada.
                    A Telecall é a primeira operadora de telecom no
                    Brasil a oferecer esse recurso do Google
                </p>
            </div>
        </React.Fragment>
    );
}

export default Section1;