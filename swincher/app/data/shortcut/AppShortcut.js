'use strict';

import Immutable from 'immutable';

const AppShortcut = Immutable.Record({
  id: '',
  path: '',
  shortcut: {
    shiftKey: false,
    altKey: false,
    ctrlKey: false,
    metaKey: false, // Win or Command key
    keyCode: -1
  }
});

export default AppShortcut;
