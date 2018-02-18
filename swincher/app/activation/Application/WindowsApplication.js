'use strict';

import Application from './Application';
import { exec } from 'child_process';

const class WindowsApplication extends Application {
  constructor(filePath) {
    super(filePath);
  }

  spawn(callback) {
    var self = this,
        command = 'cmd.exe /C start "" /d "{0}" "{1}"';

    command = command.replace('{0}', this.directory())
      .replace('{1}', this.fileName());

    this.tryAttatch(function (attatched) {
      if (attatched) {
        if (callback && typeof callback === 'function') {
          callback.call(self, self.process);
        }
      }
      else {
        exec(command, function (err, stdout, stderr) {
          if (err) {
            throw new Error(err);
          }

          if (callback && typeof callback === 'function') {
            callback.call(self, self.process);
          }
        });
      }
    });
  }

  bringToFront() {

  }
}
