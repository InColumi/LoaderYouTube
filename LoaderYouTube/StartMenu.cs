using LoaderYouTube.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoaderYouTube
{
    public partial class StartMenu : Form
    {
        #region DragWindow
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    if ((int)m.Result == HTCLIENT)
                    {
                        m.Result = (IntPtr)HTCAPTION;
                        return;
                    }
                    break;
            }
            base.WndProc(ref m);
        }
        #endregion
        Authorization _authorization;
        UserInfo _userInfo;
        public StartMenu(Authorization authorization)
        {
            _authorization = authorization;
            _userInfo = new UserInfo(_authorization.textBoxMail.Text, _authorization.textBoxPassword.Text);
            //MessageBox.Show($"{_userInfo.Mail}, {_userInfo.Password}");

            InitializeComponent();
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.FromArgb(231, 229, 234);
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.Red;
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
