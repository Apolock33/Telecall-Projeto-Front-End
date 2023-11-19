import React from 'react';
import Menu from '../../../../components/menu';
import Footer from '../../../../components/footer';
import Cover from './cover';
import Section1 from './section1';
import Section2 from './section2';

const NumeroMascara = () => {
    return (
        <React.Fragment>
            <Menu />
            <Cover />
            <Section1 />
            <Section2 />
            <Footer />
        </React.Fragment>
    );
}

export default NumeroMascara;