import React from 'react';
import { RouterProvider } from 'react-router-dom';
import Router from './Router';
import Body from './components/Body';

const App = () => {
  return (
    <React.Fragment>
      <Body>
        <RouterProvider router={Router} />
      </Body>
    </React.Fragment>
  );
}

export default App;