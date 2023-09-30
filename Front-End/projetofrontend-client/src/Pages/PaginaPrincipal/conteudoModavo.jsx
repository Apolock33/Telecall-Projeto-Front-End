import React from 'react';
import style from '../../assets/css/paginaprincipal.module.css';
import { Button, Image } from 'react-bootstrap';
import imglogo from '../../assets/img/modavo-1.png';
import modavoCover from '../../assets/img/modavo-solucoes-cpaas.png';
import { IoIosArrowForward } from 'react-icons/io';
import { FaLock } from 'react-icons/fa';
import { FiCheck, FiSmartphone } from 'react-icons/fi';
import { TbMessageCircle2Filled } from 'react-icons/tb'

const ConteudoModavo = () => {

    const arraySolucoes = [
        {
            id: 1,
            icon: FaLock,
            text: '2FA',
            width: 100,
            color: '#ffffff'
        },
        {
            id: 2,
            icon: FiSmartphone,
            text: 'Números Máscara',
            width: 100,
            color: '#ffffff'
        },
        {
            id: 3,
            icon: FiCheck,
            text: 'Google Verified Calls',
            width: 100,
            color: '#ffffff'
        },
        {
            id: 4,
            icon: TbMessageCircle2Filled,
            text: 'SMS Programável',
            width: 100,
            color: '#ffffff'
        }
    ];

    const arraySectionsExplain = [
        {
            id: 1,
            nameId: '2FA',
            title: '2FA',
            subTitle: 'Fortaleça a estratégia de segurança de seu negócio.',
            paragraph: 'Adicionar um número de telefone de recuperação a uma conta individual pode bloquear até:'
        }
    ];

    return (
        <React.Fragment>
            <section id='intro'>
                <div className={style.displayCover}>
                    <div className={style.modavoLogo}>
                        <Image src={imglogo} width={250} className={style.imgLogoModavo} />
                        <div>
                            <h5>Plataforma de Comunicação como Serviço</h5>
                            <h6>Communications Platform as a Service</h6>
                            <p>
                                É uma solução de software de comunicação que atua
                                como uma base sobre a qual desenvolvedores podem
                                integrar uma variedade de aplicativos.
                                Métodos de comunicação típicos, como voz, chamadas
                                de vídeo ou mensagens de texto SMS, podem ser
                                incorporados em outros sistemas por meio de APIs que
                                se conectam à plataforma CPaaS.
                                Essas APIs permitem que as empresas expandam suas
                                ofertas sem a necessidade de hardware ou software
                                adicional.
                            </p>
                            <Button className={style.buttonKnowMore}>
                                Saiba Mais
                                <IoIosArrowForward className={style.arrow} />
                            </Button>
                        </div>
                    </div>
                    <div className={style.imgCover}>
                        <Image src={modavoCover} width={800} />
                    </div>
                </div>
            </section>
            <section id='solucoes' className={style.solucoesSection}>
                <div className={style.text}>
                    <h1>Soluções</h1>
                </div>
                <div className={style.iconsDisplay}>
                    {arraySolucoes.map((soluc) => (
                        <div key={soluc.id} className={style.iconsContainer}>
                            <div className={style.iconsBg}>
                                <soluc.icon size={soluc.width} color={soluc.color} />
                            </div>
                            <div>
                                <h4>{soluc.text}</h4>
                            </div>
                        </div>
                    ))}
                </div>
            </section>
            <section id='2FA' className={style.tfa}>
                <div>
                    <h1>2FA</h1>
                </div>
                <div>
                    <h3>Fortaleça a estratégia de segurança de seu negócio.</h3>
                </div>
                <div>
                    <ul>
                        <li><strong>100%</strong> dos bots automatizados</li>
                        <li><strong>99%</strong> dos ataques de phishing em massa</li>
                        <li><strong>66%</strong> dos ataques direcionados.</li>
                    </ul>
                </div>
            </section>
        </React.Fragment>
    );
}

export default ConteudoModavo;