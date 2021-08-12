using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ClickerGame
{
    class RoundedButton : Button
    {
        // Using WinApi
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr RoundButton(int nLeftRect, int nTopRect, int nRightRect, int nBottonRect, int nWidthEllipse, int nHeightEllipse);

        protected int nWidthEllipse = 15;
        protected int nHeightEllipse = 15;
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            IntPtr ptr = RoundButton(0, 0, Width, Height, this.nWidthEllipse, this.nHeightEllipse);
            Region = Region.FromHrgn(ptr);
        }
    }
}
