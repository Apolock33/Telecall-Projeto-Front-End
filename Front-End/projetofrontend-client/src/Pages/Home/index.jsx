import React, { useState } from 'react';
import Menu from '../../components/Menu';
import Sidebar from '../../components/Sidebar';
import { Nav } from 'react-bootstrap';
import { useCookies } from 'react-cookie';
import { verifyLogin } from '../../Services/cookiesServices';

const Home = () => {
    const [openSideBar, setOpenSideBar] = useState(false);

    return (
        <React.Fragment>
            <Menu hasSideBar={true} onClick={() => setOpenSideBar(!openSideBar)} />
            <Sidebar
                show={openSideBar}
                close={() => setOpenSideBar(!openSideBar)}>
                    <h1>Ola mundo</h1>
            </Sidebar>
        </React.Fragment>
    );
}

export default Home;