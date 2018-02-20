'use strict';

import React, { Component } from 'react';
import { remote } from 'electron';
import PropTypes from 'prop-types';
import { ACTIVATE, DEACTIVATE } from '../constants/ActionTypes';
import Theme from '../theme/Theme';

class NavigationBar extends Component {
  constructor(props) {
    super(props);
    this.state = {
      maximized: remote.getCurrentWindow().isMaximized()
    };
  }

  closeWindow() {
    remote.getCurrentWindow().close();
  }

  resizeWindow() {
    var window = remote.getCurrentWindow();

    if (window.isMaximized()) {
      window.unmaximize();
    }
    else {
      window.maximize();
    }

    this.setState({
      maximized: window.isMaximized()
    });
  }

  minimizeWindow() {
    remote.getCurrentWindow().minimize();
  }

  render() {
    var self = this,
        navbarClass = this.props.activation === ACTIVATE ? Theme.primary : 'grey darken-2',
        resizeButton = this.state.maximized ? (<i className="far fa-window-restore"></i>) : (<i className="material-icons">check_box_outline_blank</i>);

    return (
      <div id="title-bar" className="navbar-fixed">
        <nav className={ navbarClass + ' nav-extended' }>
          <div id="navbar-resizer"></div>
          <div className="nav-wrapper">
            <a className="brand-logo left">Swincher</a>
            <ul className="right">
              <li><a onClick={ this.minimizeWindow }><i className="material-icons">remove</i></a></li>
              <li id="resize-button"><a onClick={ this.resizeWindow.bind(self) }>{ resizeButton }</a></li>
              <li><a onClick={ this.closeWindow }><i className="material-icons">close</i></a></li>
            </ul>
          </div>
          <div className="nav-content">
            <ul className="tabs tabs-transparent left">
              <li className="tab"><a href="#home-page">Home</a></li>
              <li className="tab"><a href="#app-shortcuts-page">Shortcuts</a></li>
            </ul>
            <ul id="preferences" className="right">
              <li><a href="#settings-page"><i className="material-icons">settings</i></a></li>
              <li><a href="#account-page"><i className="material-icons">account_circle</i></a></li>
            </ul>
          </div>
        </nav>
      </div>
    );
  }
}

export default NavigationBar;