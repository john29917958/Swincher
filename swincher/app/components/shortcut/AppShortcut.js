'use strict';

import React, { Component } from 'react';
import Shortcut from './Shortcut';

export default class AppShortcut extends Component {
  onChange(e) {
    if (this.props.create) {
      console.log('do nothing');
    }
    else {
      console.log('should update file path');
    }
  }

  render() {
    console.dir(this.props);
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
            <input type="file" defaultValue={this.props.path ? this.props.path : ''} onChange={this.onChange.bind(this)} />
          </div>
          <div className="file-path-wrapper">
            <input className="file-path validate" type="text" placeholder="Program" defaultValue={this.props.path ? programName : ''} />
          </div>
        </div>
        
        <div className="input-field col s6">
          <Shortcut shortcut={this.props.shortcut ? this.props.shortcut : ''} />
        </div>
      </form>
    );
  }
}
