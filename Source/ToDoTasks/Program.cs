using DAO;
using DTO;
using System;
using System.Windows.Forms;

namespace ToDoTasks
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Định nghĩa đường dẫn tập tin config.xml
            HeThong.ConfigFile = Application.UserAppDataPath + @"\config.xml";
            //Định nghĩa đường dẫn tập tin users.xml
            HeThong.UsersPath = Application.UserAppDataPath + @"\";

            //Load all settings
            HeThong.LoadSettings();

            HeThong.CaiDat.ThongTinChuongTrinh = new ThongTinChuongTrinhDTO(
                Application.ProductName,
                "Dương Diệu Pháp (1241378), Bùi Bá Lộc (1241363)",
                Application.ProductVersion,
                "d2phap@gmail.com",
                Application.ExecutablePath
                );

            Application.ApplicationExit += Application_ApplicationExit;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            
        }

        /// <summary>
        /// Lưu tất cả thiết lập của chương trình trước khi thoát chương trình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            HeThong.ApplyAllSettings();
            HeThong.SaveAllSettings();
        }
    }
}
