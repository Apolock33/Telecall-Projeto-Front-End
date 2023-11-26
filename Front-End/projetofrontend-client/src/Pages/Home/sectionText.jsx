import React, { useState } from 'react';
import style from '../../assets/css/home.module.css';

const SectionText = () => {
    const [title, setTitle] = useState(2)
    const [paragraph, setParagraph] = useState(1.2);

    function increasefontsize() {
        setParagraph(prevSize => prevSize + 0.1);
        setTitle(prevSize => prevSize + 0.1);
    }

    function decreasefontsize() {
        setParagraph(prevSize => prevSize - 0.1);
        setTitle(prevSize => prevSize - 0.1);
    }

    return (
        <section id='sectiontext' className={style.sectiontext}>
            <div>
                <button className='btn btn-primary mx-3' onClick={increasefontsize}>+</button>
                <button className='btn btn-primary mx-3' onClick={decreasefontsize}>-</button>
            </div>
            <h2 style={{ fontSize: `${title}rem` }}>Teste de Fonte Titulo</h2>
            <p style={{ fontSize: `${paragraph}rem` }}>Lorem ipsum dolor sit amet consectetur adipisicing elit. Totam mollitia laborum, cumque beatae placeat atque. Eveniet sint incidunt, repudiandae nisi quisquam, reiciendis dignissimos quia qui pariatur error rerum? Numquam, qui? Lorem ipsum dolor sit amet consectetur adipisicing elit. Repudiandae nobis excepturi officiis. Laudantium totam distinctio, iure modi rerum nemo ipsam ex similique eum iste, molestias repellendus veniam? Culpa, illum nemo! Lorem ipsum, dolor sit amet consectetur adipisicing elit. Incidunt praesentium quibusdam ad itaque optio veniam non facere veritatis deleniti, nesciunt laborum exercitationem nisi eius voluptatum tempore voluptates nam tempora repellendus.</p>
        </section>
    );
}

export default SectionText;