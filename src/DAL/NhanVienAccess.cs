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
    public class NhanVienAccess: DataAccess
    {
        public List<NhanVien> LayToanBoNhanVien()
        {
            try
            {
                List<NhanVien> dsNV = new List<NhanVien>();
                OpenConnection();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from NhanVien";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    NhanVien nv = new NhanVien()
                    {
                        MaNhanVien = reader.GetString(0),
                        TenNhanVien = reader.GetString(1),
                        NgaySinh =  reader.GetDateTime(2),
                        SoDienThoai = reader.GetString(3),
                        Email = reader.GetString(4),
                        DiaChi = reader.GetString(5),
                        IsAdmin = reader.GetInt32(8)
                    };
                    dsNV.Add(nv);
                }
                reader.Close();
                return dsNV;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void ThemNhanVien(NhanVien nv)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "proc_ThemNhanVien";
                command.Connection = conn;

                command.Parameters.Add("@MaNhanVien", SqlDbType.NVarChar).Value = nv.MaNhanVien;
                command.Parameters.Add("@TenNhanVien", SqlDbType.NVarChar).Value = nv.TenNhanVien;
                command.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = nv.NgaySinh;
                command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = nv.SoDienThoai;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = nv.Email;
                command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nv.DiaChi;
                command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = nv.Username;
                command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = nv.Password;
                command.Parameters.Add("@IsAdmin", SqlDbType.Int).Value = nv.IsAdmin;

                command.ExecuteNonQuery();
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
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "proc_SuaNhanVien";
                command.Connection = conn;

                command.Parameters.Add("@MaNhanVien", SqlDbType.NVarChar).Value = nv.MaNhanVien;
                command.Parameters.Add("@TenNhanVien", SqlDbType.NVarChar).Value = nv.TenNhanVien;
                command.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = nv.NgaySinh;
                command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = nv.SoDienThoai;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = nv.Email;
                command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nv.DiaChi;

                command.ExecuteNonQuery();
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
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "proc_XoaNhanVien";
                command.Connection = conn;

                command.Parameters.Add("@MaNhanVien", SqlDbType.NVarChar).Value = maNV;                

                command.ExecuteNonQuery();
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
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "proc_DangNhap";
                command.Connection = conn;

                command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = id;
                command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = pwd;


                SqlDataReader reader = command.ExecuteReader();
                NhanVien nv = new NhanVien();
                if (reader.Read())
                {
                    nv.MaNhanVien =  reader.GetString(0);
                    nv.TenNhanVien = reader.GetString(1);
                    nv.NgaySinh = reader.GetDateTime(2);
                    nv.SoDienThoai = reader.GetString(3);
                    nv.Email = reader.GetString(4);
                    nv.DiaChi = reader.GetString(5);
                    nv.Username = reader.GetString(6);
                    nv.Password = reader.GetString(7);
                    nv.IsAdmin = reader.GetInt32(8);
                }
                reader.Close();
                return nv;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int ValidMaNhanVienToAdd()
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select MaNhanVien from NhanVien";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();

                //this list contain special number of MaNhanVien
                List<int> dsMa = new List<int>();

                while (reader.Read())
                {
                    string s = reader.GetString(0);
                    s = s.Substring(2);
                    dsMa.Add(int.Parse(s));
                }
                reader.Close();

                int len = dsMa.Count;
                //if list is empty
                if (len == 0) return 1;
                
                //if the last = len then the next one is len + 1
                if (dsMa[len - 1] == len) return len + 1;

                for(int i = 0; i < len; i++)
                {
                    if (dsMa[i] != i + 1) return i + 1;
                }
                return 0;
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
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from NhanVien where Username='"+userName+"'";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    //username existed
                    return true;
                }
                reader.Close();
                return false;

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
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "proc_CapQuyenAdmin";
                command.Connection = conn;


                command.Parameters.Add("@MaNhanVien", SqlDbType.NVarChar).Value = maNV;

                command.ExecuteNonQuery();
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
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "proc_DoiMatKhau";
                command.Connection = conn;


                command.Parameters.Add("@MaNhanVien", SqlDbType.NVarChar).Value = maNV;
                command.Parameters.Add("@MatKhauMoi", SqlDbType.NVarChar).Value = newPassword;

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
