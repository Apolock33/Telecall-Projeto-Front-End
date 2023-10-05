import React from 'react';
import Menu from '../../components/Menu'
import Footer from '../../components/Footer'
import ConteudoModavo from './conteudoModavo';

const PaginaPrincipal = () => {

    return (
        <React.Fragment>
            <Menu />
            <ConteudoModavo/>
            <Footer />
        </React.Fragment>
    );
}

export default PaginaPrincipal;