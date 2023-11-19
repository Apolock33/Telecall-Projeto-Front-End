import React from 'react';
import style from '../../../../assets/css/gfc.module.css';

const Section3 = () => {
    return (
        <React.Fragment>
            <div className={style.section3}>
                <h1>Benefícios</h1>
                <div className={style.section3DisplayContent}>
                    <ul>
                        <li>
                            <h5>Estabeleça Confiança</h5>
                            Clientes são mais propensos a atender chamadas de organizações com os quais estão familiarizadas e com as quais já tem relação.
                        </li>
                        <li>
                            <h5>Agilize a Conexão</h5>
                            Quando o motivo da chamada é claro, a chance de o cliente atender é muito maior e a conexão com ele mais rápida e eficiente.
                        </li>
                        <li>
                            <h5>Melhore a Experiência do Cliente</h5>
                            O nome da marca, logotipo e a visualização do motivo da chamada oferecem uma experiencia melhor e muito mais amigável para o cliente.
                        </li>
                    </ul>
                </div>
            </div>
        </React.Fragment>
    );
}

export default Section3;