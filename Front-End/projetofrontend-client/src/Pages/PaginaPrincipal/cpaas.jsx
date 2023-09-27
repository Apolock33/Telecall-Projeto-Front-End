import React from 'react';
import style from '../../assets/css/paginaprincipal.module.css'
import { Badge } from 'react-bootstrap';

const Cpaas = () => {
    return (
        <React.Fragment>
            <section className={style.cpaasExplain}>
                <div>
                    <Badge className={style.knowMore} bg={'primary'} pill>Saiba Mais</Badge>
                    <h2>
                        CPaaS (Communication <br />Platform  as a Service)
                    </h2>
                    <h3>
                        O que é?
                    </h3>
                    <p>
                        Plataforma de Comunicação como Serviço. É uma solução de software de comunicação que atua como uma base sobre a qual desenvolvedores podem integrar uma variedade de aplicativos. Métodos de comunicação típicos, como voz, chamadas de vídeo ou mensagens de texto SMS, podem ser incorporados em outros sistemas por meio de APIs que se conectam à plataforma CPaaS. Essas APIs permitem que as empresas expandam suas ofertas sem a necessidade de hardware ou software adicional.
                    </p>
                </div>
                <div className={style.cpaasDigitalExplanation}>
                    <h2>
                        CPaaS e a Transformação Digital
                    </h2>
                    <ul>
                        <li>
                            Expectativa de crescimento estimado de <br/><strong>$ 8,2 bilhões em 2021.</strong>
                        </li>
                        <li>
                        <strong>85%</strong> dos profissionais se conectam de maneira diferente com colegas e clientes do que faziam há apenas 5 anos.

                        </li>
                        <li>
                            As receitas de <strong>CPaaS</strong> estão crescendo mais de 40%ao ano.
                            CPaaS já ultrapassou o mercado de <strong>UCaaS (Unified Communication as a Service).</strong>
                        </li>
                        <li>
                            Marcas que estão em <strong>múltiplos canais</strong> melhoram a experiência do usuário e aumentam seus resultados.
                        </li>
                    </ul>
                </div>
            </section>
        </React.Fragment>
    );
}

export default Cpaas;