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
                        <Image src={modavoCover} width={500} />
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
                <div className={style.sectionTitle}>
                    <h1>Autenticação de 2 Fatores (2FA)</h1>
                </div>
                <div className={style.sectionDisplay}>
                    <div className={style.tfaFSec}>
                        <div>
                            <h3>Fortaleça a estratégia de segurança<br /> de seu negócio.</h3>
                        </div>
                        <div>
                            <ul>
                                <li><strong>100%</strong> dos bots automatizados</li>
                                <li><strong>99%</strong> dos ataques de phishing em massa</li>
                                <li><strong>66%</strong> dos ataques direcionados.</li>
                            </ul>
                        </div>
                    </div>
                    <div className={style.tfaSSec}>
                        <div>
                            <h3>Benefícios</h3>
                        </div>
                        <div>
                            <ul>
                                <li>Ofereça segurança aprimorada para seus clientes.</li>
                                <li>Reduza casos de fraude e invasões e evite o acesso a dados por invasores.</li>
                                <li>Envio de OTP por meio de vários canais, incluindo SMS, voz ou e-mail.</li>
                                <li>Flexibilidade de canais garante que o usuário conseguirá completar a tarefa desejada mesmo quando tiver problema com um deles. Exemplo: Enviar OTP por SMS, em caso de falha, enviar OTP por chamada de voz, em caso de outra falha, enviar por e-mail.</li>
                                <li>API simples e de rápida implementação.</li>
                                <li>Plataforma intuitiva que permite visualizar relatórios de uso por dia, mês ou ano e pesquisar usando diversos critérios de filtro.</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </section>
            <section id='numeroMascara' className={style.numeroMascara}>
                <div className={style.sectionTitleNM}>
                    <h1>Número Máscara</h1>
                </div>
                <div className={style.sectionDisplayNM}>
                    <div className={style.nMFSec}>
                        <h3>Proteja identidades profissionais</h3>
                        <p>Garanta aos seus clientes a capacidade de fazer chamadas e enviar mensagens sem expor seus números de telefone pessoais.</p>
                        <ul>
                            <li><strong>Mascare</strong> um número de telefone para interações com mais privacidade.</li>
                            <li><strong>Permite</strong> que empresas façam negócios usando menos números de telefone.</li>
                            <li><strong>Oferece</strong> uma experiência mais segura e profissional.</li>
                        </ul>
                    </div>
                    <div className={style.nMSSec}>
                        <h3>Quem mais pode usar?</h3>
                        <h5>43% das empresas brasileiras adotou o Home Office como padrão.</h5>
                        <h5>Mesmo após o fim da pandemia, estatísticas indicam que o modelo de trabalho Home Office deve crescer cerca de 30%.</h5>
                        <p>
                            Funcionários que não possuem celular empresarial ou ramal virtual podem se beneficiar do uso de um número máscara permanente do trabalho vinculado ao seu telefone celular, assim protegendo seus número pessoais.
                        </p>
                    </div>
                </div>
                <div className={style.nMTSec}>
                    <div className={style.nMTSecContent}>
                        <h3>Recursos Avançados</h3>
                        <ul>
                            <li><strong>SMS –</strong> Número máscara é totalmente funcional para chamadas de voz e SMS.</li>
                            <li><strong>Geo Match –</strong>  Combine o código do país do número mascarado com o da chamada de origem passando pro cliente a impressão de que vocês estão na mesma região.</li>
                            <li><strong>Gestão de Sessões –</strong> Habilite números máscara permanentes, bloqueie chamadas indesejadas, validade de sessão e etc.</li>
                            <li><strong>Relatórios –</strong>  Acesso direto do cliente à relatórios detalhados.</li>
                            <li><strong>Números Simultâneos -</strong> Use o mesmo número máscara em várias ligações simultâneas.</li>
                            <li><strong>Triagem de Conteúdo –</strong> Recurso SMS onde você pode sinalizar conteúdos sensíveis para proteger dados do cliente.</li>
                            <li><strong>Escalabilidade Ilimitada –</strong> compre e adicione números conforme necessário.</li>
                        </ul>
                    </div>
                </div>
            </section>
        </React.Fragment>
    );
}

export default ConteudoModavo;