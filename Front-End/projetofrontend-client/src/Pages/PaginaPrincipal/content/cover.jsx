import React from 'react';
import style from '../../../assets/css/paginaprincipal.module.css';
import { Button } from 'react-bootstrap';
import { Link } from 'react-router-dom';
import { FiChevronRight } from 'react-icons/fi';

const Cover = () => {
    return (
        <React.Fragment>
            <div className={style.cover}>
                <div className={style.textCover}>
                    <h1>CPaaS</h1>
                    <p>
                        Saiba mais sobre nossos serviços através <br />desta página informativa
                    </p>
                    <Button variant='light'>
                        <Link to={'#section1'}>
                            Saiba Mais
                        </Link>
                        <FiChevronRight size={25} className={style.icon}/>
                    </Button>
                </div>
                <div className={style.coverImg}>
                </div>
            </div>
        </React.Fragment>
    );
}

export default Cover;