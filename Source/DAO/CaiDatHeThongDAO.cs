using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace DAO
{
    public enum SaveSettingOption
    {
        All,
        SettingsOnly,
        UserDataOnly
    }


    public class CaiDatHeThongDAO
    {
        private string _xmlPath = string.Empty;

        public CaiDatHeThongDAO(string xmlPath)
        {
            // TODO: Complete member initialization
            this._xmlPath = xmlPath;
        }

        /// <summary>
        /// Đọc tập tin config.xml
        /// </summary>
        /// <returns></returns>
        public CaiDatHeThongDTO ReadConfiguration()
        {
            CaiDatHeThongDTO caiDatHeThong = new CaiDatHeThongDTO();

            if(!File.Exists(this._xmlPath))
            {
                return caiDatHeThong;
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(this._xmlPath);

            XmlElement root = (XmlElement)doc.DocumentElement;
            XmlElement nConfig = (XmlElement)root.SelectNodes("configurations")[0];

            XmlElement nVolume = (XmlElement)nConfig.SelectNodes("volume")[0];
            int amluong = 800;
            if (!int.TryParse(nVolume.GetAttribute("value"), out amluong))
            {
                amluong = 800;
            }
            //Get <Volume> Attribute
            caiDatHeThong.AmLuongThongBao = amluong;

            XmlElement nNoticeSound = (XmlElement)nConfig.SelectNodes("notice_sound ")[0];
            //Get <Notice_Sound> Attribute
            caiDatHeThong.TapTinAmThanh = nNoticeSound.GetAttribute("value");

            XmlElement nIsHideOnStart = (XmlElement)nConfig.SelectNodes("is_hide_on_starting")[0];
            //Get <IsHideOnStart> Attribute
            caiDatHeThong.AnCTKhiKhoiDong = bool.Parse(nIsHideOnStart.GetAttribute("value"));

            XmlElement nIsStartOS = (XmlElement)nConfig.SelectNodes("is_start_with_os")[0];
            //Get <IsStartOS> Attribute
            caiDatHeThong.KhoiDongCungHeDieuHanh = bool.Parse(nIsStartOS.GetAttribute("value"));

            XmlElement nIsHideWindowMini = (XmlElement)nConfig.SelectNodes("is_hide_window_on_minimizing")[0];
            //Get <IsHideWindowMini> Attribute
            caiDatHeThong.AnCTKhiThuNho = bool.Parse(nIsHideWindowMini.GetAttribute("value"));

            XmlElement nUsers = (XmlElement)nConfig.SelectNodes("users")[0];

            if(nUsers != null)
            {
                //Get <users> Attribute
                caiDatHeThong.NguoiDung = nUsers.GetAttribute("name").Trim();
                caiDatHeThong.MaXacThuc = nUsers.GetAttribute("auth").Trim();

                //Get user list
                XmlNodeList nUserList = nUsers.SelectNodes("user");
                foreach (XmlElement item in nUserList)
                {
                    caiDatHeThong.DanhSachNguoiDung.Add(item.GetAttribute("value"));
                }
            }
            else
            {
                caiDatHeThong.NguoiDung = "anomyous";
            }
            

            return caiDatHeThong;
        }

        /// <summary>
        /// Lưu thiết lập xuống file config.xml
        /// </summary>
        /// <param name="cd"></param>
        public void SaveConfiguration(CaiDatHeThongDTO cd, SaveSettingOption op = SaveSettingOption.All)
        {
            if (op == SaveSettingOption.All ||
                op == SaveSettingOption.SettingsOnly)
            {
                XmlDocument doc = new XmlDocument();
                XmlElement root = doc.CreateElement("to_do_tasks");//<to_do_tasks>

                XmlElement nDesc = doc.CreateElement("description");//<description>
                nDesc.InnerText = "Tập tin cấu hình chương trình";
                root.AppendChild(nDesc);

                XmlElement nConf = doc.CreateElement("configurations");//<configurations>
                XmlElement n = doc.CreateElement("volume");// <volume>
                n.SetAttribute("value", cd.AmLuongThongBao.ToString());
                nConf.AppendChild(n);

                n = doc.CreateElement("notice_sound");// <notice_sound>
                n.SetAttribute("value", cd.TapTinAmThanh);
                nConf.AppendChild(n);

                n = doc.CreateElement("is_hide_on_starting");// <is_hide_on_starting>
                n.SetAttribute("value", cd.AnCTKhiKhoiDong.ToString());
                nConf.AppendChild(n);

                n = doc.CreateElement("is_start_with_os");// <is_start_with_os>
                n.SetAttribute("value", cd.KhoiDongCungHeDieuHanh.ToString());
                nConf.AppendChild(n);

                n = doc.CreateElement("is_hide_window_on_minimizing");// <is_hide_window_on_minimizing>
                n.SetAttribute("value", cd.AnCTKhiThuNho.ToString());
                nConf.AppendChild(n);

                n = doc.CreateElement("users");// <users>
                n.SetAttribute("name", cd.NguoiDung);
                n.SetAttribute("auth", cd.MaXacThuc);

                foreach (string item in HeThong.CaiDat.DanhSachNguoiDung)
                {
                    XmlElement nn = doc.CreateElement("user");// <user>
                    nn.SetAttribute("value", item);

                    n.AppendChild(nn);
                }

                nConf.AppendChild(n);

                root.AppendChild(nConf);
                doc.AppendChild(root);

                doc.Save(this._xmlPath); //save file
            }

            if (op == SaveSettingOption.All ||
                op == SaveSettingOption.UserDataOnly)
            {
                //Save user data
                TaiKhoanDAO tk = new TaiKhoanDAO(HeThong.UsersPath + HeThong.CaiDat.NguoiDung + ".xml");
                tk.SaveUsers();
            }
        }

    }
}
