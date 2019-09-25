namespace Doan
{
    partial class Form_nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_nhanvien));
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grb_thongtinnhanvien = new System.Windows.Forms.GroupBox();
            this.msk_ngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.dt_nvl = new System.Windows.Forms.DateTimePicker();
            this.txtMNQL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.txtcv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.grb_dsnv = new System.Windows.Forms.GroupBox();
            this.dtgvDS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHINV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUCVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hủyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grb_thongtinnhanvien.SuspendLayout();
            this.grb_dsnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHuy.Enabled = false;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(819, 163);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 63);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(707, 163);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 63);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(595, 163);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 63);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(483, 163);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 63);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(371, 163);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 63);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grb_thongtinnhanvien
            // 
            this.grb_thongtinnhanvien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grb_thongtinnhanvien.BackColor = System.Drawing.Color.Transparent;
            this.grb_thongtinnhanvien.Controls.Add(this.msk_ngaysinh);
            this.grb_thongtinnhanvien.Controls.Add(this.dt_nvl);
            this.grb_thongtinnhanvien.Controls.Add(this.txtMNQL);
            this.grb_thongtinnhanvien.Controls.Add(this.label10);
            this.grb_thongtinnhanvien.Controls.Add(this.txtluong);
            this.grb_thongtinnhanvien.Controls.Add(this.txtcv);
            this.grb_thongtinnhanvien.Controls.Add(this.label9);
            this.grb_thongtinnhanvien.Controls.Add(this.label8);
            this.grb_thongtinnhanvien.Controls.Add(this.label7);
            this.grb_thongtinnhanvien.Controls.Add(this.cmbGioiTinh);
            this.grb_thongtinnhanvien.Controls.Add(this.label4);
            this.grb_thongtinnhanvien.Controls.Add(this.label2);
            this.grb_thongtinnhanvien.Controls.Add(this.label5);
            this.grb_thongtinnhanvien.Controls.Add(this.label3);
            this.grb_thongtinnhanvien.Controls.Add(this.label1);
            this.grb_thongtinnhanvien.Controls.Add(this.txtDiaChi);
            this.grb_thongtinnhanvien.Controls.Add(this.txtTen);
            this.grb_thongtinnhanvien.Controls.Add(this.txtMa);
            this.grb_thongtinnhanvien.Location = new System.Drawing.Point(0, 32);
            this.grb_thongtinnhanvien.Name = "grb_thongtinnhanvien";
            this.grb_thongtinnhanvien.Size = new System.Drawing.Size(1262, 104);
            this.grb_thongtinnhanvien.TabIndex = 3;
            this.grb_thongtinnhanvien.TabStop = false;
            this.grb_thongtinnhanvien.Text = "Thông tin nhân viên";
            // 
            // msk_ngaysinh
            // 
            this.msk_ngaysinh.Location = new System.Drawing.Point(645, 38);
            this.msk_ngaysinh.Mask = "00/00/0000";
            this.msk_ngaysinh.Name = "msk_ngaysinh";
            this.msk_ngaysinh.Size = new System.Drawing.Size(130, 20);
            this.msk_ngaysinh.TabIndex = 15;
            // 
            // dt_nvl
            // 
            this.dt_nvl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_nvl.Location = new System.Drawing.Point(876, 44);
            this.dt_nvl.Name = "dt_nvl";
            this.dt_nvl.Size = new System.Drawing.Size(130, 20);
            this.dt_nvl.TabIndex = 14;
            this.dt_nvl.Value = new System.DateTime(2018, 10, 26, 0, 0, 0, 0);
            // 
            // txtMNQL
            // 
            this.txtMNQL.Location = new System.Drawing.Point(1129, 42);
            this.txtMNQL.Name = "txtMNQL";
            this.txtMNQL.Size = new System.Drawing.Size(130, 20);
            this.txtMNQL.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1035, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Mã người quản lý";
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(876, 71);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(130, 20);
            this.txtluong.TabIndex = 9;
            this.txtluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtluong_KeyPress);
            // 
            // txtcv
            // 
            this.txtcv.Location = new System.Drawing.Point(645, 75);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(130, 20);
            this.txtcv.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(798, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ngày vào làm";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(833, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Lương";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Chức vụ";
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Location = new System.Drawing.Point(97, 75);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(121, 21);
            this.cmbGioiTinh.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Location = new System.Drawing.Point(310, 75);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(262, 20);
            this.txtDiaChi.TabIndex = 0;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(310, 45);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(184, 20);
            this.txtTen.TabIndex = 0;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(97, 42);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(121, 20);
            this.txtMa.TabIndex = 0;
            // 
            // grb_dsnv
            // 
            this.grb_dsnv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_dsnv.BackColor = System.Drawing.Color.Transparent;
            this.grb_dsnv.Controls.Add(this.dtgvDS);
            this.grb_dsnv.Location = new System.Drawing.Point(0, 265);
            this.grb_dsnv.Name = "grb_dsnv";
            this.grb_dsnv.Size = new System.Drawing.Size(1262, 233);
            this.grb_dsnv.TabIndex = 4;
            this.grb_dsnv.TabStop = false;
            this.grb_dsnv.Text = "Danh sách nhân viên";
            // 
            // dtgvDS
            // 
            this.dtgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.MANV,
            this.HOTENNV,
            this.NGAYSINH,
            this.NGAYVL,
            this.GIOITINH,
            this.DIACHINV,
            this.LUONG,
            this.CHUCVU,
            this.MANQL});
            this.dtgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDS.Location = new System.Drawing.Point(3, 16);
            this.dtgvDS.Name = "dtgvDS";
            this.dtgvDS.Size = new System.Drawing.Size(1256, 214);
            this.dtgvDS.TabIndex = 0;
            this.dtgvDS.SelectionChanged += new System.EventHandler(this.dtgvDS_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.Name = "MANV";
            // 
            // HOTENNV
            // 
            this.HOTENNV.DataPropertyName = "HOTENNV";
            this.HOTENNV.HeaderText = "Họ tên nhân viên";
            this.HOTENNV.Name = "HOTENNV";
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            // 
            // NGAYVL
            // 
            this.NGAYVL.DataPropertyName = "NGAYVL";
            this.NGAYVL.HeaderText = "Ngày vào làm";
            this.NGAYVL.Name = "NGAYVL";
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "PHAI";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Name = "GIOITINH";
            // 
            // DIACHINV
            // 
            this.DIACHINV.DataPropertyName = "DIACHINV";
            this.DIACHINV.HeaderText = "Địa chỉ";
            this.DIACHINV.Name = "DIACHINV";
            // 
            // LUONG
            // 
            this.LUONG.DataPropertyName = "LUONG";
            this.LUONG.HeaderText = "Lương";
            this.LUONG.Name = "LUONG";
            // 
            // CHUCVU
            // 
            this.CHUCVU.DataPropertyName = "CHUCVU";
            this.CHUCVU.HeaderText = "Chức vụ";
            this.CHUCVU.Name = "CHUCVU";
            // 
            // MANQL
            // 
            this.MANQL.DataPropertyName = "MANQL";
            this.MANQL.HeaderText = "Mã người quản lý";
            this.MANQL.Name = "MANQL";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LavenderBlush;
            this.menuStrip1.BackgroundImage = global::Doan.Properties.Resources.download1;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.lưuToolStripMenuItem,
            this.hủyToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 29);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thêmToolStripMenuItem.Image = global::Doan.Properties.Resources._1;
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xóaToolStripMenuItem.Image = global::Doan.Properties.Resources._trash2;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sửaToolStripMenuItem.Image = global::Doan.Properties.Resources.configuration_1;
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lưuToolStripMenuItem.Image = global::Doan.Properties.Resources.floppy_128;
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.lưuToolStripMenuItem.Text = "Lưu";
            this.lưuToolStripMenuItem.Click += new System.EventHandler(this.lưuToolStripMenuItem_Click);
            // 
            // hủyToolStripMenuItem1
            // 
            this.hủyToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hủyToolStripMenuItem1.Image = global::Doan.Properties.Resources.fileclose1;
            this.hủyToolStripMenuItem1.Name = "hủyToolStripMenuItem1";
            this.hủyToolStripMenuItem1.Size = new System.Drawing.Size(66, 25);
            this.hủyToolStripMenuItem1.Text = "Hủy";
            this.hủyToolStripMenuItem1.Click += new System.EventHandler(this.hủyToolStripMenuItem1_Click);
            // 
            // Form_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 510);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grb_dsnv);
            this.Controls.Add(this.grb_thongtinnhanvien);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_nhanvien";
            this.Text = "Nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_nhanvien_FormClosing);
            this.Load += new System.EventHandler(this.Form_nhanvien_Load);
            this.grb_thongtinnhanvien.ResumeLayout(false);
            this.grb_thongtinnhanvien.PerformLayout();
            this.grb_dsnv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grb_thongtinnhanvien;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.GroupBox grb_dsnv;
        private System.Windows.Forms.DataGridView dtgvDS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMNQL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.TextBox txtcv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hủyToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHINV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUCVU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANQL;
        private System.Windows.Forms.MaskedTextBox msk_ngaysinh;
        private System.Windows.Forms.DateTimePicker dt_nvl;
    }
}