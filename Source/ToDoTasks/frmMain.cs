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
using System.Windows.Forms.Calendar;

namespace ToDoTasks
{
    public partial class frmMain : Form
    {
        private Color _FONT_COLOR = Color.FromArgb(255, 86, 90, 95);
        private string _API = "http://localhost:53456/";
        //40, 95

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
                    tabsFun.SelectedTab = tpFunSettings;
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
                    //HeThong.LoadSettings();

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
            if (HeThong.CaiDat.AnCTKhiKhoiDong)
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }

            //Load cong viec
            DateTime today = DateTime.Today;
            DateTime firstDay = today.AddDays(1 - today.DayOfWeek.GetHashCode());
            DateTime lastDay = today.AddDays(7 - today.DayOfWeek.GetHashCode());

            calSchedule.SetViewRange(firstDay, lastDay);

            //Load cong viec
            LoadTasksOnCalendar();

            lblVersion.Text = "Version:    " + Application.ProductVersion;
        }

        private void LoadTasksOnList()
        {
            if (HeThong.TaiKhoan.LichLamViec.Count > 0)
            {
                lvScheduleList.Items.Clear();
                var list = HeThong.TaiKhoan.LichLamViec[0].DanhSachCongViec
                    .OrderBy(l => l.ThoiGianDienRa.ThoiGianBatDau)
                    .ToList();
                int i = 0;

                foreach(var item in list)
                {
                    if(item.IsDone ||
                        ((item.ThoiGianDienRa.ThoiGianKetThuc - DateTime.Now).TotalMinutes < 0 &&
                        item.ThoiGianDienRa.Loai == DTO.LoaiThoiGianDienRa.Unique))
                    { }
                    else
                    {
                        ListViewItem li = lvScheduleList.Items.Add((i + 1).ToString());
                        li.SubItems.Add(item.Ten);
                        li.SubItems.Add(item.ThoiGianDienRa.Loai.ToString());
                        li.SubItems.Add(item.ThoiGianDienRa.ThoiGianBatDau.ToString("MM/dd/yyyy HH:mm"));
                        li.SubItems.Add(item.ThoiGianDienRa.ThoiGianKetThuc.ToString("MM/dd/yyyy HH:mm"));
                        li.ToolTipText = item.MieuTa;

                        li.Tag = i;
                    }

                    i++;
                }
            }
        }

        private void LoadTasksOnCalendar()
        {
            calSchedule.AllowNew = false;
            calSchedule.AllowItemResize = false;
            calSchedule.AllowItemEdit = false;

            if(radScheduleList.Checked)
            {
                LoadTasksOnList();
                return;
            }
            
            if (HeThong.TaiKhoan.LichLamViec.Count > 0)
            {
                calSchedule.Items.Clear();
                int index = 0;
                foreach (var item in HeThong.TaiKhoan.LichLamViec[0].DanhSachCongViec)
                {
                    if (item.ThoiGianDienRa.Loai == DTO.LoaiThoiGianDienRa.Repeated)
                    {
                        for (int i = 0; i < item.ThoiGianDienRa.SoLanLap; i++)
                        {
                            CalendarItem ci = new CalendarItem(calSchedule);
                            ci.Text = item.Ten + "\n\n" + item.MieuTa;

                            int songay = i * item.ThoiGianDienRa.DonViLap;

                            ci.StartDate = item.ThoiGianDienRa.ThoiGianBatDau.AddDays(songay);
                            ci.EndDate = item.ThoiGianDienRa.ThoiGianKetThuc.AddDays(songay);

                            if (!item.IsDone)
                            {
                                ci.ApplyColor(item.MauSacLich);
                            }
                            else
                            {
                                ci.ApplyColor(Color.White);
                            }
                            ci.Tag = index; //Save task index

                            if (calSchedule.ViewIntersects(ci))
                            {
                                calSchedule.Items.Add(ci);
                            }
                        }
                    }
                    else
                    {
                        CalendarItem ci = new CalendarItem(calSchedule);
                        ci.Text = item.Ten + "\n\n" + item.MieuTa;
                        ci.StartDate = item.ThoiGianDienRa.ThoiGianBatDau;
                        ci.EndDate = item.ThoiGianDienRa.ThoiGianKetThuc;
                        if (!item.IsDone)
                        {
                            ci.ApplyColor(item.MauSacLich);
                        }
                        else
                        {
                            ci.ApplyColor(Color.White);
                        }
                        ci.Tag = index; //Save task index

                        if (calSchedule.ViewIntersects(ci))
                        {
                            calSchedule.Items.Add(ci);
                        }
                    }
                    
                    index++;
                }
                calSchedule.Font = new System.Drawing.Font(this.Font.FontFamily, 9, FontStyle.Regular);
            }
        }


        private void frmMain_Shown(object sender, EventArgs e)
        {
            if (HeThong.CaiDat.AnCTKhiKhoiDong)
            {
                btnMinimizeToSystemTray_Click(btnMinimizeToSystemTray, null);
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (HeThong.CaiDat.AnCTKhiThuNho &&
                this.WindowState == FormWindowState.Minimized)
            {
                btnMinimizeToSystemTray_Click(btnMinimizeToSystemTray, null);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            tray.Visible = false;
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
            tray.ShowBalloonTip(3000, "To Do Tasks", "I am here!\nDouble click to open", ToolTipIcon.Info);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            tabs.Visible = false;
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuShowToDoTasks_Click(object sender, EventArgs e)
        {
            tray.Visible = false;

            this.ShowInTaskbar = true;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mnuShowToDoTasks_Click(null, null);
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

        #region Tab Settings
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
            string tasksFile = HeThong.UsersFile;

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
        #endregion


        private void radScheduleMonth_CheckedChanged(object sender, EventArgs e)
        {
            DateTime firstDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            calSchedule.SetViewRange(firstDay, firstDay.AddMonths(1).AddDays(-1));

            //Load cong viec
            LoadTasksOnCalendar();
            tabs.SelectedTab = tpSchedule;
            tabsFun.SelectedTab = tpFunSchedule;
        }

        private void radScheduleWeek_CheckedChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime firstDay = today.AddDays(1 - today.DayOfWeek.GetHashCode());
            DateTime lastDay = today.AddDays(7 - today.DayOfWeek.GetHashCode());

            calSchedule.SetViewRange(firstDay, lastDay);

            //Load cong viec
            LoadTasksOnCalendar();
            tabs.SelectedTab = tpSchedule;
            tabsFun.SelectedTab = tpFunSchedule;
        }

        private void radScheduleList_CheckedChanged(object sender, EventArgs e)
        {
            LoadTasksOnCalendar();
            tabs.SelectedTab = tpSchedule_List;
            tabsFun.SelectedTab = tpFunSchedule;
        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    OpenFileDialog o = new OpenFileDialog();
        //    o.InitialDirectory = "c:\\";
        //    if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        using (var client = new HttpClient())
        //        {
        //            client.BaseAddress = new Uri(_API);
        //            using (var content = new MultipartFormDataContent())
        //            {
        //                var fileContent = new ByteArrayContent(System.IO.File.ReadAllBytes(o.FileName));
        //                fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
        //                {
        //                    Name = "d2phap@gmail.com",
        //                    FileName = Path.GetFileName(o.FileName)
        //                };
        //                content.Add(fileContent);

        //                var requestUri = "api/account/sync";
        //                var result = client.PostAsync(requestUri, content).Result;

        //                if (result.IsSuccessStatusCode)
        //                {
        //                    MessageBox.Show(result.Headers.GetValues("Filename").ToList()[0]);
        //                }
        //                else
        //                {
        //                    MessageBox.Show(result.StatusCode.ToString());
        //                }
        //            }
        //        }
        //    }
        //}

        private void calSchedule_ItemClick(object sender, CalendarItemEventArgs e)
        {
            var ds = calSchedule.GetSelectedItems();
            if (ds.Count() > 0)
            {
                var item = ds.ToList()[0];
                var sysItem = HeThong.TaiKhoan.LichLamViec[0].DanhSachCongViec[
                    int.Parse(item.Tag.ToString())];

                if (sysItem.IsDone)
                {
                    sbtnFinishTask.Visible = false;
                    sbtnAddTask.Visible = true;
                    sbtnEditTask.Visible = false;
                    sbtnDeleteTask.Visible = true;
                }
                else
                {
                    sbtnFinishTask.Visible = true;
                    sbtnAddTask.Visible = true;
                    sbtnEditTask.Visible = true;
                    sbtnDeleteTask.Visible = true;
                }
            }
        }

        private void sbtnFinishTask_Click(object sender, EventArgs e)
        {
            var ds = calSchedule.GetSelectedItems();
            if (ds.Count() > 0)
            {
                var item = ds.ToList()[0];

                item.ApplyColor(Color.White);
                var sysItem = HeThong.TaiKhoan.LichLamViec[0].DanhSachCongViec[
                    int.Parse(item.Tag.ToString())];

                sysItem.MauSacLich = Color.White;
                sysItem.IsDone = true;

                if(radScheduleWeek.Checked)
                {
                    radScheduleWeek_CheckedChanged(null, null);
                }
                else if(radScheduleMonth.Checked)
                {
                    radScheduleMonth_CheckedChanged(null, null);
                }
            }
        }

        private void sbtnAddTask_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = tpEditTask;
            tabsFun.SelectedTab = tpFunScheduleNewTask;
            cmbTaskRepeatType.SelectedIndex = 0;

            ResetFormNewTask();
        }

        private void sbtnEditTask_Click(object sender, EventArgs e)
        {
            if (calSchedule.GetSelectedItems().Count() > 0)
            {
                tabs.SelectedTab = tpEditTask;
                tabsFun.SelectedTab = tpFunScheduleEditTask;

                LoadTaskToEditForm(int.Parse(calSchedule.GetSelectedItems().ToList()[0].Tag.ToString()));
            }
        }

        private void sbtnDeleteTask_Click(object sender, EventArgs e)
        {
            var ds = calSchedule.GetSelectedItems();
            if (ds.Count() > 0)
            {
                var item = ds.ToList()[0];

                item.ApplyColor(Color.White);
                HeThong.TaiKhoan.LichLamViec[0].DanhSachCongViec.RemoveAt(
                    int.Parse(item.Tag.ToString()));

                if (radScheduleWeek.Checked)
                {
                    radScheduleWeek_CheckedChanged(null, null);
                }
                else if (radScheduleMonth.Checked)
                {
                    radScheduleMonth_CheckedChanged(null, null);
                }
            }
        }

        private void btnOKAddNewTask_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            txtTaskTitle.Text = txtTaskTitle.Text.Trim();
            err.Clear();

            if(txtTaskTitle.Text.Length==0)
            {
                isValid = false;
                err.SetError(txtTaskTitle, "Task title must not be empty.");
            }
            if ((dtpTaskStartTime.Value - DateTime.Now).TotalMinutes <= 0)
            {
                isValid = false;
                err.SetError(dtpTaskStartTime, "Start time must be greater than the current time.");
            }
            if ((dtpTaskEndTime.Value - dtpTaskStartTime.Value).TotalMinutes <= 0)
            {
                isValid = false;
                err.SetError(dtpTaskEndTime, "End time must be greater than Start time.");
            }

            if(isValid)
            {
                DTO.CongViecDTO cv = new DTO.CongViecDTO();
                cv.Ten = txtTaskTitle.Text;
                cv.DiaDiem = txtTaskPlace.Text.Trim();
                cv.MieuTa = txtTaskDescription.Text.Trim();
                cv.MauSacLich = picTaskColor.BackColor;
                cv.ThoiGianDienRa.ThoiGianBatDau = dtpTaskStartTime.Value;
                cv.ThoiGianDienRa.ThoiGianKetThuc = dtpTaskEndTime.Value;
                cv.ThoiGianDienRa.Loai = 
                    (cmbTaskRepeatType.SelectedIndex == 1) ? DTO.LoaiThoiGianDienRa.Repeated : 
                    DTO.LoaiThoiGianDienRa.Unique;
                cv.ThoiGianDienRa.SoLanLap = (int)numTaskRepeatTimes.Value;
                cv.ThoiGianDienRa.DonViLap = (int)numTaskRepeatUnit.Value;
                cv.HinhThucNhacNho = new List<DTO.LoaiHinhThucNhacNho>();
                if(chkTaskRemindType_Email.Checked)
                {
                    cv.HinhThucNhacNho.Add(DTO.LoaiHinhThucNhacNho.Email);
                }
                if (chkTaskRemindType_Sound.Checked)
                {
                    cv.HinhThucNhacNho.Add(DTO.LoaiHinhThucNhacNho.Sound);
                }
                if (chkTaskRemindType_Notification.Checked)
                {
                    cv.HinhThucNhacNho.Add(DTO.LoaiHinhThucNhacNho.Notification);
                }
                cv.DanhSachThoiGianNhacNho = new List<int>();
                for (int i = 0; i < lstTaskRemindTime.Items.Count; i++)
                {
                    cv.DanhSachThoiGianNhacNho.Add((int)lstTaskRemindTime.Items[i]);
                }
                cv.IsDone = false;

                //add new task
                HeThong.TaiKhoan.LichLamViec[0].DanhSachCongViec.Add(cv);
                LoadTasksOnCalendar(); //refresh
                btnCancelAddNewTask.PerformClick(); //close new task form
            }
        }

        private void btnTaskAddRemindTime_Click(object sender, EventArgs e)
        {
            //Kiem tra co ton tai hay chua
            if (lstTaskRemindTime.Items.IndexOf(numTaskAddRemindTime.Value) == -1)
            {
                //Chua ton tai thi them
                lstTaskRemindTime.Items.Add(numTaskAddRemindTime.Value);
                
                //reset field
                numTaskAddRemindTime.Value = 0;
            }
        }

        private void btnTaskRemoveRemindTime_Click(object sender, EventArgs e)
        {
            //Remove selected remind time
            if (lstTaskRemindTime.SelectedIndices.Count > 0)
            {
                List<object> ds = new List<object>();

                foreach(int item in lstTaskRemindTime.SelectedIndices)
                {
                    ds.Add(lstTaskRemindTime.Items[item]);
                }

                foreach (object item in ds)
                {
                    lstTaskRemindTime.Items.Remove(item);
                }
            }
        }

        private void picTaskColor_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.AnyColor = true;
            c.FullOpen = true;
            
            if(c.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picTaskColor.BackColor = c.Color;
            }
        }

        private void btnCancelAddNewTask_Click(object sender, EventArgs e)
        {
            if (radScheduleList.Checked)
            {
                radScheduleList_CheckedChanged(null, null);
            }
            else if (radScheduleWeek.Checked)
            {
                radScheduleWeek_CheckedChanged(null, null);
            }
            else
            {
                radScheduleMonth_CheckedChanged(null, null);
            }
            ResetFormNewTask();
        }

        private void ResetFormNewTask()
        {
            txtTaskTitle.Text = 
                txtTaskPlace.Text = 
                txtTaskDescription.Text = string.Empty;

            txtIndexTaskEdit.Text = "";
            picTaskColor.BackColor = Color.FromArgb(39, 189, 239);

            dtpTaskStartTime.Value = 
                dtpTaskEndTime.Value = DateTime.Now;

            cmbTaskRepeatType.SelectedIndex = 0;
            numTaskAddRemindTime.Value =
                numTaskRepeatTimes.Value =
                numTaskRepeatUnit.Value = 0;

            chkTaskRemindType_Notification.Checked =
                chkTaskRemindType_Sound.Checked = !
                (chkTaskRemindType_Email.Checked = false);

            lstTaskRemindTime.Items.Clear();
        }

        private void LoadTaskToEditForm(int index)
        {
            var cv = HeThong.TaiKhoan.LichLamViec[0].DanhSachCongViec[index];

            txtTaskTitle.Text = cv.Ten;
            txtTaskPlace.Text = cv.DiaDiem;
            txtTaskDescription.Text = cv.MieuTa;
            txtIndexTaskEdit.Text = index.ToString();
            
            picTaskColor.BackColor = Color.FromArgb(cv.MauSacLich.R, cv.MauSacLich.G, cv.MauSacLich.B);
            dtpTaskStartTime.Value = cv.ThoiGianDienRa.ThoiGianBatDau;
            dtpTaskEndTime.Value = cv.ThoiGianDienRa.ThoiGianKetThuc;

            cmbTaskRepeatType.SelectedIndex = (cv.ThoiGianDienRa.Loai == DTO.LoaiThoiGianDienRa.Repeated) ? 1 : 0;
            numTaskAddRemindTime.Value = 0;
            numTaskRepeatTimes.Value = cv.ThoiGianDienRa.SoLanLap;
            numTaskRepeatUnit.Value = cv.ThoiGianDienRa.DonViLap;

            if (cv.HinhThucNhacNho.IndexOf(DTO.LoaiHinhThucNhacNho.Notification) != -1)
            {
                chkTaskRemindType_Notification.Checked = true;
            }
            if (cv.HinhThucNhacNho.IndexOf(DTO.LoaiHinhThucNhacNho.Sound) != -1)
            {
                chkTaskRemindType_Sound.Checked = true;
            }
            if (cv.HinhThucNhacNho.IndexOf(DTO.LoaiHinhThucNhacNho.Email) != -1)
            {
                chkTaskRemindType_Email.Checked = true;
            }

            lstTaskRemindTime.Items.Clear();
            foreach(var v in cv.DanhSachThoiGianNhacNho)
            {
                lstTaskRemindTime.Items.Add(v);
            }
        }

        private void btnCancelEditTask_Click(object sender, EventArgs e)
        {
            if(radScheduleList.Checked)
            {
                radScheduleList_CheckedChanged(null, null);
            }
            else if(radScheduleWeek.Checked)
            {
                radScheduleWeek_CheckedChanged(null, null);
            }
            else
            {
                radScheduleMonth_CheckedChanged(null, null);
            }

            ResetFormNewTask();
        }

        private void btnOKEditTask_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            txtTaskTitle.Text = txtTaskTitle.Text.Trim();
            err.Clear();

            if(txtTaskTitle.Text.Length==0)
            {
                isValid = false;
                err.SetError(txtTaskTitle, "Task title must not be empty.");
            }

            if (cmbTaskRepeatType.SelectedIndex == 0)
            {
                if ((dtpTaskStartTime.Value - DateTime.Now).TotalMinutes <= 0)
                {
                    isValid = false;
                    err.SetError(dtpTaskStartTime, "Start time must be greater than the current time.");
                }
                if ((dtpTaskEndTime.Value - dtpTaskStartTime.Value).TotalMinutes <= 0)
                {
                    isValid = false;
                    err.SetError(dtpTaskEndTime, "End time must be greater than Start time.");
                }
            }

            if (isValid)
            {

                int maCV = int.Parse(txtIndexTaskEdit.Text);

                DTO.CongViecDTO cv = new DTO.CongViecDTO();

                cv.Ten = txtTaskTitle.Text;
                cv.DiaDiem = txtTaskPlace.Text.Trim();
                cv.MieuTa = txtTaskDescription.Text.Trim();
                cv.MauSacLich = picTaskColor.BackColor;
                cv.ThoiGianDienRa.ThoiGianBatDau = dtpTaskStartTime.Value;
                cv.ThoiGianDienRa.ThoiGianKetThuc = dtpTaskEndTime.Value;
                cv.ThoiGianDienRa.Loai =
                    (cmbTaskRepeatType.SelectedIndex == 1) ? DTO.LoaiThoiGianDienRa.Repeated :
                    DTO.LoaiThoiGianDienRa.Unique;
                cv.ThoiGianDienRa.SoLanLap = (int)numTaskRepeatTimes.Value;
                cv.ThoiGianDienRa.DonViLap = (int)numTaskRepeatUnit.Value;
                cv.HinhThucNhacNho = new List<DTO.LoaiHinhThucNhacNho>();
                if (chkTaskRemindType_Email.Checked)
                {
                    cv.HinhThucNhacNho.Add(DTO.LoaiHinhThucNhacNho.Email);
                }
                if (chkTaskRemindType_Sound.Checked)
                {
                    cv.HinhThucNhacNho.Add(DTO.LoaiHinhThucNhacNho.Sound);
                }
                if (chkTaskRemindType_Notification.Checked)
                {
                    cv.HinhThucNhacNho.Add(DTO.LoaiHinhThucNhacNho.Notification);
                }
                cv.DanhSachThoiGianNhacNho = new List<int>();
                for (int i = 0; i < lstTaskRemindTime.Items.Count; i++)
                {
                    cv.DanhSachThoiGianNhacNho.Add((int)lstTaskRemindTime.Items[i]);
                }

                //Update
                HeThong.TaiKhoan.LichLamViec[0].DanhSachCongViec[maCV] = cv;
                LoadTasksOnCalendar(); //refresh
                btnCancelEditTask.PerformClick(); //close new task form
            }
        }

        private void calSchedule_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            tabs.SelectedTab = tpEditTask;
            tabsFun.SelectedTab = tpFunScheduleEditTask;

            int index = 0;

            if (e.Item.Tag == null || int.TryParse(e.Item.Tag.ToString(), out index))
            {
                sbtnAddTask_Click(null, null);
            }
            else
            {
                LoadTaskToEditForm(index);
            }
            
        }

        private void btnScheduleList_Finish_Click(object sender, EventArgs e)
        {
            if (lvScheduleList.SelectedIndices.Count > 0)
            {
                var sysItem = HeThong.TaiKhoan.LichLamViec[0].DanhSachCongViec[
                    int.Parse(lvScheduleList.SelectedItems[0].Tag.ToString())];

                sysItem.MauSacLich = Color.White;
                sysItem.IsDone = true;

                LoadTasksOnList();
            }
        }

        private void btnScheduleList_Add_Click(object sender, EventArgs e)
        {
            sbtnAddTask_Click(null, null);
        }

        private void btnScheduleList_Edit_Click(object sender, EventArgs e)
        {
            if (lvScheduleList.SelectedIndices.Count > 0)
            {
                tabs.SelectedTab = tpEditTask;
                tabsFun.SelectedTab = tpFunScheduleEditTask;

                LoadTaskToEditForm(int.Parse(lvScheduleList.SelectedItems[0].Tag.ToString()));
            }
        }

        private void btnScheduleList_Delete_Click(object sender, EventArgs e)
        {
            if (lvScheduleList.SelectedIndices.Count > 0)
            {
                HeThong.TaiKhoan.LichLamViec[0].DanhSachCongViec.RemoveAt(
                    int.Parse(lvScheduleList.SelectedItems[0].Tag.ToString()));

                LoadTasksOnList();
            }
        }

        private void lvScheduleList_DoubleClick(object sender, EventArgs e)
        {
            if (lvScheduleList.SelectedItems.Count > 0)
            {
                btnScheduleList_Edit_Click(null, null);
            }
        }

        
        











    }
}
