import React from 'react';
import style from '../../../assets/css/paginaprincipal.module.css';
import Frame1 from '../../../assets/img/frame1.png';
import Frame2 from '../../../assets/img/frame2.png';
import Frame3 from '../../../assets/img/frame3.png';
import Frame4 from '../../../assets/img/frame4.png';
import { Image } from 'react-bootstrap';

const section3 = () => {

    const motives = [
        {
            id: 1,
            icon: Frame1,
            title: 'Fácil de usar',
            description: 'Experimente a facilidade de uso com nosso sistema otimizado, tornando sua experiência mais eficiente e produtiva.',
            size:150
        },
        {
            id: 2,
            icon: Frame2,
            title: 'Dashboard de Monitoramento',
            description: 'Tenha uma visão abrangente sobre cada serviço e seu uso, incluindo informações sobre mensagens entregues, não entregues, custos e respostas.',
            size:150
        },
        {
            id: 3,
            icon: Frame3,
            title: 'Segurança garantida',
            description: 'Protegemos seus dados e comunicações com medidas de segurança, garantindo a privacidade e a integridade das suas comunicações.',
            size:150
        },
        {
            id: 4,
            icon: Frame4,
            title: 'API MODAVO',
            description: 'Desenvolvimento descomplicado! Nossa documentação completa e fácil de entender permite uma integração suave e eficiente com qualquer linguagem programável.',
            size:150
        }
    ];

    return (
        <React.Fragment>
            <div className={style.whyModavo}>
                <div className={style.whyModavoDescr}>
                    <h1>Por que Modavo?</h1>
                    <p>
                        Nossa plataforma conecta empresas e desenvolvedores em uma potente plataforma na nuvem, que possibilita a integração de canais de comunicação de maneira simples e descomplicada. Com as APIs Modavo você tem garantia de escalabilidade, flexibilidade, autenticação e segurança aprimoradas.
                    </p>
                </div>
                <div className={style.motivesSection}>
                    {motives.map((motive) => (
                        <div key={motive.id} className={style.motives}>
                            <Image src={motive.icon} width={motive.size}/>
                            <div className={style.motivesText}>
                                <h4>{motive.title}</h4>
                                <p>{motive.description}</p>
                            </div>
                        </div>
                    ))}
                </div>
            </div>
        </React.Fragment>
    );
}

export default section3;