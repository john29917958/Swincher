'use strict';

import * as types from '../constants/ActionTypes';

export const switchPage = function (page) {
  return {
    type: types.SWITCH_PAGE,
    page: page
  };
}
