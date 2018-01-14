using System.Collections.Generic;

namespace Swincher.Core
{
    public class AppsController
    {
        public Dictionary<App, SKeys[]> Map { get; protected set; }

        public AppsController()
        {
            Map = new Dictionary<App, SKeys[]>();
        }

        public void Register(App window, SKeys[] keys)
        {
            if (Map.ContainsKey(window))
            {
                Map.Remove(window);
            }

            Map.Add(window, keys);
        }

        public bool Focus(SKeys[] keys)
        {
            foreach (KeyValuePair<App, SKeys[]> pair in Map)
            {
                App window = pair.Key;
                List<SKeys> keySignals = new List<SKeys>(pair.Value);

                foreach (SKeys key in keys)
                {
                    if (!keySignals.Contains(key))
                    {
                        return false;
                    }

                    keySignals.Remove(key);

                    if (keySignals.Count == 0)
                    {
                        // Key combination is correct.
                        return window.BringToFront();
                    }
                }
            }

            return false;
        }
    }
}
