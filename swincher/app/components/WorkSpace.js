'use strict';

import React, { Component } from 'react';
import PropTypes from 'prop-types';
import AppShortcuts from './shortcut/AppShortcuts';
import NavigationBar from './NavigationBar';

export default class WorkSpace extends Component {
  /*
  static propTypes = {
    appShortcuts: PropTypes.array.isRequired,
    actions: PropTypes.object.isRequired
  }
  */
  render() {
    return (
      <div>
        <AppShortcuts />
      </div>
    );
  }
}
