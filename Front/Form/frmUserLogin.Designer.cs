namespace Front.Form
{
    partial class frmUserLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUserActual = new System.Windows.Forms.Label();
            this.lblNewUser = new System.Windows.Forms.Label();
            this.lblCreateNewUser = new System.Windows.Forms.Label();
            this.controlBox1 = new Front.UserControls.ControlBox();
            this.lgcNewUser = new Front.LoginControlEnter();
            this.lgcLogin = new Front.LoginControlEnter();
            this.lgcActualUser = new Front.Form.LoginControl();
            this.SuspendLayout();
            // 
            // lblUserActual
            // 
            this.lblUserActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserActual.AutoSize = true;
            this.lblUserActual.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserActual.Location = new System.Drawing.Point(911, 222);
            this.lblUserActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserActual.Name = "lblUserActual";
            this.lblUserActual.Size = new System.Drawing.Size(258, 37);
            this.lblUserActual.TabIndex = 5;
            this.lblUserActual.Text = "Manter usuário atual";
            this.lblUserActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNewUser
            // 
            this.lblNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUser.Location = new System.Drawing.Point(400, 222);
            this.lblNewUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(301, 37);
            this.lblNewUser.TabIndex = 4;
            this.lblNewUser.Text = "Entrar com novo usuário";
            this.lblNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCreateNewUser
            // 
            this.lblCreateNewUser.AutoSize = true;
            this.lblCreateNewUser.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateNewUser.Location = new System.Drawing.Point(130, 222);
            this.lblCreateNewUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateNewUser.Name = "lblCreateNewUser";
            this.lblCreateNewUser.Size = new System.Drawing.Size(229, 37);
            this.lblCreateNewUser.TabIndex = 3;
            this.lblCreateNewUser.Text = "Criar novo usuário";
            this.lblCreateNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // controlBox1
            // 
            this.controlBox1.BackColor = System.Drawing.Color.White;
            this.controlBox1.ForeColor = System.Drawing.Color.Black;
            this.controlBox1.Location = new System.Drawing.Point(0, 0);
            this.controlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.controlBox1.Name = "controlBox1";
            this.controlBox1.Size = new System.Drawing.Size(1250, 25);
            this.controlBox1.TabIndex = 6;
            // 
            // lgcNewUser
            // 
            this.lgcNewUser.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.lgcNewUser.BackColor = System.Drawing.Color.Transparent;
            this.lgcNewUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lgcNewUser.ForeColor = System.Drawing.Color.White;
            this.lgcNewUser.Location = new System.Drawing.Point(48, 263);
            this.lgcNewUser.Margin = new System.Windows.Forms.Padding(4);
            this.lgcNewUser.Message = "Clique para criar nova conta";
            this.lgcNewUser.Name = "lgcNewUser";
            this.lgcNewUser.Padding = new System.Windows.Forms.Padding(13);
            this.lgcNewUser.Size = new System.Drawing.Size(311, 137);
            this.lgcNewUser.TabIndex = 0;
            // 
            // lgcLogin
            // 
            this.lgcLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lgcLogin.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.lgcLogin.BackColor = System.Drawing.Color.Transparent;
            this.lgcLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lgcLogin.ForeColor = System.Drawing.Color.White;
            this.lgcLogin.Location = new System.Drawing.Point(390, 263);
            this.lgcLogin.Margin = new System.Windows.Forms.Padding(4);
            this.lgcLogin.Message = "Clique para sair da conta atual e acessar com outra";
            this.lgcLogin.Name = "lgcLogin";
            this.lgcLogin.Padding = new System.Windows.Forms.Padding(13);
            this.lgcLogin.Size = new System.Drawing.Size(311, 137);
            this.lgcLogin.TabIndex = 1;
            // 
            // lgcActualUser
            // 
            this.lgcActualUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lgcActualUser.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.lgcActualUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lgcActualUser.ForeColor = System.Drawing.Color.White;
            this.lgcActualUser.Location = new System.Drawing.Point(858, 263);
            this.lgcActualUser.Margin = new System.Windows.Forms.Padding(4);
            this.lgcActualUser.Name = "lgcActualUser";
            this.lgcActualUser.Padding = new System.Windows.Forms.Padding(13);
            this.lgcActualUser.Size = new System.Drawing.Size(311, 137);
            this.lgcActualUser.TabIndex = 2;
            // 
            // frmUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1250, 565);
            this.Controls.Add(this.controlBox1);
            this.Controls.Add(this.lgcNewUser);
            this.Controls.Add(this.lgcLogin);
            this.Controls.Add(this.lblCreateNewUser);
            this.Controls.Add(this.lgcActualUser);
            this.Controls.Add(this.lblNewUser);
            this.Controls.Add(this.lblUserActual);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUserLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUserLogin_FormClosing);
            this.Shown += new System.EventHandler(this.frmUserLogin_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUserActual;
        private System.Windows.Forms.Label lblNewUser;
        private LoginControl lgcActualUser;
        private System.Windows.Forms.Label lblCreateNewUser;
        private LoginControlEnter lgcLogin;
        private LoginControlEnter lgcNewUser;
        private UserControls.ControlBox controlBox1;
    }
}