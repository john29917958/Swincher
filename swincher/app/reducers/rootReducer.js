'use strict';

import { combineReducers } from 'redux';
import appShortcuts from './appShortcuts';

const rootReducer = combineReducers({
  appShortcuts: appShortcuts
});

export default rootReducer;
