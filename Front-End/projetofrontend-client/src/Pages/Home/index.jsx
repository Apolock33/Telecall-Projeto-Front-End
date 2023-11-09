import React, { useState } from 'react';
import Menu from '../../components/menu';
import Sidebar from '../../components/sidebar';
import { verifyLogin } from '../../Services/cookiesServices';

const Home = () => {
    const [openSideBar, setOpenSideBar] = useState(false);

    var loginVerificado = localStorage.getItem('islogged');

    verifyLogin(loginVerificado);

    return (
        <React.Fragment>
            <Menu hasSideBar={true} onClick={() => setOpenSideBar(!openSideBar)} />
            <Sidebar
                show={openSideBar}
                close={() => setOpenSideBar(!openSideBar)}>
            </Sidebar>
            <h1>home</h1>
        </React.Fragment>
    );
}

export default Home;