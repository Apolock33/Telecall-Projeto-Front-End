import React from 'react';
import { Image } from 'react-bootstrap';
import imgCPAAS from '../../../assets/img/modavo-solucoes-cpaas.png'
import style from '../../../assets/css/paginaprincipal.module.css';

const Section1 = () => {
    return (
        <React.Fragment>
            <div className={style.section1Text}>
                <h1>
                    Plataforma de Comunicação
                    como Serviço
                </h1>
                <h3>
                    Communications Platform as a Service
                </h3>
                <p>
                    É uma solução de software de comunicação que atua como uma base sobre a qual desenvolvedores podem integrar uma variedade de aplicativos. Métodos de comunicação típicos, como voz, chamadas de vídeo ou mensagens de texto SMS, podem ser incorporados em outros sistemas por meio de APIs que se conectam à plataforma CPaaS. Essas APIs permitem que as empresas expandam suas ofertas sem a necessidade de hardware ou software adicional.
                </p>
                <Image src={imgCPAAS} width={400}/>
            </div>
        </React.Fragment>
    );
}

export default Section1;