namespace Front.UserControls
{
    partial class LoginUserInherit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUserInherit));
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbUserImage
            // 
            this.pbUserImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUserImage.BackColor = System.Drawing.Color.Transparent;
            this.pbUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUserImage.Image = ((System.Drawing.Image)(resources.GetObject("pbUserImage.Image")));
            this.pbUserImage.Location = new System.Drawing.Point(171, 4);
            this.pbUserImage.Margin = new System.Windows.Forms.Padding(5);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.Padding = new System.Windows.Forms.Padding(13);
            this.pbUserImage.Size = new System.Drawing.Size(100, 100);
            this.pbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserImage.TabIndex = 7;
            this.pbUserImage.TabStop = false;
            this.pbUserImage.Click += new System.EventHandler(this.pbUserImage_Click);
            this.pbUserImage.MouseEnter += new System.EventHandler(this.pbUserImage_MouseEnter);
            this.pbUserImage.MouseLeave += new System.EventHandler(this.pbUserImage_MouseLeave);
            // 
            // LoginUserInherit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.Controls.Add(this.pbUserImage);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginUserInherit";
            this.Size = new System.Drawing.Size(279, 114);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginUserInherit_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUserImage;
    }
}
