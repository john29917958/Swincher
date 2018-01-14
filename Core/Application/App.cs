using System.Diagnostics;

namespace Swincher.Core.Application
{
    public abstract class App
    {
        public Process Process { get; protected set; }

        public abstract bool BringToFront();
    }
}
