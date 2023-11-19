import React from 'react';
import style from '../../../../assets/css/gfc.module.css';
import { FiPhoneCall, FiSettings, FiSmartphone } from 'react-icons/fi';

const Section2 = () => {

    const contentArray = [
        {
            id: 1,
            img: FiPhoneCall,
            text: 'Uma chamada telefônica de uma empresa assinante é feita para um cliente potencial ou existente.'
        },
        {
            id: 2,
            img: FiSettings,
            text: 'Em nanossegundos, a solicitação é encaminhada para a plataforma da Telecall que processa a chamada e adiciona as informações verificadas antes de encaminhá-la ao destinatário.'
        },
        {
            id: 3,
            img: FiSmartphone,
            text: 'As informações aparecem na tela do celular do recipiente que atenderá a ligação com uma chamada de voz normal.'
        }
    ];

    return (
        <React.Fragment>
            <div className={style.section2}>
                <h1>Como Funciona?</h1>
                <div className={style.section2GridContent}>
                    {contentArray.map((content) => (
                        <div key={content.id} className={style.content}>
                            <content.img size={100}/>
                            <p>
                                {content.text}
                            </p>
                        </div>
                    ))}
                </div>
            </div>
        </React.Fragment>
    );
}

export default Section2;