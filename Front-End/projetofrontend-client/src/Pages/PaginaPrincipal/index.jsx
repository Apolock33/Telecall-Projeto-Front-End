import React, { useState } from 'react';
import Menu from '../../components/Menu'
import Footer from '../../components/Footer'

const PaginaPrincipal = () => {
    const [bgColor, setBgColor] = useState('white');
    const [colorIcon, setColorIcon] = useState('#0C4B77');
    const [openMenu, setOpenMenu] = useState(false);

    return (
        <React.Fragment>
            <Menu/>
            <Footer/>
        </React.Fragment>
    );
}

export default PaginaPrincipal;