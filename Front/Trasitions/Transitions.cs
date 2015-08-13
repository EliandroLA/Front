using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Front.Trasitions
{
    public static class Animation
    {
        public enum Effect {
            Roll = 0,
            Slide = 0x40000,
            Center = 0x10,
            Blend = 0x80000,
            Hide = 0x00010000,
            Active = 0x00020000,
            HorPositive = 0x00000001,
            HorNegative = 0x00000002,
            VerPositive = 0x00000004,
            VerNegative = 0x00000008
        }
        public static void Animate(Control control, Effect effect, int milisec, int angle)
        {
            var flags = (int)effect;
            if (control.Visible) { flags |= 0x10000; angle += 180; }
            else
            {
                if (control.TopLevelControl == control) flags |= 0x20000;
                else if (effect == Effect.Blend) throw new ArgumentException();
            }
            flags |= dirmap[(angle % 360) / 45];
            bool ok = AnimateWindow(control.Handle, milisec, flags);
            if (!ok) throw new Exception("Animation failed");
            control.Visible = !control.Visible;
        }
        private static int[] dirmap = { 1, 5, 4, 6, 2, 10, 8, 9 };

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);
    }

}
