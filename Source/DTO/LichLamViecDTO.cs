using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LichLamViecDTO
    {
        private List<CongViecDTO> danhSachCongViec;

        #region Properties
        public List<CongViecDTO> DanhSachCongViec
        {
            get { return danhSachCongViec; }
            set { danhSachCongViec = value; }
        }
        #endregion

        public LichLamViecDTO(List<CongViecDTO> _DSCongViec)
        {
            this.DanhSachCongViec = _DSCongViec;
        }

        public LichLamViecDTO()
        {
            this.DanhSachCongViec = new List<CongViecDTO>();
        }
    }
}
