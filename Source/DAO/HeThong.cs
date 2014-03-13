using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using DTO;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Net.Mail;
using System.Windows.Forms;
using System.Drawing;

namespace DAO
{
    public class HeThong
    {
        private static string _configFile = "";
        private static string _usersFile = "";

        private static CaiDatHeThongDTO _caiDat = new CaiDatHeThongDTO();
        private static TaiKhoanDTO _taiKhoan = new TaiKhoanDTO();

        [DllImport("winmm.dll")]
        private static extern long mciGetErrorString(long dwError, string lpstrBuffer, long uLength);

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, string lpstrReturnString,
            long uReturnLength, long hwndCallback);

        #region Properties
        /// <summary>
        /// Lấy, gán đường dẫn tập tin config.xml
        /// </summary>
        public static string ConfigFile
        {
            get { return HeThong._configFile; }
            set { HeThong._configFile = value; }
        }

        /// <summary>
        /// Lấy, gán đường dẫn tập tin users.xml
        /// </summary>
        public static string UsersPath
        {
            get { return HeThong._usersFile; }
            set { HeThong._usersFile = value; }
        }

        /// <summary>
        /// Cài đặt hệ thống
        /// </summary>
        public static CaiDatHeThongDTO CaiDat
        {
            get { return _caiDat; }
            set { _caiDat = value; }
        }

        /// <summary>
        /// Thông tin tài khoản người dùng
        /// </summary>
        public static TaiKhoanDTO TaiKhoan
        {
            get { return HeThong._taiKhoan; }
            set { HeThong._taiKhoan = value; }
        }
        #endregion


        /// <summary>
        /// Đọc cài đặt từ file config.xml
        /// </summary>
        public static void LoadSettings()
        {
            // Kiểm tra thư mục cài đặt
            // ~\AppData\Roaming\To to tasks\
            if (!Directory.Exists(GetDirectoryName(ConfigFile)))
            {
                Directory.CreateDirectory(GetDirectoryName(ConfigFile));
            }

            CaiDatHeThongDAO cd = new CaiDatHeThongDAO(ConfigFile);
            CaiDat = cd.ReadConfiguration();

            //Anomyous user
            string userFile = HeThong.UsersPath + HeThong.CaiDat.NguoiDung + ".xml";

            //user file is exist
            if(File.Exists(HeThong.UsersPath + HeThong.CaiDat.NguoiDung + ".xml"))
            {

            }
            else //user file is NOT exist
            {
                //Create new xml file
                HeThong.TaiKhoan = new TaiKhoanDTO();
                HeThong.TaiKhoan.LoaiTaiKhoan = LoaiTaiKhoan.Registered;
                HeThong.SaveAllSettings(SaveSettingOption.UserDataOnly);
            }

            //Đọc danh sách người dùng
            TaiKhoanDAO tk = new TaiKhoanDAO(userFile);
            List<TaiKhoanDTO> users = tk.ReadUsers();

            //Lay thong tin nguoi dung hien tai
            HeThong.TaiKhoan = users.SingleOrDefault(u => u.Email.ToLower().CompareTo(CaiDat.NguoiDung.ToLower()) == 0);

            //Anomyous user
            if(HeThong.TaiKhoan == null)
            {
                CaiDat.NguoiDung = "Anomyous";
                CaiDat.MaXacThuc = "";

                userFile = HeThong.UsersPath + "Anomyous.xml";
                tk = new TaiKhoanDAO(userFile);
                users = tk.ReadUsers();
                //Lay thong tin nguoi dung anomyous
                HeThong.TaiKhoan = users.SingleOrDefault(u => u.Email.ToLower()
                    .CompareTo(CaiDat.NguoiDung.ToLower()) == 0);
            }

        }

        /// <summary>
        /// Lưu thiết lập vào config.xml
        /// </summary>
        public static void SaveAllSettings(SaveSettingOption op = SaveSettingOption.All)
        {
            // Kiểm tra thư mục cài đặt
            // ~\AppData\Roaming\To to tasks\
            if (!Directory.Exists(GetDirectoryName(ConfigFile)))
            {
                Directory.CreateDirectory(GetDirectoryName(ConfigFile));
            }

            CaiDatHeThongDAO cd = new CaiDatHeThongDAO(ConfigFile);
            cd.SaveConfiguration(HeThong.CaiDat, op);
        }

        /// <summary>
        /// Áp dụng các cài đặt từ config.xml vào hệ thống
        /// </summary>
        public static void ApplyAllSettings()
        {
            if(HeThong.CaiDat.KhoiDongCungHeDieuHanh)
            {
                SetStartWinOS(true);
            }
            else
            {
                SetStartWinOS(false);
            }
        }

        /// <summary>
        /// Send email
        /// </summary>
        /// <param name="to"></param>
        /// <param name="from"></param>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <param name="smtp"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public static bool SendEmail(string to, string from, string account, string password, string smtp,
            string subject, string body)
        {
            MailMessage MyMailMessage = new MailMessage();

            //From
            MyMailMessage.From = new MailAddress(from);

            //To
            MyMailMessage.To.Add(to);

            //Subject
            MyMailMessage.Subject = subject;

            //Body
            MyMailMessage.Body = body;

            //Create the SMTPClient object and specify the SMTP GMail server
            SmtpClient SMTPServer = new SmtpClient(smtp);
            SMTPServer.Port = 587;
            SMTPServer.Credentials = new System.Net.NetworkCredential(account, password);
            SMTPServer.EnableSsl = true;

            try
            {
                SMTPServer.Send(MyMailMessage);
            }
            catch (SmtpException ex)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Show notification
        /// </summary>
        /// <param name="message">Your message</param>
        public static void ShowNotification(string message)
        {
            NotificationForm f = new NotificationForm(message);
            Rectangle rec = Screen.FromControl(f).Bounds;

            //Xác định lại chiều cao vừa khít với form main
            f.Width = rec.Width - rec.Width / 5 - rec.Width / 9;
            f.Height = rec.Height - rec.Height / 2 - rec.Height / 9;

            //Hiện form ngay giữa form Main
            f.Show();
            f.SetDesktopLocation(rec.X + ((rec.Width / 2) - f.Width / 2),
                                rec.Y + ((rec.Height / 2) - f.Height / 2) + 20);

            //Kích hoạt form
            f.Activate();
        }


        /// <summary>
        /// Thiết đặt khoá registry để chương trình khởi động cùng hệ điều hành
        /// </summary>
        /// <param name="isEnabled">True nếu thiết lập, ngược lại False</param>
        private static void SetStartWinOS(bool isEnabled)
        {
            string hkey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run";

            if (isEnabled)
            {
                Registry.SetValue(hkey, HeThong.CaiDat.ThongTinChuongTrinh.TenChuongTrinh,
                    HeThong.CaiDat.ThongTinChuongTrinh.DuongDanExe, RegistryValueKind.String);
            }
            else
            {
                Registry.SetValue(hkey, HeThong.CaiDat.ThongTinChuongTrinh.TenChuongTrinh,
                    "", RegistryValueKind.String);
            }
        }


        /// <summary>
        /// Hàm lấy đường dẫn thư mục cha của thư mục / tập tin (nhanh hơn)
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        private static string GetDirectoryName(string f)
        {
            try
            {
                return f.Substring(0, f.LastIndexOf('\\'));
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Kiểm tra tính hợp lệ của email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string email)
        {
            bool invalid = false;
            if (String.IsNullOrEmpty(email))
                return false;

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format. 
            try
            {
                return Regex.IsMatch(email,
                      @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,24}))$",
                      RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Mã hoá chuỗi ký tự bằng thuật toán SHA1
        /// </summary>
        /// <param name="inputString">Chuỗi cần mã hoá</param>
        /// <returns></returns>
        public static string SHA1(string inputString)
        {
            //Mã hoá bằng SHA1
            SHA1Managed sha1 = new SHA1Managed();

            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            var hashedBytes = sha1.ComputeHash(bytes);

            StringBuilder hashedBuilder = new StringBuilder(40);
            for (int i = 0; i < hashedBytes.Length; i++)
            {
                hashedBuilder.Append(hashedBytes[i].ToString("x2"));
            }

            //Chuỗi sau khi mã hoá
            return hashedBuilder.ToString();
        }




        private static long OpenMovie(string filename)
        {
            long _Error = 0;

            //Open a movie in the default window style(Popup)
            filename = "\"" + filename + "\"";
            _Error = mciSendString("close movie", "0", 0, 0);
            //Decide which way you want the mci device to work below

            //Specify the mpegvideo driver to play the movies
            _Error = mciSendString("open " + filename + " type mpegvideo alias movie", "0", 0, 0);

            //Let the mci device decide which driver to use
            //Error = mciSendString("open " & Filename & " alias movie", 0, 0, 0)

            return _Error;
        }

        private static long PlayMovie()
        {
            dynamic _Error = null;
            //Play the movie after you open it
            _Error = mciSendString("play movie", "0", 0, 0);
            return _Error;
        }

        private static long StopMovie()
        {
            dynamic _Error = null;
            //Stops the playing of the movie
            _Error = mciSendString("stop movie", "0", 0, 0);
            return _Error;
        }

        private static long CloseMovie()
        {
            dynamic _Error = null;
            //Close the mci device
            _Error = mciSendString("close all", "0", 0, 0);
            return _Error;
        }

        /// <summary>
        /// Play audio file
        /// </summary>
        /// <param name="filename"></param>
        public static void PlayAudio(string filename)
        {
            StopMovie();
            CloseMovie();
            OpenMovie(filename);
            PlayMovie();
        }

        /// <summary>
        /// Stop audio
        /// </summary>
        public static void StopAudio()
        {
            StopMovie();
            CloseMovie();
        }

        /// <summary>
        /// Thay đổi âm lượng của chương trình
        /// </summary>
        /// <param name="value">0 - 1000</param>
        /// <returns></returns>
        public static long SetApplicationVolume(long value)
        {
            long _Error = 0;
            //Raise or lower the volume for both channels
            //1000 max - 0 min
            _Error = mciSendString("setaudio movie volume to " + value.ToString(), "0", 0, 0);
            return _Error;
        }



    }
}
