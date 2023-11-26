import React, { useState } from 'react';
import Menu from '../../components/menu';
import { verifyLogin } from '../../Services/cookiesServices';
import Cover from './cover';
import SectionText from './sectionText'

const Home = () => {
    var loginVerificado = localStorage.getItem('islogged');

    verifyLogin(loginVerificado);

    return (
        <React.Fragment>
            <Menu />
            <Cover/>
            <SectionText/>
        </React.Fragment>
    );
}

export default Home;