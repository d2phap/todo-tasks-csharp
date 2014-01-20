using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ThoiGianDienRaDTO
    {
        private string loai;
        private DateTime thoiGianBatDau;
        private DateTime thoiGianKetThuc;
        private int soLanLap;
        private int donViLap;

        public string Loai
        {
            get { return loai; }
            set { loai = value; }
        }
        public DateTime ThoiGianBatDau
        {
            get { return thoiGianBatDau; }
            set { thoiGianBatDau = value; }
        }
        public DateTime ThoiGianKetThuc
        {
            get { return thoiGianKetThuc; }
            set { thoiGianKetThuc = value; }
        }
        public int SoLanLap
        {
            get { return soLanLap; }
            set { soLanLap = value; }
        }
        public int DonViLap
        {
            get { return donViLap; }
            set { donViLap = value; }
        }

        public ThoiGianDienRaDTO(string _Loai, DateTime _ThoiGianBatDau, DateTime _ThoiGianKetThuc, int _SoLanLap, int _DonViLap)
        {
            this.loai = _Loai;
            this.thoiGianBatDau = _ThoiGianBatDau;
            this.thoiGianKetThuc = _ThoiGianKetThuc;
            this.soLanLap = _SoLanLap;
            this.donViLap = _DonViLap;
        }

        public ThoiGianDienRaDTO()
        {
            this.loai = "";
            this.thoiGianBatDau = DateTime.Now;
            this.thoiGianKetThuc = DateTime.Now.AddMinutes(1);
            this.soLanLap = 0;
            this.donViLap = 0;
        }
    }
}
