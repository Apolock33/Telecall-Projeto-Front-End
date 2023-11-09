import React, { useState } from 'react';
import style from '../../assets/css/login.module.css';
import { Form, FormGroup, FormLabel, FormControl, Image } from 'react-bootstrap';
import imgLogo from '../../assets/img/Logo - Horizontal - Sem frase.png';
import { Link } from 'react-router-dom';
import ButtonGeral from '../../components/buttonGeral';
import api from '../../Services/api';
import { useToastAlert } from '../../components/alerts';

const LogIn = () => {
    const [login, setLogin] = useState("");
    const [senha, setSenha] = useState("");
    localStorage.setItem("login", '');
    localStorage.setItem("senha", '');
    localStorage.setItem("islogged", false);

    const loginForm = (e) => {
        e.preventDefault();
        api.post(`/Usuario/LogIn?login=${login}&senha=${senha}`)
            .then((response) => {
                console.log(response);
                if (!response?.data?.success) {
                    useToastAlert({
                        texto: 'Informações de Log In erradas ou inexistentes.',
                        icon: 'error',
                        hasConfirmButton: false,
                        timer: 5000,
                        hasProgressBar: true
                    });
                } else {
                    localStorage.setItem("login", `${login}`);
                    localStorage.setItem("senha", senha);
                    localStorage.setItem("islogged", true);
                    window.location.href = '/home';
                }
            })
            .catch(error => {
                console.log(error);
            });
    }

    return (
        <React.Fragment>
            <section className={style.formSection}>
                <div className={style.imgFormLogin}>
                    <div className={style.formLogin}>
                        <Link to={'/'}>
                            <img src={imgLogo} className={style.imgSize} />
                        </Link>
                        <Form onSubmit={loginForm}>
                            <FormGroup className={style.login}>
                                <FormLabel htmlFor={'login'}>
                                    Log In
                                </FormLabel>
                                <FormControl id={'login'} type='text' value={login} onChange={(e) => setLogin(e.target.value)} />
                            </FormGroup>
                            <FormGroup className={style.password}>
                                <FormLabel htmlFor={'senha'}>
                                    Senha
                                </FormLabel>
                                <FormControl id={'senha'} type='password' value={senha} onChange={(e) => setSenha(e.target.value)} />
                            </FormGroup>
                            <FormGroup className={style.submit}>
                                <ButtonGeral
                                    type={'submit'}
                                    variant={'primary'} className={style.ButtonGeral} children={'Entrar'}
                                />
                                <p>Não possui cadastro?
                                    <Link to={'/registro'} > Clique Aqui</Link>
                                </p>
                            </FormGroup>
                        </Form>
                    </div>
                </div>
            </section>
        </React.Fragment >
    );
}

export default LogIn;