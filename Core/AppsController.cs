using System.Collections.Generic;

namespace Swincher.Core
{
    public class AppsController
    {
        public Dictionary<App, KeyCode[]> Map { get; protected set; }

        public AppsController()
        {
            Map = new Dictionary<App, KeyCode[]>();
        }

        public void Register(App window, KeyCode[] keys)
        {
            if (Map.ContainsKey(window))
            {
                Map.Remove(window);
            }

            Map.Add(window, keys);
        }

        public bool Focus(KeyCode[] keys)
        {
            foreach (KeyValuePair<App, KeyCode[]> pair in Map)
            {
                App window = pair.Key;
                List<KeyCode> keySignals = new List<KeyCode>(pair.Value);

                foreach (KeyCode key in keys)
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
