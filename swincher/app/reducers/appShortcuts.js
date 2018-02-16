'use strict';

import { ADD_APP_SHORTCUT, UPDATE_APP_SHORTCUT, DELETE_APP_SHORTCUT } from '../constants/AppShortcutActionTypes';
import AppShortcut from '../data/shortcut/AppShortcut';

const initialState = [];

export default function appShortcuts(state = initialState, action) {
  switch (action.type) {
    case ADD_APP_SHORTCUT:
      let id = state.reduce(function (maxId, appShortcuts) {
        return Math.max(appShortcuts.id, maxId);
      }, -1) + 1;
      
      state.push(
        {
          id: id,
          path: action.path,
          shortcut: action.shortcut  
        }
      );
      
      return state.slice(0, state.length);
    case UPDATE_APP_SHORTCUT:
      console.log("UPDATE!!");
      state.setIn([action.id, 'path', 'shortcut'], action.path, action.shortcut);
    case DELETE_APP_SHORTCUT:
      return state.delete(action.id);
    default:
      return state;
  }
}
