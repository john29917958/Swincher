'use strict';

import React, { Component } from 'react';
import { ACTIVATE, DEACTIVATE } from '../constants/ActionTypes';
import Theme from '../theme/Theme';

export default class Home extends Component {
  toggle() {
    switch (this.props.activation) {
      case ACTIVATE:
        this.props.actions.deActivate();
        break;
      case DEACTIVATE:
        this.props.actions.activate();
        break;
      default:
        break;
    }
  }

  render() {
    var headerClass, buttonClass, buttonText;

    switch (this.props.activation) {
      case ACTIVATE:
        headerClass = Theme.primaryText;
        buttonClass = Theme.defaultButton;
        buttonText = DEACTIVATE;
        break;
      case DEACTIVATE:
      default:
        headerClass = 'grey-text text-darken-2';
        buttonClass = Theme.primaryButton;
        buttonText = ACTIVATE;
        break;
    }

    return (
      <div id="home-page">
        <center>
          <h1 className={ headerClass }>Swincher</h1>
          <br />
          <button className={ buttonClass } type="button" onClick={ this.toggle.bind(this) }>
            { buttonText }
          </button>
        </center>
      </div>
    );
  }
}
