using System.Collections.Generic;

namespace Swincher.Core.Key
{
    public class KeyCombination
    {
        public bool Alt { get { return Keys.Contains(KeyCode.Alt); } }

        public bool Control { get { return Keys.Contains(KeyCode.Control); } }

        public List<KeyCode> Keys { get; protected set; }

        public bool Shift { get { return Keys.Contains(KeyCode.Shift); } }

        public KeyCombination()
        {
            Keys = new List<KeyCode>();
        }

        public KeyCombination(KeyCode[] keyCodes)
        {
            Keys = new List<KeyCode>(keyCodes);
        }

        public KeyCombination(List<KeyCode> keyCodes)
        {
            Keys = new List<KeyCode>(keyCodes);
        }

        public bool HasModifier()
        {
            return Keys.Contains(KeyCode.Alt) || Keys.Contains(KeyCode.Control) || Keys.Contains(KeyCode.Shift);
        }

        public bool HasNonModifier()
        {
            return Keys.Count > 0 && !IsModifier(Keys[Keys.Count - 1]);
        }

        public bool IsAlt(KeyCode key)
        {
            return key == KeyCode.Alt || key == KeyCode.Menu || key == KeyCode.LMenu || key == KeyCode.RMenu;
        }

        public bool IsControl(KeyCode key)
        {
            return key == KeyCode.ControlKey || key == KeyCode.Control || key == KeyCode.LControlKey ||
                   key == KeyCode.RControlKey;
        }

        public bool IsShift(KeyCode key)
        {
            return key == KeyCode.Shift || key == KeyCode.ShiftKey || key == KeyCode.LShiftKey ||
                   key == KeyCode.RShiftKey;
        }

        public bool IsModifier(KeyCode key)
        {
            return IsAlt(key) || IsControl(key) || IsShift(key);
        }

        public void Next(KeyCode key)
        {
            if (IsControl(key) && !Keys.Contains(KeyCode.Control))
            {
                Keys.Insert(0, KeyCode.Control);
            }

            if (IsAlt(key) && !Keys.Contains(KeyCode.Alt))
            {
                int index = 0;

                if (Control)
                {
                    index = Shift ? 2 : 1;
                }

                Keys.Insert(index, KeyCode.Alt);
            }

            if (IsShift(key) && !Keys.Contains(KeyCode.Shift))
            {
                int index = Control ? 1 : 0;
                Keys.Insert(index, KeyCode.Shift);
            }

            if (HasModifier() && !Keys.Contains(key))
            {
                if (!IsModifier(Keys[Keys.Count - 1]))
                {
                    Keys.RemoveAt(Keys.Count - 1);
                }

                Keys.Add(key);
            }
        }

        public void Remove(KeyCode key)
        {
            Keys.Remove(key);
        }

        public void Reset()
        {
            Keys.Clear();
        }

        public override string ToString()
        {
            if (Keys.Count == 0) return string.Empty;

            List<KeyCode> keys = new List<KeyCode>(Keys);
            string text = string.Empty;

            if (keys.Contains(KeyCode.Control))
            {
                text += KeyCode.Control + ", ";
                keys.Remove(KeyCode.Control);
            }

            if (keys.Contains(KeyCode.Shift))
            {
                text += KeyCode.Shift + ", ";
                keys.Remove(KeyCode.Shift);
            }

            if (keys.Contains(KeyCode.Alt))
            {
                text += KeyCode.Alt + ", ";
                keys.Remove(KeyCode.Alt);
            }

            foreach (KeyCode key in keys)
            {
                text += key + ", ";
            }

            text = text.Substring(0, text.Length - 2);

            return text;
        }
    }
}
