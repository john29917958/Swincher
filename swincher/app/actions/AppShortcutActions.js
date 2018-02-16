'use strict';

import *  as types from '../constants/AppShortcutActionTypes';

export const addAppShortcut = function (path, shortcut) {
  type: ADD_APP_SHORTCUT, shortcut
}

export const updateAppShortcut = function (id, path, shortcut) {
  type: UPDATE_APP_SHORTCUT, id, path, shortcut
}

export const deleteAppShortcut = function (id) {
  type: DELETE_APP_SHORTCUT, id
}
