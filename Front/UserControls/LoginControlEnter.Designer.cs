namespace Front
{
    partial class LoginControlEnter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnMain = new System.Windows.Forms.Panel();
            this.lgcMessage = new Front.UserControls.UserControlObjects.LoginUserEnterMessage();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnMain.Controls.Add(this.lgcMessage);
            this.pnMain.Location = new System.Drawing.Point(12, 5);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(156, 100);
            this.pnMain.TabIndex = 7;
            // 
            // lgcMessage
            // 
            this.lgcMessage.BackColor = System.Drawing.Color.Transparent;
            this.lgcMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lgcMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lgcMessage.Location = new System.Drawing.Point(0, 0);
            this.lgcMessage.Margin = new System.Windows.Forms.Padding(4);
            this.lgcMessage.Message = "";
            this.lgcMessage.Name = "lgcMessage";
            this.lgcMessage.Size = new System.Drawing.Size(156, 100);
            this.lgcMessage.TabIndex = 0;
            // 
            // LoginControlEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnMain);
            this.Name = "LoginControlEnter";
            this.Padding = new System.Windows.Forms.Padding(13);
            this.Controls.SetChildIndex(this.pnMain, 0);
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMain;
        private UserControls.UserControlObjects.LoginUserEnterMessage lgcMessage;
    }
}
