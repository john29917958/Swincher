'use strict';

import React, { Component } from 'react';
import Shortcut from './Shortcut';

export default class AppShortcut extends Component {
  render() {
    return (
      <form className="row">
        <div className="file-field input-field col s6">
          <div className="btn">
            <i className="material-icons">folder</i>
            <input type="file" />
          </div>
          <div className="file-path-wrapper">
            <input className="file-path validate" type="text" placeholder="Program executable path" />
          </div>
        </div>
        
        <div className="input-field col s6">
          <Shortcut />
        </div>
      </form>
    );
  }
}
