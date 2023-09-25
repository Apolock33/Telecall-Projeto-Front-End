import React from 'react';
import { RouterProvider } from 'react-router-dom';
import Router from './Router';
import Menu from './components/Menu';

const App = () => {
  return (
    <React.Fragment>
      <Menu />
      <RouterProvider router={Router} />
    </React.Fragment>
  );
}

export default App;