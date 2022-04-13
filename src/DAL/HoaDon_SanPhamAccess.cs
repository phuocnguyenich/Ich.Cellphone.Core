using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDon_SanPhamAccess: DataAccess
    {
        public void ThemHDSP(HoaDon_SanPham hd_sp)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "proc_Them_HDSP";
                command.Connection = conn;

                command.Parameters.Add("@SoPhieu", SqlDbType.NVarChar).Value = hd_sp.SoPhieu;
                command.Parameters.Add("@MaSanPham", SqlDbType.NVarChar).Value = hd_sp.MaSanPham;
                command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = hd_sp.SoLuong;
                command.Parameters.Add("@DonGia", SqlDbType.Int).Value = hd_sp.DonGia;
                command.Parameters.Add("@GiamTru", SqlDbType.Int).Value = hd_sp.GiamTru;

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
