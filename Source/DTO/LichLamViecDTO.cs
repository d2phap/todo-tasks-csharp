using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LichLamViecDTO
    {
        private List<CongViecDTO> danhSachCongViec;

        public List<CongViecDTO> DanhSachCongViec
        {
            get { return danhSachCongViec; }
            set { danhSachCongViec = value; }
        }

        public LichLamViecDTO(List<CongViecDTO> _DSCongViec)
        {
            this.danhSachCongViec = _DSCongViec;
        }

        public LichLamViecDTO()
        { 

        }
    }
}
