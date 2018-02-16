'use strict';

import React, { Component } from 'react';

export default class Shortcut extends Component {
  onSubmit(e) {
    console.log('hi');
  }
  
  render() {
    return(
      <input type="text"
        name="shortcut"
        placeholder="Shortcut keys"
        defaultValue={this.props.shortcut ? this.props.shortcut : ''}
        onKeyDown={this.onSubmit.bind(this)} />
    );
  }
}
