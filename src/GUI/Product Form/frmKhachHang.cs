using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideNavSample
{
    public partial class frmKhachHang : Form
    {
        
        public frmKhachHang()
        {
            InitializeComponent();
            HienThiDSKH();
        }
        #region Methods
        private void HienThiDSKH()
        {
            errorProviderThemKhachHang.Clear();
            try
            {
                lvKhachHang.Items.Clear();

                KhachHangBLL khBLL = new KhachHangBLL();
                List<KhachHang> dsKH = khBLL.LayToanBoKhachHang();

                foreach(KhachHang kh in dsKH)
                {
                    ListViewItem lvi = new ListViewItem(kh.MaKhachHang);
                    lvi.SubItems.Add(kh.TenKhachhang);
                    lvi.SubItems.Add(kh.SoDienThoai);
                    lvi.SubItems.Add(kh.DiaChi);
                    lvi.SubItems.Add(kh.GhiChu);
                    lvi.Tag = kh;

                    lvKhachHang.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy toàn bộ khách hàng:/n" + ex.Message);
            }
        }
        private void MaKhachHangTuSinh()
        {
            try
            {
                KhachHangBLL khBLL = new KhachHangBLL();
                int ma = khBLL.ValidMaKhachHang();
                if(ma == -1)
                {
                    MessageBox.Show("Something wrong");
                    return;
                }
                txtMaKhachHang.Text = "KH"+ma;
                txtTenKhachHang.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi:/n" + ex.Message);
            }
        }

        #endregion

        #region Events
        private void lvKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProviderThemKhachHang.Clear();
            if (lvKhachHang.SelectedItems.Count == 0) return;
            KhachHang kh = lvKhachHang.SelectedItems[0].Tag as KhachHang;

            txtMaKhachHang.Text = kh.MaKhachHang;
            txtTenKhachHang.Text = kh.TenKhachhang;
            txtSDT.Text = kh.SoDienThoai;
            txtDiaChi.Text = kh.DiaChi;
            txtGhiChu.Text = kh.GhiChu;

            txtTenKhachHang.Focus();
        }
        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ShowERROR()) return;
                KhachHang kh = new KhachHang()
                {
                    MaKhachHang = txtMaKhachHang.Text,
                    TenKhachhang = txtTenKhachHang.Text,
                    SoDienThoai = txtSDT.Text,
                    DiaChi = txtDiaChi.Text,
                    GhiChu = txtGhiChu.Text
                };

                KhachHangBLL khBLL = new KhachHangBLL();
                khBLL.ThemKhachHang(kh);
                MessageBox.Show("Thêm khách hàng thành công.");
                HienThiDSKH();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Thêm khách hàng vào CSDL.\nChi Tiết lỗi:\n" + ex.Message);
            }
        }   

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = txtGhiChu.Text = txtSDT.Text = txtTenKhachHang.Text = "";
            txtTenKhachHang.Focus();
            MaKhachHangTuSinh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvKhachHang.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng trong danh sách.");
                return;
            }
            try
            {
                KhachHang kh = new KhachHang()
                {
                    MaKhachHang = txtMaKhachHang.Text,
                    TenKhachhang = txtTenKhachHang.Text,
                    SoDienThoai = txtSDT.Text,
                    DiaChi = txtDiaChi.Text,
                    GhiChu = txtGhiChu.Text
                };

                KhachHangBLL khBLL = new KhachHangBLL();
                khBLL.SuaKhachHang(kh);
                MessageBox.Show("Sửa thông tin khách hàng thành công.");
                HienThiDSKH();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Sửa thông tin khách hàng.\nChi Tiết lỗi:\n" + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvKhachHang.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng trong danh sách.");
                return;
            }
            try
            {
                DialogResult ret = MessageBox.Show(
                    "Bạn muốn xóa khách hàng này?", 
                    "Question",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (ret == DialogResult.No) return;

                KhachHang kh = lvKhachHang.SelectedItems[0].Tag as KhachHang;
                KhachHangBLL khBLL = new KhachHangBLL();
                khBLL.XoaKhachHang(kh.MaKhachHang);
                MessageBox.Show("Xoá thành công");
                HienThiDSKH();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Xóa khách hàng.\nChi Tiết lỗi:\n" + ex.Message);
            }
        }

        #region errorProvider
        private bool ShowERROR()
        {
            errorProviderThemKhachHang.Clear();

            if (txtTenKhachHang.Text == "")
            {
                errorProviderThemKhachHang.SetError(txtTenKhachHang, "Không được trống");
                return false;
            }

            if (txtDiaChi.Text == "")
            {
                errorProviderThemKhachHang.SetError(txtDiaChi, "Không được trống");
                return false;
            }

            return true;
        }





        #endregion

        #endregion

        
    }
}
