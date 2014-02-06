using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

            //Load all settings
            HeThong.LoadSettings();

            Application.ApplicationExit += Application_ApplicationExit;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());

            
        }

        /// <summary>
        /// Lưu tất cả thiết lập của chương trình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            HeThong.SaveAllSettings();
        }
    }
}
