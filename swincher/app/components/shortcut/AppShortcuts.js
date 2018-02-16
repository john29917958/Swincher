'use strict';

import React, { Component } from 'react';
import AppShortcut from './AppShortcut';

export default class AppShortcuts extends Component {
  render() {
    var appShortcutItems = this.props.appShortcuts.map(function (appShortcut) {
      return (
        <AppShortcut key={appShortcut.id} create={false} path={appShortcut.path} shortcut={appShortcut.shortcut} actions={appShortcut.actions} />
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
