using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ThongTinChuongTrinhDTO
    {
        private string tenChuongTrinh;
        private string tacGia;
        private string phienBan;
        private string lienHe;

        public string TenChuongTrinh
        {
            get { return tenChuongTrinh; }
            set { tenChuongTrinh = value; }
        }
        public string TacGia
        {
            get { return tacGia; }
            set { tacGia = value; }
        }
        public string PhienBan
        {
            get { return phienBan; }
            set { phienBan = value; }
        }
        public string LienHe
        {
            get { return lienHe; }
            set { lienHe = value; }
        }

        public ThongTinChuongTrinhDTO(string _TenChuongTrinh, string _TacGia, string _PhienBan, string _LienHe)
        {
            this.tenChuongTrinh = _TenChuongTrinh;
            this.tacGia = _TacGia;
            this.phienBan = _PhienBan;
            this.lienHe = _LienHe;
        }

        public ThongTinChuongTrinhDTO()
        {
            this.tenChuongTrinh = "";
            this.tacGia = "";
            this.phienBan = "";
            this.lienHe = "";
        }
    }
}
