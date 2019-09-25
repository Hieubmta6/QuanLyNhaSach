namespace Doan
{
    partial class Form_Tacgia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Tacgia));
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grb_dssach = new System.Windows.Forms.GroupBox();
            this.dtgv_tacgia = new System.Windows.Forms.DataGridView();
            this.stt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.grb_tg = new System.Windows.Forms.GroupBox();
            this.lbl_matg = new System.Windows.Forms.Label();
            this.txt_Matg = new System.Windows.Forms.TextBox();
            this.lbl_tentg = new System.Windows.Forms.Label();
            this.txt_tentg = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hủyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grb_dssach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_tacgia)).BeginInit();
            this.grb_tg.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(234, 131);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(104, 63);
            this.btn_sua.TabIndex = 35;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(390, 131);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(104, 63);
            this.btn_xoa.TabIndex = 34;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHuy.Enabled = false;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(739, 131);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(104, 63);
            this.btnHuy.TabIndex = 32;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // grb_dssach
            // 
            this.grb_dssach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_dssach.Controls.Add(this.dtgv_tacgia);
            this.grb_dssach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_dssach.Location = new System.Drawing.Point(-2, 200);
            this.grb_dssach.Name = "grb_dssach";
            this.grb_dssach.Size = new System.Drawing.Size(918, 204);
            this.grb_dssach.TabIndex = 31;
            this.grb_dssach.TabStop = false;
            this.grb_dssach.Text = "Sach";
            // 
            // dtgv_tacgia
            // 
            this.dtgv_tacgia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_tacgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_tacgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_tacgia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt1,
            this.MATG,
            this.TENTG});
            this.dtgv_tacgia.Location = new System.Drawing.Point(10, 21);
            this.dtgv_tacgia.Name = "dtgv_tacgia";
            this.dtgv_tacgia.Size = new System.Drawing.Size(902, 185);
            this.dtgv_tacgia.TabIndex = 0;
            this.dtgv_tacgia.SelectionChanged += new System.EventHandler(this.dtgv_tacgia_SelectionChanged);
            // 
            // stt1
            // 
            this.stt1.FillWeight = 60F;
            this.stt1.HeaderText = "STT";
            this.stt1.Name = "stt1";
            // 
            // MATG
            // 
            this.MATG.DataPropertyName = "MATG";
            this.MATG.FillWeight = 150F;
            this.MATG.HeaderText = "Mã tác giả";
            this.MATG.Name = "MATG";
            // 
            // TENTG
            // 
            this.TENTG.DataPropertyName = "TENTG";
            this.TENTG.FillWeight = 200F;
            this.TENTG.HeaderText = "Tên tác giả";
            this.TENTG.Name = "TENTG";
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(62, 131);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(104, 63);
            this.btn_them.TabIndex = 33;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_luu.Enabled = false;
            this.btn_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(566, 131);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(104, 63);
            this.btn_luu.TabIndex = 36;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // grb_tg
            // 
            this.grb_tg.Controls.Add(this.lbl_matg);
            this.grb_tg.Controls.Add(this.txt_Matg);
            this.grb_tg.Controls.Add(this.lbl_tentg);
            this.grb_tg.Controls.Add(this.txt_tentg);
            this.grb_tg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_tg.Location = new System.Drawing.Point(8, 33);
            this.grb_tg.Name = "grb_tg";
            this.grb_tg.Size = new System.Drawing.Size(908, 92);
            this.grb_tg.TabIndex = 37;
            this.grb_tg.TabStop = false;
            this.grb_tg.Text = "Thông tin tác giả";
            // 
            // lbl_matg
            // 
            this.lbl_matg.AutoSize = true;
            this.lbl_matg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matg.Location = new System.Drawing.Point(50, 31);
            this.lbl_matg.Name = "lbl_matg";
            this.lbl_matg.Size = new System.Drawing.Size(95, 24);
            this.lbl_matg.TabIndex = 27;
            this.lbl_matg.Text = "Mã tác giả";
            // 
            // txt_Matg
            // 
            this.txt_Matg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Matg.Location = new System.Drawing.Point(157, 31);
            this.txt_Matg.Multiline = true;
            this.txt_Matg.Name = "txt_Matg";
            this.txt_Matg.Size = new System.Drawing.Size(247, 24);
            this.txt_Matg.TabIndex = 0;
            // 
            // lbl_tentg
            // 
            this.lbl_tentg.AutoSize = true;
            this.lbl_tentg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tentg.Location = new System.Drawing.Point(505, 31);
            this.lbl_tentg.Name = "lbl_tentg";
            this.lbl_tentg.Size = new System.Drawing.Size(103, 24);
            this.lbl_tentg.TabIndex = 25;
            this.lbl_tentg.Text = "Tên tác giả";
            // 
            // txt_tentg
            // 
            this.txt_tentg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tentg.Location = new System.Drawing.Point(614, 31);
            this.txt_tentg.Multiline = true;
            this.txt_tentg.Name = "txt_tentg";
            this.txt_tentg.Size = new System.Drawing.Size(221, 24);
            this.txt_tentg.TabIndex = 1;
            this.txt_tentg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tentg_KeyDown);
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
            this.hủyToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 29);
            this.menuStrip1.TabIndex = 38;
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
            this.xóaToolStripMenuItem.Image = global::Doan.Properties.Resources._trash6;
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
            // hủyToolStripMenuItem1
            // 
            this.hủyToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hủyToolStripMenuItem1.Image = global::Doan.Properties.Resources.fileclose1;
            this.hủyToolStripMenuItem1.Name = "hủyToolStripMenuItem1";
            this.hủyToolStripMenuItem1.Size = new System.Drawing.Size(66, 25);
            this.hủyToolStripMenuItem1.Text = "Hủy";
            this.hủyToolStripMenuItem1.Click += new System.EventHandler(this.hủyToolStripMenuItem1_Click);
            // 
            // Form_Tacgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 419);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grb_tg);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.grb_dssach);
            this.Controls.Add(this.btn_them);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Tacgia";
            this.Text = "Tác giả";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Tacgia_FormClosing);
            this.Load += new System.EventHandler(this.Form_Tacgia_Load);
            this.grb_dssach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_tacgia)).EndInit();
            this.grb_tg.ResumeLayout(false);
            this.grb_tg.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox grb_dssach;
        private System.Windows.Forms.DataGridView dtgv_tacgia;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTG;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.GroupBox grb_tg;
        private System.Windows.Forms.Label lbl_matg;
        private System.Windows.Forms.TextBox txt_Matg;
        private System.Windows.Forms.Label lbl_tentg;
        private System.Windows.Forms.TextBox txt_tentg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hủyToolStripMenuItem1;
    }
}