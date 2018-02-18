'use strict';

import React, { Component } from 'react';
import PropTypes from 'prop-types';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import NavigationBar from '../components/NavigationBar';
import WorkSpace from '../components/WorkSpace';
import * as PageActions from '../actions/PageActions';
import * as ActivationActions from '../actions/ActivationActions';
import * as AppShortcutActions from '../actions/AppShortcutActions';

class App extends Component {
  render() {
    return (
      <div>
        <NavigationBar activation={ this.props.activation } page={ this.props.page } actions={ this.props.pageActions } />
        <div className='container'>
          <WorkSpace activation={ this.props.activation }
            page={ this.props.page }
            appShortcuts={ this.props.appShortcuts }
            activationActions={ this.props.activationActions }
            actions={ this.props.appShortcutActions } />
        </div>
      </div>
    );
  }
}

App.propTypes = {
  appShortcuts: PropTypes.array.isRequired,
  appShortcutActions: PropTypes.object.isRequired,
  page: PropTypes.string.isRequired,
  pageActions: PropTypes.object.isRequired,
  activation: PropTypes.string.isRequired,
  activationActions: PropTypes.object.isRequired
};

const mapStateToProps = function (state) {
  return {
    page: state.page,
    activation: state.activation,
    appShortcuts: state.appShortcuts
  };
}

const mapDispatchToProps = function (dispatch) {
  return {
    pageActions: bindActionCreators(PageActions, dispatch),
    activationActions: bindActionCreators(ActivationActions, dispatch),
    appShortcutActions: bindActionCreators(AppShortcutActions, dispatch)
  };
}

export default connect(mapStateToProps, mapDispatchToProps)(App);
