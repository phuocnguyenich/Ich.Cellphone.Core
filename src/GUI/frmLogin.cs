using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BLL;
using DTO;

namespace SideNavSample
{
    public partial class frmLogin : Form
    {
        //Fields
        private NhanVien currentUser;
        private string currentUsername;
        private string currentPassword;
        public frmLogin()
        {
            InitializeComponent();
        }
        #region Events

        #region Link_SignUp
        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp frm = new frmSignUp();
            frm.Show();
        }
        #endregion
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if(txtUserName.Text == "USERNAME")
            {
                lblIncorrect.Visible = false;
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.LightGray;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "USERNAME";
                txtUserName.ForeColor = Color.DimGray;
            }
            else
            {
                currentUsername = txtUserName.Text;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            lblIncorrect.Visible = false;
            if(txtPassword.Text == "PASSWORD")
            {
                lblIncorrect.Visible = false;
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "PASSWORD";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                currentPassword = txtPassword.Text;
            }
        }
        #region Accept_Minimize_Close
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (currentPassword != null && currentUsername != null)
            {
                try
                {
                    NhanVienBLL nvBll = new NhanVienBLL();
                    //nhân viên này đang đăng nhập
                    currentUser = nvBll.DangNhap(currentUsername, currentPassword);

                    if (currentUser.MaNhanVien == null)
                    {
                        lblIncorrect.Visible = true;
                        return;
                    }
                    else
                    {                       
                        this.Tag = currentUser;
                        this.DialogResult = DialogResult.OK;
                        Close();                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đăng nhập.\n" + ex.Message);
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #endregion

        #region Move_Form
        //su dung de di chuyen form bang chuot
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
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

        
    }
}
