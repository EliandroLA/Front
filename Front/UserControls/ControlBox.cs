using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Front.Trasitions;

namespace Front.UserControls
{
    public partial class ControlBox : UserControl
    {
        private bool _isOpen = true;

        public ControlBox()
        {
            InitializeComponent();
        }

        public void Open()
        {
            if (_isOpen) return;
            Visible = false;
            Animation.Animate(this, Animation.Effect.Active, 150, 90);
            _isOpen = true;
        }

        public void Close()
        {
            if (!_isOpen) return;
            Visible = true;
            Animation.Animate(this, Animation.Effect.Active, 150, 90);
            _isOpen = false;
        }

        private void ControlBox_Load(object sender, EventArgs e)
        {
            if (ParentForm != null)
            {
                Width = ParentForm.Width;
                ParentForm.MouseMove += ParentForm_MouseMove;
                foreach (Control item in ParentForm.Controls)
                {
                    if (item.Name != "ctbControlBox")
                        item.MouseMove += ParentForm_MouseMove;
                }
                lblTitle.Text = ParentForm.Text;
            }

            Location = new Point(0, 0);
        }

        private void ParentForm_MouseMove(object sender, MouseEventArgs e)
        {
            var point = Cursor.Position;
            if (point.Y <= 10)
            {
                Open();
            }
            else
            {
                Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (ParentForm != null)
                ParentForm.Close();
        }


    }
}
