namespace Doan
{
    partial class Form_taikhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_taikhoan));
            this.label4 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grb_tk = new System.Windows.Forms.GroupBox();
            this.dtgv_tk = new System.Windows.Forms.DataGridView();
            this.stt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUYEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSWORK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_THONGTINTK = new System.Windows.Forms.GroupBox();
            this.dtp_ngaylap = new System.Windows.Forms.DateTimePicker();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tentk = new System.Windows.Forms.TextBox();
            this.txt_quyen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_matk = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hủyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grb_tk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_tk)).BeginInit();
            this.grb_THONGTINTK.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1008, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ngày lập";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHuy.Enabled = false;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Location = new System.Drawing.Point(641, 142);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 63);
            this.btnHuy.TabIndex = 50;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // grb_tk
            // 
            this.grb_tk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_tk.Controls.Add(this.dtgv_tk);
            this.grb_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_tk.Location = new System.Drawing.Point(12, 220);
            this.grb_tk.Name = "grb_tk";
            this.grb_tk.Size = new System.Drawing.Size(1248, 201);
            this.grb_tk.TabIndex = 48;
            this.grb_tk.TabStop = false;
            this.grb_tk.Text = "Danh sách tài khoản";
            // 
            // dtgv_tk
            // 
            this.dtgv_tk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_tk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_tk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_tk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt1,
            this.MATK,
            this.QUYEN,
            this.TENTK,
            this.PASSWORK,
            this.NGAYLAP});
            this.dtgv_tk.Location = new System.Drawing.Point(6, 21);
            this.dtgv_tk.Name = "dtgv_tk";
            this.dtgv_tk.Size = new System.Drawing.Size(1239, 182);
            this.dtgv_tk.TabIndex = 0;
            this.dtgv_tk.SelectionChanged += new System.EventHandler(this.dtgv_tk_SelectionChanged);
            // 
            // stt1
            // 
            this.stt1.FillWeight = 50F;
            this.stt1.HeaderText = "STT";
            this.stt1.Name = "stt1";
            // 
            // MATK
            // 
            this.MATK.DataPropertyName = "MATK";
            this.MATK.FillWeight = 110F;
            this.MATK.HeaderText = "Mã tài khoản";
            this.MATK.Name = "MATK";
            // 
            // QUYEN
            // 
            this.QUYEN.DataPropertyName = "QUYEN";
            this.QUYEN.FillWeight = 200F;
            this.QUYEN.HeaderText = "Quyền";
            this.QUYEN.Name = "QUYEN";
            // 
            // TENTK
            // 
            this.TENTK.DataPropertyName = "TENTK";
            this.TENTK.HeaderText = "Tên tài khoản";
            this.TENTK.Name = "TENTK";
            // 
            // PASSWORK
            // 
            this.PASSWORK.DataPropertyName = "PASSWORK";
            this.PASSWORK.HeaderText = "Mật khẩu";
            this.PASSWORK.Name = "PASSWORK";
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.DataPropertyName = "NGAYLAP";
            this.NGAYLAP.HeaderText = "Ngày lập";
            this.NGAYLAP.Name = "NGAYLAP";
            // 
            // grb_THONGTINTK
            // 
            this.grb_THONGTINTK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grb_THONGTINTK.BackColor = System.Drawing.Color.Transparent;
            this.grb_THONGTINTK.Controls.Add(this.dtp_ngaylap);
            this.grb_THONGTINTK.Controls.Add(this.label4);
            this.grb_THONGTINTK.Controls.Add(this.txt_mk);
            this.grb_THONGTINTK.Controls.Add(this.label2);
            this.grb_THONGTINTK.Controls.Add(this.txt_tentk);
            this.grb_THONGTINTK.Controls.Add(this.txt_quyen);
            this.grb_THONGTINTK.Controls.Add(this.label5);
            this.grb_THONGTINTK.Controls.Add(this.label3);
            this.grb_THONGTINTK.Controls.Add(this.label1);
            this.grb_THONGTINTK.Controls.Add(this.txt_matk);
            this.grb_THONGTINTK.Enabled = false;
            this.grb_THONGTINTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_THONGTINTK.Location = new System.Drawing.Point(15, 43);
            this.grb_THONGTINTK.Name = "grb_THONGTINTK";
            this.grb_THONGTINTK.Size = new System.Drawing.Size(1248, 71);
            this.grb_THONGTINTK.TabIndex = 49;
            this.grb_THONGTINTK.TabStop = false;
            this.grb_THONGTINTK.Text = "Thông tin tài khoản";
            // 
            // dtp_ngaylap
            // 
            this.dtp_ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaylap.Location = new System.Drawing.Point(1079, 35);
            this.dtp_ngaylap.Name = "dtp_ngaylap";
            this.dtp_ngaylap.Size = new System.Drawing.Size(132, 24);
            this.dtp_ngaylap.TabIndex = 20;
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(808, 36);
            this.txt_mk.MaxLength = 10;
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(172, 24);
            this.txt_mk.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(733, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mật khẩu";
            // 
            // txt_tentk
            // 
            this.txt_tentk.Location = new System.Drawing.Point(555, 36);
            this.txt_tentk.MaxLength = 10;
            this.txt_tentk.Name = "txt_tentk";
            this.txt_tentk.Size = new System.Drawing.Size(172, 24);
            this.txt_tentk.TabIndex = 2;
            // 
            // txt_quyen
            // 
            this.txt_quyen.Location = new System.Drawing.Point(277, 35);
            this.txt_quyen.MaxLength = 10;
            this.txt_quyen.Name = "txt_quyen";
            this.txt_quyen.Size = new System.Drawing.Size(154, 24);
            this.txt_quyen.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quyền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã tài khoản";
            // 
            // txt_matk
            // 
            this.txt_matk.Location = new System.Drawing.Point(105, 35);
            this.txt_matk.MaxLength = 10;
            this.txt_matk.Name = "txt_matk";
            this.txt_matk.Size = new System.Drawing.Size(102, 24);
            this.txt_matk.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(417, 142);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 63);
            this.btnSua.TabIndex = 52;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Location = new System.Drawing.Point(529, 142);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 63);
            this.btnLuu.TabIndex = 51;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoa.Location = new System.Drawing.Point(310, 142);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 63);
            this.btn_xoa.TabIndex = 54;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LavenderBlush;
            this.menuStrip1.BackgroundImage = global::Doan.Properties.Resources.download1;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.hủyToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1270, 29);
            this.menuStrip1.TabIndex = 53;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xóaToolStripMenuItem.Image = global::Doan.Properties.Resources._trash7;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sửaToolStripMenuItem.Image = global::Doan.Properties.Resources.configuration_1;
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // hủyToolStripMenuItem1
            // 
            this.hủyToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hủyToolStripMenuItem1.Image = global::Doan.Properties.Resources.fileclose1;
            this.hủyToolStripMenuItem1.Name = "hủyToolStripMenuItem1";
            this.hủyToolStripMenuItem1.Size = new System.Drawing.Size(66, 25);
            this.hủyToolStripMenuItem1.Text = "Hủy";
            // 
            // Form_taikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 412);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.grb_tk);
            this.Controls.Add(this.grb_THONGTINTK);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_taikhoan";
            this.Text = "Form_taikhoan";
            this.Load += new System.EventHandler(this.Form_taikhoan_Load);
            this.grb_tk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_tk)).EndInit();
            this.grb_THONGTINTK.ResumeLayout(false);
            this.grb_THONGTINTK.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox grb_tk;
        private System.Windows.Forms.DataGridView dtgv_tk;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATK;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUYEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSWORK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
        private System.Windows.Forms.GroupBox grb_THONGTINTK;
        private System.Windows.Forms.DateTimePicker dtp_ngaylap;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tentk;
        private System.Windows.Forms.TextBox txt_quyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_matk;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hủyToolStripMenuItem1;
        private System.Windows.Forms.Button btn_xoa;
    }
}