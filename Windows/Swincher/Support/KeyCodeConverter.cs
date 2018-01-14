using System;
using System.Windows.Forms;
using Swincher.Core;

namespace Swincher.Support
{
    static class KeyCodeConverter
    {
        public static SKeys Convert(Keys key)
        {
            if (key == Keys.ControlKey || key == Keys.Control || key == Keys.LControlKey || key == Keys.RControlKey)
            {
                return SKeys.Control;
            }

            if (key == Keys.Alt || key == Keys.Menu || key == Keys.LMenu || key == Keys.RMenu)
            {
                return SKeys.Alt;
            }

            if (key == Keys.Shift || key == Keys.ShiftKey || key == Keys.LShiftKey || key == Keys.RShiftKey)
            {
                return SKeys.Shift;
            }

            return (SKeys) Enum.Parse(typeof(SKeys), key.ToString());
        }
    }
}
