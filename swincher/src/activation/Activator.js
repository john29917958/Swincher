'use strict';

const { globalShortcut } = require('electron').remote;
import path from 'path';
import { exec, execFile } from 'child_process';
import ps from 'ps-node';
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
  
  ps.lookup({
    command: processName
  }, function (err, list) {
    if (err) {
      throw new Error(err);
    }
    
    if (!list || list.length === 0) {
      // Windows support only now...
      let command = 'cmd.exe /C start "" /d "{0}" "{1}"';
      command = command.replace('{0}', programDir).replace('{1}', processName);
      exec(command, function (err, stdout, stderr) {
        if (err) {
          throw new Error(err);
        }
      });
    }
    else {
      execFile('dependencies\\WinWindowBringer.exe', [list[0].pid], function (error, stdout, stderr) {
        throw new Error(err);
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
