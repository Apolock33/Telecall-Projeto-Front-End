import React from 'react';
import { RouterProvider } from 'react-router-dom';
import Router from './Router';
import './assets/css/index.css';

const App = () => {
  return (
    <React.Fragment>
      <RouterProvider router={Router} />
    </React.Fragment>
  );
}

export default App;