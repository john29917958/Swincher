using System.Diagnostics;

namespace Switcher.Core
{
    public abstract class Window
    {
        public Process Process { get; protected set; }

        public abstract bool BringToFront();
    }
}
