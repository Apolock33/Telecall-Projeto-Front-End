import React, { useState } from 'react';
import style from '../../assets/css/login.module.css';
import { Form, FormGroup, FormLabel, FormControl, Image } from 'react-bootstrap';
import imgLogo from '../../assets/img/Logo - Horizontal - Sem frase.png';
import { Link } from 'react-router-dom';
import ButtonGeral from '../../components/ButtonGeral';
import { Cookies } from 'react-cookie';
import api from '../../Services/api';

const LogIn = () => {
    let cookies = new Cookies();
    const [login, setLogin] = useState("");
    const [senha, setSenha] = useState("");
    let logged = false;

    cookies.set('logged', logged);

    const loginForm = (e) => {
        api.post(`/Usuario/LogIn?login=${login}&senha=${senha}`)
            .then(response => {
                cookies.set("login", login);
                cookies.set("senha", senha);
                cookies.set("token", response?.data?.token);
                cookies.set("logged", true);

                window.location.href = '/home';
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
                            <Image src={imgLogo} width={400} />
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
                            <FormGroup className={style.extras}>
                                <Form.Check
                                    type={'checkbox'}
                                    label={'Manter Log In'}
                                />
                                <Link>Esqueci Minha Senha</Link>
                            </FormGroup>
                            <FormGroup className={style.submit}>
                                <ButtonGeral
                                    type={'submit'}
                                    variant={'primary'} className={style.ButtonGeral} content={'Entrar'}
                                />
                            </FormGroup>
                        </Form>
                    </div>
                </div>
            </section>
        </React.Fragment >
    );
}

export default LogIn;