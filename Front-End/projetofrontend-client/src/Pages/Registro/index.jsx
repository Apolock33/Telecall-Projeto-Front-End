import React, { useState } from 'react';
import { Form, FormGroup, FormLabel, FormControl, Image, FormSelect } from 'react-bootstrap';
import { Link } from 'react-router-dom'
import style from '../../assets/css/registro.module.css'
import ButtonGeral from '../../components/ButtonGeral';
import api from '../../Services/api';
import imgLogo from '../../assets/img/Logo - Horizontal - Sem frase.png';
import InputMask from 'react-input-mask';
import { FiArrowRight } from 'react-icons/fi';

const Registro = () => {
    const [validated, setValidated] = useState(false);
    const [formRegistro, setFormRegistro] = useState({
        nome: '',
        sexo: '',
        documento: '',
        celular: '',
        fixo: '',
        dataNascimento: '',
        nomeMaterno: '',
        login: '',
        senha: ''
    });

    localStorage.setItem('login', '');
    localStorage.setItem('senha', '');
    localStorage.setItem('islogged', false);

    const handleChange = (e) => {
        const { name, value } = e.target
        setFormRegistro({
            ...formRegistro, [name]: value
        });
    }

    const handleSubmit = (e) => {
        const form = e.currentTarget;
        e.preventDefault();
        if (form.checkValidity() === false) {
            e.preventDefault();
            e.stopPropagation();
        } else {
            setValidated(true);
            if (validated) {
                api.post('/Usuario/Registrar', formRegistro)
                    .then(() => {
                        localStorage.setItem('login', formRegistro.login);
                        localStorage.setItem('senha', formRegistro.senha);
                        localStorage.setItem('islogged', true);
                        window.location.href = '/home'
                    }).catch((error) => {
                        console.log(error);
                    });
            }
        }
    }

    return (
        <React.Fragment>
            <section id='registro' className={style.registerFormContainer}>
                <div className={style.imgRegistroForm}>
                    <div className={style.formRegisterSection}>
                        <Form onSubmit={handleSubmit} className={style.formRegister}>
                            <Link to={'/'} className={style.imgForm}>
                                <Image src={imgLogo} width={400} />
                            </Link>
                            <FormGroup>
                                <FormLabel
                                    htmlFor={'nome'}>
                                    Nome
                                </FormLabel>
                                <FormControl
                                    size={'md'}
                                    required
                                    name={'nome'}
                                    id={'nome'}
                                    type='text'
                                    onChange={handleChange}
                                    isValid={(formRegistro.nome.length > 0 && (formRegistro.nome.length >= 15 && formRegistro.nome.length <= 60)) ? true : false}
                                    isInvalid={(formRegistro.nome.length > 0 && formRegistro.nome.length > 60) ? true : false} />
                                {(formRegistro.nome.length > 0 && formRegistro.nome.length < 15) ? <Form.Label style={{ marginTop: '1rem' }}>O campo nome deve ter ao menos 15 caracteres</Form.Label> : null}
                                <Form.Control.Feedback type="invalid">
                                    O campo nome só pode ter até 60 caracteres.
                                </Form.Control.Feedback>
                            </FormGroup>
                            <FormGroup>
                                <FormLabel htmlFor={'sexo'}>
                                    Sexo
                                </FormLabel>
                                <FormSelect
                                    onChange={handleChange}
                                    size={'md'}
                                    required
                                    name={'sexo'}
                                    id={'sexo'}>
                                    <option>Selecione...</option>
                                    <option value='M'>Masculino</option>
                                    <option value='F'>Feminino</option>
                                </FormSelect>
                            </FormGroup>
                            <FormGroup>
                                <FormLabel
                                    htmlFor={'documento'}>
                                    Documento
                                </FormLabel>
                                <InputMask
                                    className='form-control'
                                    mask={'999.999.999-99'}
                                    required
                                    name={'documento'}
                                    id={'documento'}
                                    type='text'
                                    onChange={handleChange} />
                            </FormGroup>
                            <FormGroup>
                                <FormLabel
                                    htmlFor={'celular'}>
                                    Celular
                                </FormLabel>
                                <InputMask
                                    className='form-control'
                                    mask={'(99) 99999-9999'}
                                    size={'md'}
                                    required
                                    name={'celular'}
                                    id={'celular'}
                                    type='text'
                                    onChange={handleChange} />
                            </FormGroup>
                            <FormGroup>
                                <FormLabel
                                    htmlFor={'fixo'}>
                                    Fixo
                                </FormLabel>
                                <InputMask
                                    className='form-control'
                                    mask={'(99) 9999-9999'}
                                    required
                                    name={'fixo'}
                                    id={'fixo'}
                                    type='text'
                                    onChange={handleChange} />
                            </FormGroup>
                            <FormGroup>
                                <FormLabel
                                    htmlFor={'dataNascimento'}>
                                    Data de Nascimento
                                </FormLabel>
                                <FormControl
                                    size={'md'}
                                    required
                                    name={'dataNascimento'}
                                    id={'dataNascimento'}
                                    type='date'
                                    onChange={handleChange} />
                            </FormGroup>
                            <FormGroup>
                                <FormLabel
                                    htmlFor={'nomeMaterno'}>
                                    Nome Materno
                                </FormLabel>
                                <FormControl
                                    size={'md'}
                                    required
                                    name={'nomeMaterno'}
                                    id={'nomeMaterno'}
                                    type='text'
                                    onChange={handleChange} />
                            </FormGroup>
                            <FormGroup>
                                <FormLabel
                                    htmlFor={'logIn'}>
                                    Log In
                                </FormLabel>
                                <FormControl
                                    maxLength={6}
                                    size={'md'}
                                    required
                                    name={'login'}
                                    id={'logIn'}
                                    type='text'
                                    onChange={handleChange}
                                    isValid={(formRegistro.login.length == 6) ? true : false} />
                            </FormGroup>
                            <FormGroup className={style.password}>
                                <FormLabel htmlFor={'senha'}>
                                    Senha
                                </FormLabel>
                                <FormControl
                                    size={'md'}
                                    required
                                    name={'senha'}
                                    id={'senha'}
                                    type='password'
                                    onChange={handleChange}
                                    isValid={(formRegistro.senha.length > 0 && formRegistro.senha.length >= 8) ? true : false}
                                    isInvalid={(formRegistro.senha.length > 0 && formRegistro.senha.length < 8) ? true : false} />
                                <Form.Control.Feedback type="invalid">
                                    A senha deve conter:
                                    <ul>
                                        <li>Ao menos 8 Caracteres</li>
                                        <li>Ao menos 8 Caracteres Alfabéticos</li>
                                        <li>Numeros</li>
                                        <li>Letras Maíusculas</li>
                                        <li>Símbolos</li>
                                    </ul>
                                </Form.Control.Feedback>
                            </FormGroup>
                            <FormGroup className={style.password}>
                                <FormLabel htmlFor={'senha'}>
                                    Confirmação de Senha
                                </FormLabel>
                                <FormControl
                                    size={'md'}
                                    required
                                    id={'senhaConfirm'}
                                    type='password' />
                                <Form.Control.Feedback type="invalid">
                                    A senha deve coincidir com a confirmação
                                </Form.Control.Feedback>
                            </FormGroup>
                            <FormGroup className={style.submit}>
                                <ButtonGeral
                                    type={'submit'}
                                    variant={'primary'}
                                    className={style.ButtonGeral}>
                                    <FiArrowRight
                                        size={30}
                                        className={style.submitIcon} />
                                </ButtonGeral>
                                <p>Já possui cadastro? <Link to={'/login'}>Clique Aqui</Link>
                                </p>
                            </FormGroup>
                        </Form>
                    </div>
                </div>
            </section>
        </React.Fragment>
    );
}

export default Registro;