using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPhamBLL
    {
        public List<SanPham> LayToanBoSanPham()
        {
            try
            {
                SanPhamAccess spA = new SanPhamAccess();
                return spA.LayToanBoSanPham();

            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<SanPham> LaySanPhamTheoMaLoaiHang(string maLoaiHang)
        {
            try
            {
                SanPhamAccess spA = new SanPhamAccess();
                return spA.LaySanPhamTheoMaLoaiHang(maLoaiHang);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ValidMaSanPhamToAdd(string maSinh)

        {
            try
            {
                SanPhamAccess spA = new SanPhamAccess();
                return spA.ValidMaSanPhamToAdd(maSinh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ThemSanPham(SanPham sp)
        {
            try
            {
                SanPhamAccess spA = new SanPhamAccess();
                spA.ThemSanPham(sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void XoaSanPham(string maSP)
        {
            try
            {
                SanPhamAccess spA = new SanPhamAccess();
                spA.XoaSanPham(maSP);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SuaSanPham(SanPham sp)
        {
            try
            {
                SanPhamAccess spA = new SanPhamAccess();
                spA.SuaSanPham(sp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
