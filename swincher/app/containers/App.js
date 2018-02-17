'use strict';

import React, { Component } from 'react';
import PropTypes from 'prop-types';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import NavigationBar from '../components/NavigationBar';
import WorkSpace from '../components/WorkSpace';
import * as AppShortcutActions from '../actions/AppShortcutActions';
import * as PageActions from '../actions/PageActions';

class App extends Component {
  render() {
    return (
      <div>
        <NavigationBar page={ this.props.page } actions={ this.props.pageActions } />
        <div className='container'>
          <WorkSpace page={ this.props.page } appShortcuts={ this.props.appShortcuts } actions={ this.props.appShortcutActions } />
        </div>
      </div>
    );
  }
}

App.propTypes = {
  appShortcuts: PropTypes.array.isRequired,
  appShortcutActions: PropTypes.object.isRequired,
  page: PropTypes.string.isRequired,
  pageActions: PropTypes.object.isRequired
};

const mapStateToProps = function (state) {
  return {
    appShortcuts: state.appShortcuts,
    page: state.page
  };
}

const mapDispatchToProps = function (dispatch) {
  return {
    appShortcutActions: bindActionCreators(AppShortcutActions, dispatch),
    pageActions: bindActionCreators(PageActions, dispatch)
  };  
}

export default connect(mapStateToProps, mapDispatchToProps)(App);
