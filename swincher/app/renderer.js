// This file is required by the index.html file and will
// be executed in the renderer process for that window.
// All of the Node.js APIs are available in this process.

window.$ = window.jQuery = require('jquery');
require('hammerjs');

import React from 'react';
import ReactDOM from 'react-dom';
//import Home from 'containers/home/Home';
import Home from './containers/home/Home';

ReactDOM.render(
  <Home />,
  document.getElementById('home')
);
