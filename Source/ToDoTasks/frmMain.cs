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
using System.Text.RegularExpressions;

namespace ToDoTasks
{
    public partial class frmMain : Form
    {
        private Color _FONT_COLOR = Color.FromArgb(255, 86, 90, 95);
        private string _API = "http://localhost:53456/";

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

            tabs.Visible = true;

            switch (rad.Name)
            {
                case "rabTabStatus":
                    tabs.SelectedTab = tpStatus;
                    tabsFun.SelectedTab = tpFunStatus;
                    break;

                case "radTabSchedule":
                    tabs.SelectedTab = tpSchedule;
                    tabsFun.SelectedTab = tpFunSchedule;

                    break;

                case "radTabSettings":
                    tabs.SelectedTab = tpSettings;
                    break;

                case "radTabLogin":


                    tabs.SelectedTab = tpLogin;
                    tabsFun.SelectedTab = tpFunLogin;
                    break;

                default:
                    break;
            }
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabs.SelectedTab.Name)
            {
                case "tpSettings":
                    //Load all settings
                    HeThong.LoadSettings();

                    trbVolume.Value = HeThong.CaiDat.AmLuongThongBao;
                    lblVolumeValue.Text = trbVolume.Value.ToString();

                    chkStartWithOS.Checked = HeThong.CaiDat.KhoiDongCungHeDieuHanh;
                    chkHideOnStarting.Checked = HeThong.CaiDat.AnCTKhiKhoiDong;
                    chkHideOnMinimizing.Checked = HeThong.CaiDat.AnCTKhiThuNho;

                    txtSoundFile.Text = HeThong.CaiDat.TapTinAmThanh;

                    if(HeThong.TaiKhoan.LoaiTaiKhoan == DTO.LoaiTaiKhoan.Anomyous)
                    {
                        lblLastSync.Text = "Last sync: never";
                    }
                    else
                    {
                        ///////////////////////////////////////////////
                        lblLastSync.Text = "Last sync: never";
                    }

                    break;

                default:
                    break;
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
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(_API);
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

        #region Tab Status
        private void btnMinimizeToSystemTray_Click(object sender, EventArgs e)
        {
            tray.Visible = true;
            this.Hide();
            tray.ShowBalloonTip(3000, "To do tasks", "I am here!\nDouble click to open", ToolTipIcon.Info);
        }

        private void tray_DoubleClick(object sender, EventArgs e)
        {
            tray.Visible = false;
            this.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            tabs.Visible = false;
        }
        #endregion

        #region Tab Login
        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            txtAccountName.Text = string.Empty;
            txtAccountEmail.Text = string.Empty;
            txtAccountPassword.Text = string.Empty;
            txtAccountConfirmPassword.Text = string.Empty;

            tabs.SelectedTab = tpRegisterNewAccount;
            tabsFun.SelectedTab = tpFunLoginNewAccount;
        }
        

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(!HeThong.IsValidEmail(txtLogInEmail.Text) || txtLogInPassword.Text.Length == 0)
            {
                MessageBox.Show("Invalid email or password!");
                return;
            }

            string email = txtLogInEmail.Text.Trim();
            string password = HeThong.SHA1(txtLogInPassword.Text);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_API);
                var requestUri = string.Format("api/account/login?email={0}&password={1}", email, password);

                try
                {
                    var result = client.GetAsync(requestUri).Result;

                    if (result.IsSuccessStatusCode)
                    {
                        var name = result.Content.ReadAsAsync<string>().Result;

                        //Dang nhap that bai
                        if (name == null)
                        {
                            MessageBox.Show("Login failed!");
                        }
                        else //Dang nhap thanh cong
                        {
                            radTabLogin.Text = "Account";
                            lblAccountName.Text = "Welcome " + name + "!";
                            lblAccountName.Tag = name;
                            tabs.SelectedTab = tpAccount;
                            tabsFun.SelectedTab = tpFunLogout;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Connection timeout!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            radTabLogin.Text = "Log in";
            lblAccountName.Text = "Welcome #";
            lblAccountName.Tag = string.Empty;
            tabs.SelectedTab = tpLogin;
            tabsFun.SelectedTab = tpFunLogin;
        }

        private void btnAccountOK_Click(object sender, EventArgs e)
        {
            if(txtAccountName.Text.Trim().Length == 0 ||
                !HeThong.IsValidEmail(txtAccountEmail.Text) ||
                txtAccountPassword.Text.CompareTo(txtAccountConfirmPassword.Text) != 0)
            {
                MessageBox.Show("Invalid input data!");
                return;
            }
            string email = txtAccountEmail.Text.Trim();
            string password = HeThong.SHA1(txtAccountPassword.Text);
            string name = txtAccountName.Text.Trim();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_API);
                var requestUri = string.Format("api/account/register?email={0}&password={1}&name={2}", 
                    email, password, name);

                try
                {
                    var result = client.GetAsync(requestUri).Result;

                    if (result.IsSuccessStatusCode)
                    {
                        var kq = result.Content.ReadAsAsync<bool>().Result;

                        //Dang ky that bai
                        if (!kq)
                        {
                            MessageBox.Show("Email " + email + " is already existed!\nPlease try another email.");
                        }
                        else //Dang ky thanh cong
                        {
                            MessageBox.Show("Your account has been created!");

                            txtLogInEmail.Text = string.Empty;
                            txtLogInPassword.Text = string.Empty;

                            tabs.SelectedTab = tpLogin;
                            tabsFun.SelectedTab = tpFunLogin;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Connection timeout!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void btnAccountCancel_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = tpLogin;
            tabsFun.SelectedTab = tpFunLogin;
        }
        #endregion

        private void btnSyncCancel_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = tpSettings;
        }

        private void radCompleteSync_CheckedChanged(object sender, EventArgs e)
        {
            dtSyncStart.Enabled = false;
            dtSyncEnd.Enabled = false;
        }

        private void radCustomSync_CheckedChanged(object sender, EventArgs e)
        {
            dtSyncStart.Enabled = true;
            dtSyncEnd.Enabled = true;
        }

        private void btnSync_Click(object sender, EventArgs e)
        {

            if (radCustomSync.Checked &&
                (dtSyncEnd.Value.Date - dtSyncStart.Value.Date).TotalDays < 0)
            {
                MessageBox.Show("End date must be greater than start date!");
                return;
            }

            string email = "";
            string tasksFile = "";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_API);
                using (var content = new MultipartFormDataContent())
                {
                    var fileContent = new ByteArrayContent(System.IO.File.ReadAllBytes(tasksFile));
                    fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
                    {
                        Name = email,
                        FileName = Path.GetFileName(tasksFile)
                    };
                    content.Add(fileContent);

                    var requestUri = "api/account/sync";
                    var result = client.PostAsync(requestUri, content).Result;

                    if (result.IsSuccessStatusCode)
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

        private void trbVolume_Scroll(object sender, EventArgs e)
        {
            lblVolumeValue.Text = trbVolume.Value.ToString();
            HeThong.SetApplicationVolume(trbVolume.Value);
            HeThong.CaiDat.AmLuongThongBao = trbVolume.Value;
        }

        private void btnSoundBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "All files (*.*)|*.*";

            if(o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSoundFile.Text = o.FileName;
                HeThong.CaiDat.TapTinAmThanh = o.FileName;

                //Test
                //HeThong.PlayAudio(o.FileName);
            }
        }

        private void txtSoundFile_TextChanged(object sender, EventArgs e)
        {
            HeThong.CaiDat.TapTinAmThanh = txtSoundFile.Text.Trim();
        }

        private void lnkStartSync_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblAccountName.Tag == null || lblAccountName.Tag.ToString() == "")
            {
                radTabLogin.Checked = true;
                radTab_CheckedChanged(radTabLogin, null);
                return;
            }
            
            tabs.SelectedTab = tpSync;
            tabsFun.SelectedTab = tpFunSettingsSync;
        }

        private void chkStartWithOS_CheckedChanged(object sender, EventArgs e)
        {
            HeThong.CaiDat.KhoiDongCungHeDieuHanh = chkStartWithOS.Checked;
        }

        private void chkHideOnStarting_CheckedChanged(object sender, EventArgs e)
        {
            HeThong.CaiDat.AnCTKhiKhoiDong = chkHideOnStarting.Checked;
        }

        private void chkHideOnMinimizing_CheckedChanged(object sender, EventArgs e)
        {
            HeThong.CaiDat.AnCTKhiThuNho = chkHideOnMinimizing.Checked;
        }

        

        



    }
}
