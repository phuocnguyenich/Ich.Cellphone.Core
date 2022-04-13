using BLL;
using DevComponents.DotNetBar;
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
    public partial class frmThemLoaiHang : Form
    {
        public frmThemLoaiHang()
        {
            InitializeComponent();
            styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
        }

        private void btnThemLoaiHang_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiHang.Text == "" || txtSinhMa.Text == "" || txtTenLoaiHang.Text == "") return;
            try
            {
                LoaiHang Lh = new LoaiHang()
                {
                    MaLoaiHang = txtMaLoaiHang.Text,
                    TenLoaiHang = txtTenLoaiHang.Text,
                    MaSanPhamTuSinh = txtSinhMa.Text
                };

                LoaiHangBLL lhBLL = new LoaiHangBLL();
                lhBLL.ThemLoaiHang(Lh);
                MessageBox.Show("Thêm Loại Hàng Thành Công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR:\n" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
