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
using DTO;
using FontAwesome.Sharp;

namespace SideNavSample
{
    public partial class frmMain : Form
    {
        //Fields
        private IconButton currentButton;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        /// <summary>
        /// nhân viên đang sử dụng phẩm mềm
        /// </summary>
        private NhanVien currentUser;

        //Constructor
        public frmMain()
        {
            InitializeComponent();
            UserLogin();            
        }
                

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(179, 110, 2);
            public static Color color11 = Color.FromArgb(255, 153, 3);

            public static Color color2 = Color.FromArgb(181, 23, 2);
            public static Color color21 = Color.FromArgb(249, 85, 62);

            public static Color color3 = Color.FromArgb(27, 145, 6);
            public static Color color31 = Color.FromArgb(118, 235, 98);

            public static Color color4 = Color.FromArgb(8, 45, 133);
            public static Color color41 = Color.FromArgb(59, 99, 192);

            public static Color color5 = Color.FromArgb(99, 8, 133);
            public static Color color51 = Color.FromArgb(158, 93, 182);

            public static Color color6 = Color.FromArgb(5, 107, 102);
            public static Color color61 = Color.FromArgb(103, 191, 187);

        }


        #region Methods

        #region Login Field
        private void UserLogin()
        {
            this.Visible = false;
            frmLogin frm = new frmLogin();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                currentUser = frm.Tag as NhanVien;

                MainFormLoad();
                this.Visible = true;
            }
            else
            {
                Application.Exit();
            }
            
        }

        #endregion
        private void MainFormLoad()
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 52);
            panelMenu.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //
            btnLogo.PerformClick();

            //hello
            txtHelloUser.Text = "Xin chào " + currentUser.TenNhanVien;
        }


        /// <summary>
        /// when click a tab
        /// </summary>
        /// <param name="senderButton"></param>
        /// <param name="color"></param>
        private void  ActivateButton(object senderButton,Color colorButtonlLogo, Color colorChildForm)
        {
            if(senderButton != null)
            {
                DisableButton();
                //Button
                currentButton = (IconButton)senderButton;

                currentButton.BackColor = colorChildForm;                
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                //left border button
                leftBorderBtn.BackColor = colorChildForm;
                leftBorderBtn.Visible = true;
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.BringToFront();

                // icon current child form
                iconCurrentChildForm.IconChar = currentButton.IconChar;
                
                //label current child form
                labelTitleChildForm.Text = currentButton.Text;
                

                //panel current child form
                panelChildForm.BackColor = colorChildForm;

                //panel logo
                btnLogo.BackColor = colorButtonlLogo;

                //txtHello
                txtHelloUser.BackColor = colorChildForm;
                
            }
        }
        /// <summary>
        /// when unclick currrent tab
        /// </summary>
        private void DisableButton()
        {
            if(currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(50, 52, 76);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;

                txtHelloUser.BackColor = Color.FromArgb(50, 52, 76);
                btnLogo.BackColor = Color.FromArgb(10, 20, 40);
                panelChildForm.BackColor = Color.FromArgb(50, 52, 76);
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //labelTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            // icon current child form
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            labelTitleChildForm.Text = "Home";
            txtHelloUser.BackColor = Color.FromArgb(50, 52, 76);
        }

        #region Drag_Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelChildForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        #endregion


        #region Events
        private void btnLogo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }              
        #region Menu_Button_Clicks
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1, RGBColors.color11);
            
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2, RGBColors.color21);
             OpenChildForm(new frmOrder(currentUser));
        }       

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3, RGBColors.color31);
            OpenChildForm(new frmSanPham());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4, RGBColors.color41);
            OpenChildForm(new frmKhachHang());
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5, RGBColors.color51);
            OpenChildForm(new frmNhanVien(currentUser) );
        }      

        #endregion       

        #region SignOut_Close-Maximize-Minimize
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show(
                "Sign Out?",
                "Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (ret == DialogResult.Yes)
            {
                UserLogin();
            }
            
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            
            else
                this.WindowState = FormWindowState.Normal;
            
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #endregion


    }
}
