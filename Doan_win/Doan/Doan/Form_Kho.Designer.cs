namespace Doan
{
    partial class Form_Kho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Kho));
            this.btnHuy = new System.Windows.Forms.Button();
            this.grb_dssach = new System.Windows.Forms.GroupBox();
            this.dtgv_kho = new System.Windows.Forms.DataGridView();
            this.stt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAISH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_nk = new System.Windows.Forms.Button();
            this.grp_kho = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.cmb_tensach = new System.Windows.Forms.ComboBox();
            this.lbl_Ma = new System.Windows.Forms.Label();
            this.lbl_sl = new System.Windows.Forms.Label();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_cnk = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cnkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hủyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grb_dssach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_kho)).BeginInit();
            this.grp_kho.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHuy.Enabled = false;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(691, 139);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(104, 63);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // grb_dssach
            // 
            this.grb_dssach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_dssach.Controls.Add(this.dtgv_kho);
            this.grb_dssach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_dssach.Location = new System.Drawing.Point(12, 208);
            this.grb_dssach.Name = "grb_dssach";
            this.grb_dssach.Size = new System.Drawing.Size(916, 204);
            this.grb_dssach.TabIndex = 16;
            this.grb_dssach.TabStop = false;
            this.grb_dssach.Text = "Sach";
            // 
            // dtgv_kho
            // 
            this.dtgv_kho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_kho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_kho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_kho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt1,
            this.MASH,
            this.TENSH,
            this.TENLOAISH,
            this.NAMXB,
            this.KHO});
            this.dtgv_kho.Location = new System.Drawing.Point(10, 19);
            this.dtgv_kho.Name = "dtgv_kho";
            this.dtgv_kho.Size = new System.Drawing.Size(900, 185);
            this.dtgv_kho.TabIndex = 0;
            this.dtgv_kho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_kho_CellContentClick);
            this.dtgv_kho.SelectionChanged += new System.EventHandler(this.dtgv_kho_SelectionChanged);
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
            // TENLOAISH
            // 
            this.TENLOAISH.DataPropertyName = "TENLOAISH";
            this.TENLOAISH.HeaderText = "Thể loại";
            this.TENLOAISH.Name = "TENLOAISH";
            // 
            // NAMXB
            // 
            this.NAMXB.DataPropertyName = "NAMXB";
            this.NAMXB.HeaderText = "Năm xuất bản";
            this.NAMXB.Name = "NAMXB";
            // 
            // KHO
            // 
            this.KHO.DataPropertyName = "SOLUONG";
            this.KHO.HeaderText = "Số lượng";
            this.KHO.Name = "KHO";
            // 
            // btn_nk
            // 
            this.btn_nk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_nk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_nk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_nk.Location = new System.Drawing.Point(179, 139);
            this.btn_nk.Name = "btn_nk";
            this.btn_nk.Size = new System.Drawing.Size(104, 63);
            this.btn_nk.TabIndex = 19;
            this.btn_nk.Text = "Nhập kho";
            this.btn_nk.UseVisualStyleBackColor = false;
            this.btn_nk.Click += new System.EventHandler(this.btn_nk_Click);
            // 
            // grp_kho
            // 
            this.grp_kho.Controls.Add(this.label1);
            this.grp_kho.Controls.Add(this.txt_Ma);
            this.grp_kho.Controls.Add(this.cmb_tensach);
            this.grp_kho.Controls.Add(this.lbl_Ma);
            this.grp_kho.Controls.Add(this.lbl_sl);
            this.grp_kho.Controls.Add(this.txt_sl);
            this.grp_kho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grp_kho.Location = new System.Drawing.Point(4, 31);
            this.grp_kho.Name = "grp_kho";
            this.grp_kho.Size = new System.Drawing.Size(918, 92);
            this.grp_kho.TabIndex = 22;
            this.grp_kho.TabStop = false;
            this.grp_kho.Text = "Thông tin nhập kho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã sách";
            // 
            // txt_Ma
            // 
            this.txt_Ma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Ma.Enabled = false;
            this.txt_Ma.Location = new System.Drawing.Point(156, 32);
            this.txt_Ma.MaxLength = 50;
            this.txt_Ma.Multiline = true;
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(146, 24);
            this.txt_Ma.TabIndex = 0;
            // 
            // cmb_tensach
            // 
            this.cmb_tensach.FormattingEnabled = true;
            this.cmb_tensach.Location = new System.Drawing.Point(420, 35);
            this.cmb_tensach.Name = "cmb_tensach";
            this.cmb_tensach.Size = new System.Drawing.Size(187, 26);
            this.cmb_tensach.TabIndex = 1;
            // 
            // lbl_Ma
            // 
            this.lbl_Ma.AutoSize = true;
            this.lbl_Ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ma.Location = new System.Drawing.Point(325, 32);
            this.lbl_Ma.Name = "lbl_Ma";
            this.lbl_Ma.Size = new System.Drawing.Size(89, 24);
            this.lbl_Ma.TabIndex = 25;
            this.lbl_Ma.Text = "Tên sách";
            // 
            // lbl_sl
            // 
            this.lbl_sl.AutoSize = true;
            this.lbl_sl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sl.Location = new System.Drawing.Point(648, 34);
            this.lbl_sl.Name = "lbl_sl";
            this.lbl_sl.Size = new System.Drawing.Size(86, 24);
            this.lbl_sl.TabIndex = 23;
            this.lbl_sl.Text = "Số lượng";
            // 
            // txt_sl
            // 
            this.txt_sl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sl.Location = new System.Drawing.Point(740, 34);
            this.txt_sl.MaxLength = 50;
            this.txt_sl.Multiline = true;
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(112, 24);
            this.txt_sl.TabIndex = 2;
            this.txt_sl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sl_KeyPress);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(519, 139);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(104, 63);
            this.btn_xoa.TabIndex = 23;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_cnk
            // 
            this.btn_cnk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cnk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_cnk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cnk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cnk.Location = new System.Drawing.Point(351, 139);
            this.btn_cnk.Name = "btn_cnk";
            this.btn_cnk.Size = new System.Drawing.Size(104, 63);
            this.btn_cnk.TabIndex = 25;
            this.btn_cnk.Text = "Cập nhật kho";
            this.btn_cnk.UseVisualStyleBackColor = false;
            this.btn_cnk.Click += new System.EventHandler(this.btn_cnk_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LavenderBlush;
            this.menuStrip1.BackgroundImage = global::Doan.Properties.Resources.download1;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.cnkToolStripMenuItem,
            this.xoaToolStripMenuItem,
            this.hủyToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 29);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thêmToolStripMenuItem.Image = global::Doan.Properties.Resources._1;
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(106, 25);
            this.thêmToolStripMenuItem.Text = "Nhập kho";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // cnkToolStripMenuItem
            // 
            this.cnkToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnkToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cnkToolStripMenuItem.Image")));
            this.cnkToolStripMenuItem.Name = "cnkToolStripMenuItem";
            this.cnkToolStripMenuItem.Size = new System.Drawing.Size(134, 25);
            this.cnkToolStripMenuItem.Text = "Cập nhập kho";
            this.cnkToolStripMenuItem.Click += new System.EventHandler(this.cnkToolStripMenuItem_Click);
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xoaToolStripMenuItem.Image")));
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.xoaToolStripMenuItem.Text = "Xóa";
            this.xoaToolStripMenuItem.Click += new System.EventHandler(this.xoaToolStripMenuItem_Click);
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
            // Form_Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 424);
            this.Controls.Add(this.btn_cnk);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.grp_kho);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.grb_dssach);
            this.Controls.Add(this.btn_nk);
            this.Name = "Form_Kho";
            this.Text = "Form_Kho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Kho_FormClosing);
            this.Load += new System.EventHandler(this.Form_Kho_Load);
            this.grb_dssach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_kho)).EndInit();
            this.grp_kho.ResumeLayout(false);
            this.grp_kho.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox grb_dssach;
        private System.Windows.Forms.DataGridView dtgv_kho;
        private System.Windows.Forms.Button btn_nk;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAISH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn KHO;
        private System.Windows.Forms.GroupBox grp_kho;
        private System.Windows.Forms.ComboBox cmb_tensach;
        private System.Windows.Forms.Label lbl_Ma;
        private System.Windows.Forms.Label lbl_sl;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cnkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hủyToolStripMenuItem1;
        private System.Windows.Forms.Button btn_cnk;
    }
}