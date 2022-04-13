using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        public List<KhachHang> LayToanBoKhachHang()
        {
            try
            {
                KhachHangAccess khAC = new KhachHangAccess();
                return khAC.LayToanBoKhachHang();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void ThemKhachHang(KhachHang kh)
        {
            try
            {
                KhachHangAccess khAC = new KhachHangAccess();
                khAC.ThemKhachHang(kh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SuaKhachHang(KhachHang kh)
        {
            try
            {
                KhachHangAccess khAC = new KhachHangAccess();
                khAC.SuaKhachHang(kh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void XoaKhachHang(string maKH)
        {
            try
            {
                KhachHangAccess khAC = new KhachHangAccess();
                khAC.XoaKhachHang(maKH);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ValidMaKhachHang()
        {
            try
            {
                KhachHangAccess khAc = new KhachHangAccess();
                return khAc.ValidMaKhachHang();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<KhachHang> TimKhachHang(string tenKH)
        {
            try
            {
                KhachHangAccess khAc = new KhachHangAccess();
                return khAc.TimKhachHang(tenKH);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        }
}
