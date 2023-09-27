import React from 'react';
import { Image, Carousel } from 'react-bootstrap';

const Carrossel = ({ imgArray }) => {
    return (
        <React.Fragment>
            <Carousel>
                {imgArray.map((imgs) => (
                    <Carousel.Item key={imgs.src}>
                        <Image src={imgs.src} alt={imgs.alt} />
                    </Carousel.Item>
                ))}
            </Carousel>
        </React.Fragment>
    );
}

export default Carrossel;