'use strict';

import React, { Component } from 'react';
import Shortcut from './Shortcut';

export default class AppShortcut extends Component {
  constructor(props) {
    super(props);
    this.state = {
      path: this.props.path ? this.props.path : ''
    };
  }

  onUpdateProgramPath(e) {
    if (this.props.create) {
      this.setState({ path: e.target.files[0].path });
    }
    else {
      this.props.actions.updateAppShortcut(this.props.id, e.target.files[0].path, this.props.shortcut);
    }
  }

  onSubmit(shortcut) {
    if (this.props.create) {
      this.props.actions.addAppShortcut(this.state.path, shortcut);
    }
    else {
      this.props.actions.updateAppShortcut(this.props.id, this.props.path, shortcut);
    }
  }

  render() {
    var programPath = this.props.path,
        programName = '';

    if (programPath) {
      programName = programPath.split('\\');
      programName = programName.length > 0 ? programName[programName.length - 1] : '';
    }

    return (
      <form className="row">
        <div className="file-field input-field col s6">
          <div className="btn">
            <i className="material-icons">folder</i>
            <input type="file" defaultValue={this.state.path} onChange={this.onUpdateProgramPath.bind(this)} />
          </div>
          <div className="file-path-wrapper">
            <input className="file-path validate" type="text" placeholder="Program" defaultValue={this.props.path ? programName : ''} />
          </div>
        </div>
        
        <div className="input-field col s6">
          <Shortcut id={this.props.id} create={this.props.create} shortcut={this.props.shortcut ? this.props.shortcut : ''} action={this.onSubmit.bind(this)} />
        </div>
      </form>
    );
  }
}
