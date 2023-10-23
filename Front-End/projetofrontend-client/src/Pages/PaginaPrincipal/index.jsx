import React from 'react';
import Menu from '../../components/Menu'
import Footer from '../../components/Footer'
import Section from './section';
import Cover from './content/cover';
import Section1 from './content/section1';
import Section2 from './content/section2';
import Section3 from './content/section3';

const PaginaPrincipal = () => {

    return (
        <React.Fragment>
            <Menu />
            <Section id={'cover'}>
                <Cover />
            </Section>
            <Section id={'section1'}>
                <Section1 />
            </Section>
            <Section id={'section2'}>
                <Section2 />
            </Section>
            <Section id={'section3'}>
                <Section3 />
            </Section>
            <Section id={'section4'} children={Cover} />
            <Footer />
        </React.Fragment>
    );
}

export default PaginaPrincipal;