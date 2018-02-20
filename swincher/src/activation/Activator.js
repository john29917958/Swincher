'use strict';

const { globalShortcut } = require('electron').remote;
import path from 'path';
import { exec, execFile } from 'child_process';
import find from 'find-process';
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
  var processName = path.basename(programPath),
      programDir = path.dirname(programPath);
  
  find('name', processName).then(function (list) {
    if (!list || list.length === 0) {
      // Windows support only now...
      let command = 'cmd.exe /C start "" /d "{0}" "{1}"';
      command = command.replace('{0}', programDir).replace('{1}', processName);
      exec(command, function (error, stdout, stderr) {
        if (error) {
          throw new Error(error);
        }
      });
    }
    else {
      execFile('dependencies\\WinWindowBringer.exe', [list[0].pid], function (error, stdout, stderr) {
        if (error) {
          throw new Error(error);
        }
      });
    }
  });
}

const Activator = {
  activate: function (appShortcuts) {
    appShortcuts.forEach(function (appShortcut) {
      var shortcut = getShortcutString(appShortcut.shortcut);
      
      if (shortcut) {
        globalShortcut.register(shortcut, function () {
          bringToFront(appShortcut.path);
        });
      }
    });
  },

  deactivate: function (appShortcuts = null) {
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

export default Activator;
