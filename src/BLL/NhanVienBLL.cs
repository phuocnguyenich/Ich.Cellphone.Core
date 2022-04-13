using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        public List<NhanVien> LayToanBoNhanVien()
        {
            try
            {
                NhanVienAccess nvAC = new NhanVienAccess();
                return nvAC.LayToanBoNhanVien();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ThemNhanVien(NhanVien nv)
        {
            try
            {
                NhanVienAccess nvAC = new NhanVienAccess();
                nvAC.ThemNhanVien(nv);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SuaNhanVien(NhanVien nv)
        {
            try
            {
                NhanVienAccess nvAC = new NhanVienAccess();
                nvAC.SuaNhanVien(nv);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void XoaNhanVien(string maNV)
        {
            try
            {
                NhanVienAccess nvAC = new NhanVienAccess();
                nvAC.XoaNhanVien(maNV);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public NhanVien DangNhap(string id, string pwd)
        {
            try
            {
                NhanVienAccess nvAc = new NhanVienAccess();
                return nvAc.DangNhap(id, pwd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ValidMaNhanVienToAdd()
        {
            try
            {
                NhanVienAccess nvAc = new NhanVienAccess();
                return nvAc.ValidMaNhanVienToAdd();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// return true if the username exists
        /// else false
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool IsExistedUsername(string userName)
        {
            try
            {
                NhanVienAccess nvAc = new NhanVienAccess();
                return nvAc.IsExistedUsername(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CapQuyenAdmin(string maNV)
        {
            try
            {
                NhanVienAccess nvAc = new NhanVienAccess();
                nvAc.CapQuyenAdmin(maNV);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DoiMatKhau(string maNV, string newPassword)
        {
            try
            {
                NhanVienAccess nvAc = new NhanVienAccess();
                nvAc.DoiMatKhau(maNV, newPassword);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
