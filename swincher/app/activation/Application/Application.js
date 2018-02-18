'use strict';

import path from 'path';

const class Application {
  constructor(filePath) {
    var self = this;

    this.filePath = filePath;
    findProcess(this.fileName(), function (process) {
      self.process = process;
    });
  }

  get directory() {
    return path.dirname(this.filePath);
  }

  get fileName() {
    return path.basename(this.filePath);
  }

  findProcess(name, callback) {
    var self = this,
        process = null;

    ps.lookup({
      command: name
    }, function (err, list) {
      if (err) {
        throw new Error(err);
      }

      if (list && list.length > 0) {
        // Only support single app instance now.
        process = list[0];
      }

      if (callback && typeof callback === 'function') {
        callback.call(self, process);
      }
    });
  }

  tryAttatch(callback) {
    var self = this;

    if (this.process &&
        this.process.command === this.filePath) {
      if (callback && typeof callback === 'function') {
        callback.call(this, true);
        return;
      }
    }
    else {
      this.findProcess(function (process) {
        self.process = process;
        if (self.process) {
          if (callback && typeof callback === 'function') {
            callback.call(this, true);
          }
        }
        else {
          callback.call(this, false);
        }
      });
    }
  }
}

switch (process.platform) {
  case 'win32':
  default:
    Application.
}