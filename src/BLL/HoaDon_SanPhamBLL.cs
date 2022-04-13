using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDon_SanPhamBLL
    {
        public void ThemHDSP(HoaDon_SanPham hd_sp)
        {
            try
            {
                HoaDon_SanPhamAccess hd_spAC = new HoaDon_SanPhamAccess();
                hd_spAC.ThemHDSP(hd_sp);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
