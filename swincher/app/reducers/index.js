'use strict';

import { combineReducers } from 'redux';
import pageReducer from './pageReducer';
import activationReducer from './activationReducer';
import appShortcutsReducer from './appShortcutsReducer';

const rootReducer = combineReducers({
  page: pageReducer,
  activation: activationReducer,
  appShortcuts: appShortcutsReducer
});

export default rootReducer;
