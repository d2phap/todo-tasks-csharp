using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public enum LoaiTaiKhoan
    {
        Anomyous,
        Registered
    }

    public class TaiKhoanDTO
    {
        private string email;
        private string hoTen;
        private string matKhau;
        private LoaiTaiKhoan loaiTaiKhoan;
        private List<LichLamViecDTO> lichLamViec;

        #region Properties
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
        public LoaiTaiKhoan LoaiTaiKhoan
        {
            get { return loaiTaiKhoan; }
            set { loaiTaiKhoan = value; }
        }
        public List<LichLamViecDTO> LichLamViec
        {
            get { return lichLamViec; }
            set { lichLamViec = value; }
        }
        #endregion

        public TaiKhoanDTO()
        {
            this.Email = "";
            this.HoTen = "";
            this.MatKhau = "";
            this.LoaiTaiKhoan = LoaiTaiKhoan.Anomyous;
            this.LichLamViec = new List<LichLamViecDTO>();
        }
    }
}
