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
    public class LoaiHangAccess:DataAccess
    {
        public List<LoaiHang> LayToanBoLoaiHang()
        {
            
            try
            {
                List<LoaiHang> dsLH = new List<LoaiHang>();
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from LoaiHang";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string maLH = reader.GetString(0);
                    string tenLH = reader.GetString(1);
                    string maSinhSP = reader.GetString(2);
                    LoaiHang lh = new LoaiHang()
                    {
                        MaLoaiHang = maLH,
                        TenLoaiHang = tenLH,
                        MaSanPhamTuSinh = maSinhSP
                    };
                    dsLH.Add(lh);
                }
                reader.Close();
                return dsLH;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ThemLoaiHang(LoaiHang lh)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand();

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "proc_ThemLoaiHang";
                command.Connection = conn;

                //SqlCommandBuilder builder = new SqlCommandBuilder();
                
                command.Parameters.Add("@MaLoaiHang", SqlDbType.NVarChar).Value = lh.MaLoaiHang;
                command.Parameters.Add("@TenLoaiHang", SqlDbType.NVarChar).Value = lh.TenLoaiHang;
                command.Parameters.Add("@MaSanPhamTuSinh", SqlDbType.NVarChar).Value = lh.MaSanPhamTuSinh;

                command.ExecuteNonQuery();
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
                OpenConnection();
                SqlCommand command = new SqlCommand();

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "pro_SuaLoaiHang";
                command.Connection = conn;

        

                command.Parameters.Add("@MaLoaiHang", SqlDbType.NVarChar).Value = lh.MaLoaiHang;
                command.Parameters.Add("@TenLoaiHang", SqlDbType.NVarChar).Value = lh.TenLoaiHang;
                command.Parameters.Add("@MaSanPhamTuSinh", SqlDbType.NVarChar).Value = lh.MaSanPhamTuSinh;

                command.ExecuteNonQuery();
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
                OpenConnection();
                SqlCommand command = new SqlCommand();

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "pro_XoaLoaiHang";
                command.Connection = conn;



                command.Parameters.Add("@MaLoaiHang", SqlDbType.NVarChar).Value = maLH;
                

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string LayMaLoaiHangTheoTen(string tenLH)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand();

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "pro_TimLoaiHang";
                command.Connection = conn;



                command.Parameters.Add("@TenLoaiHang", SqlDbType.NVarChar).Value = tenLH;

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {                    
                    return reader.GetString(0);                    
                }
                reader.Close();
                return "";
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
                OpenConnection();
                SqlCommand command = new SqlCommand();

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select TenLoaiHang from LoaiHang where MaLoaiHang = '"+maLH+"'";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetString(0);
                }
                reader.Close();
                return "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
