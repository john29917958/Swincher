'use strict';

import { SWITCH_PAGE } from '../constants/ActionTypes';
import * as Pages from '../constants/Pages';

const initialState = Pages.HOME_PAGE;

export default function page(state = initialState, action) {
  switch (action.type) {
    case SWITCH_PAGE:
      return action.page;
    default:
      return state;
  }
}
