using System.ComponentModel;
using Newtonsoft.Json;

namespace Swincher.Core.Application
{
    public class AppBinding
    {
        public string ApplicationPath { get; set; }
        public string Keys { get; set; }

        [Browsable(false)]
        [JsonIgnore]
        public bool IsEmpty
        {
            get { return string.IsNullOrWhiteSpace(ApplicationPath) && string.IsNullOrWhiteSpace(Keys); }
        }
    }
}
