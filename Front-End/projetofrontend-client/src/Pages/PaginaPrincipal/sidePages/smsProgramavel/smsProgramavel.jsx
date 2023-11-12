import React from 'react';
import Menu from '../../../../components/menu';
import Cover from './cover';
import Section1 from './section1';
import Footer from '../../../../components/footer';
import Section2 from './section2';
import Section3 from './section3';
import Section4 from './section4';

const SmsProgramavel = () => {
    return (
        <React.Fragment>
            <Menu />
            <Cover />
            <Section1 />
            <Section2 />
            <Section3 />
            <Section4 />
            <Footer />
        </React.Fragment>
    );
}

export default SmsProgramavel;