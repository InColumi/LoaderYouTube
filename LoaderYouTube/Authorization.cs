using LoaderYouTube.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoaderYouTube
{
    public partial class Authorization : Form
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
        public Authorization()
        {
            InitializeComponent();
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.Red;
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowStartMenu()
        {
            StartMenu startMenu = new StartMenu(this);
            startMenu.Show();
            Shower.Form(startMenu);
            this.Visible = false;
        }

        private bool CheckCorrectMail()
        {
            string mail = textBoxMail.Text;
            if (mail.Contains('@') && mail.Contains('.'))
            {
                return true;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(
                    this,
                    "Некорректный адрес почты. Будем гуглить ?",
                    "Внимательность",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Process.Start(@"https://www.google.com/search?q=%D0%BA%D0%B0%D0%BA+%D0%B2%D1%8B%D0%B3%D0%BB%D1%8F%D0%B4%D0%B8%D1%82+%D0%B0%D0%B4%D1%80%D0%B5%D1%81+%D1%8D%D0%BB%D0%B5%D0%BA%D1%82%D1%80%D0%BE%D0%BD%D0%BD%D0%BE%D0%B9+%D0%BF%D0%BE%D1%87%D1%82%D1%8B&source=lmns&bih=868&biw=1768&hl=ru&sa=X&ved=2ahUKEwiysuuoiJfyAhXSwyoKHW0RA_AQ_AUoAHoECAEQAA"); 
                }
                return false;
            }
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            if (CheckCorrectMail())
            {
                ShowStartMenu();
            }
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.AliceBlue;
        }

        private void Authorization_Shown(object sender, EventArgs e)
        {
            Shower.Form(this);
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '#';
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == string.Empty)
            {
                textBoxPassword.Text = "введите пароль";
            }
        }

        private void textBoxMail_Leave(object sender, EventArgs e)
        {
            if (textBoxMail.Text == string.Empty)
            {
                textBoxMail.Text = "введите почту";
            }
        }
    }
}
