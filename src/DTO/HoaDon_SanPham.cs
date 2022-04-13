using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_SanPham
    {
        public string SoPhieu { get; set; }
        public string MaSanPham { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int GiamTru { get; set; }

        public int TongTienHang()
        {
            return SoLuong * DonGia;
        }
        public int TienGiamTru()
        {
            return (TongTienHang() * GiamTru) / 100;
        }
        public int TienThanhToan()
        {
            return TongTienHang() - TienGiamTru();
        }
    }
}
