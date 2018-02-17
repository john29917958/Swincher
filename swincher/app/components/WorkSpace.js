'use strict';

import React, { Component } from 'react';
import PropTypes from 'prop-types';
import * as Pages from '../constants/Pages';
import AppShortcuts from './shortcut/AppShortcuts';
import Home from './Home';

function getPage() {
  switch (this.props.page) {
    case Pages.HOME_PAGE:
      return (<Home />);
    case Pages.APP_SHORTCUT_PAGE:
      return (<AppShortcuts appShortcuts={this.props.appShortcuts} actions={this.props.actions} />);
    case Pages.CONFIG_PAGE:
      return null;
    default:
      return null;
  }
}

class WorkSpace extends Component {
  render() {
    return (
      <div>
        {getPage.apply(this)}
      </div>
    );
  }
}

WorkSpace.propTypes = {
  appShortcuts: PropTypes.array.isRequired,
  actions: PropTypes.object.isRequired,
  page: PropTypes.string.isRequired
};

export default WorkSpace;