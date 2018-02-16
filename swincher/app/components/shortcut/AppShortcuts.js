'use strict';

import React, { Component } from 'react';
import AppShortcut from './AppShortcut';

export default class AppShortcuts extends Component {
  render() {
    var self = this,
        appShortcutItems = this.props.appShortcuts.map(function (appShortcut) {
          return (
            <AppShortcut key={appShortcut.id} create={false} id={appShortcut.id} path={appShortcut.path} shortcut={appShortcut.shortcut} actions={self.props.actions} />
          );
        });

    return (
      <div>
        <AppShortcut create={true} actions={this.props.actions} />
        {appShortcutItems}
      </div>
    );
  }
}
