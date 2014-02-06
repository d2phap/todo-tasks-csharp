using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Drawing;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        private string _xmlPath = string.Empty;
        public TaiKhoanDAO(string xmlPath)
        {
            this._xmlPath = xmlPath;
        }

        public TaiKhoanDTO ReadUser()
        {
            TaiKhoanDTO taiKhoan = new TaiKhoanDTO();

            XmlDocument doc = new XmlDocument();
            doc.Load(this._xmlPath);
            XmlElement root = (XmlElement)doc.DocumentElement;
            XmlElement nUser = (XmlElement)root.SelectNodes("user")[0];

            XmlElement nEmail = (XmlElement)nUser.SelectNodes("email")[0];
            taiKhoan.Email = nEmail.InnerText;

            XmlElement nName = (XmlElement)nUser.SelectNodes("name")[0];
            taiKhoan.HoTen = nName.InnerText;

            XmlElement nLoaiTaiKhoan = (XmlElement)nUser.SelectNodes("type")[0];

            if (nLoaiTaiKhoan.InnerText.ToLower().CompareTo("registered") == 0)
            {
                taiKhoan.LoaiTaiKhoan = DTO.LoaiTaiKhoan.Registered;
            }
            else
            {
                taiKhoan.LoaiTaiKhoan = DTO.LoaiTaiKhoan.Anomyous;
            }

            XmlElement nSchedules = (XmlElement)nUser.SelectNodes("schedules")[0];
            taiKhoan.LichLamViec = new List<LichLamViecDTO>();
            for (int i = 0; i < taiKhoan.LichLamViec.Count; i++)
            {

                XmlElement nItem = (XmlElement)nSchedules.SelectNodes( " " +(i + 1).ToString())[0];
                for (int j = 0; j < (i + 1); j++)
                {
                    CongViecDTO CongViec = new CongViecDTO();
                    XmlElement nTask = (XmlElement)nItem.SelectNodes(" " + (j + 1).ToString())[0];

                    XmlElement nTitle = (XmlElement)nTask.SelectNodes("title")[0];
                    CongViec.Ten = nTitle.InnerText;
                    XmlElement nPlace = (XmlElement)nTask.SelectNodes("place")[0];
                    CongViec.DiaDiem = nPlace.InnerText;
                    XmlElement nDesCription = (XmlElement)nTask.SelectNodes("description")[0];
                    CongViec.MieuTa = nDesCription.InnerText;
                    XmlElement nColor = (XmlElement)nTask.SelectNodes("color")[0];
                    //CongViec.MauSacLich =  nColor.InnerText;
                    XmlElement nTime = (XmlElement)nTask.SelectNodes("time")[0];
                    //XmlElement n
                }
            }

                return null;

        }
    }
}
