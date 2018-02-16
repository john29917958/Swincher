'use strict';

const AppShortcut = {
  id: '',
  
  path: '',
  
  shortcut: {
    shiftKey: false,
    altKey: false,
    ctrlKey: false,
    metaKey: false, // Win or Command key
    keyCode: -1
  },

  create: function (id, path, shortcut) {
    var newAppShortcut = Object.create(this);
    newAppShortcut.id = id;
    newAppShortcut.path = path;
    newAppShortcut.shortcut = shortcut;

    return newAppShortcut;
  }
};

export default AppShortcut;
