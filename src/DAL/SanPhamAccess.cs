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
    public class SanPhamAccess: DataAccess
    {
        public List<SanPham> LayToanBoSanPham()
        {
            
            try
            {
                List<SanPham> dsSP = new List<SanPham>();
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = 
                    "select * from SanPham";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    
                    string maSp = reader.GetString(0);
                    string tenSp = reader.GetString(1);
                    int donGia = reader.GetInt32(2);
                    DateTime ngayNhap = reader.GetDateTime(3);   
                    int tonKho = reader.GetInt32(4);
                    string maLH =  reader.GetString(5);
                    string ghiCHu = reader.GetString(6);
                                       

                    SanPham sp = new SanPham()
                    {
                        MaSanPham = maSp,
                        TenSanPham = tenSp,
                        DonGia = donGia,                       
                        NgayNhap = ngayNhap,                      
                        MaLoaiHang = maLH,
                        TonKho = tonKho,
                        GhiChu = ghiCHu
                    };
                    dsSP.Add(sp);
                }
                reader.Close();
                return dsSP;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private DateTime HandlingOnDateTime(SqlDataReader reader, int v)
        {
            if (!reader.IsDBNull(v)) return reader.GetDateTime(v);
            return DateTime.Parse("01/01/1911");
        }

        public void ThemSanPham(SanPham sp)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText =  "proc_ThemSanPham";
                command.Connection = conn;

                command.Parameters.Add("@MaSanPham", SqlDbType.NVarChar).Value = sp.MaSanPham;
                command.Parameters.Add("@TenSanPham", SqlDbType.NVarChar).Value = sp.TenSanPham;
                command.Parameters.Add("@DonGia", SqlDbType.Int).Value = sp.DonGia;
                command.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = sp.NgayNhap;
               // ngày bán bằng null (xem proc_ThemSanPham)              
                command.Parameters.Add("@TonKho", SqlDbType.Int).Value = sp.TonKho;
                command.Parameters.Add("@MaLoaiHang", SqlDbType.NVarChar).Value = sp.MaLoaiHang;
                command.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = sp.GhiChu;

                command.ExecuteNonQuery();
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
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText =
                    "select MaSanPham " +
                    "from SanPham " +
                    "where MaSanPham like '"+maSinh+"%'";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                
                //ds này lưu các mã sản phẩm thuộc maSinh
                //sau khi đã lược bỏ maSinh
                //ví dụ: maSinh = AB -> mã sản phẩm 'AB23'
                //->lược bỏ maSinh -> còn '23'
                //do đó lưu một tập số nguyên để tìm valid mã sản phẩm 
                List<int> dsMa = new List<int>();


                while (reader.Read())
                {
                    string s = reader.GetString(0);
                    s=s.Replace(maSinh, "");
                    dsMa.Add(int.Parse(s));
                }
                reader.Close();
                if (dsMa.Count == 0) return 1;
                dsMa.Sort();// sắp xếp tăng dần

                //quá trình tìm-------------

                //độ dài dsMa
                int len = dsMa.Count;

                //nếu len == dsMa[len - 1] thì tồn tại len sản phẩm có mã
                // đi từ 1 đến len
                //do đó valid mã sẽ là len+1 (mã từ 1 -> len đã có rồi)
                if (len == dsMa[len - 1]) return len + 1;

                //ngược lại sẽ tồn tại một hoặc nhiều mã từ 1 -> len mà bỏ trống
                // ví dụ : 1 2 3 5 6 7 -> trống 4 
                //lúc này ta add 4 vào thì 4 vẫn được
                for(int i = 0; i < len; i++)
                {
                    if(dsMa[i] != i+1)// theo ví dụ trên tại đây 5 != 4 -> ta trả về 4
                    {
                        return i + 1;
                    }
                }
                return -1;
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
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "proc_XoaSanPham";
                command.Connection = conn;

                command.Parameters.Add("@MaSanPham", SqlDbType.NVarChar).Value = maSP;
                

                command.ExecuteNonQuery();
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
                OpenConnection();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "proc_SuaSanPham";
                command.Connection = conn;

                command.Parameters.Add("@MaSanPham", SqlDbType.NVarChar).Value = sp.MaSanPham;
                command.Parameters.Add("@TenSanPham", SqlDbType.NVarChar).Value = sp.TenSanPham;
                command.Parameters.Add("@DonGia", SqlDbType.Int).Value = sp.DonGia;
                command.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = sp.NgayNhap;                             
                command.Parameters.Add("@TonKho", SqlDbType.Int).Value = sp.TonKho;                
                command.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = sp.GhiChu;


                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SanPham> LaySanPhamTheoMaLoaiHang(string maLoaiHang)
        {
            try
            {
                OpenConnection();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from SanPham where MaLoaiHang='"+maLoaiHang+"'";
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();
                List<SanPham> dsSP = new List<SanPham>();

                while (reader.Read())
                {

                    string maSp = reader.GetString(0);
                    string tenSp = reader.GetString(1);
                    int donGia = reader.GetInt32(2);
                    DateTime ngayNhap = reader.GetDateTime(3);
                                        
                    int tonKho = reader.GetInt32(4);
                    string maLH = reader.GetString(5);
                    string ghiCHu = reader.GetString(6);


                    SanPham sp = new SanPham()
                    {
                        MaSanPham = maSp,
                        TenSanPham = tenSp,
                        DonGia = donGia,                       
                        NgayNhap = ngayNhap,
                        MaLoaiHang = maLH,
                        TonKho = tonKho,
                        GhiChu = ghiCHu
                    };
                    dsSP.Add(sp);

                }
                reader.Close();
                return dsSP;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
