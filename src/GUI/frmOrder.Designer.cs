namespace SideNavSample
{
    partial class frmOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboLoaiHang = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDecrease = new FontAwesome.Sharp.IconButton();
            this.btnIncrease = new FontAwesome.Sharp.IconButton();
            this.txtGiamTru = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btnThemVaoGioHang = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSoLuongToiDa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTenSanPham = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvGioHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTienPhaiTra = new System.Windows.Forms.TextBox();
            this.btnLoaiBoMatHang = new System.Windows.Forms.Button();
            this.btnHuyGioHang = new System.Windows.Forms.Button();
            this.txtTienGiamTru = new System.Windows.Forms.TextBox();
            this.txtTongTienHang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lvDSKHTim = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFind = new FontAwesome.Sharp.IconButton();
            this.btnChon = new System.Windows.Forms.Button();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimKhachHang = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại hàng";
            // 
            // cboLoaiHang
            // 
            this.cboLoaiHang.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiHang.FormattingEnabled = true;
            this.cboLoaiHang.Location = new System.Drawing.Point(16, 45);
            this.cboLoaiHang.Name = "cboLoaiHang";
            this.cboLoaiHang.Size = new System.Drawing.Size(294, 24);
            this.cboLoaiHang.TabIndex = 1;
            this.cboLoaiHang.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiHang_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnDecrease);
            this.groupBox1.Controls.Add(this.btnIncrease);
            this.groupBox1.Controls.Add(this.cboLoaiHang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGiamTru);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnThemVaoGioHang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblSoLuongToiDa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboTenSanPham);
            this.groupBox1.Location = new System.Drawing.Point(14, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 309);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mặt hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "(%)";
            // 
            // btnDecrease
            // 
            this.btnDecrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(85)))), ((int)(((byte)(62)))));
            this.btnDecrease.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(9)))), ((int)(((byte)(33)))));
            this.btnDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrease.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDecrease.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.btnDecrease.IconColor = System.Drawing.Color.Black;
            this.btnDecrease.IconSize = 16;
            this.btnDecrease.Location = new System.Drawing.Point(279, 198);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Rotation = 0D;
            this.btnDecrease.Size = new System.Drawing.Size(33, 12);
            this.btnDecrease.TabIndex = 5;
            this.btnDecrease.UseVisualStyleBackColor = false;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(85)))), ((int)(((byte)(62)))));
            this.btnIncrease.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(9)))), ((int)(((byte)(33)))));
            this.btnIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrease.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnIncrease.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
            this.btnIncrease.IconColor = System.Drawing.Color.Black;
            this.btnIncrease.IconSize = 16;
            this.btnIncrease.Location = new System.Drawing.Point(279, 186);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Rotation = 0D;
            this.btnIncrease.Size = new System.Drawing.Size(33, 12);
            this.btnIncrease.TabIndex = 5;
            this.btnIncrease.UseVisualStyleBackColor = false;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // txtGiamTru
            // 
            this.txtGiamTru.Location = new System.Drawing.Point(91, 234);
            this.txtGiamTru.Name = "txtGiamTru";
            this.txtGiamTru.Size = new System.Drawing.Size(181, 23);
            this.txtGiamTru.TabIndex = 4;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(91, 140);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(181, 23);
            this.txtDonGia.TabIndex = 4;
            this.txtDonGia.Leave += new System.EventHandler(this.txtSoLuong_Leave);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(91, 186);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(181, 23);
            this.txtSoLuong.TabIndex = 4;
            this.txtSoLuong.Leave += new System.EventHandler(this.txtSoLuong_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.listView2);
            this.groupBox3.Location = new System.Drawing.Point(360, -38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 367);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giỏ hàng";
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView2.Location = new System.Drawing.Point(3, 19);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(412, 208);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btnThemVaoGioHang
            // 
            this.btnThemVaoGioHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(85)))), ((int)(((byte)(62)))));
            this.btnThemVaoGioHang.FlatAppearance.BorderSize = 0;
            this.btnThemVaoGioHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(9)))), ((int)(((byte)(33)))));
            this.btnThemVaoGioHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoGioHang.Location = new System.Drawing.Point(16, 266);
            this.btnThemVaoGioHang.Name = "btnThemVaoGioHang";
            this.btnThemVaoGioHang.Size = new System.Drawing.Size(299, 27);
            this.btnThemVaoGioHang.TabIndex = 2;
            this.btnThemVaoGioHang.Text = "Thêm vào giỏ hàng";
            this.btnThemVaoGioHang.UseVisualStyleBackColor = false;
            this.btnThemVaoGioHang.Click += new System.EventHandler(this.btnThemVaoGioHang_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giảm trừ ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đơn giá";
            // 
            // lblSoLuongToiDa
            // 
            this.lblSoLuongToiDa.AutoSize = true;
            this.lblSoLuongToiDa.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSoLuongToiDa.Location = new System.Drawing.Point(94, 213);
            this.lblSoLuongToiDa.Name = "lblSoLuongToiDa";
            this.lblSoLuongToiDa.Size = new System.Drawing.Size(113, 17);
            this.lblSoLuongToiDa.TabIndex = 0;
            this.lblSoLuongToiDa.Text = "[số lượng tối đa]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm";
            // 
            // cboTenSanPham
            // 
            this.cboTenSanPham.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenSanPham.FormattingEnabled = true;
            this.cboTenSanPham.Location = new System.Drawing.Point(16, 101);
            this.cboTenSanPham.Name = "cboTenSanPham";
            this.cboTenSanPham.Size = new System.Drawing.Size(296, 24);
            this.cboTenSanPham.TabIndex = 1;
            this.cboTenSanPham.SelectedIndexChanged += new System.EventHandler(this.cboTenSanPham_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.lvGioHang);
            this.groupBox2.Controls.Add(this.txtTienPhaiTra);
            this.groupBox2.Controls.Add(this.btnLoaiBoMatHang);
            this.groupBox2.Controls.Add(this.btnHuyGioHang);
            this.groupBox2.Controls.Add(this.txtTienGiamTru);
            this.groupBox2.Controls.Add(this.txtTongTienHang);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(369, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 362);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ hàng";
            // 
            // lvGioHang
            // 
            this.lvGioHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvGioHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvGioHang.FullRowSelect = true;
            this.lvGioHang.GridLines = true;
            this.lvGioHang.Location = new System.Drawing.Point(3, 19);
            this.lvGioHang.Name = "lvGioHang";
            this.lvGioHang.Size = new System.Drawing.Size(501, 227);
            this.lvGioHang.TabIndex = 0;
            this.lvGioHang.UseCompatibleStateImageBehavior = false;
            this.lvGioHang.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên sản phẩm";
            this.columnHeader1.Width = 214;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Loại hàng";
            this.columnHeader2.Width = 158;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 104;
            // 
            // txtTienPhaiTra
            // 
            this.txtTienPhaiTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTienPhaiTra.BackColor = System.Drawing.Color.LightGray;
            this.txtTienPhaiTra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienPhaiTra.Location = new System.Drawing.Point(301, 332);
            this.txtTienPhaiTra.Name = "txtTienPhaiTra";
            this.txtTienPhaiTra.ReadOnly = true;
            this.txtTienPhaiTra.Size = new System.Drawing.Size(197, 23);
            this.txtTienPhaiTra.TabIndex = 8;
            this.txtTienPhaiTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLoaiBoMatHang
            // 
            this.btnLoaiBoMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoaiBoMatHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(85)))), ((int)(((byte)(62)))));
            this.btnLoaiBoMatHang.FlatAppearance.BorderSize = 0;
            this.btnLoaiBoMatHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(9)))), ((int)(((byte)(33)))));
            this.btnLoaiBoMatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiBoMatHang.Location = new System.Drawing.Point(12, 264);
            this.btnLoaiBoMatHang.Name = "btnLoaiBoMatHang";
            this.btnLoaiBoMatHang.Size = new System.Drawing.Size(164, 27);
            this.btnLoaiBoMatHang.TabIndex = 2;
            this.btnLoaiBoMatHang.Text = "Loại bỏ khỏi giỏ hàng";
            this.btnLoaiBoMatHang.UseVisualStyleBackColor = false;
            this.btnLoaiBoMatHang.Click += new System.EventHandler(this.btnLoaiBoMatHang_Click);
            // 
            // btnHuyGioHang
            // 
            this.btnHuyGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuyGioHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(85)))), ((int)(((byte)(62)))));
            this.btnHuyGioHang.FlatAppearance.BorderSize = 0;
            this.btnHuyGioHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(9)))), ((int)(((byte)(33)))));
            this.btnHuyGioHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyGioHang.Location = new System.Drawing.Point(11, 320);
            this.btnHuyGioHang.Name = "btnHuyGioHang";
            this.btnHuyGioHang.Size = new System.Drawing.Size(164, 27);
            this.btnHuyGioHang.TabIndex = 2;
            this.btnHuyGioHang.Text = "Hủy giỏ hàng";
            this.btnHuyGioHang.UseVisualStyleBackColor = false;
            this.btnHuyGioHang.Click += new System.EventHandler(this.btnHuyGioHang_Click);
            // 
            // txtTienGiamTru
            // 
            this.txtTienGiamTru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTienGiamTru.BackColor = System.Drawing.Color.LightGray;
            this.txtTienGiamTru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienGiamTru.Location = new System.Drawing.Point(301, 301);
            this.txtTienGiamTru.Name = "txtTienGiamTru";
            this.txtTienGiamTru.ReadOnly = true;
            this.txtTienGiamTru.Size = new System.Drawing.Size(197, 23);
            this.txtTienGiamTru.TabIndex = 7;
            this.txtTienGiamTru.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTongTienHang
            // 
            this.txtTongTienHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongTienHang.BackColor = System.Drawing.Color.LightGray;
            this.txtTongTienHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTienHang.Location = new System.Drawing.Point(301, 267);
            this.txtTongTienHang.Name = "txtTongTienHang";
            this.txtTongTienHang.ReadOnly = true;
            this.txtTongTienHang.Size = new System.Drawing.Size(197, 23);
            this.txtTongTienHang.TabIndex = 6;
            this.txtTongTienHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng tiền hàng:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(190, 335);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Phải trả:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(189, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tiền giảm trừ:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtGhiChu);
            this.groupBox4.Controls.Add(this.lvDSKHTim);
            this.groupBox4.Controls.Add(this.btnFind);
            this.groupBox4.Controls.Add(this.btnChon);
            this.groupBox4.Controls.Add(this.txtTenKhachHang);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtTimKhachHang);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnTaoHoaDon);
            this.groupBox4.Location = new System.Drawing.Point(12, 380);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(863, 227);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGhiChu.BackColor = System.Drawing.Color.White;
            this.txtGhiChu.Location = new System.Drawing.Point(96, 97);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(245, 23);
            this.txtGhiChu.TabIndex = 8;
            this.txtGhiChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lvDSKHTim
            // 
            this.lvDSKHTim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDSKHTim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvDSKHTim.FullRowSelect = true;
            this.lvDSKHTim.GridLines = true;
            this.lvDSKHTim.Location = new System.Drawing.Point(391, 97);
            this.lvDSKHTim.Name = "lvDSKHTim";
            this.lvDSKHTim.Size = new System.Drawing.Size(451, 114);
            this.lvDSKHTim.TabIndex = 3;
            this.lvDSKHTim.UseCompatibleStateImageBehavior = false;
            this.lvDSKHTim.View = System.Windows.Forms.View.Details;
            this.lvDSKHTim.SelectedIndexChanged += new System.EventHandler(this.lvDSKHTim_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã khách hàng";
            this.columnHeader4.Width = 141;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên khách hàng";
            this.columnHeader5.Width = 295;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Địa chỉ";
            this.columnHeader6.Width = 300;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(85)))), ((int)(((byte)(62)))));
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(9)))), ((int)(((byte)(33)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFind.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFind.IconColor = System.Drawing.Color.Black;
            this.btnFind.IconSize = 16;
            this.btnFind.Location = new System.Drawing.Point(719, 52);
            this.btnFind.Name = "btnFind";
            this.btnFind.Rotation = 0D;
            this.btnFind.Size = new System.Drawing.Size(39, 26);
            this.btnFind.TabIndex = 5;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(85)))), ((int)(((byte)(62)))));
            this.btnChon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(9)))), ((int)(((byte)(33)))));
            this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChon.Location = new System.Drawing.Point(764, 52);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(56, 26);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenKhachHang.BackColor = System.Drawing.Color.LightGray;
            this.txtTenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKhachHang.ForeColor = System.Drawing.Color.Blue;
            this.txtTenKhachHang.Location = new System.Drawing.Point(21, 52);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.ReadOnly = true;
            this.txtTenKhachHang.Size = new System.Drawing.Size(320, 23);
            this.txtTenKhachHang.TabIndex = 1;
            this.txtTenKhachHang.Text = "Chưa chọn khách hàng";
            this.txtTenKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ghi chú";
            // 
            // txtTimKhachHang
            // 
            this.txtTimKhachHang.Location = new System.Drawing.Point(391, 52);
            this.txtTimKhachHang.Name = "txtTimKhachHang";
            this.txtTimKhachHang.Size = new System.Drawing.Size(308, 23);
            this.txtTimKhachHang.TabIndex = 1;
            this.txtTimKhachHang.Text = "(Tên khách hàng)";
            this.txtTimKhachHang.Enter += new System.EventHandler(this.txtTimKhachHang_Enter);
            this.txtTimKhachHang.Leave += new System.EventHandler(this.txtTimKhachHang_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm khách hàng:";
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(85)))), ((int)(((byte)(62)))));
            this.btnTaoHoaDon.FlatAppearance.BorderSize = 0;
            this.btnTaoHoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(9)))), ((int)(((byte)(33)))));
            this.btnTaoHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoHoaDon.Location = new System.Drawing.Point(18, 146);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(321, 25);
            this.btnTaoHoaDon.TabIndex = 2;
            this.btnTaoHoaDon.Text = "Tạo hóa đơn";
            this.btnTaoHoaDon.UseVisualStyleBackColor = false;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.BackColor = System.Drawing.Color.LightGray;
            this.txtSoPhieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoPhieu.Location = new System.Drawing.Point(91, 21);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.ReadOnly = true;
            this.txtSoPhieu.Size = new System.Drawing.Size(260, 23);
            this.txtSoPhieu.TabIndex = 1;
            this.txtSoPhieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số phiếu:";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(888, 621);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoPhieu);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOrder";
            this.Text = "frmOrder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLoaiHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnDecrease;
        private FontAwesome.Sharp.IconButton btnIncrease;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btnThemVaoGioHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTenSanPham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvGioHang;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lvDSKHTim;
        private System.Windows.Forms.TextBox txtTimKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGiamTru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTaoHoaDon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private FontAwesome.Sharp.IconButton btnFind;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.TextBox txtTienPhaiTra;
        private System.Windows.Forms.TextBox txtTienGiamTru;
        private System.Windows.Forms.TextBox txtTongTienHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnLoaiBoMatHang;
        private System.Windows.Forms.Button btnHuyGioHang;
        private System.Windows.Forms.Label lblSoLuongToiDa;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}