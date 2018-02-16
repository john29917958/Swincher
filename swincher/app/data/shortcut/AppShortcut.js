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
    this.id = id;
    this.path = path;
    this.shortcut = shortcut;

    return this;
  }
};

export default AppShortcut;
