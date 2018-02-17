'use strict';

import { combineReducers } from 'redux';
import appShortcutsReducer from './appShortcutsReducer';
import pageReducer from './pageReducer';

const rootReducer = combineReducers({
  appShortcuts: appShortcutsReducer,
  page: pageReducer
});

export default rootReducer;
