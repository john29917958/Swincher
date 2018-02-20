'use strict';

import React, { Component } from 'react';
import PropTypes from 'prop-types';
import AppShortcuts from './shortcut/AppShortcuts';
import Home from './Home';

class WorkSpace extends Component {
  render() {
    return (
      <div>
        <Home activation={ this.props.activation } actions={ this.props.activationActions } />
        <AppShortcuts appShortcuts={ this.props.appShortcuts } actions={ this.props.actions } />
        <div id="settings-page"></div>
        <div id="account-page"></div>
      </div>
    );
  }
}

WorkSpace.propTypes = {
  actions: PropTypes.object.isRequired,
  appShortcuts: PropTypes.array.isRequired
};

export default WorkSpace;