namespace SideNavSample
{
    partial class frmThemLoaiHang
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
            this.components = new System.ComponentModel.Container();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtMaLoaiHang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenLoaiHang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnThemLoaiHang = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtSinhMa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelX1.Location = new System.Drawing.Point(16, 22);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(100, 28);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã Loại Hàng";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelX2.Location = new System.Drawing.Point(16, 78);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(100, 28);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Tên Loại Hàng";
            // 
            // txtMaLoaiHang
            // 
            this.txtMaLoaiHang.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMaLoaiHang.Border.Class = "TextBoxBorder";
            this.txtMaLoaiHang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaLoaiHang.DisabledBackColor = System.Drawing.Color.White;
            this.txtMaLoaiHang.ForeColor = System.Drawing.Color.Black;
            this.txtMaLoaiHang.Location = new System.Drawing.Point(184, 24);
            this.txtMaLoaiHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLoaiHang.Name = "txtMaLoaiHang";
            this.txtMaLoaiHang.PreventEnterBeep = true;
            this.txtMaLoaiHang.Size = new System.Drawing.Size(317, 23);
            this.txtMaLoaiHang.TabIndex = 1;
            // 
            // txtTenLoaiHang
            // 
            this.txtTenLoaiHang.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTenLoaiHang.Border.Class = "TextBoxBorder";
            this.txtTenLoaiHang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenLoaiHang.DisabledBackColor = System.Drawing.Color.White;
            this.txtTenLoaiHang.ForeColor = System.Drawing.Color.Black;
            this.txtTenLoaiHang.Location = new System.Drawing.Point(184, 81);
            this.txtTenLoaiHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLoaiHang.Name = "txtTenLoaiHang";
            this.txtTenLoaiHang.PreventEnterBeep = true;
            this.txtTenLoaiHang.Size = new System.Drawing.Size(317, 23);
            this.txtTenLoaiHang.TabIndex = 3;
            // 
            // btnThemLoaiHang
            // 
            this.btnThemLoaiHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(235)))), ((int)(((byte)(98)))));
            this.btnThemLoaiHang.FlatAppearance.BorderSize = 0;
            this.btnThemLoaiHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThemLoaiHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLoaiHang.ForeColor = System.Drawing.Color.Black;
            this.btnThemLoaiHang.Location = new System.Drawing.Point(86, 180);
            this.btnThemLoaiHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemLoaiHang.Name = "btnThemLoaiHang";
            this.btnThemLoaiHang.Size = new System.Drawing.Size(100, 28);
            this.btnThemLoaiHang.TabIndex = 6;
            this.btnThemLoaiHang.Text = "Thêm";
            this.btnThemLoaiHang.UseVisualStyleBackColor = false;
            this.btnThemLoaiHang.Click += new System.EventHandler(this.btnThemLoaiHang_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(235)))), ((int)(((byte)(98)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(327, 180);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelX3.Location = new System.Drawing.Point(16, 134);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(160, 28);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Mã Sản Phẩm Tự Sinh";
            // 
            // txtSinhMa
            // 
            this.txtSinhMa.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSinhMa.Border.Class = "TextBoxBorder";
            this.txtSinhMa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSinhMa.DisabledBackColor = System.Drawing.Color.White;
            this.txtSinhMa.ForeColor = System.Drawing.Color.Black;
            this.txtSinhMa.Location = new System.Drawing.Point(184, 137);
            this.txtSinhMa.Margin = new System.Windows.Forms.Padding(4);
            this.txtSinhMa.Name = "txtSinhMa";
            this.txtSinhMa.PreventEnterBeep = true;
            this.txtSinhMa.Size = new System.Drawing.Size(317, 23);
            this.txtSinhMa.TabIndex = 5;
            // 
            // frmThemLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(529, 227);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnThemLoaiHang);
            this.Controls.Add(this.txtSinhMa);
            this.Controls.Add(this.txtTenLoaiHang);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtMaLoaiHang);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmThemLoaiHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm Loại Hàng";
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaLoaiHang;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenLoaiHang;
        private System.Windows.Forms.Button btnThemLoaiHang;
        private System.Windows.Forms.Button btnCancel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSinhMa;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}