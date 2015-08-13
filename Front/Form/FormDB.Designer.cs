namespace Front.Form
{
    partial class FormDB
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lgcUser = new Front.Form.LoginControl();
            this.pnNavigatorMenu = new System.Windows.Forms.Panel();
            this.btnAux = new System.Windows.Forms.Button();
            this.ctbControlBox = new Front.UserControls.ControlBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pnTitle.SuspendLayout();
            this.pnNavigatorMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.Transparent;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(25, 178);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(981, 400);
            this.pnMain.TabIndex = 2;
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnTitle.Controls.Add(this.lblTitle);
            this.pnTitle.Controls.Add(this.lgcUser);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(25, 25);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(981, 106);
            this.pnTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(702, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tela Inicial";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lgcUser
            // 
            this.lgcUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.lgcUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lgcUser.ForeColor = System.Drawing.Color.White;
            this.lgcUser.Location = new System.Drawing.Point(702, 0);
            this.lgcUser.Margin = new System.Windows.Forms.Padding(4);
            this.lgcUser.Name = "lgcUser";
            this.lgcUser.Padding = new System.Windows.Forms.Padding(13);
            this.lgcUser.Size = new System.Drawing.Size(279, 106);
            this.lgcUser.TabIndex = 0;
            // 
            // pnNavigatorMenu
            // 
            this.pnNavigatorMenu.Controls.Add(this.button5);
            this.pnNavigatorMenu.Controls.Add(this.button4);
            this.pnNavigatorMenu.Controls.Add(this.button3);
            this.pnNavigatorMenu.Controls.Add(this.button2);
            this.pnNavigatorMenu.Controls.Add(this.button1);
            this.pnNavigatorMenu.Controls.Add(this.btnAux);
            this.pnNavigatorMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNavigatorMenu.Location = new System.Drawing.Point(25, 131);
            this.pnNavigatorMenu.Name = "pnNavigatorMenu";
            this.pnNavigatorMenu.Size = new System.Drawing.Size(981, 47);
            this.pnNavigatorMenu.TabIndex = 0;
            // 
            // btnAux
            // 
            this.btnAux.BackColor = System.Drawing.Color.Transparent;
            this.btnAux.FlatAppearance.BorderSize = 0;
            this.btnAux.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAux.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAux.ForeColor = System.Drawing.Color.White;
            this.btnAux.Location = new System.Drawing.Point(0, 0);
            this.btnAux.Name = "btnAux";
            this.btnAux.Size = new System.Drawing.Size(135, 47);
            this.btnAux.TabIndex = 0;
            this.btnAux.Text = "Bloco de Notas";
            this.btnAux.UseVisualStyleBackColor = false;
            this.btnAux.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctbControlBox
            // 
            this.ctbControlBox.BackColor = System.Drawing.Color.Black;
            this.ctbControlBox.Location = new System.Drawing.Point(0, 0);
            this.ctbControlBox.Margin = new System.Windows.Forms.Padding(4);
            this.ctbControlBox.Name = "ctbControlBox";
            this.ctbControlBox.Size = new System.Drawing.Size(1022, 25);
            this.ctbControlBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(137, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bloco de Notas";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(276, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Bloco de Notas";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(416, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Bloco de Notas";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(555, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 47);
            this.button4.TabIndex = 4;
            this.button4.Text = "Bloco de Notas";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(693, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 47);
            this.button5.TabIndex = 5;
            this.button5.Text = "Bloco de Notas";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // FormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1006, 578);
            this.Controls.Add(this.ctbControlBox);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnNavigatorMenu);
            this.Controls.Add(this.pnTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDB";
            this.Opacity = 0.97D;
            this.Padding = new System.Windows.Forms.Padding(25, 25, 0, 0);
            this.Text = "FormDB";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDB_FormClosing);
            this.Load += new System.EventHandler(this.FormDB_Load);
            this.Click += new System.EventHandler(this.FormDB_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormDB_MouseMove);
            this.pnTitle.ResumeLayout(false);
            this.pnNavigatorMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lblTitle;
        private LoginControl lgcUser;
        private System.Windows.Forms.Panel pnNavigatorMenu;
        private System.Windows.Forms.Button btnAux;
        private UserControls.ControlBox ctbControlBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel pnMain;
    }
}