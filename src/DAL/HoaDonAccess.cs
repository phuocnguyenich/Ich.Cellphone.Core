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
    public class HoaDonAccess: DataAccess
    {
        public void ThemHoaDon(HoaDon hd)
        {
            try
            {                
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "proc_ThemHoaDon";
                command.Connection = conn;

                command.Parameters.Add("@SoPhieu", SqlDbType.NVarChar).Value = hd.SoPhieu;
                command.Parameters.Add("@MaNhanVien", SqlDbType.NVarChar).Value = hd.MaNhanVien;
                command.Parameters.Add("@MaKhachHang", SqlDbType.NVarChar).Value = hd.MaKhachhang;
                command.Parameters.Add("@NgayLapPhieu", SqlDbType.DateTime).Value = hd.NgayLapPhieu;
                command.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = hd.GhiChu;

                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void XoaHoaDon(string soPhieu)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.proc_XoaHoaDon";
                command.Connection = conn;

                command.Parameters.Add("@SoPhieu", SqlDbType.NVarChar).Value = soPhieu;

                command.ExecuteNonQuery();
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
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select SoPhieu from HoaDonBanHang";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                List<int> dsMa = new List<int>();
                while (reader.Read())
                {
                    string s = reader.GetString(0);
                    s = s.Substring(2);
                    dsMa.Add(int.Parse(s));
                }
                reader.Close();

                if (dsMa.Count == 0) return 1;
                int len = dsMa.Count;
                if (dsMa[len - 1] == len) return len + 1;

                for(int i = 0; i < len; i++)
                {
                    if (dsMa[i] != i + 1) return i + 1;
                }
                return -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
