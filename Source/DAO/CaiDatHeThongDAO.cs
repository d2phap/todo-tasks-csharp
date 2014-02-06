using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace DAO
{
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

            return caiDatHeThong;
        }
    }
}
