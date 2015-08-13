using System;
using System.Drawing;
using Front.UserControls;

namespace Front.Form
{
    public partial class LoginControl : LoginUserInherit
    {

        public LoginControl()
        {
            InitializeComponent();
        }

        private void LoginControl_Resize(object sender, EventArgs e)
        {
            lblUser.Font = new Font(lblUser.Font.FontFamily, Height / 9, lblUser.Font.Style);
            lblUser.Height = (int)Math.Floor((decimal)Height / 3);

            lblProfile.Font = new Font(lblProfile.Font.FontFamily, Height / 9, lblProfile.Font.Style);
            lblProfile.Height = (int)Math.Floor((decimal)Height / 3);
            lblProfile.Location = new Point(lblProfile.Location.X, lblUser.Location.Y + lblUser.Height);
        }

        public void SetActionOnClickUser(Action onClick)
        {
            SetActionOnClick(onClick);
        }

    }
}
