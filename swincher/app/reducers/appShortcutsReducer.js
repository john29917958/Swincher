'use strict';

import { ADD_APP_SHORTCUT, UPDATE_APP_SHORTCUT, DELETE_APP_SHORTCUT } from '../constants/ActionTypes';
import AppShortcut from '../data/shortcut/AppShortcut';

const initialState = [];

export default function appShortcuts(state = initialState, action) {
  switch (action.type) {
    case ADD_APP_SHORTCUT:
      let id = state.reduce(function (maxId, appShortcuts) {
        return Math.max(appShortcuts.id, maxId);
      }, -1) + 1;

      state.push(AppShortcut.create(id, action.path, action.shortcut));

      return state.slice(0, state.length);
    case UPDATE_APP_SHORTCUT:
      return state.map(function (appShortcut) {
        if (appShortcut.id === action.id) {
          appShortcut.path = action.path;
          appShortcut.shortcut = action.shortcut;
        }

        return appShortcut;
      });
    case DELETE_APP_SHORTCUT:
      return state.filter(function (appShortcut) {
        return appShortcut.id !== action.id;
      });
    default:
      return state;
  }
}
