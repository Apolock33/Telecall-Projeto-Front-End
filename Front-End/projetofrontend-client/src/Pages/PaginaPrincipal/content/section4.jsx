import React from 'react';
import style from '../../../assets/css/paginaprincipal.module.css';
import { FiPhone, FiActivity, FiBox, FiShoppingCart } from 'react-icons/fi'

const Section4 = () => {

    const howToCards = [
        {
            id: 1,
            icon: FiBox,
            title: 'Logística',
            description1: 'Acesso seguro com 2FA.',
            description2: ' Uso de números mascarados para proteção de funcionário e cliente.',
            description3: 'Mantenha o cliente informado sobre entrega e serviços.',
            size: 60
        },
        {
            id: 2,
            icon: FiShoppingCart,
            title: 'Varejo',
            description1: 'Mantenha o cliente informado sobre entrega e serviços.',
            description2: ' Avisos sobre compras e entregas.',
            description3: 'Upsell com novas ofertas e vantagens via SMS.',
            size: 60
        },
        {
            id: 3,
            icon: FiPhone,
            title: 'Call Center',
            description1: 'Melhore taxas de abertura utilizando alertas SMS para confirmações.',
            description2: 'Economia de números com o uso de um único número máscara por todos os agentes.',
            size: 60
        },
        {
            id: 4,
            icon: FiActivity,
            title: 'Saúde',
            description1: 'Melhore o agendamento e reduza faltas com lembretes por SMS.',
            description2: 'Tokens de autorização para procedimentos com 2FA.',
            size: 60
        },
    ]

    return (
        <React.Fragment>
            <div className={style.howTo}>
                <h1>Como as Empresas usam CPaas?</h1>
                <div className={style.howToCards}>
                    {howToCards.map((cards) => (
                        <div key={cards.id} className={style.howToCardsInternConfig}>
                            <cards.icon size={cards.size} />
                            <h3>{cards.title}</h3>
                            <p>{cards.description1}</p>
                            <p>{cards.description2}</p>
                            <p>{cards.description3}</p>
                        </div>
                    ))}
                </div>
            </div>
        </React.Fragment>
    );
}

export default Section4;