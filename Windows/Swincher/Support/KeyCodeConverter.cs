using System;
using System.Windows.Forms;
using Swincher.Core.Key;

namespace Swincher.Support
{
    static class KeyCodeConverter
    {
        public static KeyCode Convert(Keys key)
        {
            if (key == Keys.ControlKey || key == Keys.Control || key == Keys.LControlKey || key == Keys.RControlKey)
            {
                return KeyCode.Control;
            }

            if (key == Keys.Alt || key == Keys.Menu || key == Keys.LMenu || key == Keys.RMenu)
            {
                return KeyCode.Alt;
            }

            if (key == Keys.Shift || key == Keys.ShiftKey || key == Keys.LShiftKey || key == Keys.RShiftKey)
            {
                return KeyCode.Shift;
            }

            return (KeyCode) Enum.Parse(typeof(KeyCode), key.ToString());
        }
    }
}
