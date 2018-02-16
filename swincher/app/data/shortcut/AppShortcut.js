'use strict';

const template = {
  id: '',
  
  path: '',
  
  shortcut: {
    shiftKey: false,
    altKey: false,
    ctrlKey: false,
    metaKey: false, // Win or Command key
    keyCode: -1
  }
};

const AppShortcut = {
  create: function (id, path, shortcut) {
    var newAppShortcut = Object.create(template);
    newAppShortcut.id = id;
    newAppShortcut.path = path;
    newAppShortcut.shortcut = shortcut;

    return newAppShortcut;
  }
};

export default AppShortcut;
