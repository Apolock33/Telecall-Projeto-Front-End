import React from 'react';
import style from '../../../../assets/css/sms.module.css';

const Section1 = () => {

    const contentArray = [
        {
            id: 1,
            percentage: '98%',
            text: 'de taxa de abertura'
        },
        {
            id: 2,
            percentage: '90%',
            text: 'dos SMS são lidos em até 3 minutos'
        },
        {
            id: 3,
            percentage: '80%',
            text: 'das pessoas interagem com SMS comerciais'
        },
        {
            id: 4,
            percentage: '35x',
            text: 'maior a probabilidade de um cliente abrir um SMS do que um e-mail.'
        },
    ]

    return (
        <React.Fragment>
            <div className={style.smsSection1}>
                <h3>SMS é a forma mais rápida, eficiente e de baixo custo para se comunicar com seus clientes.</h3>
                <div className={style.smsGridContent}>
                    {contentArray.map((content) => (
                        <div key={content.id} className={style.smsContent}>
                            <h1>{content.percentage}</h1>
                            <h4>{content.text}</h4>
                        </div>
                    ))}
                </div>
            </div>
        </React.Fragment>
    );
}

export default Section1;