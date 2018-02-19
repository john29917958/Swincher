'use strict';

import { combineReducers } from 'redux';
import pageReducer from './pageReducer';
import activationReducer from './activationReducer';
import appShortcutsReducer from './appShortcutsReducer';

// Combines reducers with the state specified by the key
// in given JSON object.
// state.page => pageReducer
// state.activation => activationReducer
// and so on...
const rootReducer = combineReducers({
  page: pageReducer,
  activation: activationReducer,
  appShortcuts: appShortcutsReducer
});

export default rootReducer;
