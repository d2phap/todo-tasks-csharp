using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LoaiTaiKhoanDTO
    {
        private string email;
        private string hoTen;
        private string matKhau;
        private string loaiTaiKhoan;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        public string LoaiTaiKhoan
        {
            get { return loaiTaiKhoan; }
            set { loaiTaiKhoan = value; }
        }

        public LoaiTaiKhoanDTO(string _Email, string _HoTen, string _MatKhau, string _LoaiTaiKhoan)
        {
            this.email = _Email;
            this.hoTen = _HoTen;
            this.matKhau = _MatKhau;
            this.loaiTaiKhoan = _LoaiTaiKhoan;
        }

        public LoaiTaiKhoanDTO()
        {
            this.email = "";
            this.hoTen = "";
            this.matKhau = "";
            this.loaiTaiKhoan = "";
        }
    }
}
