'use strict';

import * as types from '../constants/ActionTypes';

export const addAppShortcut = function (path, shortcut) {
  return {
    type: types.ADD_APP_SHORTCUT,
    path: path,
    shortcut: shortcut
  };
}

export const updateAppShortcut = function (id, path, shortcut) {
  return {
    type: types.UPDATE_APP_SHORTCUT,
    id: id,
    path: path,
    shortcut: shortcut
  };  
}

export const deleteAppShortcut = function (id) {
  return {
    type: types.DELETE_APP_SHORTCUT,
    id: id
  };
}
