using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiHang
    {
        public string MaLoaiHang { get; set; }
        public string TenLoaiHang { get; set; }
        public string MaSanPhamTuSinh{ get; set; }
        public override string ToString()
        {
            return TenLoaiHang;
        }
    }
}
