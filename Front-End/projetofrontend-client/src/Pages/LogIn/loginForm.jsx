import React, { useState } from 'react';
import style from '../../assets/css/login.module.css';
import { Form, FormGroup, FormLabel, FormControl, Image } from 'react-bootstrap';
import imgLogo from '../../assets/img/Logo - Horizontal - Sem frase.png';
import { Link } from 'react-router-dom';
import ButtonGeral from '../../components/ButtonGeral';

const LoginForm = () => {
    const [login, setLogin] = useState("");
    const [senha, setSenha] = useState("");

    function logIn(e) {
        e.preventDefault();
        console.log({ login, senha });
    }

    return (
        <React.Fragment>
            <section className={style.formSection}>
                <div className={style.imgFormLogin}>
                    <div className={style.formLogin}>
                        <Link to={'/'}>
                            <Image src={imgLogo} width={400} />
                        </Link>
                        <Form onSubmit={logIn}>
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
                                    variant={'primary'} className={style.ButtonGeral} content={'Entrar'} />
                            </FormGroup>
                        </Form>
                    </div>
                </div>
            </section >
        </React.Fragment >
    );
}

export default LoginForm;