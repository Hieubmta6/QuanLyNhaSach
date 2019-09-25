namespace Doan
{
    partial class frm_KH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KH));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv_KH = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxt_ngaySinh = new System.Windows.Forms.MaskedTextBox();
            this.cb_GT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_suaKH = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_luuKH = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoaKH = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_HoTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soDT = new System.Windows.Forms.TextBox();
            this.txt_DCKH = new System.Windows.Forms.TextBox();
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_themKH = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_KH)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgv_KH);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(10, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 282);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // dtgv_KH
            // 
            this.dtgv_KH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_KH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_KH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_KH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.NGAYSINH,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dtgv_KH.Location = new System.Drawing.Point(13, 25);
            this.dtgv_KH.Name = "dtgv_KH";
            this.dtgv_KH.ReadOnly = true;
            this.dtgv_KH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_KH.Size = new System.Drawing.Size(965, 251);
            this.dtgv_KH.TabIndex = 45;
            this.dtgv_KH.SelectionChanged += new System.EventHandler(this.dtgv_KH_SelectionChanged);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "STT";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAKH";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HOTEN";
            this.Column3.HeaderText = "Họ tên";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GIOITINH";
            this.Column5.HeaderText = "Giới tính";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DIACHI";
            this.Column6.HeaderText = "Địa chỉ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DTKH";
            this.Column7.HeaderText = "Số điện thoại";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.mtxt_ngaySinh);
            this.groupBox1.Controls.Add(this.cb_GT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_suaKH);
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Controls.Add(this.btn_luuKH);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_xoaKH);
            this.groupBox1.Controls.Add(this.btn_themKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_HoTenKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_soDT);
            this.groupBox1.Controls.Add(this.txt_DCKH);
            this.groupBox1.Controls.Add(this.txt_maKH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 182);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // mtxt_ngaySinh
            // 
            this.mtxt_ngaySinh.Location = new System.Drawing.Point(161, 105);
            this.mtxt_ngaySinh.Mask = "00-00-0000";
            this.mtxt_ngaySinh.Name = "mtxt_ngaySinh";
            this.mtxt_ngaySinh.Size = new System.Drawing.Size(304, 22);
            this.mtxt_ngaySinh.TabIndex = 35;
            this.mtxt_ngaySinh.TextChanged += new System.EventHandler(this.mtxt_ngaySinh_TextChanged);
            // 
            // cb_GT
            // 
            this.cb_GT.FormattingEnabled = true;
            this.cb_GT.Location = new System.Drawing.Point(623, 104);
            this.cb_GT.Name = "cb_GT";
            this.cb_GT.Size = new System.Drawing.Size(121, 24);
            this.cb_GT.TabIndex = 36;
            this.cb_GT.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Số điện thoại";
            this.label4.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "Giới tính";
            this.label7.UseWaitCursor = true;
            // 
            // btn_suaKH
            // 
            this.btn_suaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_suaKH.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_suaKH.Location = new System.Drawing.Point(342, 149);
            this.btn_suaKH.Name = "btn_suaKH";
            this.btn_suaKH.Size = new System.Drawing.Size(75, 23);
            this.btn_suaKH.TabIndex = 39;
            this.btn_suaKH.Text = "Sửa";
            this.btn_suaKH.UseVisualStyleBackColor = false;
            this.btn_suaKH.UseWaitCursor = true;
            this.btn_suaKH.Click += new System.EventHandler(this.btn_suaKH_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Clear.Location = new System.Drawing.Point(475, 149);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 40;
            this.btn_Clear.Text = "Làm mới";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.UseWaitCursor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_luuKH
            // 
            this.btn_luuKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_luuKH.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_luuKH.Location = new System.Drawing.Point(601, 149);
            this.btn_luuKH.Name = "btn_luuKH";
            this.btn_luuKH.Size = new System.Drawing.Size(75, 23);
            this.btn_luuKH.TabIndex = 41;
            this.btn_luuKH.Text = "Lưu";
            this.btn_luuKH.UseVisualStyleBackColor = false;
            this.btn_luuKH.UseWaitCursor = true;
            this.btn_luuKH.Click += new System.EventHandler(this.btn_luuKH_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoat.Location = new System.Drawing.Point(707, 149);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 42;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.UseWaitCursor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoaKH
            // 
            this.btn_xoaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_xoaKH.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_xoaKH.Location = new System.Drawing.Point(220, 149);
            this.btn_xoaKH.Name = "btn_xoaKH";
            this.btn_xoaKH.Size = new System.Drawing.Size(75, 23);
            this.btn_xoaKH.TabIndex = 38;
            this.btn_xoaKH.Text = "Xóa";
            this.btn_xoaKH.UseVisualStyleBackColor = false;
            this.btn_xoaKH.UseWaitCursor = true;
            this.btn_xoaKH.Click += new System.EventHandler(this.btn_xoaKH_click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Địa chỉ";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Tên khách hàng";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_HoTenKH
            // 
            this.txt_HoTenKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_HoTenKH.Location = new System.Drawing.Point(623, 20);
            this.txt_HoTenKH.Name = "txt_HoTenKH";
            this.txt_HoTenKH.Size = new System.Drawing.Size(328, 22);
            this.txt_HoTenKH.TabIndex = 32;
            this.txt_HoTenKH.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Ngày sinh";
            this.label5.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mã khách hàng";
            this.label1.UseWaitCursor = true;
            // 
            // txt_soDT
            // 
            this.txt_soDT.Location = new System.Drawing.Point(623, 66);
            this.txt_soDT.Name = "txt_soDT";
            this.txt_soDT.Size = new System.Drawing.Size(328, 22);
            this.txt_soDT.TabIndex = 34;
            this.txt_soDT.UseWaitCursor = true;
            this.txt_soDT.TextChanged += new System.EventHandler(this.txt_soDT_TextChanged);
            // 
            // txt_DCKH
            // 
            this.txt_DCKH.Location = new System.Drawing.Point(164, 61);
            this.txt_DCKH.Name = "txt_DCKH";
            this.txt_DCKH.Size = new System.Drawing.Size(301, 22);
            this.txt_DCKH.TabIndex = 33;
            this.txt_DCKH.UseWaitCursor = true;
            // 
            // txt_maKH
            // 
            this.txt_maKH.Location = new System.Drawing.Point(164, 20);
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.Size = new System.Drawing.Size(301, 22);
            this.txt_maKH.TabIndex = 31;
            this.txt_maKH.UseWaitCursor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_themKH
            // 
            this.btn_themKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_themKH.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_themKH.Location = new System.Drawing.Point(99, 149);
            this.btn_themKH.Name = "btn_themKH";
            this.btn_themKH.Size = new System.Drawing.Size(75, 23);
            this.btn_themKH.TabIndex = 37;
            this.btn_themKH.Text = "Thêm";
            this.btn_themKH.UseVisualStyleBackColor = false;
            this.btn_themKH.UseWaitCursor = true;
            this.btn_themKH.Click += new System.EventHandler(this.btn_themKH_Click);
            // 
            // frm_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_KH";
            this.Text = "Form_KhachHang";
            this.Load += new System.EventHandler(this.frm_KH_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_KH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgv_KH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxt_ngaySinh;
        private System.Windows.Forms.ComboBox cb_GT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_suaKH;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_luuKH;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoaKH;
        private System.Windows.Forms.Button btn_themKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_HoTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soDT;
        private System.Windows.Forms.TextBox txt_DCKH;
        private System.Windows.Forms.TextBox txt_maKH;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}