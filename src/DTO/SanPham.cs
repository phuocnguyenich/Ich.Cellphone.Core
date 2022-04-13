using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }       
        public int DonGia { get; set; }
        public DateTime NgayNhap { get; set; }
        public DateTime NgayBan { get; set; }        
        public int TonKho { get; set; }
        public string MaLoaiHang { get; set; }
        public string GhiChu { get; set; }
        public override string ToString()
        {
            return TenSanPham;
        }

    }
}