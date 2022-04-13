using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// 1 - this is an admin
        /// 0 - this is a staff
        /// </summary>
        public int IsAdmin { get; set; }
        
    }
}
