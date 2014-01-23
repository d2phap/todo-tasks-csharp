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
        private List<ThongTinChuongTrinhDTO> thongTinChuongTrinh;

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
        public List<ThongTinChuongTrinhDTO> ThongTinChuongTrinh
        {
            get { return thongTinChuongTrinh; }
            set { thongTinChuongTrinh = value; }
        }

        public CaiDatHeThongDTO(int _amLuongTB, string _TapTinAmThanh, bool _AnCTKhoiDong, bool _KhoiDongHeDieuHanh, bool _AnCTThuNho, List<ThongTinChuongTrinhDTO> _ThongTinCT)
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
            this.amLuongThongBao = 0;
            this.tapTinAmThanh = "";
            this.anCTKhiKhoiDong = true;
            this.khoiDongCungHeDieuHanh = true;
            this.anCTKhiThuNho = true;
        }
    }
}
