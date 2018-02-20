'use strict';

export const CONFIG_VERSION = '1.0.0';

export const DefaultConfig = {
  version: CONFIG_VERSION,
  appShortcuts: []
};

const ConfigManager = {
  upgrade: function(config) {
    // do nothing.
  }
};

export default ConfigManager;
