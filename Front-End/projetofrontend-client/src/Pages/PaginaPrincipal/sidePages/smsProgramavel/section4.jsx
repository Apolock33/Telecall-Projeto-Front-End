import React from 'react';
import style from '../../../../assets/css/sms.module.css';

const Section4 = () => {

    const benefitsArray = [
        {
            id:1,
            text:'Comunicação rápida, eficiente e escalável.'
        },
        {
            id:2,
            text:'Excelente custo-benefício.'
        },
        {
            id:3,
            text:'Altas taxas de abertura e engajamento.'
        },
        {
            id:4,
            text:'Interação bidirecional: possibilidade de receber respostas.'
        },
        {
            id:5,
            text:'Plataforma fácil de usar.'
        },
        {
            id:6,
            text:'Acompanhamento de métricas e geração de relatórios.'
        },
        {
            id:7,
            text:'Mensagens personalizadas.'
        },
        {
            id:8,
            text:'Confiabilidade e segurança.'
        },
    ]

    return (
        <React.Fragment >
            <div className={style.smsSection4}>
                <h1>Benefícios</h1>
                <div className={style.section4GridBenefits}>
                    {benefitsArray.map(benefits=>(
                        <div key={benefits.id} className={style.benefitsContent}>
                            <h4>{benefits.text}</h4>
                        </div>
                    ))}
                </div>
            </div>
        </React.Fragment>
    );
}

export default Section4;