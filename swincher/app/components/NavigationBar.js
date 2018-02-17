'use strict';

import React, { Component } from 'react';
import PropTypes from 'prop-types';
import * as Pages from '../constants/Pages';

class NavigationBar extends Component {
  onSwitchPage(page) {
    this.props.actions.switchPage(page);
  }

  render() {
    var activePage = {
      homePage: this.props.page === Pages.HOME_PAGE ? 'active' : '',
      shortcutsPage: this.props.page === Pages.APP_SHORTCUT_PAGE ? 'active' : '',
      configPage: this.props.page === Pages.CONFIG_PAGE ? 'active' : ''
    };

    return (
      <nav>
        <div className="container">
          <div className="nav-wrapper">
            <a href="#!" className="brand-logo left" onClick={this.onSwitchPage.bind(this, Pages.HOME_PAGE)}>Swincher</a>
            <ul className="right">
              <li className={activePage.shortcutsPage}><a href="#!" onClick={this.onSwitchPage.bind(this, Pages.APP_SHORTCUT_PAGE)}>Shortcuts</a></li>
              <li className={activePage.configPage}><a href="#!" onClick={this.onSwitchPage.bind(this, Pages.CONFIG_PAGE)}><i className="material-icons">settings</i></a></li>
              <li><a className="disabled" href="#!"><i className="material-icons">account_circle</i></a></li>
            </ul>
          </div>
        </div>
      </nav>
    );
  }
}

NavigationBar.propTypes = {
  page: PropTypes.string.isRequired,
  actions: PropTypes.object.isRequired
};

export default NavigationBar;