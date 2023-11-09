import React from 'react';
import style from '../../../../assets/css/2fa.module.css';
import Img from '../../../../assets/img/2fa-steps (1).png';

const Section2 = () => {

    const benefitsArrays = [
        {
            id: 1,
            txt: 'Ofereça segurança aprimorada para seus clientes'
        },
        {
            id: 2,
            txt: 'Reduza casos de fraude e invasões e evite o acesso a dados por invasores.'
        },
        {
            id: 3,
            txt: 'Envio de OTP por meio de vários canais, incluindo SMS e voz.'
        },
        {
            id: 4,
            txt: 'Flexibilidade de canais garante que o usuário conseguirá completar a tarefa desejada.'
        },
        {
            id: 5,
            txt: 'API simples e de rápida implementação.'
        },
        {
            id: 6,
            txt: 'Plataforma intuitiva que permite visualizar relatórios de uso por dia, mês ou ano.'
        }
    ];

    return (
        <React.Fragment>
            <div className={style.benefitsSection}>
                <h1>Benefícios do 2FA</h1>
                <div className={style.benefits}>
                    <img src={Img} width={250} />
                    <div >
                        {benefitsArrays.map((benefits) => (
                            <ul key={benefits.id} className={style.list}>
                                <li>{benefits.txt}</li>
                            </ul>
                        ))}
                    </div>
                </div>
            </div>
        </React.Fragment>
    );
}

export default Section2;