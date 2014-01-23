using DTO;
using System;
using System.Collections.Generic;
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


        public CaiDatHeThongDTO ReadConfiguration()
        {
            CaiDatHeThongDTO CaiDatHeThong = new CaiDatHeThongDTO();
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
            CaiDatHeThong.AmLuongThongBao = amluong;

            XmlElement nNoticeSound = (XmlElement)nConfig.SelectNodes("notice_sound ")[0];
            //Get <Notice_Sound> Attribute
            CaiDatHeThong.TapTinAmThanh = nNoticeSound.GetAttribute("value");

            XmlElement nIsHideOnStart = (XmlElement)nConfig.SelectNodes("is_hide_on_starting")[0];
            //Get <IsHideOnStart> Attribute
            CaiDatHeThong.AnCTKhiKhoiDong = bool.Parse(nIsHideOnStart.GetAttribute("value"));

            XmlElement nIsStartOS = (XmlElement)nConfig.SelectNodes("is_start_with_os")[0];
            //Get <IsStartOS> Attribute
            CaiDatHeThong.KhoiDongCungHeDieuHanh = bool.Parse(nIsStartOS.GetAttribute("value"));

            XmlElement nIsHideWindowMini = (XmlElement)nConfig.SelectNodes("is_hide_window_on_minimizing")[0];
            //Get <IsHideWindowMini> Attribute
            CaiDatHeThong.AnCTKhiThuNho = bool.Parse(nIsHideWindowMini.GetAttribute("value"));

            return CaiDatHeThong;
        }
    }
}
