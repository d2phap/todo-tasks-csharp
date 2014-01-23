using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;

namespace ToDoTasks
{
    public partial class frmMain : Form
    {
        private Color _FONT_COLOR = Color.FromArgb(255, 86, 90, 95);

        public frmMain()
        {
            InitializeComponent();
        }

        private void radTab_CheckedChanged(object sender, EventArgs e)
        {            
            RadioButton rad = (RadioButton)sender;

            if(rad.Checked)
            {
                rad.ForeColor = Color.White;
            }
            else
            {
                rad.ForeColor = _FONT_COLOR;
            }
            
        }

        private void timSys_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CaiDatHeThongDAO caidat = new CaiDatHeThongDAO("config.xml");
            caidat.ReadConfiguration();
        }


    }
}
