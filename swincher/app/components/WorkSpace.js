'use strict';

import React, { Component } from 'react';
import PropTypes from 'prop-types';
import AppShortcuts from './shortcut/AppShortcuts';
import NavigationBar from './NavigationBar';

class WorkSpace extends Component {
  render() {
    return (
      <div>
        <AppShortcuts appShortcuts={this.props.appShortcuts} actions={this.props.actions} />
      </div>
    );
  }
}

WorkSpace.propTypes = {
  appShortcuts: PropTypes.array.isRequired,
  actions: PropTypes.object.isRequired
};

export default WorkSpace;