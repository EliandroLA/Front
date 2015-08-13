using Front.Trasitions;
using System;
using System.Windows.Forms;

namespace Front.Form
{
    public partial class frmUserLogin : System.Windows.Forms.Form
    {
        public frmUserLogin()
        {
            InitializeComponent();

            lgcActualUser.SetActionOnClickUser(new Action(() => Close()));

            lgcLogin.SetActionOnClickUser(new Action(() => { lgcLogin.SetToLogin(); lgcLogin.SetActionOnClick(new Action(() => Close())); }));
        }

        private void frmUserLogin_Shown(object sender, EventArgs e)
        {
            Visible = false;
            Animation.Animate(this, Animation.Effect.Active, 300, 0);
        }

        private void frmUserLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Animation.Animate(this, Animation.Effect.Active, 300, 0);
        }
    }
}
