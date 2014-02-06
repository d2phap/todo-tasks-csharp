using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CaiDatHeThongDTO
    {
        private int amLuongThongBao;
        private string tapTinAmThanh;
        private bool anCTKhiKhoiDong;
        private bool khoiDongCungHeDieuHanh;
        private bool anCTKhiThuNho;
        private ThongTinChuongTrinhDTO thongTinChuongTrinh;

        public int AmLuongThongBao
        {
            get { return amLuongThongBao; }
            set { amLuongThongBao = value; }
        }
        public string TapTinAmThanh
        {
            get { return tapTinAmThanh; }
            set { tapTinAmThanh = value; }
        }
        public bool AnCTKhiKhoiDong
        {
            get { return anCTKhiKhoiDong; }
            set { anCTKhiKhoiDong = value; }
        }
        public bool KhoiDongCungHeDieuHanh
        {
            get { return khoiDongCungHeDieuHanh; }
            set { khoiDongCungHeDieuHanh = value; }
        }
        public bool AnCTKhiThuNho
        {
            get { return anCTKhiThuNho; }
            set { anCTKhiThuNho = value; }
        }
        public ThongTinChuongTrinhDTO ThongTinChuongTrinh
        {
            get { return thongTinChuongTrinh; }
            set { thongTinChuongTrinh = value; }
        }

        public CaiDatHeThongDTO(int _amLuongTB, string _TapTinAmThanh, bool _AnCTKhoiDong, 
            bool _KhoiDongHeDieuHanh, bool _AnCTThuNho, ThongTinChuongTrinhDTO _ThongTinCT)
        {
            this.amLuongThongBao = _amLuongTB;
            this.tapTinAmThanh = _TapTinAmThanh;
            this.anCTKhiKhoiDong = _AnCTKhoiDong;
            this.khoiDongCungHeDieuHanh = _KhoiDongHeDieuHanh;
            this.anCTKhiThuNho = _AnCTThuNho;
            this.thongTinChuongTrinh = _ThongTinCT;
        }

        public CaiDatHeThongDTO()
        {
            this.amLuongThongBao = 800;
            this.tapTinAmThanh = "";
            this.anCTKhiKhoiDong = false;
            this.khoiDongCungHeDieuHanh = true;
            this.anCTKhiThuNho = false;
            this.thongTinChuongTrinh = new ThongTinChuongTrinhDTO("To do tasks", 
                "Dương Diệu Pháp, Bùi Bá Lộc", "1.0", "d2phap@gmail.com");
        }
    }
}
