'use strict';

import React, { Component } from 'react';

export default class Shortcut extends Component {
  render() {
    return(
      <input type="text" name="shortcut" placeholder="Shortcut keys" />
    );
  }
}
