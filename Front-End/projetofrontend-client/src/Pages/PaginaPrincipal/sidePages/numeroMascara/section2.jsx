import React from 'react';
import Img1 from '../../../../assets/img/taxi.png';
import Img2 from '../../../../assets/img/chat.png';
import Img3 from '../../../../assets/img/shopping-cart.png';
import Img4 from '../../../../assets/img/express-delivery.png';
import style from '../../../../assets/css/numeromascara.module.css';


const whoUses = [
    {
        id: 1,
        img: Img1,
        title: 'Apps de Transporte',
        text: 'Permite que motorista e passageiro se comuniquem sem compartilhar seus números pessoais.',
        size:100
    },
    {
        id: 2,
        img: Img2,
        title: 'Apps de Relacionamento',
        text: 'Permite uma maneira privada e segura para usuários interagirem sem expor contatos pessoais.',
        size:100
    },
    {
        id: 3,
        img: Img3,
        title: 'E-Commerce',
        text: 'Permite que clientes entrem em contato através do aplicativo. Podem também integrar chamadas internacionais.',
        size:100
    },
    {
        id: 4,
        img: Img4,
        title: 'Entregas & Logística',
        text: 'Mantenha seu cliente informado sobre entregas e serviços, tire dúvidas, etc.',
        size:100
    },
]

const Section2 = () => {
    return (
        <React.Fragment>
            <div className={style.section2}>
                <h1>Quem Usa?</h1>
                <div className={style.section2DisplayContent}>
                    {whoUses.map((uses) => (
                        <div className={style.section2Content}>
                            <img src={uses.img} width={uses.size}/>
                            <h4>{uses.title}</h4>
                            <p>{uses.text}</p>
                        </div>
                    ))}
                </div>
            </div>
        </React.Fragment>
    );
}

export default Section2;