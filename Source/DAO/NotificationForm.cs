using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DAO
{
    public partial class NotificationForm : Form
    {
        string _noiDung = "";
        public NotificationForm(string noidung)
        {
            InitializeComponent();
            _noiDung = noidung;
        }

        private void NotificationForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.FromArgb(32, 161, 204), 2), 0, 1, panBot.Width, 1);

            e.Graphics.DrawLine(new Pen(Color.FromArgb(32, 161, 204), 2), 1, 0, 1, this.Height);
            e.Graphics.DrawLine(new Pen(Color.FromArgb(32, 161, 204), 2), this.Width - 1, 0, this.Width - 1, this.Height);
        }

        private void panBot_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.FromArgb(32, 161, 204), 2), 1, 0, 1, this.Height);
            e.Graphics.DrawLine(new Pen(Color.FromArgb(32, 161, 204), 2), panBot.Width - 1, 0, panBot.Width - 1, panBot.Height);

            e.Graphics.DrawLine(new Pen(Color.FromArgb(32, 161, 204), 2), 0, panBot.Height - 1, panBot.Width, panBot.Height - 1);
        }

        /// <summary>
        /// Di chuyển form 
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            int WM_NCHITTEST = 0x84;
            if (m.Msg == WM_NCHITTEST)
            {
                int HTCLIENT = 1;
                int HTCAPTION = 2;
                if (m.Result.ToInt32() == HTCLIENT)
                    m.Result = (IntPtr)HTCAPTION;
            }
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            lblNoiDung.Text = _noiDung;
        }

        private void chkClose_Click(object sender, EventArgs e)
        {
            HeThong.StopAudio();
            this.Close();
        }

        private void chkClose_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
