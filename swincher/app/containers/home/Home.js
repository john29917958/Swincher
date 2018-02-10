import React, { Component } from 'react';

export default class Home extends Component {
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
          <input type="text" name="shortcut" placeholder="Shortcut keys" />
        </div>
      </form>
    );
  }
}