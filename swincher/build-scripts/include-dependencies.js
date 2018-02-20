'use strict';

const fs = require('fs-extra'),
    path = require('path');

module.exports = function (buildPath, electronVersion, platform, arch, callback) {
  if (platform === 'win32') {
    fs.copySync('./dependencies', path.join(buildPath, 'dependencies'));
  }
  
  if (callback && typeof callback === 'function') {
    callback();
  }
}
