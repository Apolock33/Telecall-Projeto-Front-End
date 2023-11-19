import React from 'react';
import Menu from '../../../../components/menu';
import Footer from '../../../../components/footer';
import Section1 from './section1';
import Cover from './cover';
import Section2 from './section2';
import Section3 from './section3';

const GoogleVerifiedCalls = () => {
    return (
        <React.Fragment>
            <Menu />
            <Cover />
            <Section1 />
            <Section2 />
            <Section3 />
            <Footer />
        </React.Fragment>
    );
}

export default GoogleVerifiedCalls;