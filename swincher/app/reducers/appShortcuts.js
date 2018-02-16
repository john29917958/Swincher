'use strict';

import { ADD_APP_SHORTCUT, UPDATE_APP_SHORTCUT, DELETE_APP_SHORTCUT } from '../constants/AppShortcutActionTypes';
import AppShortcut from '../data/shortcut/AppShortcut';

const initialState = [];

export default function appShortcuts(state = initialState, action) {
  switch (action.type) {
    case ADD_APP_SHORTCUT:
      let id = state.reduce(function (maxId, appShortcuts) {
        Math.max(appShortcuts.id, maxId)
      }, -1) + 1;

      return state.set(id, new AppShortcut({
        id,
        path: action.path,
        shortcut: action.shortcut
      }));
    case UPDATE_APP_SHORTCUT:
      return state.setIn([action.id, 'path', 'shortcut'], action.path, action.shortcut);
    case DELETE_APP_SHORTCUT:
      return state.delete(action.id);
    default:
      return state;
  }
}
