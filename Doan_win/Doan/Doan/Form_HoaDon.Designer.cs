namespace Doan
{
    partial class frm_HD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HD));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv_CTHD = new System.Windows.Forms.DataGridView();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgv_HD = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_lapHD = new System.Windows.Forms.GroupBox();
            this.cb_donGia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_suaHD = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_luuHD = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoaHD = new System.Windows.Forms.Button();
            this.btn_xuLiCTHD = new System.Windows.Forms.Button();
            this.btn_xuLiHD = new System.Windows.Forms.Button();
            this.btn_themHD = new System.Windows.Forms.Button();
            this.mtxt_ngayLap = new System.Windows.Forms.MaskedTextBox();
            this.cb_KH = new System.Windows.Forms.ComboBox();
            this.cb_NV = new System.Windows.Forms.ComboBox();
            this.cb_SH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.txt_maHD = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CTHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HD)).BeginInit();
            this.grb_lapHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgv_CTHD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(791, 316);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(487, 298);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // dtgv_CTHD
            // 
            this.dtgv_CTHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_CTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_CTHD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv_CTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_CTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16});
            this.dtgv_CTHD.Location = new System.Drawing.Point(8, 41);
            this.dtgv_CTHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgv_CTHD.Name = "dtgv_CTHD";
            this.dtgv_CTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_CTHD.Size = new System.Drawing.Size(471, 229);
            this.dtgv_CTHD.TabIndex = 82;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "MAHD";
            this.Column13.HeaderText = "MAHD";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "MASH";
            this.Column14.HeaderText = "MASH";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "DONGIA";
            this.Column15.HeaderText = "DONGIA";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "SOLUONG";
            this.Column16.HeaderText = "SOLUONG";
            this.Column16.Name = "Column16";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtgv_HD);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(55, 316);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(728, 298);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dtgv_HD
            // 
            this.dtgv_HD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_HD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_HD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_HD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column9,
            this.NGAYLAP,
            this.Column12,
            this.Column7,
            this.Column10});
            this.dtgv_HD.Location = new System.Drawing.Point(12, 41);
            this.dtgv_HD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgv_HD.Name = "dtgv_HD";
            this.dtgv_HD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_HD.Size = new System.Drawing.Size(708, 229);
            this.dtgv_HD.TabIndex = 65;
            this.dtgv_HD.SelectionChanged += new System.EventHandler(this.dtgv_HD_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAHD";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MAKH";
            this.Column5.HeaderText = "Mã khách hàng";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "HOTEN";
            this.Column9.HeaderText = "Tên khách hàng";
            this.Column9.Name = "Column9";
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.DataPropertyName = "NGAYLAP";
            this.NGAYLAP.HeaderText = "Ngày lập";
            this.NGAYLAP.Name = "NGAYLAP";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "TONGTIEN";
            this.Column12.HeaderText = "Tổng tiền";
            this.Column12.Name = "Column12";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MANV";
            this.Column7.HeaderText = "Mã nhân viên";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "HOTENNV";
            this.Column10.HeaderText = "Tên nhân viên";
            this.Column10.Name = "Column10";
            // 
            // grb_lapHD
            // 
            this.grb_lapHD.Controls.Add(this.cb_donGia);
            this.grb_lapHD.Controls.Add(this.label3);
            this.grb_lapHD.Controls.Add(this.btn_suaHD);
            this.grb_lapHD.Controls.Add(this.btn_Clear);
            this.grb_lapHD.Controls.Add(this.btn_luuHD);
            this.grb_lapHD.Controls.Add(this.btn_thoat);
            this.grb_lapHD.Controls.Add(this.btn_xoaHD);
            this.grb_lapHD.Controls.Add(this.btn_xuLiCTHD);
            this.grb_lapHD.Controls.Add(this.btn_xuLiHD);
            this.grb_lapHD.Controls.Add(this.btn_themHD);
            this.grb_lapHD.Controls.Add(this.mtxt_ngayLap);
            this.grb_lapHD.Controls.Add(this.cb_KH);
            this.grb_lapHD.Controls.Add(this.cb_NV);
            this.grb_lapHD.Controls.Add(this.cb_SH);
            this.grb_lapHD.Controls.Add(this.label4);
            this.grb_lapHD.Controls.Add(this.label7);
            this.grb_lapHD.Controls.Add(this.label6);
            this.grb_lapHD.Controls.Add(this.label2);
            this.grb_lapHD.Controls.Add(this.label5);
            this.grb_lapHD.Controls.Add(this.label1);
            this.grb_lapHD.Controls.Add(this.txt_soLuong);
            this.grb_lapHD.Controls.Add(this.txt_maHD);
            this.grb_lapHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grb_lapHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_lapHD.Location = new System.Drawing.Point(55, 17);
            this.grb_lapHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_lapHD.Name = "grb_lapHD";
            this.grb_lapHD.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_lapHD.Size = new System.Drawing.Size(1223, 272);
            this.grb_lapHD.TabIndex = 65;
            this.grb_lapHD.TabStop = false;
            this.grb_lapHD.Text = "Xử lí hóa đơn";
            // 
            // cb_donGia
            // 
            this.cb_donGia.FormattingEnabled = true;
            this.cb_donGia.Location = new System.Drawing.Point(1049, 138);
            this.cb_donGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_donGia.Name = "cb_donGia";
            this.cb_donGia.Size = new System.Drawing.Size(160, 28);
            this.cb_donGia.TabIndex = 80;
            this.cb_donGia.UseWaitCursor = true;
            this.cb_donGia.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(959, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 81;
            this.label3.Text = "Đơn giá";
            this.label3.UseWaitCursor = true;
            this.label3.Visible = false;
            // 
            // btn_suaHD
            // 
            this.btn_suaHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_suaHD.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_suaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_suaHD.Location = new System.Drawing.Point(416, 220);
            this.btn_suaHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_suaHD.Name = "btn_suaHD";
            this.btn_suaHD.Size = new System.Drawing.Size(100, 44);
            this.btn_suaHD.TabIndex = 76;
            this.btn_suaHD.Text = "Sửa";
            this.btn_suaHD.UseVisualStyleBackColor = false;
            this.btn_suaHD.UseWaitCursor = true;
            this.btn_suaHD.Click += new System.EventHandler(this.btn_suaHD_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Clear.Location = new System.Drawing.Point(593, 220);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 44);
            this.btn_Clear.TabIndex = 77;
            this.btn_Clear.Text = "Làm mới";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.UseWaitCursor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_luuHD
            // 
            this.btn_luuHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_luuHD.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_luuHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_luuHD.Location = new System.Drawing.Point(744, 221);
            this.btn_luuHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_luuHD.Name = "btn_luuHD";
            this.btn_luuHD.Size = new System.Drawing.Size(100, 44);
            this.btn_luuHD.TabIndex = 74;
            this.btn_luuHD.Text = "Lưu";
            this.btn_luuHD.UseVisualStyleBackColor = false;
            this.btn_luuHD.UseWaitCursor = true;
            this.btn_luuHD.Click += new System.EventHandler(this.btn_luuHD_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thoat.Location = new System.Drawing.Point(903, 220);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 44);
            this.btn_thoat.TabIndex = 75;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.UseWaitCursor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoaHD
            // 
            this.btn_xoaHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_xoaHD.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_xoaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoaHD.Location = new System.Drawing.Point(260, 220);
            this.btn_xoaHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xoaHD.Name = "btn_xoaHD";
            this.btn_xoaHD.Size = new System.Drawing.Size(100, 44);
            this.btn_xoaHD.TabIndex = 78;
            this.btn_xoaHD.Text = "Xóa";
            this.btn_xoaHD.UseVisualStyleBackColor = false;
            this.btn_xoaHD.UseWaitCursor = true;
            this.btn_xoaHD.Click += new System.EventHandler(this.btn_xoaHD_Click);
            // 
            // btn_xuLiCTHD
            // 
            this.btn_xuLiCTHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_xuLiCTHD.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_xuLiCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xuLiCTHD.Location = new System.Drawing.Point(593, 171);
            this.btn_xuLiCTHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xuLiCTHD.Name = "btn_xuLiCTHD";
            this.btn_xuLiCTHD.Size = new System.Drawing.Size(409, 42);
            this.btn_xuLiCTHD.TabIndex = 79;
            this.btn_xuLiCTHD.Text = "Xử lí chi tiết hóa đơn";
            this.btn_xuLiCTHD.UseVisualStyleBackColor = false;
            this.btn_xuLiCTHD.UseWaitCursor = true;
            this.btn_xuLiCTHD.Click += new System.EventHandler(this.btn_xuLiCTHD_Click);
            // 
            // btn_xuLiHD
            // 
            this.btn_xuLiHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_xuLiHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xuLiHD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xuLiHD.Location = new System.Drawing.Point(92, 167);
            this.btn_xuLiHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xuLiHD.Name = "btn_xuLiHD";
            this.btn_xuLiHD.Size = new System.Drawing.Size(424, 46);
            this.btn_xuLiHD.TabIndex = 79;
            this.btn_xuLiHD.Text = "Xử lí hóa đơn";
            this.btn_xuLiHD.UseVisualStyleBackColor = false;
            this.btn_xuLiHD.UseWaitCursor = true;
            this.btn_xuLiHD.Click += new System.EventHandler(this.btn_xuLiHD_Click);
            // 
            // btn_themHD
            // 
            this.btn_themHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_themHD.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_themHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_themHD.Location = new System.Drawing.Point(92, 220);
            this.btn_themHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_themHD.Name = "btn_themHD";
            this.btn_themHD.Size = new System.Drawing.Size(100, 44);
            this.btn_themHD.TabIndex = 79;
            this.btn_themHD.Text = "Thêm";
            this.btn_themHD.UseVisualStyleBackColor = false;
            this.btn_themHD.UseWaitCursor = true;
            this.btn_themHD.Click += new System.EventHandler(this.btn_themHD_Click);
            // 
            // mtxt_ngayLap
            // 
            this.mtxt_ngayLap.Location = new System.Drawing.Point(136, 133);
            this.mtxt_ngayLap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxt_ngayLap.Mask = "00/00/0000";
            this.mtxt_ngayLap.Name = "mtxt_ngayLap";
            this.mtxt_ngayLap.Size = new System.Drawing.Size(345, 26);
            this.mtxt_ngayLap.TabIndex = 73;
            // 
            // cb_KH
            // 
            this.cb_KH.FormattingEnabled = true;
            this.cb_KH.Location = new System.Drawing.Point(560, 34);
            this.cb_KH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_KH.Name = "cb_KH";
            this.cb_KH.Size = new System.Drawing.Size(275, 28);
            this.cb_KH.TabIndex = 72;
            this.cb_KH.UseWaitCursor = true;
            // 
            // cb_NV
            // 
            this.cb_NV.FormattingEnabled = true;
            this.cb_NV.Location = new System.Drawing.Point(948, 34);
            this.cb_NV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_NV.Name = "cb_NV";
            this.cb_NV.Size = new System.Drawing.Size(263, 28);
            this.cb_NV.TabIndex = 71;
            this.cb_NV.UseWaitCursor = true;
            // 
            // cb_SH
            // 
            this.cb_SH.FormattingEnabled = true;
            this.cb_SH.Location = new System.Drawing.Point(136, 86);
            this.cb_SH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_SH.Name = "cb_SH";
            this.cb_SH.Size = new System.Drawing.Size(699, 28);
            this.cb_SH.TabIndex = 70;
            this.cb_SH.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(859, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Số lượng";
            this.label4.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "Tên sách";
            this.label7.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(856, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Nhân viên";
            this.label6.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Khách hàng";
            this.label2.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Ngày lập";
            this.label5.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Mã hóa đơn";
            this.label1.UseWaitCursor = true;
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Location = new System.Drawing.Point(948, 84);
            this.txt_soLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(263, 26);
            this.txt_soLuong.TabIndex = 69;
            this.txt_soLuong.UseWaitCursor = true;
            // 
            // txt_maHD
            // 
            this.txt_maHD.Location = new System.Drawing.Point(136, 36);
            this.txt_maHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_maHD.Name = "txt_maHD";
            this.txt_maHD.Size = new System.Drawing.Size(291, 26);
            this.txt_maHD.TabIndex = 68;
            this.txt_maHD.UseWaitCursor = true;
            // 
            // frm_HD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1332, 612);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_lapHD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_HD";
            this.Text = "Form_HoaDon";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_HD_FormClosed);
            this.Load += new System.EventHandler(this.frm_HD_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CTHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HD)).EndInit();
            this.grb_lapHD.ResumeLayout(false);
            this.grb_lapHD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgv_CTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgv_HD;
        private System.Windows.Forms.GroupBox grb_lapHD;
        private System.Windows.Forms.ComboBox cb_donGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_suaHD;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_luuHD;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoaHD;
        private System.Windows.Forms.Button btn_xuLiCTHD;
        private System.Windows.Forms.Button btn_xuLiHD;
        private System.Windows.Forms.Button btn_themHD;
        private System.Windows.Forms.MaskedTextBox mtxt_ngayLap;
        private System.Windows.Forms.ComboBox cb_KH;
        private System.Windows.Forms.ComboBox cb_NV;
        private System.Windows.Forms.ComboBox cb_SH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.TextBox txt_maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}