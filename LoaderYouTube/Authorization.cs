using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void buttonSign_Click(object sender, EventArgs e)
        {
            new StartMenu(this.Owner).Show();
            
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.AliceBlue;
        }

        private async void Authorization_Shown(object sender, EventArgs e)
        {
            double opasity = 0.97;
            Opacity = 0;
            for (double i = 0.1; Opacity < opasity; i += 0.01)
            {
                Opacity += i;
                await Task.Delay(40);
            }
            Opacity = opasity;
        }
    }
}
