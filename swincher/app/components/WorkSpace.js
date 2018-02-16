'use strict';

import React, { Component } from 'react';
import PropTypes from 'prop-types';
import AppShortcuts from './shortcut/AppShortcuts';
import NavigationBar from './NavigationBar';

class WorkSpace extends Component { 
  render() {
    return (
      <div>
        <AppShortcuts />
      </div>
    );
  }
}

WorkSpace.propTypes = {
  appShortcuts: PropTypes.array.isRequired,
  actions: PropTypes.object.isRequired
};

export default WorkSpace;