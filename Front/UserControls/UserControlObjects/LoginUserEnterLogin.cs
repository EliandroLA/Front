using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front.UserControls.UserControlObjects
{
    public partial class LoginUserEnterLogin : UserControl
    {
        public LoginUserEnterLogin()
        {
            InitializeComponent();
        }

        private void LoginUserEnterLogin_Resize(object sender, EventArgs e)
        {
            lblUser.Font = new Font(lblUser.Font.FontFamily, Height / 10, lblUser.Font.Style);
            lblPassword.Font = new Font(lblPassword.Font.FontFamily, Height / 10, lblPassword.Font.Style);
            tbxUser.Font = new Font(tbxUser.Font.FontFamily, Height / 11, tbxUser.Font.Style);
            tbxPassword.Font = new Font(tbxUser.Font.FontFamily, Height / 11, tbxUser.Font.Style);
        }
    }
}
