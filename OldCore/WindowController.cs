using System.Collections.Generic;

namespace Switcher.Core
{
    public class WindowController
    {
        public Dictionary<Window, Keys[]> Map { get; protected set; }

        public WindowController()
        {
            Map = new Dictionary<Window, Keys[]>();
        }

        public void Register(Window window, Keys[] keys)
        {
            if (Map.ContainsKey(window))
            {
                Map.Remove(window);
            }

            Map.Add(window, keys);
        }

        public bool Focus(Keys[] keys)
        {
            foreach (KeyValuePair<Window, Keys[]> pair in Map)
            {
                Window window = pair.Key;
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
