'use strict';

const config = new (require('electron-config'))();
import { ADD_APP_SHORTCUT, UPDATE_APP_SHORTCUT, DELETE_APP_SHORTCUT, ACTIVATE, DEACTIVATE } from '../constants/ActionTypes';
import AppShortcut from '../data/shortcut/AppShortcut';
import * as ConfigEntries from '../constants/ConfigEntries';
import Hooker from '../hook/Hooker';

const initialState = config.has(ConfigEntries.APP_SHORTCUT) ? config.get(ConfigEntries.APP_SHORTCUT) : [];

export default function appShortcuts(state = initialState, action) {
  switch (action.type) {
    case ADD_APP_SHORTCUT:
      let id = state.reduce(function (maxId, appShortcuts) {
        return Math.max(appShortcuts.id, maxId);
      }, -1) + 1;

      state.push(AppShortcut.create(id, action.path, action.shortcut));
      config.set(ConfigEntries.APP_SHORTCUT, state);

      return state.slice(0, state.length);
    case UPDATE_APP_SHORTCUT:
      state = state.map(function (appShortcut) {
        if (appShortcut.id === action.id) {
          appShortcut.path = action.path;
          appShortcut.shortcut = action.shortcut;
        }

        return appShortcut;
      });

      config.set(ConfigEntries.APP_SHORTCUT, state);

      return state;
    case DELETE_APP_SHORTCUT:
      state = state.filter(function (appShortcut) {
        return appShortcut.id !== action.id;
      });

      config.set(ConfigEntries.APP_SHORTCUT, state);

      return state;
    case ACTIVATE:
      Hooker.hook(state);
      return state;
    case DEACTIVATE:
      Hooker.unhook();
      return state;
    default:
      return state;
  }
}
