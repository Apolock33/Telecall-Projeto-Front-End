import React from 'react';
import { Image } from 'react-bootstrap';
import style from '../../assets/css/footer.module.css';
import logoFooter from '../../assets/img/Logo Telecall  - Horizontal  (Sem Frase) - Branca.png';
import { BsBehance, BsGithub, BsInstagram, BsLinkedin } from 'react-icons/bs';

const Footer = () => {
    return (
        <React.Fragment>
            <footer className={style.footerBg}>
                <Image src={logoFooter} width={150} />
                
                <div className={style.textContainer}>
                    <p className={style.textConfig}>Políticas de Privacidade</p>
                    <p className={style.textConfig}>Termos e Condições</p>
                    <p className={style.textConfig}>Desenhado e Desenvolvido por Carlos Alberto M M Gomes</p>
                </div>

                <div className={style.iconsConfig}>
                    <BsInstagram size={30} className={style.marginIcon} />
                    <BsGithub size={30} className={style.marginIcon} />
                    <BsBehance size={30} className={style.marginIcon} />
                    <BsLinkedin size={30} className={style.marginIcon} />
                </div>
            </footer>
        </React.Fragment>
    );
}

export default Footer;