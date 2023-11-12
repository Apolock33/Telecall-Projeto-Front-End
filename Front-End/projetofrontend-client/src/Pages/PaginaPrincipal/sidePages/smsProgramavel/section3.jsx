import React from 'react';
import style from '../../../../assets/css/sms.module.css';
import { Image } from 'react-bootstrap';
import ImgSection3 from '../../../../assets/img/campanha-sms-em-massa.png'

const Section2 = () => {
    return (
        <React.Fragment>
            <section className={style.smsSection3}>
                <h1>Como Funciona?</h1>
                <div className={style.section3Content}>
                    <Image src={ImgSection3} className={style.imgSection3} />
                    <div>
                        <p>Configure sua mensagem em minutos! Faça um cadastro, compre créditos e crie sua campanha.</p>
                        <p>Com a nossa solução, a gestão de campanhas de SMS atinge níveis superiores de eficiência com garantia de entrega, segurança e velocidade.</p>
                        <p>Não perca tempo, integre agora nossa API e comece a enviar mensagens de SMS.</p>
                    </div>
                </div>
            </section>
        </React.Fragment>
    );
}

export default Section2;