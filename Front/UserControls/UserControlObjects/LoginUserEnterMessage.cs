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
    public partial class LoginUserEnterMessage : UserControl
    {
        public LoginUserEnterMessage()
        {
            InitializeComponent();
        }

        public string Message {
            get { return lblMessage.Text; } set { lblMessage.Text = value; }
        }

        private void LoginUserEnterMessage_Resize(object sender, EventArgs e)
        {
            lblMessage.Font = new Font(lblMessage.Font.FontFamily, Height / 9, lblMessage.Font.Style);
        }
    }
}
