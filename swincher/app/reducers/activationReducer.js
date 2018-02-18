'use strict';

import { ACTIVATE, DEACTIVATE } from '../constants/ActionTypes';

const initialState = DEACTIVATE;

export default function shortcutHook(state = initialState, action) {
  switch (action.type) {
    case ACTIVATE:
      return ACTIVATE;
    case DEACTIVATE:
      return DEACTIVATE;
    default:
      return state;
  }
}
