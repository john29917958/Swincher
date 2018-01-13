using System.ComponentModel;

namespace Swincher.Core
{
    public class Binding
    {
        public string ApplicationPath { get; set; }
        public string Keys { get; set; }

        [Browsable(false)]
        public bool IsEmpty
        {
            get { return string.IsNullOrWhiteSpace(ApplicationPath) && string.IsNullOrWhiteSpace(Keys); }
        }
    }
}
