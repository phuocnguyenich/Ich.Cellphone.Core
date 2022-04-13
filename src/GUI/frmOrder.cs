using BLL;
using DevComponents.DotNetBar;
using DTO;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideNavSample
{
    public partial class frmOrder : Form
    {
        #region Properties      
        /// <summary>
        ///  người đang sử dụng phần mềm
        ///  là nhân viên lập hóa đơn
        /// </summary>        
        private NhanVien currentUser;

        /// <summary>
        /// hóa đơn của khách hàng này
        /// </summary>
        private KhachHang currentKhachHang;

        /// <summary>
        /// thêm sản phẩm này vào giỏ hàng
        /// </summary>
        private SanPham currentSanPham;

        /// <summary>
        /// danh sách sản phẩm hiện tại 
        /// </summary>
        private List<HoaDon_SanPham> gioHang = new List<HoaDon_SanPham>();

        //another
        private int tongTienHang = 0;
        private int tienGiamTru = 0;
        private int tienThanhToan = 0;


        #endregion

        public frmOrder(NhanVien curUser)
        {
            InitializeComponent();
            currentUser = curUser;

              /*Test
            currentUser = new NhanVien()
             {
                 MaNhanVien = "NV89",
                 TenNhanVien = "NVTest"
             };
            */
            frmOrder_Load();
        }

        private void frmOrder_Load()
        {
            KhoiTaoHoaDon_UI();
        }

        #region Methods       

        private void KhoiTaoHoaDon_UI()
        {
            currentSanPham = null;
            cboLoaiHang.Text = cboTenSanPham.Text = txtSoLuong.Text = txtGiamTru.Text = "";
            lblSoLuongToiDa.Visible = false;

            lvGioHang.Items.Clear();
            //another
            txtTongTienHang.Text = txtTienGiamTru.Text = txtTienPhaiTra.Text = txtGhiChu.Text = "";

            //so phieu
            try
            {
                HoaDonBLL hdBLL = new HoaDonBLL();
                txtSoPhieu.Text = "HD" + hdBLL.ValidSoPhieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo mã hóa đơn:\n" + ex.Message);
            }

            HienThiLoaiHang();
        }

        /// <summary>
        /// hien thi loai hang len combobox LoaiHang
        /// </summary>
        private void HienThiLoaiHang()
        {
            cboLoaiHang.Items.Clear();
            try
            {
                LoaiHangBLL lhBLL = new LoaiHangBLL();
                List<LoaiHang> dsLH = lhBLL.LayToanBoLoaiHang();
                foreach (LoaiHang lh in dsLH)
                {
                    cboLoaiHang.Items.Add(lh);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị loại hàng:\n" + ex.Message);
            }
        }
        /// <summary>
        /// hien thi dsSP cua loai hang vua chon len comboboxSanPham
        /// </summary>
        /// <param name="lh"></param>
        private void HienThiSanPham(LoaiHang lh)
        {
            cboTenSanPham.Items.Clear();
            try
            {                
                SanPhamBLL spBLL = new SanPhamBLL();
                List<SanPham> dsSP = spBLL.LaySanPhamTheoMaLoaiHang(lh.MaLoaiHang);
                foreach (SanPham sp in dsSP)
                {
                    cboTenSanPham.Items.Add(sp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị sản phẩm:\n" + ex.Message);
            }
        }


        /// <summary>
        /// thêm gioHang vào csdl
        /// </summary>       
        private void ThemGioHangVaoCSDL()
        {
            try
            {
                HoaDon_SanPhamBLL hdspBLL = new HoaDon_SanPhamBLL();
                foreach (HoaDon_SanPham hdsp in gioHang)
                {
                    hdspBLL.ThemHDSP(hdsp);
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm giỏ hàng vào csdl (thêm hóa đơn_sản phẩm)\n" + ex.Message);
            }
        }
        /// <summary>
        /// hien thi tong tien hang, tien giam tru, tien phai tra
        /// </summary>
        private void HienThiTien()
        {
            txtTongTienHang.Text = tongTienHang + "";
            txtTienGiamTru.Text = tienGiamTru + "";
            txtTienPhaiTra.Text = tienThanhToan + "";
        }
        #endregion

        #region Event

        #region Chon_San_Pham_Them_Vao_Gio_Hang
        private void cmbLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiHang.SelectedIndex == -1) return;
            LoaiHang lh = cboLoaiHang.SelectedItem as LoaiHang;

            HienThiSanPham(lh);
        }

        private void cboTenSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenSanPham.SelectedIndex == -1) return;
            currentSanPham = cboTenSanPham.SelectedItem as SanPham;

            txtSoLuong.Text = txtGiamTru.Text = "0";
            txtDonGia.Text = currentSanPham.DonGia + "";
            if (currentSanPham.TonKho > 0)
                lblSoLuongToiDa.Text = "[số lượng tối đa: " + currentSanPham.TonKho + " ]";
            else
                lblSoLuongToiDa.Text = "[đã hết hàng]";
            lblSoLuongToiDa.Visible = true;
        }
        private void btnIncrease_Click(object sender, EventArgs e)
        {

            int sl;
            if (int.TryParse(txtSoLuong.Text, out sl) == false) return;
            if (sl == currentSanPham.TonKho) return;
            txtSoLuong.Text = sl + 1 + "";
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            int sl;
            if (int.TryParse(txtSoLuong.Text, out sl) == false) return;
            if (sl <= 1) return;
            else txtSoLuong.Text = sl - 1 + "";

        }
        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            int maxSL = int.Parse(txtSoLuong.Text);
            if (maxSL < 0) txtSoLuong.Text = "0";
            else if (maxSL > currentSanPham.TonKho) txtSoLuong.Text = currentSanPham.TonKho + "";
        }

        private void btnThemVaoGioHang_Click(object sender, EventArgs e)
        {
            if (currentSanPham == null)
            {
                MessageBox.Show("null");
                return;
            }
            if (txtSoLuong.Text == "0")
            {
                MessageBox.Show("số lượng phải > 0");
                return;
            }

            //thêm vào Giỏ hàng
            ListViewItem lvi = new ListViewItem(currentSanPham.TenSanPham);
            lvi.SubItems.Add(cboLoaiHang.Text);
            lvi.SubItems.Add(txtSoLuong.Text);
            lvi.Tag = currentSanPham;

            lvGioHang.Items.Add(lvi);

            //them vào gioHang
            HoaDon_SanPham hdsp = new HoaDon_SanPham()
            {
                SoPhieu = txtSoPhieu.Text,
                MaSanPham = currentSanPham.MaSanPham,
                SoLuong = int.Parse(txtSoLuong.Text),
                DonGia = currentSanPham.DonGia,
                GiamTru = int.Parse(txtGiamTru.Text)
            };
            gioHang.Add(hdsp);

            //cập nhật tiền
            tongTienHang += hdsp.TongTienHang();
            tienGiamTru += hdsp.TienGiamTru();
            tienThanhToan += hdsp.TienThanhToan();

            HienThiTien();
        }

        #endregion

        #region Event_On_GioHang

        private void btnLoaiBoMatHang_Click(object sender, EventArgs e)
        {
            if (lvGioHang.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn một mặt hàng");
                return;
            }
            //loại bỏ khỏi giỏ hàng
            ListViewItem curSP = lvGioHang.SelectedItems[0];
            SanPham sp = lvGioHang.SelectedItems[0].Tag as SanPham;
            lvGioHang.Items.Remove(curSP);

            //Loại bỏ khỏi gioHang

            for (int i = 0; i < gioHang.Count; i++)
            {
                HoaDon_SanPham hdsp = gioHang[i];
                if (hdsp.MaSanPham == sp.MaSanPham)
                {
                    //cập nhật tiền
                    tongTienHang -= hdsp.TongTienHang();
                    tienGiamTru -= hdsp.TienGiamTru();
                    tienThanhToan -= hdsp.TienThanhToan();
                    HienThiTien();

                    //loại bỏ
                    gioHang.RemoveAt(i);
                    // MessageBox.Show(gioHang.Count+"");
                    return;
                }
            }


        }

        private void btnHuyGioHang_Click(object sender, EventArgs e)
        {
            lvGioHang.Items.Clear();
            gioHang.Clear();

            //cập nhật tiền
            tongTienHang = tienThanhToan = tienGiamTru = 0;
            HienThiTien();
        }
        #endregion

        #region Tim_Va_Chon_Khach_Hang

        private void txtTimKhachHang_Enter(object sender, EventArgs e)
        {
            if (txtTimKhachHang.Text == "(Tên khách hàng)")
            {
                txtTimKhachHang.Text = "";
            }
        }

        private void txtTimKhachHang_Leave(object sender, EventArgs e)
        {
            if (txtTimKhachHang.Text == "")
            {
                txtTimKhachHang.Text = "(Tên khách hàng)";
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lvDSKHTim.Items.Clear();
            if (txtTimKhachHang.Text == "" || txtTimKhachHang.Text == "(Tên khách hàng)")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng cần tìm.");
                return;
            }

            try
            {
                KhachHangBLL khBLL = new KhachHangBLL();
                List<KhachHang> dsKH = new List<KhachHang>();
                dsKH = khBLL.TimKhachHang(txtTimKhachHang.Text);

                foreach (KhachHang kh in dsKH)
                {
                    ListViewItem lvi = new ListViewItem(kh.MaKhachHang);
                    lvi.SubItems.Add(kh.TenKhachhang);
                    lvi.SubItems.Add(kh.DiaChi);
                    lvi.Tag = kh;

                    lvDSKHTim.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm khách hàng*\n" + ex.Message);
                return;
            }
        }


        private void lvDSKHTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDSKHTim.SelectedItems.Count == 0) return;
            currentKhachHang = lvDSKHTim.SelectedItems[0].Tag as KhachHang;

            txtTimKhachHang.Text = currentKhachHang.TenKhachhang;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (lvDSKHTim.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn một khách hàng ở danh sách tìm kiếm.");
                return;
            }

            txtTenKhachHang.Text = currentKhachHang.TenKhachhang;

        }
        #endregion

        #region Tao_Hoa_Don
        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            if(currentKhachHang == null)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng.");
                return;
            }
            if(gioHang.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm khách hàng mua vào giỏ hàng.");
                return;
            }

            try
            {
                //thêm hóa đơn vào csdl
                HoaDon hd = new HoaDon()
                {
                    SoPhieu = txtSoPhieu.Text,
                    MaNhanVien = currentUser.MaNhanVien,
                    MaKhachhang = currentKhachHang.MaKhachHang,
                    NgayLapPhieu = DateTime.Now,
                    GhiChu = txtGhiChu.Text
                };

                HoaDonBLL hdBLL = new HoaDonBLL();
                hdBLL.ThemHoaDon(hd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đưa hóa đơn vào CSDL:\nChi tiết lỗi:" + ex.Message);
                return;
            }

            //thêm các sản phẩm của hóa đơn(giỏ hàng) vào csdl
            ThemGioHangVaoCSDL();

            MessageBox.Show("Tạo hóa đơn thành công.");
            frmOrder_Load();
        }
        #endregion

        #endregion

    }
}

