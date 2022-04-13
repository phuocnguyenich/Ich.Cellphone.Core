using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiHangBLL
    {
        public List<LoaiHang> LayToanBoLoaiHang()
        {
           
            try
            {                
                LoaiHangAccess lhA = new LoaiHangAccess();                
                return lhA.LayToanBoLoaiHang();
            }
            catch(Exception ex)
            {
               
                throw ex;
            }
           
        }
        public void ThemLoaiHang(LoaiHang lh)
        {
            try
            {
                LoaiHangAccess lhA = new LoaiHangAccess();
                lhA.ThemLoaiHang(lh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SuaLoaiHang(LoaiHang lh)
        {
            try
            {
                LoaiHangAccess lhA = new LoaiHangAccess();
                lhA.SuaLoaiHang(lh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void XoaLoaiHang(string maLH)
        {
            try
            {
                LoaiHangAccess lhA = new LoaiHangAccess();
                lhA.XoaLoaiHang(maLH);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string LayTenLoaiHangTheoMa(string maLH)
        {
            try
            {
                LoaiHangAccess lhA = new LoaiHangAccess();
                return lhA.LayTenLoaiHangTheoMa(maLH);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
