import React from 'react';
import ScrollToTop from 'react-scroll-to-top';
import style from '../../assets/css/scroll-to-top.module.css';

const ButtonScrollTop = () => {
    return (
        <React.Fragment>
            <ScrollToTop className={style.scrollTop} color='#ffffff' style={{backgroundColor:'#0C4B77', borderRadius: '5rem', display:'flex',justifyContent:'center', alignItems:'center', padding: '0.5rem'}} smooth />
        </React.Fragment>
    );
}

export default ButtonScrollTop;