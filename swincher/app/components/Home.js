'use strict';

import React, { Component } from 'react';
import Theme from '../theme/Theme';

export default class Home extends Component {
  render() {
    return (
      <div>
        <center>
          <h1 className="blue-grey-text text-lighten-3">Swincher</h1>
          <br />
          <button className={Theme.primaryButton} type="button">Activate</button>
        </center>
      </div>
    );
  }
}
