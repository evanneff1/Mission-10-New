import React from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';

import './App.css';
import Header from './Header';
import BowlerList from './Bowlers/BowlerList';

function App() {
  return (
    <div className="App">
      <Header />
      <br></br>
      <BowlerList />
    </div>
  );
}

export default App;
