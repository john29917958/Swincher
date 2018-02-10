import React, { Component } from 'react';

export default class NavigationBar extends Component {
  render() {
    return (
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
    );
  }
}
