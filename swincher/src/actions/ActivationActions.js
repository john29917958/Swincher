'use strict';

import * as types from '../constants/ActionTypes';

export const activate = function () {
  return {
    type: types.ACTIVATE
  };
}

export const deActivate = function () {
  return {
    type: types.DEACTIVATE
  };
}
