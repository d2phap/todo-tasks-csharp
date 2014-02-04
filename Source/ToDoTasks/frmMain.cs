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
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;

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

            if (rad.Checked)
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
            //CaiDatHeThongDAO caidat = new CaiDatHeThongDAO("config.xml");
            //caidat.ReadConfiguration();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if(o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string api = "http://localhost:53456/";

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(api);
                    using (var content = new MultipartFormDataContent())
                    {
                        var fileContent = new ByteArrayContent(System.IO.File.ReadAllBytes(o.FileName));
                        fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
                        {
                            Name = "d2phap@gmail.com",
                            FileName = Path.GetFileName(o.FileName)
                        };
                        content.Add(fileContent);

                        var requestUri = "api/account/sync";
                        var result = client.PostAsync(requestUri, content).Result;

                        if(result.IsSuccessStatusCode)
                        {
                            MessageBox.Show(result.Headers.GetValues("Filename").ToList()[0]);
                        }
                        else
                        {
                            MessageBox.Show(result.StatusCode.ToString());
                        }
                    }
                }
            }

        }


    }
}
