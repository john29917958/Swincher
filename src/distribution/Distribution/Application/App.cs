using System.Diagnostics;

namespace Swincher.Distribution.Application
{
    public abstract class App
    {
        public Process Process { get; protected set; }

        public abstract bool BringToFront();
    }
}
