using System;
using System.Drawing;
using System.Windows.Forms;

namespace Front.UserControls
{
    public partial class LoginUserInherit : UserControl
    {
        private Action _onClick;

        public LoginUserInherit()
        {
            InitializeComponent();

            GotFocus += LoginUserInherit_GotFocus;
            LostFocus += LoginUserInherit_LostFocus;
        }

        private void LoginUserInherit_LostFocus(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }

        private void LoginUserInherit_GotFocus(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbUserImage_MouseEnter(object sender, System.EventArgs e)
        {
            pbUserImage.BackColor = Color.Thistle;
            //#FFD8BFD8
        }

        private void pbUserImage_MouseLeave(object sender, System.EventArgs e)
        {
            pbUserImage.BackColor = Color.Transparent;
        }

        public void SetActionOnClick(Action onClick)
        {
            _onClick = onClick;
        }

        private void pbUserImage_Click(object sender, System.EventArgs e)
        {
            if (_onClick != null)
                _onClick();
        }

        private void LoginUserInherit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                pbUserImage_Click(sender, new EventArgs());
            }
        }
    }
}
