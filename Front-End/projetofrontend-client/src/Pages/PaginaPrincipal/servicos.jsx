import React from 'react';
import { Image } from 'react-bootstrap';
import { FiLock, FiCheck, FiSmartphone, FiMessageCircle } from 'react-icons/fi';
import style from '../../assets/css/paginaprincipal.module.css'

const Servicos = () => {

    const imgArray = [
        {
            src: FiLock,
            alt: '',
            size: 100,
            color: '#0C4B77',
            text:'Autenticação de 2 Fatores'
        },
        {
            src: FiCheck,
            alt: '',
            size: 100,
            color: '#0C4B77',
            text:'Google Verified Calls'
        },
        {
            src: FiSmartphone,
            alt: '',
            size: 100,
            color: '#0C4B77',
            text:'Número Máscara'
        },
        {
            src: FiMessageCircle,
            alt: '',
            size: 100,
            color: '#0C4B77',
            text:'SMS Programavel'
        }
    ];

    return (
        <React.Fragment>
            <section>
                <div className={style.servicesContainer}>
                    {imgArray.map((imgs) => (
                        <div>
                            <imgs.src size={imgs.size} color={imgs.color} />
                            <div>
                                <h3>{imgs.text}</h3>
                            </div>
                        </div>
                    ))}
                </div>
            </section>
        </React.Fragment>
    );
}

export default Servicos;