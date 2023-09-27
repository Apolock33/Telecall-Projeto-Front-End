import React, { useState } from 'react';
import Menu from '../../components/Menu';
import Sidebar from '../../components/Sidebar';
import Carrossel from '../../components/Carrossel';
import imgCarrossel from '../../assets/img/../../assets/img/Celular_empresarial_Desktop.png'
import imgCarrossel2 from '../../assets/img/../../assets/img/PABX_Desktop.png'
import imgCarrossel3 from '../../assets/img/../../assets/img/Internet_Desktop1.png'
import Footer from '../../components/Footer';
import Cpaas from './cpaas';
import Servicos from './servicos';

const PaginaPrincipal = () => {
    const [bgColor, setBgColor] = useState('white');
    const [colorIcon, setColorIcon] = useState('#0C4B77');
    const [openMenu, setOpenMenu] = useState(false);

    const arrayImg = [
        {
            src: imgCarrossel,
            alt: ''
        },
        {
            src: imgCarrossel2,
            alt: ''
        },
        {
            src: imgCarrossel3,
            alt: ''
        }
    ]

    return (
        <React.Fragment>
            <Menu bgColor={bgColor} onClick={() => setOpenMenu(!openMenu)} colorIcon={colorIcon} hasSideBar={false}>
                <Carrossel imgArray={arrayImg} />
                <Cpaas />
                <hr/>
                <Servicos />
                <Footer />
            </Menu>
        </React.Fragment>
    );
}

export default PaginaPrincipal;