using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HinhThucNhacNhoDTO
    {
        private string tenHinhThuc;

        public string TenHinhThuc
        {
            get { return tenHinhThuc; }
            set { tenHinhThuc = value; }
        }

        public HinhThucNhacNhoDTO(string _TenHinhThuc)
        {
            this.tenHinhThuc = _TenHinhThuc;
        }

        public HinhThucNhacNhoDTO()
        {
            this.tenHinhThuc = "";
        }
    }
}
