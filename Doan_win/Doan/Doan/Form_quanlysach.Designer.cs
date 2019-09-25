namespace Doan
{
    partial class Form_quanlysach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_quanlysach));
            this.grb_dssach = new System.Windows.Forms.GroupBox();
            this.dtgv_sach = new System.Windows.Forms.DataGridView();
            this.stt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAISH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAISH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grb_thongtinsach = new System.Windows.Forms.GroupBox();
            this.cmb_nxb = new System.Windows.Forms.ComboBox();
            this.cmb_ttg = new System.Windows.Forms.ComboBox();
            this.cmb_tl = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nanxb = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hủyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grb_dssach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sach)).BeginInit();
            this.grb_thongtinsach.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_dssach
            // 
            this.grb_dssach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_dssach.Controls.Add(this.dtgv_sach);
            this.grb_dssach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_dssach.Location = new System.Drawing.Point(0, 260);
            this.grb_dssach.Name = "grb_dssach";
            this.grb_dssach.Size = new System.Drawing.Size(1267, 201);
            this.grb_dssach.TabIndex = 5;
            this.grb_dssach.TabStop = false;
            this.grb_dssach.Text = "Sach";
            // 
            // dtgv_sach
            // 
            this.dtgv_sach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_sach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_sach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt1,
            this.MASH,
            this.TENSH,
            this.MALOAISH,
            this.TENLOAISH,
            this.MATG,
            this.TENTG,
            this.NAMXB,
            this.MANXB,
            this.TENNXB,
            this.GIATIEN,
            this.KHO});
            this.dtgv_sach.Location = new System.Drawing.Point(3, 16);
            this.dtgv_sach.Name = "dtgv_sach";
            this.dtgv_sach.Size = new System.Drawing.Size(1264, 182);
            this.dtgv_sach.TabIndex = 0;
            this.dtgv_sach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_sach_CellContentClick);
            this.dtgv_sach.SelectionChanged += new System.EventHandler(this.dtgv_sach_SelectionChanged);
            // 
            // stt1
            // 
            this.stt1.FillWeight = 50F;
            this.stt1.HeaderText = "STT";
            this.stt1.Name = "stt1";
            // 
            // MASH
            // 
            this.MASH.DataPropertyName = "MASH";
            this.MASH.FillWeight = 80F;
            this.MASH.HeaderText = "Mã sách";
            this.MASH.Name = "MASH";
            // 
            // TENSH
            // 
            this.TENSH.DataPropertyName = "TENSH";
            this.TENSH.FillWeight = 200F;
            this.TENSH.HeaderText = "Tên sách";
            this.TENSH.Name = "TENSH";
            // 
            // MALOAISH
            // 
            this.MALOAISH.DataPropertyName = "MALOAISH";
            this.MALOAISH.HeaderText = "Mã thể loại";
            this.MALOAISH.Name = "MALOAISH";
            this.MALOAISH.Visible = false;
            // 
            // TENLOAISH
            // 
            this.TENLOAISH.DataPropertyName = "TENLOAISH";
            this.TENLOAISH.HeaderText = "Thể loại";
            this.TENLOAISH.Name = "TENLOAISH";
            // 
            // MATG
            // 
            this.MATG.DataPropertyName = "MATG";
            this.MATG.FillWeight = 80F;
            this.MATG.HeaderText = "Mã tác giả";
            this.MATG.Name = "MATG";
            this.MATG.Visible = false;
            // 
            // TENTG
            // 
            this.TENTG.DataPropertyName = "TENTG";
            this.TENTG.HeaderText = "Tên tác giả";
            this.TENTG.Name = "TENTG";
            // 
            // NAMXB
            // 
            this.NAMXB.DataPropertyName = "NAMXB";
            this.NAMXB.HeaderText = "Năm xuất bản";
            this.NAMXB.Name = "NAMXB";
            // 
            // MANXB
            // 
            this.MANXB.DataPropertyName = "MANXB";
            this.MANXB.FillWeight = 110F;
            this.MANXB.HeaderText = "Mã nhà xuất bản";
            this.MANXB.Name = "MANXB";
            this.MANXB.Visible = false;
            // 
            // TENNXB
            // 
            this.TENNXB.DataPropertyName = "TENNXB";
            this.TENNXB.FillWeight = 200F;
            this.TENNXB.HeaderText = "Nhà xuất bản";
            this.TENNXB.Name = "TENNXB";
            // 
            // GIATIEN
            // 
            this.GIATIEN.DataPropertyName = "GIATiEN";
            this.GIATIEN.HeaderText = "Gía tiền";
            this.GIATIEN.Name = "GIATIEN";
            // 
            // KHO
            // 
            this.KHO.DataPropertyName = "SOLUONG";
            this.KHO.HeaderText = "Số lượng";
            this.KHO.Name = "KHO";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHuy.Enabled = false;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(866, 174);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 63);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(754, 174);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 63);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(642, 174);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 63);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(530, 174);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 63);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(418, 174);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 63);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grb_thongtinsach
            // 
            this.grb_thongtinsach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grb_thongtinsach.BackColor = System.Drawing.Color.Transparent;
            this.grb_thongtinsach.Controls.Add(this.cmb_nxb);
            this.grb_thongtinsach.Controls.Add(this.cmb_ttg);
            this.grb_thongtinsach.Controls.Add(this.cmb_tl);
            this.grb_thongtinsach.Controls.Add(this.label10);
            this.grb_thongtinsach.Controls.Add(this.txtgia);
            this.grb_thongtinsach.Controls.Add(this.label9);
            this.grb_thongtinsach.Controls.Add(this.label8);
            this.grb_thongtinsach.Controls.Add(this.label4);
            this.grb_thongtinsach.Controls.Add(this.label5);
            this.grb_thongtinsach.Controls.Add(this.label3);
            this.grb_thongtinsach.Controls.Add(this.label1);
            this.grb_thongtinsach.Controls.Add(this.txt_nanxb);
            this.grb_thongtinsach.Controls.Add(this.txtTen);
            this.grb_thongtinsach.Controls.Add(this.txtMa);
            this.grb_thongtinsach.Enabled = false;
            this.grb_thongtinsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_thongtinsach.Location = new System.Drawing.Point(5, 64);
            this.grb_thongtinsach.Name = "grb_thongtinsach";
            this.grb_thongtinsach.Size = new System.Drawing.Size(1262, 104);
            this.grb_thongtinsach.TabIndex = 10;
            this.grb_thongtinsach.TabStop = false;
            this.grb_thongtinsach.Text = "Thông tin sách";
            // 
            // cmb_nxb
            // 
            this.cmb_nxb.FormattingEnabled = true;
            this.cmb_nxb.Location = new System.Drawing.Point(1012, 31);
            this.cmb_nxb.Name = "cmb_nxb";
            this.cmb_nxb.Size = new System.Drawing.Size(190, 24);
            this.cmb_nxb.TabIndex = 3;
            // 
            // cmb_ttg
            // 
            this.cmb_ttg.FormattingEnabled = true;
            this.cmb_ttg.Location = new System.Drawing.Point(351, 69);
            this.cmb_ttg.Name = "cmb_ttg";
            this.cmb_ttg.Size = new System.Drawing.Size(176, 24);
            this.cmb_ttg.TabIndex = 5;
            // 
            // cmb_tl
            // 
            this.cmb_tl.FormattingEnabled = true;
            this.cmb_tl.Location = new System.Drawing.Point(670, 28);
            this.cmb_tl.Name = "cmb_tl";
            this.cmb_tl.Size = new System.Drawing.Size(176, 24);
            this.cmb_tl.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(920, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Nhà xuất bản";
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(670, 69);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(176, 22);
            this.txtgia.TabIndex = 6;
            this.txtgia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtgia_KeyDown);
            this.txtgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgia_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tên tác giả";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(593, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Gía tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Năm xuất bản";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Thể loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sách";
            // 
            // txt_nanxb
            // 
            this.txt_nanxb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nanxb.Location = new System.Drawing.Point(102, 70);
            this.txt_nanxb.Name = "txt_nanxb";
            this.txt_nanxb.Size = new System.Drawing.Size(101, 22);
            this.txt_nanxb.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(351, 24);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(163, 22);
            this.txtTen.TabIndex = 1;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(102, 28);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(101, 22);
            this.txtMa.TabIndex = 0;
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
            this.menuStrip1.Size = new System.Drawing.Size(1271, 29);
            this.menuStrip1.TabIndex = 16;
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
            this.xóaToolStripMenuItem.Image = global::Doan.Properties.Resources._trash4;
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
            // Form_quanlysach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1271, 457);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.grb_dssach);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grb_thongtinsach);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_quanlysach";
            this.Text = "Quản lý sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_quanlysach_FormClosing);
            this.Load += new System.EventHandler(this.Form_quanlysach_Load);
            this.grb_dssach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_sach)).EndInit();
            this.grb_thongtinsach.ResumeLayout(false);
            this.grb_thongtinsach.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_dssach;
        private System.Windows.Forms.DataGridView dtgv_sach;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grb_thongtinsach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.ComboBox cmb_nxb;
        private System.Windows.Forms.ComboBox cmb_ttg;
        private System.Windows.Forms.ComboBox cmb_tl;
        private System.Windows.Forms.TextBox txt_nanxb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAISH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAISH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KHO;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hủyToolStripMenuItem1;


    }
}