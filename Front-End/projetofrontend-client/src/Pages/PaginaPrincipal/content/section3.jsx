import React from 'react';
import style from '../../../assets/css/paginaprincipal.module.css';

const section3 = () => {

    const motives = [
        {
            id: 1,
            icon: '',
            title: '',
            description: ''
        },
        {
            id: 2,
            icon: '',
            title: '',
            description: ''
        },
        {
            id: 3,
            icon: '',
            title: '',
            description: ''
        },
        {
            id: 4,
            icon: '',
            title: '',
            description: ''
        }
    ];

    return (
        <React.Fragment>
            <div className={style.whyModavo}>
                <h1>Por que Modavo?</h1>
                <p>
                    Nossa plataforma conecta empresas e desenvolvedores em uma potente plataforma na nuvem, que possibilita a integração de canais de comunicação de maneira simples e descomplicada. Com as APIs Modavo você tem garantia de escalabilidade, flexibilidade, autenticação e segurança aprimoradas.
                </p>
                <div>
                    {motives.map((motive) => (
                        <div key={motive.id} className={style.motives}>
                            
                        </div>
                    ))}
                </div>
            </div>
        </React.Fragment>
    );
}

export default section3;