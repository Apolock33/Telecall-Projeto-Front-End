import React from 'react';
import style from '../../../assets/css/paginaprincipal.module.css';
import { Link } from 'react-router-dom';
import { FiLock, FiMessageCircle, FiSmartphone, FiCheckCircle } from 'react-icons/fi';

const Section2 = () => {

    const cards = [
        {
            id: 1,
            title: 'Autenticação de Dois Fatores',
            description: 'Fortaleça a estratégia de segurança de seu negócio.',
            icon: FiLock,
            size: 80,
            router: '/'
        },
        {
            id: 2,
            title: 'Número Máscara',
            description: 'Proteja identidades profissionais.',
            icon: FiSmartphone,
            size: 80,
            router: '/'
        },
        {
            id: 3,
            title: 'SMS Programavel',
            description: 'Conecte-se com seus clientes de forma fácil e rápida.',
            icon: FiMessageCircle,
            size: 80,
            router: '/'
        },
        {
            id: 4,
            title: 'Google Verified Calls',
            description: 'Ofereça uma melhor experiência de vendas e promoções para seus clientes.',
            icon: FiCheckCircle,
            size: 80,
            router: '/'
        }
    ]

    return (
        <React.Fragment>
            <div className={style.solutions}>
                <h1>Nossas Soluções</h1>
                <p>
                    Potencialize suas estratégias de comunicação com nossas soluções inovadoras
                </p>
                <div className={style.solutionsCards}>
                    {cards.map((card) => (
                        <Link key={card.id} to={card.router}>
                            <div className={style.nSIcons}>
                                <card.icon size={card.size} />
                                <h4>{card.title}</h4>
                                <p>{card.description}</p>
                            </div>
                        </Link>
                    ))}
                </div>
            </div>
        </React.Fragment>
    );
}

export default Section2;