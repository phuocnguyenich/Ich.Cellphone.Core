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
    public partial class frmSanPham : Form
    {
        //Fields
        private SanPham currentSanPham;
        public frmSanPham()
        {
            InitializeComponent();
            HienThiDanhSachSanPham();
            HienThiLoaiHangLenCombobox();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
                 
        }

        #region Methods
        private void HienThiDanhSachSanPham()
        {
            
            try
            {
                lvSanPham.Items.Clear();
                SanPhamBLL spBLL = new SanPhamBLL();
                List<SanPham> dssp = spBLL.LayToanBoSanPham();
                foreach(SanPham sp in dssp)
                {
                    ListViewItem lvi = new ListViewItem(sp.MaSanPham);
                    lvi.SubItems.Add(sp.TenSanPham);
                    lvi.SubItems.Add(sp.DonGia+"");                    
                    lvi.SubItems.Add(sp.NgayNhap + "");

                    if(sp.NgayBan.Year < sp.NgayNhap.Year)      lvi.SubItems.Add("null");
                    else lvi.SubItems.Add(sp.NgayBan + "");
                    lvi.SubItems.Add(sp.TonKho + "");

                    lvi.Tag = sp;                    

                    lvSanPham.Items.Add(lvi);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Khi lấy toàn bộ sản phẩm.\nChi tiết lỗi:\n" + ex.Message);
            }
        }
        private void HienThiLoaiHangLenCombobox()
        {
            try
            {
                cboLoaiHang.Items.Clear();
                LoaiHangBLL lhBll = new LoaiHangBLL();
                List<LoaiHang> dsLH = lhBll.LayToanBoLoaiHang();
                foreach (LoaiHang lh in dsLH)
                {
                    cboLoaiHang.Items.Add(lh);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Khi lấy Loại Hàng.\nChi tiết lỗi:\n" + ex.Message);
            }
        }
        #endregion


        #region Events
        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count == 0) return;
            SanPham sp = lvSanPham.SelectedItems[0].Tag as SanPham;
            LoaiHangBLL lhbll = new LoaiHangBLL();

            cboLoaiHang.Text = lhbll.LayTenLoaiHangTheoMa(sp.MaLoaiHang);
            txtMaSanPham.Text = sp.MaSanPham;
            txtTenSanPham.Text = sp.TenSanPham;
            txtTonKho.Text = sp.TonKho + "";
            txtGhiChu.Text = sp.GhiChu;
            txtDonGia.Text = sp.DonGia + "";
            dtpNgayNhap.Value = sp.NgayNhap;
            
            
            
        }
        private void cboLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaSanPham.Text = "";
            if (cboLoaiHang.SelectedIndex == -1) return;
            try
            {    
                LoaiHang lh = cboLoaiHang.SelectedItem as LoaiHang;
                SanPhamBLL spBLL = new SanPhamBLL();
                int soLuongSanPhamCuaMaSinh = spBLL.ValidMaSanPhamToAdd(lh.MaSanPhamTuSinh);
                txtMaSanPham.Text = lh.MaSanPhamTuSinh + soLuongSanPhamCuaMaSinh;
                txtTenSanPham.Focus();

                //current san pham
                currentSanPham = new SanPham()
                {
                    MaLoaiHang = lh.MaLoaiHang,
                    MaSanPham = txtMaSanPham.Text
                };                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi sản phẩm Lấy valid mã sinh\n" + ex.Message);
            }
        }

        private void btnThemLoaiHang_Click(object sender, EventArgs e)
        {
            frmThemLoaiHang Frm = new frmThemLoaiHang();
            if (Frm.ShowDialog() == DialogResult.OK)
            {
                HienThiLoaiHangLenCombobox();
            }
        }
        private void btnNewSanPham_Click(object sender, EventArgs e)
        {
            cboLoaiHang.Text = "";
            txtMaSanPham.Text = "";
            txtTenSanPham.Text = "";
            txtTonKho.Text = "";
            txtGhiChu.Text = "";
            txtDonGia.Text = "";
            
            cboLoaiHang.Focus();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            
            if (!ShowError()) return;
            try
            {
                currentSanPham.TenSanPham = txtTenSanPham.Text;
                currentSanPham.DonGia = int.Parse(txtDonGia.Text);
                currentSanPham.TonKho = int.Parse(txtTonKho.Text);
                currentSanPham.NgayNhap = dtpNgayNhap.Value;                 
                currentSanPham.GhiChu = txtGhiChu.Text;

                //insert new sanpham to database
                SanPhamBLL spBLL = new SanPhamBLL();
                spBLL.ThemSanPham(currentSanPham);
                MessageBox.Show("Thêm sản phẩm thành công.");
                HienThiDanhSachSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sản phẩm.\nChi tiết lỗi:\n" + ex.Message);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ShowError()) return;
            try
            {
                if (lvSanPham.SelectedItems.Count == 0) return;
                SanPham curSP = lvSanPham.SelectedItems[0].Tag as SanPham;
                SanPhamBLL spBLL = new SanPhamBLL();

                curSP.TenSanPham = txtTenSanPham.Text;
                curSP.DonGia = int.Parse(txtDonGia.Text);
                curSP.TonKho = int.Parse(txtTonKho.Text);
                curSP.NgayNhap = dtpNgayNhap.Value;
                curSP.GhiChu = txtGhiChu.Text;


                // cboLoaiHang_SelectedIndexChanged
                // current sanpham now exist
                if (currentSanPham.MaLoaiHang != curSP.MaLoaiHang)
                {
                    //another elements
                    currentSanPham.TenSanPham = txtTenSanPham.Text;
                    currentSanPham.DonGia = int.Parse(txtDonGia.Text);
                    currentSanPham.TonKho = int.Parse(txtTonKho.Text);
                    currentSanPham.NgayNhap = dtpNgayNhap.Value;
                    currentSanPham.GhiChu = txtGhiChu.Text;

                    //delete the old 
                    spBLL.XoaSanPham(curSP.MaSanPham);
                    //insert the new
                    spBLL.ThemSanPham(currentSanPham);
                }
                else               
                    spBLL.SuaSanPham(curSP);

                MessageBox.Show("Sửa sản phẩm thành công.");
                HienThiDanhSachSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa sản phẩm.\nChi tiết lỗi:\n" + ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (lvSanPham.SelectedItems.Count == 0) return;
                SanPham curSP = lvSanPham.SelectedItems[0].Tag as SanPham;

                DialogResult ret = MessageBox.Show(
                    "Bạn muốn xóa sản phẩm này?",
                    "Question",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (ret == DialogResult.No) return;

                SanPhamBLL spBLL = new SanPhamBLL();
                spBLL.XoaSanPham(curSP.MaSanPham);
                MessageBox.Show("Xóa sản phẩm thành công.");
                HienThiDanhSachSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa sản phẩm.\nChi tiết lỗi:\n" + ex.Message);
            }

        }

        #region ErrorOnErrorProvider
        private bool ShowError()
        {
            errorProvider1.Clear();
            if (cboLoaiHang.SelectedIndex == -1)
            {
                errorProvider1.SetError(
                    cboLoaiHang,
                    "Chọn một Loại Hàng hoặc tạo mới."
                    );
                return false;
            }
            if (txtTenSanPham.Text == "")
            {
                errorProvider1.SetError(txtTenSanPham, "Không được trống.");
                return false;
            }
            int check = -1;
            if (!int.TryParse(txtDonGia.Text,out check))
            {
                errorProvider1.SetError(txtDonGia, "Không được trống.");
                return false;
            }
            if (!int.TryParse(txtTonKho.Text, out check))
            {
                errorProvider1.SetError(txtTonKho, "Không được trống.");
                return false;
            }            
            return true;
        }






        #endregion

        #endregion

        
    }
}
