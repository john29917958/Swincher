import React, { Component } from 'react';

export default class Home extends Component {
  render() {
    return (
      <div>
        <nav>
          <div className="nav-wrapper">
            <a href="#!" className="brand-logo center">Swincher</a>
            <ul className="right">
              <li><a className="disabled" href="#!">EN</a></li>
              <li><a href="#!"><i className="material-icons">settings</i></a></li>
              <li><a className="disabled" href="#!"><i className="material-icons">account_circle</i></a></li>
            </ul>
          </div>
        </nav>
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
      </div>
    );
  }
}