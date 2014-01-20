using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CaiDatHeThongDTO
    {
        private int amLuongThongBao;
        private bool anCTKhiKhoiDong;
        private bool khoiDongCungHeDieuHanh;
        private bool anCTKhiThuNho;
        private List<ThongTinChuongTrinhDTO> thongTinChuongTrinh;

        public int AmLuongThongBao
        {
            get { return amLuongThongBao; }
            set { amLuongThongBao = value; }
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
        public List<ThongTinChuongTrinhDTO> ThongTinChuongTrinh
        {
            get { return thongTinChuongTrinh; }
            set { thongTinChuongTrinh = value; }
        }

        public CaiDatHeThongDTO(int _amLuongTB, bool _AnCTKhoiDong, bool _KhoiDongHeDieuHanh, bool _AnCTThuNho, List<ThongTinChuongTrinhDTO> _ThongTinCT)
        {
            this.amLuongThongBao = _amLuongTB;
            this.anCTKhiKhoiDong = _AnCTKhoiDong;
            this.khoiDongCungHeDieuHanh = _KhoiDongHeDieuHanh;
            this.anCTKhiThuNho = _AnCTThuNho;
            this.thongTinChuongTrinh = _ThongTinCT;
        }

        public CaiDatHeThongDTO()
        {
            this.amLuongThongBao = 0;
            this.anCTKhiKhoiDong = true;
            this.khoiDongCungHeDieuHanh = true;
            this.anCTKhiThuNho = true;
        }
    }
}
