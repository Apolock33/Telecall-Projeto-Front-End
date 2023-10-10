import React, { useState } from 'react';
import { Form, FormGroup, FormLabel, FormControl, Image } from 'react-bootstrap';
import { Link } from 'react-router-dom'
import style from '../../assets/css/registro.module.css'
import ButtonGeral from '../../components/ButtonGeral';
import api from '../../Services/api';
import Menu from '../../components/Menu';
import imgLogo from '../../assets/img/Logo - Horizontal - Sem frase.png';
import { FiArrowRight } from 'react-icons/fi';

const Registro = () => {
    const [validated, setValidated] = useState(false);
    const [formRegistro, setFormRegistro] = useState({
        nome: '',
        sexo: '',
        documento: '',
        celular: '',
        fixo: '',
        nascimento: '',
        nomeMaterno: ''
    });

    const handleChange = (e) => {
        const { name, value } = e.target
        setFormRegistro({
            ...formRegistro, [name]: value
        });
    }

    const handleSubmit = (event) => {
        const form = event.currentTarget;
        console.log(form.checkValidity())
        event.preventDefault();
        if (form.checkValidity() === false) {
            event.preventDefault();
            event.stopPropagation();
        } else {
            setValidated(true);
            if (validated) {
                api.post('/Usuario/Registrar', formRegistro)
                    .then((response) => {
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
                            <div className={style.imgForm}>
                                <Image src={imgLogo} width={400} />
                            </div>
                            <FormGroup>
                                <FormLabel
                                    htmlFor={'nome'}>
                                    Nome
                                </FormLabel>
                                <FormControl
                                    required
                                    name={'nome'}
                                    id={'nome'}
                                    type='text'
                                    onChange={handleChange}
                                    isValid={(formRegistro.nome.length > 0 && (formRegistro.nome.length >= 15 && formRegistro.nome.length <= 60)) ? true : false}
                                    isInvalid={(formRegistro.nome.length > 0 && formRegistro.nome.length > 60) ? true : false}  />
                            </FormGroup>
                            <FormGroup>
                                <FormLabel htmlFor={'sexo'}>
                                    Sexo
                                </FormLabel>
                                <FormControl
                                    required
                                    name={'sexo'}
                                    id={'sexo'}
                                    type='text'
                                    onChange={handleChange} />
                            </FormGroup>
                            <FormGroup>
                                <FormLabel
                                    htmlFor={'documento'}>
                                    Documento
                                </FormLabel>
                                <FormControl
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
                                <FormControl
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
                                <FormControl
                                    required
                                    name={'fixo'}
                                    id={'fixo'}
                                    type='text'
                                    onChange={handleChange} />
                            </FormGroup>
                            <FormGroup>
                                <FormLabel
                                    htmlFor={'nascimento'}>
                                    Data de Nascimento
                                </FormLabel>
                                <FormControl
                                    required
                                    name={'nascimento'}
                                    id={'nascimento'}
                                    type='date'
                                    onChange={handleChange} />
                            </FormGroup>
                            <FormGroup>
                                <FormLabel
                                    htmlFor={'nomeMaterno'}>
                                    Nome Materno
                                </FormLabel>
                                <FormControl
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
                                    required
                                    name={'login'}
                                    id={'logIn'}
                                    type='text'
                                    onChange={handleChange} />
                            </FormGroup>
                            <FormGroup className={style.password}>
                                <FormLabel htmlFor={'senha'}>
                                    Senha
                                </FormLabel>
                                <FormControl
                                    required
                                    name={'senha'}
                                    id={'senha'}
                                    type='password'
                                    onChange={handleChange} />
                            </FormGroup>
                            <FormGroup className={style.submit}>
                                <ButtonGeral
                                    type={'submit'}
                                    variant={'primary'}
                                    className={style.ButtonGeral}>
                                    <FiArrowRight
                                        size={50}
                                        className={style.submitIcon} />
                                </ButtonGeral>
                                <p>Já possui cadastro?
                                    <Link to={'/login'}> Clique Aqui</Link>
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