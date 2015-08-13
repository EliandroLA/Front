using System;
using System.Windows.Forms;
using Front.UserControls.UserControlObjects;
using Front.Trasitions;
using Front.UserControls;

namespace Front
{
    public partial class LoginControlEnter : LoginUserInherit
    {

        private bool _inLogin;

        public string Message { get { return lgcMessage != null ? lgcMessage.Message : ""; } set { if(lgcMessage != null) lgcMessage.Message = value; } }

        public LoginControlEnter()
        {
            InitializeComponent();
        }

        public void SetActionOnClickUser(Action onClick)
        {
            SetActionOnClick(onClick);
        }

        public void SetToLogin()
        {
            Animation.Animate(pnMain.Controls[0], Animation.Effect.Active, 200, 0);
            pnMain.Controls.Clear();

            var lgcLogin = new LoginUserEnterLogin();
            lgcLogin.Dock = DockStyle.Fill;
            pnMain.Controls.Add(lgcLogin);
            lgcLogin.Focus();
            lgcLogin.Select();
            _inLogin = true;
        }

        public void SetToCreate()
        {
            
        }
    }
}
