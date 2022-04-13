using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideNavSample
{
    public partial class frmSignUp : Form
    {
        //Field
        private static NhanVienBLL nvBLL = new NhanVienBLL();
        private NhanVien currentStaff;

        public frmSignUp()
        {
            InitializeComponent();
            CreateNewStaff();
        }
        #region Methods
        private void CreateNewStaff()
        {
            try
            {
                currentStaff = new NhanVien()
                {
                    MaNhanVien = "NV" + nvBLL.ValidMaNhanVienToAdd(),
                    NgaySinh = DateTime.Parse("01/01/1800")
                };                
            }
            catch(Exception ex)
            {                
                MessageBox.Show("Lỗi tạo Mã nhân viên.\nChi tiết lỗi:\n" + ex.Message);
            }
        }        
        #endregion
        #region Move_Form
        //su dung de di chuyen form bang chuot
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void frmSignUp_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion

        #region Events
        #region Text_Fields
        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "NAME")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.LightGray;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "NAME";
                txtName.ForeColor = Color.DimGray;
                
            }
            else
            {
                currentStaff.TenNhanVien = txtName.Text;               
            }
        }

        private void txtDOB_Enter(object sender, EventArgs e)
        {
            if (txtDOB.Text == "DATE OF BIRTH")
            {
                lblDOBError.Visible = false;
                txtDOB.Text = "";
                txtDOB.ForeColor = Color.LightGray;
            }
        }

        private void txtDOB_Leave(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            if (DateTime.TryParse(txtDOB.Text, out dt) == false)
            {                
                txtDOB.Text = "DATE OF BIRTH";
                txtDOB.ForeColor = Color.DimGray;
                lblDOBError.Visible = true;
                
            }

            //valid datime, continue check
            if(dt.Year < 1900)
            {
                lblDOBError.Text = "[invalid datime]";
                lblDOBError.Visible = true;
            }
            else
            {
                currentStaff.NgaySinh = dt;                
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "PHONE NUMBER")
            {
                txtPhone.Text = "";
                txtPhone.ForeColor = Color.LightGray;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.Text = "PHONE NUMBER";
                txtPhone.ForeColor = Color.DimGray;
                
            }
            else
            {
                currentStaff.SoDienThoai = txtPhone.Text;
               
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "EMAIL")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.LightGray;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "EMAIL";
                txtEmail.ForeColor = Color.DimGray;
                
            }
            else
            {
                currentStaff.Email = txtEmail.Text;
                
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "ADDRESS")
            {
                txtAddress.Text = "";
                txtAddress.ForeColor = Color.LightGray;
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.Text = "ADDRESS";
                txtAddress.ForeColor = Color.DimGray;
                
            }
            else
            {
                currentStaff.DiaChi = txtAddress.Text;
              
            }
        }


        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "USERNAME")
            {
                lblExistsUsername.Visible = false;
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.LightGray;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "USERNAME";
                txtUsername.ForeColor = Color.DimGray;
                
            }
            else
            {
                try
                {
                    bool check = nvBLL.IsExistedUsername(txtUsername.Text);
                    if (check)
                    {
                        lblExistsUsername.Visible = true;
                    }
                    else
                    {
                        lblExistsUsername.Visible = false;
                        currentStaff.Username = txtUsername.Text;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Username Exists.\n" + ex.Message);
                }                               
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            //anytime go on Password, ConfirmPassword reset
            txtConfirmPassword.Text = "CONFIRM PASSWORD";

            if (txtPassword.Text == "PASSWORD")
            {
                lblPasswordLong.Visible = false;
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 6)
            {
                lblPasswordLong.Visible = true;
                txtPassword.Text = "PASSWORD";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
                
            }
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            lblConfirmError.Visible = false;
            if (txtConfirmPassword.Text == "CONFIRM PASSWORD")
            {
                txtConfirmPassword.Text = "";
                txtConfirmPassword.ForeColor = Color.LightGray;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != txtPassword.Text )
            {
                if (txtPassword.Text == "PASSWORD" || txtConfirmPassword.Text == "CONFIRM PASSWORD")               
                {
                        txtConfirmPassword.Text = "CONFIRM PASSWORD";
                        txtConfirmPassword.ForeColor = Color.DimGray;                        
                        txtConfirmPassword.UseSystemPasswordChar = false;
                }
                else
                {
                    lblConfirmError.Visible = true;

                    txtConfirmPassword.Text = "CONFIRM PASSWORD";
                    txtConfirmPassword.ForeColor = Color.DimGray;
                    txtConfirmPassword.UseSystemPasswordChar = false;
                }                
            }
            else
            {
                currentStaff.Password = txtPassword.Text;
                
            }
        }
        #endregion


        #region Button_Accept_Minimize_Exit
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (currentStaff.MaNhanVien != null &&
                currentStaff.TenNhanVien != null &&
                lblDOBError.Visible == false &&
                currentStaff.NgaySinh.Year > 1900 &&
                currentStaff.SoDienThoai != null &&
                currentStaff.DiaChi != null &&                
                currentStaff.Username != null &&
                currentStaff.Password != null 
                )
            {
               // MessageBox.Show(currentStaff.NgaySinh+"");
                
                currentStaff.IsAdmin = 0;
                nvBLL.ThemNhanVien(currentStaff);
                MessageBox.Show("Đăng ký thành công.\nVui lòng đăng nhập lại để sử dụng.");
                Close();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #endregion



    }
}
