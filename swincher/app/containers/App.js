'use strict';

import React, { Component } from 'react';
import PropTypes from 'prop-types';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import NavigationBar from '../components/NavigationBar';
import WorkSpace from '../components/WorkSpace';
import * as AppShortcutActions from '../actions/AppShortcutActions';

class App extends Component {
  render() {
    return (
      <div>
        <NavigationBar />
        <WorkSpace appShortcuts={ this.props.appShortcuts } actions={ this.props.actions } />
      </div>
    );
  }
}

App.propTypes = {
  appShortcuts: PropTypes.array.isRequired,
  actions: PropTypes.object.isRequired
};

const mapStateToProps = function (state) {
  return {
    appShortcuts: state.appShortcuts
  };
}

const mapDispatchToProps = function (dispatch) {
  return {
    actions: bindActionCreators(AppShortcutActions, dispatch)
  };  
}

export default connect(mapStateToProps, mapDispatchToProps)(App);
