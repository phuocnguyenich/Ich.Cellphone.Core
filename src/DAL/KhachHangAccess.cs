using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangAccess:DataAccess
    {
        public List<KhachHang> LayToanBoKhachHang()
        {
            try
            {
                List<KhachHang> dsKH = new List<KhachHang>();
                OpenConnection();
                SqlCommand commamd = new SqlCommand();
                commamd.CommandType = CommandType.Text;
                commamd.CommandText = "select * from KhachHang";
                commamd.Connection = conn;

                SqlDataReader reader = commamd.ExecuteReader();

                while (reader.Read())
                {
                    KhachHang kh = new KhachHang()
                    {
                        MaKhachHang = reader.GetString(0),
                        TenKhachhang = reader.GetString(1),
                        SoDienThoai = reader.GetString(2),
                        DiaChi = reader.GetString(3),
                        GhiChu = reader.GetString(4)
                    };
                    dsKH.Add(kh);
                }
                reader.Close();

                return dsKH;
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
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "proc_ThemKhachHang";
                command.Connection = conn;

                command.Parameters.Add("@MaKhachHang", SqlDbType.NVarChar).Value = kh.MaKhachHang;
                command.Parameters.Add("@TenKhachhang", SqlDbType.NVarChar).Value = kh.TenKhachhang;
                command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = kh.SoDienThoai;
                command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = kh.DiaChi;
                command.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = kh.GhiChu;

                command.ExecuteNonQuery();
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
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "proc_SuaKhachHang";
                command.Connection = conn;

                command.Parameters.Add("@MaKhachHang", SqlDbType.NVarChar).Value = kh.MaKhachHang;
                command.Parameters.Add("@TenKhachhang", SqlDbType.NVarChar).Value = kh.TenKhachhang;
                command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = kh.SoDienThoai;
                command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = kh.DiaChi;
                command.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = kh.GhiChu;

                command.ExecuteNonQuery();
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
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "proc_XoaKhachHang";
                command.Connection = conn;

                command.Parameters.Add("@MaKhachHang", SqlDbType.NVarChar).Value = maKH;
               
                command.ExecuteNonQuery();
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
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select MaKhachHang from KhachHang";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                List<int> dsMa = new List<int>();
                while (reader.Read())
                {
                    string s = reader.GetString(0);
                    s = s.Replace("KH","");
                    dsMa.Add(int.Parse(s));
                    
                }
                if (dsMa.Count == 0) return 1;
                
                int len = dsMa.Count;
                if (dsMa[len - 1] == len) return len + 1;
                dsMa.Sort();
                for(int i = 0; i < len-1; i++)
                    {
                        if (dsMa[i] != i + 1) 
                            return i+1;
                    }
                return -1;
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
                List<KhachHang> dsKH = new List<KhachHang>();
                
                OpenConnection();
                SqlCommand commamd = new SqlCommand();
                commamd.CommandType = CommandType.StoredProcedure;
                commamd.CommandText = "proc_TimKhachHang";
                commamd.Connection = conn;

                commamd.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar).Value = tenKH;

                SqlDataReader reader = commamd.ExecuteReader();

                while (reader.Read())
                {
                    KhachHang kh = new KhachHang()
                    {
                        MaKhachHang = reader.GetString(0),
                        TenKhachhang = reader.GetString(1),
                        SoDienThoai = reader.GetString(2),
                        DiaChi = reader.GetString(3),
                        GhiChu = reader.GetString(4)
                    };
                    dsKH.Add(kh);
                }
                reader.Close();

                return dsKH;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
