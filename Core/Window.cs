﻿using System.Diagnostics;

namespace Swincher.Core
{
    public abstract class Window
    {
        public Process Process { get; protected set; }

        public abstract bool BringToFront();
    }
}
