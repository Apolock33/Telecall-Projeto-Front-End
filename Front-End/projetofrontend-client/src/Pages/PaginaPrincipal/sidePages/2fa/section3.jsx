import React from 'react';
import style from '../../../../assets/css/2fa.module.css';
import { FaMoneyCheck, FaHeartbeat, FaPlane, FaCartArrowDown, FaBox, FaHotel } from 'react-icons/fa'

const Section3 = () => {

    const utilitiesArray = [
        {
            id: 1,
            icon: FaMoneyCheck,
            title: 'Finanças',
            txt1: 'Acesso ao portal/app',
            txt2: 'Autenticação para transações bancárias ',
            txt3: 'Pagamentos Online',
            txt4: 'Digital Wallets ',
            size: 100
        },
        {
            id: 2,
            icon: FaHeartbeat,
            title: 'Saúde',
            txt1: 'Acesso ao portal/app',
            txt2: 'Agendamentos',
            txt3: 'Tokens de autorização',
            txt4: 'Telemedicina',
            size: 100
        },
        {
            id: 3,
            icon: FaPlane,
            title: 'Turismo',
            txt1: 'Acesso ao portal/app',
            txt2: 'Gestão de Reservas',
            txt3: 'Acesso ao histórico',
            txt4: 'Salvar dados de pagamentos',
            txt5: 'Recuperação de senha',
            size: 100
        },
        {
            id: 4,
            icon: FaCartArrowDown,
            title: 'Varejo',
            txt1: 'Acesso ao portal/app',
            txt2: 'Salvar dados de pagamentos',
            txt3: 'Acesso ao histórico',
            txt4: 'Recuperação de senha',
            txt5: 'Recibo Eletrônico',
            size: 100
        },
        {
            id: 5,
            icon: FaBox,
            title: 'Logística',
            txt1: 'Acesso ao portal/app',
            txt2: 'Salvar dados de pagamentos',
            txt3: 'Acesso ao histórico',
            txt4: 'Recuperação de senha',
            size: 100
        },
        {
            id: 6,
            icon: FaHotel,
            title: 'Governo',
            txt1: 'Acesso ao portal/app',
            txt2: 'Gestão de informações',
            txt3: 'Agendamentos',
            txt4: 'Recuperação de senha',
            size: 100
        }
    ];

    return (
        <React.Fragment>
            <div className={style.utilitiesSection}>
                <h1>Utilidades</h1>
                <div className={style.utilitiesAlign}>
                    <div className={style.utilitiesDisplay}>
                        {utilitiesArray.map((utilities) => (
                            <div key={utilities.id} className={style.utilities}>
                                <utilities.icon size={utilities.size} />
                                <h5>{utilities.title}</h5>
                                <ul>
                                    <li>{utilities.txt1}</li>
                                    <li>{utilities.txt2}</li>
                                    <li>{utilities.txt3}</li>
                                    <li>{utilities.txt4}</li>
                                </ul>
                            </div>
                        ))}
                    </div>
                </div>
            </div>
        </React.Fragment>
    );
}

export default Section3;