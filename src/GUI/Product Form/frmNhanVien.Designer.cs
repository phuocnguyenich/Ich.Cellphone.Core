namespace SideNavSample
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAdminWarning = new System.Windows.Forms.Label();
            this.btnXoaNhanVien = new System.Windows.Forms.Button();
            this.chbNotAdmin = new System.Windows.Forms.CheckBox();
            this.chbAdmin = new System.Windows.Forms.CheckBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.grbDSNV = new System.Windows.Forms.GroupBox();
            this.lvNhanVien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThongTinCaNhan = new FontAwesome.Sharp.IconButton();
            this.panelPersonel = new System.Windows.Forms.Panel();
            this.btnDoiMatKhau_PanelPersonel = new FontAwesome.Sharp.IconButton();
            this.btnXemDSNH_PP = new FontAwesome.Sharp.IconButton();
            this.dtpDOB_PanelPersonel = new System.Windows.Forms.DateTimePicker();
            this.btnLuu_PanelPersonel = new System.Windows.Forms.Button();
            this.txtAddress_PanelPersonel = new System.Windows.Forms.TextBox();
            this.txtEmail_PanelPersonel = new System.Windows.Forms.TextBox();
            this.txtSDT_PanelPersonel = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien_PanelPersonel = new System.Windows.Forms.TextBox();
            this.grbResetPassword_PanelPersonel = new System.Windows.Forms.GroupBox();
            this.lblConfirmPassword_PP = new System.Windows.Forms.Label();
            this.lblOldPassword_PP = new System.Windows.Forms.Label();
            this.btnAccept_PanelPersonel = new System.Windows.Forms.Button();
            this.txtConfirmPassword_PanelPersonel = new System.Windows.Forms.TextBox();
            this.txtNewPassword_PanelPersonel = new System.Windows.Forms.TextBox();
            this.txtOldPassword_PanelPersonel = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbDSNV.SuspendLayout();
            this.panelPersonel.SuspendLayout();
            this.grbResetPassword_PanelPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdminWarning
            // 
            this.lblAdminWarning.AutoSize = true;
            this.lblAdminWarning.ForeColor = System.Drawing.Color.Red;
            this.lblAdminWarning.Location = new System.Drawing.Point(35, 147);
            this.lblAdminWarning.Name = "lblAdminWarning";
            this.lblAdminWarning.Size = new System.Drawing.Size(304, 17);
            this.lblAdminWarning.TabIndex = 33;
            this.lblAdminWarning.Text = "[không thể thay đổi quền hạn của một Admin]";
            this.lblAdminWarning.Visible = false;
            // 
            // btnXoaNhanVien
            // 
            this.btnXoaNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(93)))), ((int)(((byte)(182)))));
            this.btnXoaNhanVien.FlatAppearance.BorderSize = 0;
            this.btnXoaNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnXoaNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnXoaNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNhanVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXoaNhanVien.Location = new System.Drawing.Point(39, 433);
            this.btnXoaNhanVien.Name = "btnXoaNhanVien";
            this.btnXoaNhanVien.Size = new System.Drawing.Size(454, 23);
            this.btnXoaNhanVien.TabIndex = 32;
            this.btnXoaNhanVien.Text = "Xóa nhân viên này";
            this.btnXoaNhanVien.UseVisualStyleBackColor = false;
            this.btnXoaNhanVien.Click += new System.EventHandler(this.btnXoaNhanVien_Click);
            // 
            // chbNotAdmin
            // 
            this.chbNotAdmin.AutoSize = true;
            this.chbNotAdmin.ForeColor = System.Drawing.Color.Blue;
            this.chbNotAdmin.Location = new System.Drawing.Point(90, 225);
            this.chbNotAdmin.Name = "chbNotAdmin";
            this.chbNotAdmin.Size = new System.Drawing.Size(130, 21);
            this.chbNotAdmin.TabIndex = 30;
            this.chbNotAdmin.Text = "không là Admin";
            this.chbNotAdmin.UseVisualStyleBackColor = true;
            // 
            // chbAdmin
            // 
            this.chbAdmin.AutoSize = true;
            this.chbAdmin.ForeColor = System.Drawing.Color.Blue;
            this.chbAdmin.Location = new System.Drawing.Point(90, 178);
            this.chbAdmin.Name = "chbAdmin";
            this.chbAdmin.Size = new System.Drawing.Size(85, 21);
            this.chbAdmin.TabIndex = 31;
            this.chbAdmin.Text = "là Admin";
            this.chbAdmin.UseVisualStyleBackColor = true;
            this.chbAdmin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chbAdmin_MouseClick);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(142, 383);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(334, 23);
            this.txtDiaChi.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(142, 336);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(334, 23);
            this.txtEmail.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Quyền hạn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Email";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(142, 293);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(334, 23);
            this.txtSDT.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Đang chọn";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.BackColor = System.Drawing.Color.LightGray;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(93)))), ((int)(((byte)(182)))));
            this.lblTenNhanVien.Location = new System.Drawing.Point(92, 62);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(227, 19);
            this.lblTenNhanVien.TabIndex = 26;
            this.lblTenNhanVien.Text = "(Chưa chọn nhân viên nào)";
            // 
            // grbDSNV
            // 
            this.grbDSNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDSNV.Controls.Add(this.lvNhanVien);
            this.grbDSNV.ForeColor = System.Drawing.Color.Black;
            this.grbDSNV.Location = new System.Drawing.Point(499, 14);
            this.grbDSNV.Name = "grbDSNV";
            this.grbDSNV.Size = new System.Drawing.Size(385, 473);
            this.grbDSNV.TabIndex = 20;
            this.grbDSNV.TabStop = false;
            this.grbDSNV.Text = "Danh sách nhân viên";
            // 
            // lvNhanVien
            // 
            this.lvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNhanVien.FullRowSelect = true;
            this.lvNhanVien.GridLines = true;
            this.lvNhanVien.Location = new System.Drawing.Point(3, 19);
            this.lvNhanVien.Name = "lvNhanVien";
            this.lvNhanVien.Size = new System.Drawing.Size(379, 451);
            this.lvNhanVien.TabIndex = 0;
            this.lvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvNhanVien.View = System.Windows.Forms.View.Details;
            this.lvNhanVien.SelectedIndexChanged += new System.EventHandler(this.lvNhanVien_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã nhân viên";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên nhân viên";
            this.columnHeader2.Width = 195;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày sinh";
            this.columnHeader3.Width = 202;
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThongTinCaNhan.FlatAppearance.BorderSize = 0;
            this.btnThongTinCaNhan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnThongTinCaNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinCaNhan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThongTinCaNhan.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnThongTinCaNhan.IconColor = System.Drawing.Color.Black;
            this.btnThongTinCaNhan.IconSize = 32;
            this.btnThongTinCaNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongTinCaNhan.Location = new System.Drawing.Point(714, 490);
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.Rotation = 0D;
            this.btnThongTinCaNhan.Size = new System.Drawing.Size(170, 26);
            this.btnThongTinCaNhan.TabIndex = 34;
            this.btnThongTinCaNhan.Text = "Thông tin cá nhân";
            this.btnThongTinCaNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinCaNhan.UseVisualStyleBackColor = true;
            this.btnThongTinCaNhan.Click += new System.EventHandler(this.btnThongTinCaNhan_Click);
            // 
            // panelPersonel
            // 
            this.panelPersonel.Controls.Add(this.btnDoiMatKhau_PanelPersonel);
            this.panelPersonel.Controls.Add(this.btnXemDSNH_PP);
            this.panelPersonel.Controls.Add(this.dtpDOB_PanelPersonel);
            this.panelPersonel.Controls.Add(this.btnLuu_PanelPersonel);
            this.panelPersonel.Controls.Add(this.txtAddress_PanelPersonel);
            this.panelPersonel.Controls.Add(this.txtEmail_PanelPersonel);
            this.panelPersonel.Controls.Add(this.txtSDT_PanelPersonel);
            this.panelPersonel.Controls.Add(this.txtTenNhanVien_PanelPersonel);
            this.panelPersonel.Controls.Add(this.grbResetPassword_PanelPersonel);
            this.panelPersonel.Controls.Add(this.label11);
            this.panelPersonel.Controls.Add(this.label10);
            this.panelPersonel.Controls.Add(this.label9);
            this.panelPersonel.Controls.Add(this.label8);
            this.panelPersonel.Controls.Add(this.label7);
            this.panelPersonel.Controls.Add(this.label6);
            this.panelPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPersonel.Location = new System.Drawing.Point(0, 0);
            this.panelPersonel.Name = "panelPersonel";
            this.panelPersonel.Size = new System.Drawing.Size(896, 523);
            this.panelPersonel.TabIndex = 35;
            // 
            // btnDoiMatKhau_PanelPersonel
            // 
            this.btnDoiMatKhau_PanelPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(93)))), ((int)(((byte)(182)))));
            this.btnDoiMatKhau_PanelPersonel.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau_PanelPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau_PanelPersonel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDoiMatKhau_PanelPersonel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDoiMatKhau_PanelPersonel.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btnDoiMatKhau_PanelPersonel.IconColor = System.Drawing.Color.Black;
            this.btnDoiMatKhau_PanelPersonel.IconSize = 16;
            this.btnDoiMatKhau_PanelPersonel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiMatKhau_PanelPersonel.Location = new System.Drawing.Point(152, 393);
            this.btnDoiMatKhau_PanelPersonel.Name = "btnDoiMatKhau_PanelPersonel";
            this.btnDoiMatKhau_PanelPersonel.Rotation = 0D;
            this.btnDoiMatKhau_PanelPersonel.Size = new System.Drawing.Size(262, 23);
            this.btnDoiMatKhau_PanelPersonel.TabIndex = 6;
            this.btnDoiMatKhau_PanelPersonel.Text = "Đặt lại mật khẩu";
            this.btnDoiMatKhau_PanelPersonel.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau_PanelPersonel.Click += new System.EventHandler(this.btnDoiMatKhau_PanelPersonel_Click);
            // 
            // btnXemDSNH_PP
            // 
            this.btnXemDSNH_PP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXemDSNH_PP.BackColor = System.Drawing.Color.LightGray;
            this.btnXemDSNH_PP.FlatAppearance.BorderSize = 0;
            this.btnXemDSNH_PP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(174)))), ((int)(((byte)(196)))));
            this.btnXemDSNH_PP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDSNH_PP.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnXemDSNH_PP.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnXemDSNH_PP.IconColor = System.Drawing.Color.Black;
            this.btnXemDSNH_PP.IconSize = 32;
            this.btnXemDSNH_PP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemDSNH_PP.Location = new System.Drawing.Point(5, 484);
            this.btnXemDSNH_PP.Name = "btnXemDSNH_PP";
            this.btnXemDSNH_PP.Rotation = 0D;
            this.btnXemDSNH_PP.Size = new System.Drawing.Size(232, 35);
            this.btnXemDSNH_PP.TabIndex = 7;
            this.btnXemDSNH_PP.Text = "Xem Danh sách nhân viên";
            this.btnXemDSNH_PP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemDSNH_PP.UseVisualStyleBackColor = false;
            this.btnXemDSNH_PP.Click += new System.EventHandler(this.btnXemDSNH_PP_Click);
            // 
            // dtpDOB_PanelPersonel
            // 
            this.dtpDOB_PanelPersonel.Location = new System.Drawing.Point(152, 128);
            this.dtpDOB_PanelPersonel.Name = "dtpDOB_PanelPersonel";
            this.dtpDOB_PanelPersonel.Size = new System.Drawing.Size(262, 23);
            this.dtpDOB_PanelPersonel.TabIndex = 1;
            // 
            // btnLuu_PanelPersonel
            // 
            this.btnLuu_PanelPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(93)))), ((int)(((byte)(182)))));
            this.btnLuu_PanelPersonel.FlatAppearance.BorderSize = 0;
            this.btnLuu_PanelPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu_PanelPersonel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLuu_PanelPersonel.Location = new System.Drawing.Point(152, 341);
            this.btnLuu_PanelPersonel.Name = "btnLuu_PanelPersonel";
            this.btnLuu_PanelPersonel.Size = new System.Drawing.Size(262, 23);
            this.btnLuu_PanelPersonel.TabIndex = 5;
            this.btnLuu_PanelPersonel.Text = "Cập nhật";
            this.btnLuu_PanelPersonel.UseVisualStyleBackColor = false;
            this.btnLuu_PanelPersonel.Click += new System.EventHandler(this.btnLuu_PanelPersonel_Click);
            // 
            // txtAddress_PanelPersonel
            // 
            this.txtAddress_PanelPersonel.Location = new System.Drawing.Point(152, 277);
            this.txtAddress_PanelPersonel.Name = "txtAddress_PanelPersonel";
            this.txtAddress_PanelPersonel.Size = new System.Drawing.Size(262, 23);
            this.txtAddress_PanelPersonel.TabIndex = 4;
            // 
            // txtEmail_PanelPersonel
            // 
            this.txtEmail_PanelPersonel.Location = new System.Drawing.Point(152, 227);
            this.txtEmail_PanelPersonel.Name = "txtEmail_PanelPersonel";
            this.txtEmail_PanelPersonel.Size = new System.Drawing.Size(262, 23);
            this.txtEmail_PanelPersonel.TabIndex = 3;
            // 
            // txtSDT_PanelPersonel
            // 
            this.txtSDT_PanelPersonel.Location = new System.Drawing.Point(152, 177);
            this.txtSDT_PanelPersonel.Name = "txtSDT_PanelPersonel";
            this.txtSDT_PanelPersonel.Size = new System.Drawing.Size(262, 23);
            this.txtSDT_PanelPersonel.TabIndex = 2;
            // 
            // txtTenNhanVien_PanelPersonel
            // 
            this.txtTenNhanVien_PanelPersonel.Location = new System.Drawing.Point(152, 81);
            this.txtTenNhanVien_PanelPersonel.Name = "txtTenNhanVien_PanelPersonel";
            this.txtTenNhanVien_PanelPersonel.Size = new System.Drawing.Size(262, 23);
            this.txtTenNhanVien_PanelPersonel.TabIndex = 0;
            // 
            // grbResetPassword_PanelPersonel
            // 
            this.grbResetPassword_PanelPersonel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbResetPassword_PanelPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.grbResetPassword_PanelPersonel.Controls.Add(this.lblConfirmPassword_PP);
            this.grbResetPassword_PanelPersonel.Controls.Add(this.lblOldPassword_PP);
            this.grbResetPassword_PanelPersonel.Controls.Add(this.btnAccept_PanelPersonel);
            this.grbResetPassword_PanelPersonel.Controls.Add(this.txtConfirmPassword_PanelPersonel);
            this.grbResetPassword_PanelPersonel.Controls.Add(this.txtNewPassword_PanelPersonel);
            this.grbResetPassword_PanelPersonel.Controls.Add(this.txtOldPassword_PanelPersonel);
            this.grbResetPassword_PanelPersonel.Controls.Add(this.shapeContainer1);
            this.grbResetPassword_PanelPersonel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbResetPassword_PanelPersonel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(93)))), ((int)(((byte)(182)))));
            this.grbResetPassword_PanelPersonel.Location = new System.Drawing.Point(564, 0);
            this.grbResetPassword_PanelPersonel.Name = "grbResetPassword_PanelPersonel";
            this.grbResetPassword_PanelPersonel.Size = new System.Drawing.Size(332, 523);
            this.grbResetPassword_PanelPersonel.TabIndex = 0;
            this.grbResetPassword_PanelPersonel.TabStop = false;
            this.grbResetPassword_PanelPersonel.Text = "Đặt lại mật khẩu";
            // 
            // lblConfirmPassword_PP
            // 
            this.lblConfirmPassword_PP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmPassword_PP.AutoSize = true;
            this.lblConfirmPassword_PP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword_PP.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmPassword_PP.Location = new System.Drawing.Point(30, 289);
            this.lblConfirmPassword_PP.Name = "lblConfirmPassword_PP";
            this.lblConfirmPassword_PP.Size = new System.Drawing.Size(206, 17);
            this.lblConfirmPassword_PP.TabIndex = 5;
            this.lblConfirmPassword_PP.Text = "[confirm password is incorrect]";
            this.lblConfirmPassword_PP.Visible = false;
            // 
            // lblOldPassword_PP
            // 
            this.lblOldPassword_PP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOldPassword_PP.AutoSize = true;
            this.lblOldPassword_PP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword_PP.ForeColor = System.Drawing.Color.Red;
            this.lblOldPassword_PP.Location = new System.Drawing.Point(29, 149);
            this.lblOldPassword_PP.Name = "lblOldPassword_PP";
            this.lblOldPassword_PP.Size = new System.Drawing.Size(153, 17);
            this.lblOldPassword_PP.TabIndex = 5;
            this.lblOldPassword_PP.Text = "[password is incorrect]";
            this.lblOldPassword_PP.Visible = false;
            // 
            // btnAccept_PanelPersonel
            // 
            this.btnAccept_PanelPersonel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccept_PanelPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAccept_PanelPersonel.FlatAppearance.BorderSize = 0;
            this.btnAccept_PanelPersonel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAccept_PanelPersonel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAccept_PanelPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept_PanelPersonel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept_PanelPersonel.ForeColor = System.Drawing.Color.LightGray;
            this.btnAccept_PanelPersonel.Location = new System.Drawing.Point(32, 342);
            this.btnAccept_PanelPersonel.Name = "btnAccept_PanelPersonel";
            this.btnAccept_PanelPersonel.Size = new System.Drawing.Size(270, 23);
            this.btnAccept_PanelPersonel.TabIndex = 4;
            this.btnAccept_PanelPersonel.Text = "ACCEPT";
            this.btnAccept_PanelPersonel.UseVisualStyleBackColor = false;
            this.btnAccept_PanelPersonel.Click += new System.EventHandler(this.btnAccept_PanelPersonel_Click);
            // 
            // txtConfirmPassword_PanelPersonel
            // 
            this.txtConfirmPassword_PanelPersonel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmPassword_PanelPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtConfirmPassword_PanelPersonel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword_PanelPersonel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword_PanelPersonel.ForeColor = System.Drawing.Color.DimGray;
            this.txtConfirmPassword_PanelPersonel.Location = new System.Drawing.Point(33, 269);
            this.txtConfirmPassword_PanelPersonel.Name = "txtConfirmPassword_PanelPersonel";
            this.txtConfirmPassword_PanelPersonel.Size = new System.Drawing.Size(270, 16);
            this.txtConfirmPassword_PanelPersonel.TabIndex = 3;
            this.txtConfirmPassword_PanelPersonel.Text = "CONFIRM PASSWORD";
            this.txtConfirmPassword_PanelPersonel.Enter += new System.EventHandler(this.txtConfirmPassword_PanelPersonel_Enter);
            this.txtConfirmPassword_PanelPersonel.Leave += new System.EventHandler(this.txtConfirmPassword_PanelPersonel_Leave);
            // 
            // txtNewPassword_PanelPersonel
            // 
            this.txtNewPassword_PanelPersonel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPassword_PanelPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNewPassword_PanelPersonel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword_PanelPersonel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword_PanelPersonel.ForeColor = System.Drawing.Color.DimGray;
            this.txtNewPassword_PanelPersonel.Location = new System.Drawing.Point(33, 199);
            this.txtNewPassword_PanelPersonel.Name = "txtNewPassword_PanelPersonel";
            this.txtNewPassword_PanelPersonel.Size = new System.Drawing.Size(270, 16);
            this.txtNewPassword_PanelPersonel.TabIndex = 2;
            this.txtNewPassword_PanelPersonel.Text = "NEW PASSWORD";
            this.txtNewPassword_PanelPersonel.Enter += new System.EventHandler(this.txtNewPassword_PanelPersonel_Enter);
            this.txtNewPassword_PanelPersonel.Leave += new System.EventHandler(this.txtNewPassword_PanelPersonel_Leave);
            // 
            // txtOldPassword_PanelPersonel
            // 
            this.txtOldPassword_PanelPersonel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOldPassword_PanelPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtOldPassword_PanelPersonel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOldPassword_PanelPersonel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword_PanelPersonel.ForeColor = System.Drawing.Color.DimGray;
            this.txtOldPassword_PanelPersonel.Location = new System.Drawing.Point(33, 130);
            this.txtOldPassword_PanelPersonel.Name = "txtOldPassword_PanelPersonel";
            this.txtOldPassword_PanelPersonel.Size = new System.Drawing.Size(270, 16);
            this.txtOldPassword_PanelPersonel.TabIndex = 1;
            this.txtOldPassword_PanelPersonel.Text = "OLD PASSWORD";
            this.txtOldPassword_PanelPersonel.Enter += new System.EventHandler(this.txtOldPassword_PanelPersonel_Enter);
            this.txtOldPassword_PanelPersonel.Leave += new System.EventHandler(this.txtOldPassword_PanelPersonel_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 23);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(326, 497);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 29;
            this.lineShape3.X2 = 298;
            this.lineShape3.Y1 = 124;
            this.lineShape3.Y2 = 124;
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 29;
            this.lineShape2.X2 = 298;
            this.lineShape2.Y1 = 194;
            this.lineShape2.Y2 = 194;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 29;
            this.lineShape1.X2 = 298;
            this.lineShape1.Y1 = 264;
            this.lineShape1.Y2 = 264;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Địa chỉ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Họ và tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(93)))), ((int)(((byte)(182)))));
            this.label6.Location = new System.Drawing.Point(43, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sửa đổi thông tin cá nhân";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(896, 523);
            this.Controls.Add(this.panelPersonel);
            this.Controls.Add(this.btnThongTinCaNhan);
            this.Controls.Add(this.lblAdminWarning);
            this.Controls.Add(this.btnXoaNhanVien);
            this.Controls.Add(this.chbNotAdmin);
            this.Controls.Add(this.chbAdmin);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTenNhanVien);
            this.Controls.Add(this.grbDSNV);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.grbDSNV.ResumeLayout(false);
            this.panelPersonel.ResumeLayout(false);
            this.panelPersonel.PerformLayout();
            this.grbResetPassword_PanelPersonel.ResumeLayout(false);
            this.grbResetPassword_PanelPersonel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminWarning;
        private System.Windows.Forms.Button btnXoaNhanVien;
        private System.Windows.Forms.CheckBox chbNotAdmin;
        private System.Windows.Forms.CheckBox chbAdmin;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.GroupBox grbDSNV;
        private System.Windows.Forms.ListView lvNhanVien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private FontAwesome.Sharp.IconButton btnThongTinCaNhan;
        private System.Windows.Forms.Panel panelPersonel;
        private FontAwesome.Sharp.IconButton btnXemDSNH_PP;
        private System.Windows.Forms.DateTimePicker dtpDOB_PanelPersonel;
        private System.Windows.Forms.Button btnLuu_PanelPersonel;
        private System.Windows.Forms.TextBox txtAddress_PanelPersonel;
        private System.Windows.Forms.TextBox txtEmail_PanelPersonel;
        private System.Windows.Forms.TextBox txtSDT_PanelPersonel;
        private System.Windows.Forms.TextBox txtTenNhanVien_PanelPersonel;
        private System.Windows.Forms.GroupBox grbResetPassword_PanelPersonel;
        private System.Windows.Forms.Button btnAccept_PanelPersonel;
        private System.Windows.Forms.TextBox txtConfirmPassword_PanelPersonel;
        private System.Windows.Forms.TextBox txtNewPassword_PanelPersonel;
        private System.Windows.Forms.TextBox txtOldPassword_PanelPersonel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblConfirmPassword_PP;
        private System.Windows.Forms.Label lblOldPassword_PP;
        private FontAwesome.Sharp.IconButton btnDoiMatKhau_PanelPersonel;
    }
}