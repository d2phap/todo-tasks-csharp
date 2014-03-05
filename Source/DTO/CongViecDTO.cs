using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DTO
{
    public enum LoaiHinhThucNhacNho
    {
        MessageBox,
        Email,
        Sound
    }

    public class CongViecDTO
    {
        private string ten;
        private ThoiGianDienRaDTO thoiGianDienRa;
        private string diaDiem;
        private string mieuTa;
        private Color mauSacLich;
        private List<int> danhSachThoiGianNhacNho;
        private List<LoaiHinhThucNhacNho> hinhThucNhacNho;
        private bool isDone;

        

        #region Properties
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public ThoiGianDienRaDTO ThoiGianDienRa
        {
            get { return thoiGianDienRa; }
            set { thoiGianDienRa = value; }
        }
        public string DiaDiem
        {
            get { return diaDiem; }
            set { diaDiem = value; }
        }
        public string MieuTa
        {
            get { return mieuTa; }
            set { mieuTa = value; }
        }
        public Color MauSacLich
        {
            get { return mauSacLich; }
            set { mauSacLich = value; }
        }
        public List<int> DanhSachThoiGianNhacNho
        {
            get { return danhSachThoiGianNhacNho; }
            set { danhSachThoiGianNhacNho = value; }
        }
        public List<LoaiHinhThucNhacNho> HinhThucNhacNho
        {
            get { return hinhThucNhacNho; }
            set { hinhThucNhacNho = value; }
        }
        public bool IsDone
        {
            get { return isDone; }
            set { isDone = value; }
        }
        #endregion

        public CongViecDTO()
        {
            this.ten = "";
            this.diaDiem = "";
            this.mieuTa = "";
            this.danhSachThoiGianNhacNho = new List<int>();
            this.mauSacLich = Color.Blue;
            this.HinhThucNhacNho = new List<LoaiHinhThucNhacNho>();
            this.ThoiGianDienRa = new ThoiGianDienRaDTO();
            this.isDone = false;
        }

    }
}
