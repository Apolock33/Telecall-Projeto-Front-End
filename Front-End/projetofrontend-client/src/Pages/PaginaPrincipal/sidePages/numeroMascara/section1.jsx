import React from 'react';
import style from '../../../../assets/css/numeromascara.module.css'
import Img1 from '../../../../assets/img/number_masking1.png'
import Img2 from '../../../../assets/img/number_masking2.png'
import Img3 from '../../../../assets/img/number_masking3.png'

const Section1 = () => {
    const howItWorksArray = [
        {
            id: 1,
            img: Img1,
            text1: 'Usuário faz uma chamada através de um aplicativo.',
            text2: 'Ex.: usuário liga para o entregador ou motorista de taxi ou entra em contato com a central de atendimento.'
        },
        {
            id: 2,
            img: Img2,
            text1: 'Plataforma mascara o número original.',
            text2: 'A plataforma recebe a chamada e mascara o número antes de conectar o destinatário.'
        },
        {
            id: 3,
            img: Img3,
            text1: 'Ambas as partes são conectadas.',
            text2: 'A plataforma conecta ambas as partes mantendo a privacidade dos dois.'
        },
    ]
    return (
        <React.Fragment>
            <div className={style.section1}>
                <h1>Como Funciona?</h1>
                <div className={style.section1DisplayContent}>
                    {howItWorksArray.map((content) => (
                        <div key={content.id} className={style.section1Content}>
                            <p>{content.text1}</p>
                            <img src={content.img} />
                            <p>{content.text2}</p>
                        </div>
                    ))}
                </div>
            </div>
        </React.Fragment>
    );
}

export default Section1;