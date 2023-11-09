import React from 'react';
import Laptop from '../../../../assets/img/laptop.png';
import Laptop2 from '../../../../assets/img/laptop2.png';
import Warning from '../../../../assets/img/warning.png';
import Pin from '../../../../assets/img/smartphone-pin.png';
import style from '../../../../assets/css/2fa.module.css';

const Section1 = () => {

    const stepsArray = [
        {
            id:1,
            img: Laptop,
            txt: 'O usuário acessa seu site ou aplicativo e digita a senha cadastrada para entrar em seu perfil ou completar uma transação.',
            size:150
        },
        {
            id:2,
            img: Warning,
            txt: 'A Telecall recebe a tentativa de login e solicita que o usuário insira seu número de telefone para autorizar o acesso.',
            size:120
        },
        {
            id:3,
            img: Pin,
            txt: 'Após inserir seu número, a Telecall envia para o usuário por SMS ou chamada de voz um código PIN de uso único.',
            size:70
        },
        {
            id:4,
            img: Laptop2,
            txt: 'O usuário insere o código no site ou aplicativo para concluir o processo de verificação.',
            size:150
        }
    ];

    return (
        <React.Fragment>
            <div className={style.stepsSection}>
                <h1>Como Funciona?</h1>
                <div className={style.stepsGrid}>
                    {stepsArray.map((steps)=>(
                        <div key={steps.id} className={style.steps}>
                            <img src={steps.img} width={steps.size}/>
                            <p>{steps.txt}</p>
                        </div>
                    ))}
                </div>
            </div>
        </React.Fragment>
    );
}

export default Section1;