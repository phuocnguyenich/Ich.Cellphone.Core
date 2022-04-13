using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        public void ThemHoaDon(HoaDon hd)
        {
            try
            {
                HoaDonAccess hdAC = new HoaDonAccess();
                hdAC.ThemHoaDon(hd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void XoaHoaDon(string soPhieu)
        {
            try
            {
                HoaDonAccess hdAC = new HoaDonAccess();
                hdAC.XoaHoaDon(soPhieu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ValidSoPhieu()
        {
            try
            {
                HoaDonAccess hdAC = new HoaDonAccess();
                return hdAC.ValidSoPhieu();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        }
}
