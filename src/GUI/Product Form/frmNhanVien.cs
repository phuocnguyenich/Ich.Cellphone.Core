using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideNavSample
{
    public partial class frmNhanVien : Form
    {
        //Fields
        private NhanVienBLL nvBLL = new NhanVienBLL();
        private NhanVien currentNhanVien;
        private NhanVien currentUser ;
        
        public frmNhanVien(NhanVien currentUser_NhanVien)
        {
            InitializeComponent();
            InitializeFrmNhanVien(currentUser_NhanVien);
        }

        #region Methods         
        private void InitializeFrmNhanVien(NhanVien curUser)
        {
            /*Testing
            currentUser = new NhanVien()
            {
                MaNhanVien = "22",
                TenNhanVien = "22",
                DiaChi = "22",
                Email = "33",
                IsAdmin = 1,
                NgaySinh = DateTime.Parse("01/01/1991"),
                SoDienThoai = "22"
            };*/

            currentUser = curUser;


            chbAdmin.Enabled = false;
            chbNotAdmin.Enabled = false;

            if (currentUser.IsAdmin == 0)
            {
                btnXemDSNH_PP.Visible = false;
            }
            LoadPanelPersonel();
        }

        /// <summary>
        /// use for form admin only 
        /// </summary>
        private void HienThiDSNV()
        {
            try
            {
                lvNhanVien.Items.Clear();
                               
                List<NhanVien> dsNV = nvBLL.LayToanBoNhanVien();

                foreach(NhanVien nv in dsNV)
                {
                    ListViewItem lvi = new ListViewItem(nv.MaNhanVien);
                    lvi.SubItems.Add(nv.TenNhanVien);
                    lvi.SubItems.Add(nv.NgaySinh + "");
                    lvi.Tag = nv;

                    lvNhanVien.Items.Add(lvi);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi lấy danh sách nhân viên.\nChi tiết lỗi:\n" + ex.Message);
            }
        }

        /// <summary>
        /// use for panelPersonel
        /// </summary>
        private void LoadPanelPersonel()
        {
            txtTenNhanVien_PanelPersonel.Text = currentUser.TenNhanVien;
            dtpDOB_PanelPersonel.Value = currentUser.NgaySinh;
            //MessageBox.Show(currentUser.NgaySinh+"");
            txtSDT_PanelPersonel.Text = currentUser.SoDienThoai;
            txtEmail_PanelPersonel.Text = currentUser.Email;
            txtAddress_PanelPersonel.Text = currentUser.DiaChi;

            //hide groupbox Dat lai mat khau
            grbResetPassword_PanelPersonel.Visible = false;
        }

        #endregion
         
        #region Events_On_Form_Admin_Only
        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count == 0) return;
            currentNhanVien = lvNhanVien.SelectedItems[0].Tag as NhanVien;

            lblTenNhanVien.Text = currentNhanVien.TenNhanVien;
            txtDiaChi.Text = currentNhanVien.DiaChi;
            txtEmail.Text = currentNhanVien.Email;
            txtSDT.Text = currentNhanVien.SoDienThoai;

            if(currentNhanVien.IsAdmin == 1)
            {
                chbAdmin.Checked = true;
                chbNotAdmin.Checked = false;

                chbAdmin.Enabled = false;               

                lblAdminWarning.Visible = true;
            }
            else
            {
                lblAdminWarning.Visible = false;

                chbNotAdmin.Checked = true;
                chbAdmin.Checked = false;

                chbAdmin.Enabled = true;
            }

            chbNotAdmin.Enabled = false;
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (currentNhanVien == null)
            {
                MessageBox.Show(
                    "Chọn một nhân viên.", 
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }     
            if(currentNhanVien.IsAdmin == 1)
            {
                MessageBox.Show(
                    "Không thể xóa một Admin.",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            try
            {
                DialogResult ret = MessageBox.Show(
                    "Bạn muốn xóa nhân viên [ "+currentNhanVien.TenNhanVien+" ]?",
                    "Question",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (ret == DialogResult.No) return;

                
                nvBLL.XoaNhanVien(currentNhanVien.MaNhanVien);
                MessageBox.Show("Xóa nhân viên thành công");

                //currentNhanVien is deleted
                currentNhanVien = null;

                //reset screen
                lblTenNhanVien.Text = "(Chưa chọn nhân viên nào)";
                chbAdmin.Checked = false;
                chbAdmin.Enabled = false;
                chbNotAdmin.Checked = false;

                txtDiaChi.Text = txtEmail.Text = txtSDT.Text = "";

                HienThiDSNV();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi xóa nhân viên.\nChi tiết lỗi:\n"+ex.Message);
            }
        }        
        /// <summary>
        /// cấp quyền cho nhân viên là 1 admin?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult ret = MessageBox.Show(
                "Cấp quyền cho nhân viên này là một admin?\n" +
                "[Sau khi cấp quyền không thể hoàn tác]",
                "Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (ret == DialogResult.No)
            {
                chbAdmin.Checked = false;
                return;
            }

            try
            {
                nvBLL.CapQuyenAdmin(currentNhanVien.MaNhanVien);
                MessageBox.Show("Cấp quyền thành công.");

                //now currentNhanVien is a Admin
                currentNhanVien.IsAdmin = 1;

                //checkbox have to change
                chbAdmin.Checked = true;
                chbNotAdmin.Checked = false;
                chbAdmin.Enabled = false;   

                //show error 
                lblAdminWarning.Visible = true;
                
                
                
                HienThiDSNV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cấp quyền nhân viên.\nChi tiết lỗi:\n" + ex.Message);
            }
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            panelPersonel.Visible = true;
        }

        #endregion

        #region Events_On_PanelPersonel

        private void btnLuu_PanelPersonel_Click(object sender, EventArgs e)
        {
            try
            {
                currentUser.TenNhanVien = txtTenNhanVien_PanelPersonel.Text;
                currentUser.NgaySinh = dtpDOB_PanelPersonel.Value;
                currentUser.SoDienThoai = txtSDT_PanelPersonel.Text;
                currentUser.Email = txtEmail_PanelPersonel.Text;
                currentUser.DiaChi = txtAddress_PanelPersonel.Text;

                nvBLL.SuaNhanVien(currentUser);
                MessageBox.Show("Cập nhật thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi:\n" + ex.Message);
            }
        }

        private void btnDoiMatKhau_PanelPersonel_Click(object sender, EventArgs e)
        {
            if(grbResetPassword_PanelPersonel.Visible == false)
            {
                grbResetPassword_PanelPersonel.Visible = true;
                grbResetPassword_PanelPersonel.Focus();
                btnDoiMatKhau_PanelPersonel.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            }
            else
            {
                grbResetPassword_PanelPersonel.Visible = false;
                grbResetPassword_PanelPersonel.Focus();
                btnDoiMatKhau_PanelPersonel.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            }

            txtOldPassword_PanelPersonel.Text = "OLD PASSWORD";
            txtNewPassword_PanelPersonel.Text = "NEW PASSWORD";
            txtConfirmPassword_PanelPersonel.Text = "CONFIRM PASSWORD";

            txtConfirmPassword_PanelPersonel.UseSystemPasswordChar = false;
            txtNewPassword_PanelPersonel.UseSystemPasswordChar = false;
            txtOldPassword_PanelPersonel.UseSystemPasswordChar = false;
        }

        private void btnXemDSNH_PP_Click(object sender, EventArgs e)
        {
            panelPersonel.Visible = false;

            HienThiDSNV();
        }

        #region Events_On_GroupBox_DatLaiMatKhau

        private void txtOldPassword_PanelPersonel_Enter(object sender, EventArgs e)
        {
            lblOldPassword_PP.Visible = false;
            if(txtOldPassword_PanelPersonel.Text == "OLD PASSWORD")
            {
                txtOldPassword_PanelPersonel.Text = "";
                txtOldPassword_PanelPersonel.ForeColor = Color.LightGray;
                txtOldPassword_PanelPersonel.UseSystemPasswordChar = true;
            }
        }

        private void txtOldPassword_PanelPersonel_Leave(object sender, EventArgs e)
        {
            if (txtOldPassword_PanelPersonel.Text == "")
            {
                txtOldPassword_PanelPersonel.Text = "OLD PASSWORD";
                txtOldPassword_PanelPersonel.ForeColor = Color.DimGray;
                txtOldPassword_PanelPersonel.UseSystemPasswordChar = false;
            }
        }

        private void txtNewPassword_PanelPersonel_Enter(object sender, EventArgs e)
        {
            if(txtNewPassword_PanelPersonel.Text == "NEW PASSWORD")
            {
                txtNewPassword_PanelPersonel.Text = "";
                txtNewPassword_PanelPersonel.ForeColor = Color.LightGray;
                txtNewPassword_PanelPersonel.UseSystemPasswordChar = true;
            }
        }

        private void txtNewPassword_PanelPersonel_Leave(object sender, EventArgs e)
        {
            if (txtNewPassword_PanelPersonel.Text == "")
            {
                txtNewPassword_PanelPersonel.Text = "NEW PASSWORD";
                txtNewPassword_PanelPersonel.ForeColor = Color.DimGray;
                txtNewPassword_PanelPersonel.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmPassword_PanelPersonel_Enter(object sender, EventArgs e)
        {
            lblConfirmPassword_PP.Visible = false;
            if (txtConfirmPassword_PanelPersonel.Text == "CONFIRM PASSWORD")
            {
                txtConfirmPassword_PanelPersonel.Text = "";
                txtConfirmPassword_PanelPersonel.ForeColor = Color.LightGray;
                txtConfirmPassword_PanelPersonel.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmPassword_PanelPersonel_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPassword_PanelPersonel.Text == "")
            {
                txtConfirmPassword_PanelPersonel.Text = "CONFIRM PASSWORD";
                txtConfirmPassword_PanelPersonel.ForeColor = Color.DimGray;
                txtConfirmPassword_PanelPersonel.UseSystemPasswordChar = false;
            }
        }
        private void btnAccept_PanelPersonel_Click(object sender, EventArgs e)
        {
            if (txtOldPassword_PanelPersonel.Text != currentUser.Password)
            {
                lblOldPassword_PP.Visible = true;
                return;
            }
            if (txtNewPassword_PanelPersonel.Text != txtConfirmPassword_PanelPersonel.Text)
            {
                lblConfirmPassword_PP.Visible = true;
                return;
            }
            try
            {
                nvBLL.DoiMatKhau(currentUser.MaNhanVien, txtNewPassword_PanelPersonel.Text);
                MessageBox.Show("Đặt lại mật khẩu thành công.");
                btnDoiMatKhau_PanelPersonel.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổi mật khẩu:\n" + ex.Message);
            }
        }
        #endregion

        #endregion
    }
}
