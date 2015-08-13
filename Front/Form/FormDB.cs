using Front.DB;
using Front.Trasitions;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;

namespace Front.Form
{
    public partial class FormDB : System.Windows.Forms.Form
    {
        private DataBase _dataBase = new DataBase();
        private bool _closing;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        public ConnectionString ConnectionString { get { return _dataBase.ConnectionString; } set { _dataBase.SetConnectionString(value); } }

        public FormDB()
        {
            InitializeComponent();
        }

        public NonQuery CreateNonQuery(string sql)
        {
            return _dataBase.CreateNonQuery(sql);
        }

        public Query CreateQuery(string sql)
        {
            return _dataBase.CreateQuery(sql);
        }

        public bool HasRows(string sql)
        {
            return _dataBase.CreateQuery(sql).HasRows();
        }

        public bool HasRows<T>(string sql, out T result)
        {
            return _dataBase.CreateQuery(sql).HasRows<T>(out result);
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void FormDB_MouseMove(object sender, MouseEventArgs e)
        {
            var point = Cursor.Position;
            Opacity = point.X <= 3 ? 0.35 : 1;
        }

        private void FormDB_Load(object sender, System.EventArgs e)
        {
            lgcUser.SetActionOnClickUser(OpenUserChange);

            foreach (Control item in Controls)
            {
                if (item.Name != "ctbControlBox")
                    item.MouseMove += FormDB_MouseMove;
            }

        }

        private void OpenUserChange()
        {
            var frmUserLogin = new frmUserLogin();
            frmUserLogin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = System.Diagnostics.Process.Start("notepad.exe");
            p.WaitForInputIdle();
            SetParent(p.MainWindowHandle, pnMain.Handle);
        }

        private void FormDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            _closing = true;
        }

        private void FormDB_Click(object sender, EventArgs e)
        {
            if (Cursor.Position.X <= 3) WindowState = FormWindowState.Minimized;
        }
    }
}
