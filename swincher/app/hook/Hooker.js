'use strict';

const { globalShortcut } = require('electron').remote;
const ps = require('ps-node');
import keycode from 'keycode';

function getShortcutString(shortcut) {
  var shortcutString = '';

  if (shortcut.ctrlKey) {
    shortcutString += 'CommandOrControl+';
  }

  if (shortcut.shiftKey) {
    shortcutString += 'Shift+';
  }

  if (shortcut.altKey) {
    shortcutString += 'Alt+';
  }

  if (shortcut.metaKey) {
    shortcutString += 'Super+';
  }

  if (shortcut.keyCode !== -1) {
    shortcutString += keycode(shortcut.keyCode) + '+';
  }

  if (shortcutString === '') {
    return '';
  }

  shortcutString = shortcutString.substring(0, shortcutString.length - 1);

  return shortcutString;
}

function bringToFront(programPath) {
  var processName = '';

  processName = programPath.split('\\');
  processName = processName.length > 0 ? processName[processName.length - 1] : processName;

  ps.lookup({
    command: processName
  }, function (err, list) {
    var process;

    if (err) {
      throw new Error(err);
    }
    
    if (list.length === 0) {
      return;
    }

    process = list[0];
    if (process) {
      console.log(process.pid, process.command, process.arguments);
    }
  });
}

const Hooker = {
  hook: function (appShortcuts) {
    appShortcuts.forEach(function (appShortcut) {
      var shortcut = getShortcutString(appShortcut.shortcut);
      
      if (shortcut) {
        globalShortcut.register(shortcut, function () {
          bringToFront(appShortcut.path);
        });
      }
    });
  },

  unhook: function (appShortcuts = null) {
    if (appShortcuts) {
      appShortcuts.forEach(function (appShortcut) {
        var shortcut = getShortcutString(appShortcut.shortcut);

        if (shortcut) {
          globalShortcut.unregister(shortcut);
        }
      });
    }
    else {
      globalShortcut.unregisterAll();
    }
  }
}

export default Hooker;
