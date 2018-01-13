using System.Collections.Generic;

namespace Swincher.Core
{
    public class AppsController
    {
        public Dictionary<App, Keys[]> Map { get; protected set; }

        public AppsController()
        {
            Map = new Dictionary<App, Keys[]>();
        }

        public void Register(App window, Keys[] keys)
        {
            if (Map.ContainsKey(window))
            {
                Map.Remove(window);
            }

            Map.Add(window, keys);
        }

        public bool Focus(Keys[] keys)
        {
            foreach (KeyValuePair<App, Keys[]> pair in Map)
            {
                App window = pair.Key;
                List<Keys> keySignals = new List<Keys>(pair.Value);

                foreach (Keys key in keys)
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
