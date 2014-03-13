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

        /// <summary>
        /// Đọc dữ liệu người dùng từ tập tin xml
        /// </summary>
        /// <returns></returns>
        public List<TaiKhoanDTO> ReadUsers()
        {
            List<TaiKhoanDTO> users = new List<TaiKhoanDTO>();

            XmlDocument doc = new XmlDocument();
            doc.Load(this._xmlPath);
            XmlElement root = (XmlElement)doc.DocumentElement;// <to_do_tasks>
            XmlNodeList nUsers = root.SelectNodes("user"); // <user>

            //Duyet tung user
            foreach (XmlElement nUser in nUsers)
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();

                // <email>
                XmlElement n = (XmlElement)nUser.SelectNodes("email")[0];
                tk.Email = n.InnerText;

                // <name>
                n = (XmlElement)nUser.SelectNodes("name")[0];
                tk.HoTen = n.InnerText;

                // <type>
                n = (XmlElement)nUser.SelectNodes("type")[0];
                if(n.InnerText.ToLower().CompareTo("registered") == 0)
                {
                    tk.LoaiTaiKhoan = LoaiTaiKhoan.Registered;
                }
                else
                {
                    tk.LoaiTaiKhoan = LoaiTaiKhoan.Anomyous;
                }

                // <schedules>
                n = (XmlElement)nUser.SelectNodes("schedules")[0];

                // <schedule><item>
                XmlNodeList nSchedules = n.SelectNodes("item");
                List<LichLamViecDTO> schedules = new List<LichLamViecDTO>();

                // Duyệt danh sách lịch làm việc
                foreach (XmlElement nSchedule in nSchedules)
                {
                    LichLamViecDTO schedule = new LichLamViecDTO();
                    schedule.ThoiGianDongBoMoiNhat = DateTime.Parse(n.GetAttribute("lastsync"));
                    schedule.Ten = nSchedule.GetAttribute("name");

                    // <task>
                    XmlNodeList nTasks = nSchedule.SelectNodes("task");
                    List<CongViecDTO> tasks = new List<CongViecDTO>();

                    // Duyet danh sach cong viec
                    foreach (XmlElement nTask in nTasks)
                    {
                        CongViecDTO task = new CongViecDTO();

                        // <title>
                        XmlElement nn = (XmlElement)nTask.SelectNodes("title")[0];
                        task.Ten = nn.InnerText;

                        // <place>
                        nn = (XmlElement)nTask.SelectNodes("place")[0];
                        task.DiaDiem = nn.InnerText;

                        // <description>
                        nn = (XmlElement)nTask.SelectNodes("description")[0];
                        task.MieuTa = nn.InnerText;

                        // <color>
                        nn = (XmlElement)nTask.SelectNodes("color")[0];
                        task.MauSacLich = Color.FromArgb(int.Parse(nn.InnerText));

                        // <time>
                        XmlElement nTime = (XmlElement)nTask.SelectNodes("time")[0];

                        // <time><type>
                        nn = (XmlElement)nTime.SelectNodes("type")[0];
                        if(nn.InnerText.ToLower().CompareTo("repeated") == 0)
                        {
                            task.ThoiGianDienRa.Loai = LoaiThoiGianDienRa.Repeated;
                        }
                        else
                        {
                            task.ThoiGianDienRa.Loai = LoaiThoiGianDienRa.Unique;
                        }
                        
                        // <time><start>
                        nn = (XmlElement)nTime.SelectNodes("start")[0];
                        task.ThoiGianDienRa.ThoiGianBatDau = DateTime.Parse(nn.InnerText);

                        // <time><end>
                        nn = (XmlElement)nTime.SelectNodes("end")[0];
                        task.ThoiGianDienRa.ThoiGianKetThuc = DateTime.Parse(nn.InnerText);

                        // <time><repeat>
                        nn = (XmlElement)nTime.SelectNodes("repeat")[0];
                        task.ThoiGianDienRa.SoLanLap = int.Parse(nn.InnerText);

                        // <time><repeated_unit>
                        nn = (XmlElement)nTime.SelectNodes("repeated_unit")[0];
                        task.ThoiGianDienRa.DonViLap = int.Parse(nn.InnerText);

                        // <remind>
                        XmlElement nRemind = (XmlElement)nTask.SelectNodes("remind")[0];

                        // <remind><type>
                        XmlElement nRemindType = (XmlElement)nRemind.SelectNodes("type")[0];

                        // <remind><type><item>
                        XmlNodeList nRemindTypeItems = nRemindType.SelectNodes("item");
                        task.HinhThucNhacNho = new List<LoaiHinhThucNhacNho>();

                        // Duyet danh sach hinh thuc nhac nho
                        foreach(XmlElement item in nRemindTypeItems)
                        {
                            if(item.InnerText.ToLower().CompareTo("email") == 0)
                            {
                                //Kiem tra chua ton tai thi moi them vao
                                if(task.HinhThucNhacNho.IndexOf(LoaiHinhThucNhacNho.Email) == -1)
                                {
                                    task.HinhThucNhacNho.Add(LoaiHinhThucNhacNho.Email);
                                }
                            }
                            else if (item.InnerText.ToLower().CompareTo("notification") == 0)
                            {
                                //Kiem tra chua ton tai thi moi them vao
                                if (task.HinhThucNhacNho.IndexOf(LoaiHinhThucNhacNho.Notification) == -1)
                                {
                                    task.HinhThucNhacNho.Add(LoaiHinhThucNhacNho.Notification);
                                }
                            }
                            else if (item.InnerText.ToLower().CompareTo("sound") == 0)
                            {
                                //Kiem tra chua ton tai thi moi them vao
                                if (task.HinhThucNhacNho.IndexOf(LoaiHinhThucNhacNho.Sound) == -1)
                                {
                                    task.HinhThucNhacNho.Add(LoaiHinhThucNhacNho.Sound);
                                }
                            }
                        }// END Duyet danh sach hinh thuc nhac nho

                        // <remind><time>
                        XmlElement nRemindTime = (XmlElement)nRemind.SelectNodes("time")[0];

                        // <remind><time><item>
                        XmlNodeList nRemindTimeItems = nRemindTime.SelectNodes("item");
                        task.DanhSachThoiGianNhacNho = new List<int>();

                        // Duyet danh sach thoi gian nhac nho (minute)
                        foreach (XmlElement item in nRemindTimeItems)
                        {
                            int v = 0;
                            if (int.TryParse(item.InnerText, out v))
                            {
                                //Kiem tra chua ton tai thi moi them vao
                                if(task.DanhSachThoiGianNhacNho.IndexOf(v) ==-1)
                                {
                                    task.DanhSachThoiGianNhacNho.Add(v);
                                }
                            }

                        }// END Duyet danh sach thoi gian nhac nho

                        // <done>
                        nn = (XmlElement)nTask.SelectNodes("done")[0];
                        task.IsDone = bool.Parse(nn.InnerText);

                        //Them cong viec vao danh sach
                        tasks.Add(task);

                    }// END Duyet danh sach cong viec

                    //Gan danh sach cong viec vao lich lam viec
                    schedule.DanhSachCongViec = tasks;

                    //Them lich lam viec vao danh sach
                    schedules.Add(schedule);

                }// END Duyệt danh sách lịch làm việc

                //Gan danh sach lich lam viec vao user
                tk.LichLamViec = schedules;

                //Them nguoi dung vao danh sach
                users.Add(tk);

            }// END Duyet tung user

            return users;
        }


        /// <summary>
        /// Lưu dữ liệu người dùng xuống file xml
        /// </summary>
        public void SaveUsers()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("to_do_tasks");//<to_do_tasks>

            XmlElement nDesc = doc.CreateElement("description");//<description>
            nDesc.InnerText = "Lịch làm việc của người dùng";
            root.AppendChild(nDesc);

            XmlElement nNode = doc.CreateElement("user");//<user>
            XmlElement n = doc.CreateElement("email");// <email>
            n.InnerText = HeThong.CaiDat.NguoiDung;
            nNode.AppendChild(n);

            n = doc.CreateElement("name");// <name>
            n.InnerText=HeThong.TaiKhoan.HoTen;
            nNode.AppendChild(n);

            n = doc.CreateElement("type");// <type>
            n.InnerText = HeThong.TaiKhoan.LoaiTaiKhoan.ToString();
            nNode.AppendChild(n);

            XmlElement nSchedules = doc.CreateElement("schedules");// <schedules>            
            //duyet danh sach lich lam viec
            foreach (var sc in HeThong.TaiKhoan.LichLamViec)
            {
                nSchedules.SetAttribute("lastsync", sc.ThoiGianDongBoMoiNhat.ToString("MM/dd/yyyy hh:mm:ss"));

                XmlElement nSchedule_Item = doc.CreateElement("item"); // <item>
                nSchedule_Item.SetAttribute("name", sc.Ten);

                foreach(var cv in sc.DanhSachCongViec)
                {
                    XmlElement nTask = doc.CreateElement("task");// <task>
                    n = doc.CreateElement("title"); // <title>
                    n.InnerText = cv.Ten;
                    nTask.AppendChild(n);

                    n = doc.CreateElement("place"); // <place>
                    n.InnerText = cv.DiaDiem;
                    nTask.AppendChild(n);

                    n = doc.CreateElement("description"); // <description>
                    n.InnerText = cv.MieuTa;
                    nTask.AppendChild(n);

                    n = doc.CreateElement("color"); // <color>
                    n.InnerText = cv.MauSacLich.ToArgb().ToString();
                    nTask.AppendChild(n);

                    n = doc.CreateElement("time"); // <time>
                    {
                        XmlElement nTime_child = doc.CreateElement("type");// <type>
                        nTime_child.InnerText = cv.ThoiGianDienRa.Loai.ToString();
                        n.AppendChild(nTime_child);

                        nTime_child = doc.CreateElement("start");// <start>
                        nTime_child.InnerText = cv.ThoiGianDienRa.ThoiGianBatDau.ToString("MM/dd/yyyy hh:mm:ss");
                        n.AppendChild(nTime_child);

                        nTime_child = doc.CreateElement("end");// <end>
                        nTime_child.InnerText = cv.ThoiGianDienRa.ThoiGianKetThuc.ToString("MM/dd/yyyy hh:mm:ss");
                        n.AppendChild(nTime_child);

                        nTime_child = doc.CreateElement("repeat");// <repeat>
                        nTime_child.InnerText = cv.ThoiGianDienRa.SoLanLap.ToString();
                        n.AppendChild(nTime_child);

                        nTime_child = doc.CreateElement("repeated_unit");// <repeated_unit>
                        nTime_child.InnerText = cv.ThoiGianDienRa.DonViLap.ToString();
                        n.AppendChild(nTime_child);
                    }
                    nTask.AppendChild(n);// </time>

                    n = doc.CreateElement("remind"); // <remind>
                    {
                        var nRemind_type = doc.CreateElement("type");// <type>
                        {
                            foreach (LoaiHinhThucNhacNho _item in cv.HinhThucNhacNho)
                            {
                                var nn = doc.CreateElement("item"); // <item>
                                nn.InnerText = _item.ToString();
                                nRemind_type.AppendChild(nn);// </item>
                            }
                        }
                        n.AppendChild(nRemind_type);// </type>

                        var nRemind_time = doc.CreateElement("time");// <time>
                        {
                            foreach (var _item in cv.DanhSachThoiGianNhacNho)
                            {
                                var nn = doc.CreateElement("item"); // <item>
                                nn.InnerText = _item.ToString();
                                nRemind_time.AppendChild(nn);// </item>
                            }
                        }
                        n.AppendChild(nRemind_time);// </time>
                    }
                    nTask.AppendChild(n);// </remind>

                    n = doc.CreateElement("done"); // <done>
                    n.InnerText = cv.IsDone.ToString();
                    nTask.AppendChild(n);

                    nSchedule_Item.AppendChild(nTask); // </task>
                }

                nSchedules.AppendChild(nSchedule_Item); // </item>
            }
            nNode.AppendChild(nSchedules);// </schedules>


            root.AppendChild(nNode);
            doc.AppendChild(root);

            doc.Save(this._xmlPath); //save file
        }





    }
}
