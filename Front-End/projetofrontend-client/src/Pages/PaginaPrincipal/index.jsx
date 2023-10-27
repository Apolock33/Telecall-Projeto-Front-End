import React from 'react';
import Menu from '../../components/Menu'
import Footer from '../../components/Footer'
import Section from './section';
import Cover from './content/cover';
import Section1 from './content/section1';
import Section2 from './content/section2';
import Section3 from './content/section3';
import Section4 from './content/section4';

const PaginaPrincipal = () => {

    const content = [
        {
            id: 1,
            section: Cover,
            idsection: 'cover'
        },
        {
            id: 2,
            section: Section1,
            idsection: 'Section1'
        },
        {
            id: 3,
            section: Section2,
            idsection: 'Section2'
        },
        {
            id: 4,
            section: Section3,
            idsection: 'Section3'
        },
        {
            id: 5,
            section: Section4,
            idsection: 'Section4'
        }
    ]

    return (
        <React.Fragment>
            <Menu />
            {content.map(cont => (
                <Section key={cont.id} id={cont.idsection}>
                    <cont.section />
                </Section>
            ))}
            <Footer />
        </React.Fragment>
    );
}

export default PaginaPrincipal;