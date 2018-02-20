'use strict';

import React, { Component } from 'react';
import keycode from 'keycode';

var modifierNames = [
  'ctrl', 'alt', 'shift', 'left command'
];

function getKeyNames(keyData) {
  var keyNames = [];

  if (keyData.ctrlKey) {
    keyNames.push('ctrl');
  }

  if (keyData.shiftKey) {
    keyNames.push('shift');
  }

  if (keyData.altKey) {
    keyNames.push('alt');
  }

  if (keyData.metaKey) {
    keyNames.push('meta (win / command)');
  }

  if (keyData.keyCode !== -1) {
    keyNames.push(keycode(keyData.keyCode));
  }

  return keyNames.toString();
}

function getInitialState() {
  var keyData = this.props.shortcut ? this.props.shortcut : {
    shiftKey: false,
    altKey: false,
    ctrlKey: false,
    metaKey: false, // Win or Command key
    keyCode: -1
  };
  
  return {
    keyData: keyData,
    pressedKeys: [],
    keyNames: getKeyNames(keyData)
  };
}

function getUpdatedKeyData(e, keyData) {
  var pressedKeyName = keycode(e.keyCode);

  return {
    shiftKey: keyData.shiftKey || e.shiftKey,
    altKey: keyData.altKey || e.altKey,
    ctrlKey: keyData.ctrlKey || e.ctrlKey,
    metaKey: keyData.metaKey || e.metaKey,
    keyCode: pressedKeyName && !modifierNames.includes(pressedKeyName) ? e.keyCode : keyData.keyCode
  };
}

export default class Shortcut extends Component {
  constructor(props) {
    super(props);
    this.state = getInitialState.apply(this);
  }

  onKeyDown(e) {
    if (e.keyCode === 13) { // Enter
      this.props.action(this.state.keyData);
      this.setState(getInitialState.apply(this));
    }
    else if (e.keyCode === 27) { // Escape
      this.setState(getInitialState.apply(this));
    }
    else {
      var keyData = this.state.keyData,
          pressedKeys = this.state.pressedKeys;

      // If user released all keys and press again,
      // reset keyData to initial state.
      if (pressedKeys.length === 0) {
        keyData = getInitialState.apply(this).keyData;
      }

      if (!pressedKeys.includes(e.keyCode)) {
        pressedKeys.push(e.keyCode);
      }

      keyData = getUpdatedKeyData.call(this, e, keyData);

      this.setState({
        keyData: keyData,
        pressedKeys: pressedKeys,
        keyNames: getKeyNames(keyData)
      });
    }
  }

  onKeyUp(e) {
    var pressedKeys = this.state.pressedKeys,
        index = pressedKeys.indexOf(e.keyCode);
    
    if (index > -1) {
      pressedKeys.splice(index, 1);
    }
    
    this.setState({
      pressedKeys: pressedKeys
    });
  }

  updateShortcut() {
    if (!this.props.create) {
      this.props.action(this.state.keyData);
    }
  }

  dummyFunction(e) {
    // do nothing.
  }
  
  render() {
    return(
      <input type="text"
        name="shortcut"
        placeholder="Shortcut keys"
        value={ this.state.keyNames }
        onKeyDown={ this.onKeyDown.bind(this) }
        onKeyUp={ this.onKeyUp.bind(this) }
        onChange={ this.dummyFunction }
        onBlur={ this.updateShortcut.bind(this) } />
    );
  }
}
