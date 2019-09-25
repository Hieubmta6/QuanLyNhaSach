namespace Doan
{
    partial class Form_Kho2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Kho2));
            this.dtgv_kho = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_suasl = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_luusl = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoasl = new System.Windows.Forms.Button();
            this.btn_themsl = new System.Windows.Forms.Button();
            this.Tho = new System.Windows.Forms.GroupBox();
            this.cb_TenSH = new System.Windows.Forms.ComboBox();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cnkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hủyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_kho)).BeginInit();
            this.Tho.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_kho
            // 
            this.dtgv_kho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_kho.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv_kho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_kho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.MASH,
            this.TENSH,
            this.SOLUONG});
            this.dtgv_kho.Location = new System.Drawing.Point(43, 228);
            this.dtgv_kho.Name = "dtgv_kho";
            this.dtgv_kho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_kho.Size = new System.Drawing.Size(679, 223);
            this.dtgv_kho.TabIndex = 2;
            this.dtgv_kho.SelectionChanged += new System.EventHandler(this.dtgv_kho_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // MASH
            // 
            this.MASH.DataPropertyName = "MASH";
            this.MASH.HeaderText = "Mã sách";
            this.MASH.Name = "MASH";
            this.MASH.Visible = false;
            // 
            // TENSH
            // 
            this.TENSH.DataPropertyName = "TENSH";
            this.TENSH.HeaderText = "Tên sách";
            this.TENSH.Name = "TENSH";
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.Name = "SOLUONG";
            // 
            // btn_suasl
            // 
            this.btn_suasl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_suasl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_suasl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_suasl.Location = new System.Drawing.Point(282, 155);
            this.btn_suasl.Name = "btn_suasl";
            this.btn_suasl.Size = new System.Drawing.Size(75, 54);
            this.btn_suasl.TabIndex = 82;
            this.btn_suasl.Text = "Sửa";
            this.btn_suasl.UseVisualStyleBackColor = false;
            this.btn_suasl.Click += new System.EventHandler(this.btn_suasl_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Clear.Location = new System.Drawing.Point(415, 155);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 54);
            this.btn_Clear.TabIndex = 83;
            this.btn_Clear.Text = "Làm mới";
            this.btn_Clear.UseVisualStyleBackColor = false;
            // 
            // btn_luusl
            // 
            this.btn_luusl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_luusl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_luusl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_luusl.Location = new System.Drawing.Point(541, 155);
            this.btn_luusl.Name = "btn_luusl";
            this.btn_luusl.Size = new System.Drawing.Size(75, 54);
            this.btn_luusl.TabIndex = 80;
            this.btn_luusl.Text = "Lưu";
            this.btn_luusl.UseVisualStyleBackColor = false;
            this.btn_luusl.Click += new System.EventHandler(this.btn_luusl_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thoat.Location = new System.Drawing.Point(647, 155);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 54);
            this.btn_thoat.TabIndex = 81;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoasl
            // 
            this.btn_xoasl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_xoasl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_xoasl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoasl.Location = new System.Drawing.Point(160, 155);
            this.btn_xoasl.Name = "btn_xoasl";
            this.btn_xoasl.Size = new System.Drawing.Size(75, 54);
            this.btn_xoasl.TabIndex = 84;
            this.btn_xoasl.Text = "Xóa";
            this.btn_xoasl.UseVisualStyleBackColor = false;
            this.btn_xoasl.Click += new System.EventHandler(this.btn_xoasl_Click);
            // 
            // btn_themsl
            // 
            this.btn_themsl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_themsl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_themsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_themsl.Location = new System.Drawing.Point(39, 155);
            this.btn_themsl.Name = "btn_themsl";
            this.btn_themsl.Size = new System.Drawing.Size(75, 54);
            this.btn_themsl.TabIndex = 85;
            this.btn_themsl.Text = "Thêm";
            this.btn_themsl.UseVisualStyleBackColor = false;
            this.btn_themsl.Click += new System.EventHandler(this.btn_themsl_Click);
            // 
            // Tho
            // 
            this.Tho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tho.Controls.Add(this.cb_TenSH);
            this.Tho.Controls.Add(this.txt_soLuong);
            this.Tho.Controls.Add(this.label2);
            this.Tho.Controls.Add(this.label1);
            this.Tho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tho.Location = new System.Drawing.Point(38, 33);
            this.Tho.Name = "Tho";
            this.Tho.Size = new System.Drawing.Size(679, 97);
            this.Tho.TabIndex = 86;
            this.Tho.TabStop = false;
            this.Tho.Text = "Thông tin kho";
            // 
            // cb_TenSH
            // 
            this.cb_TenSH.FormattingEnabled = true;
            this.cb_TenSH.Location = new System.Drawing.Point(170, 40);
            this.cb_TenSH.Name = "cb_TenSH";
            this.cb_TenSH.Size = new System.Drawing.Size(121, 28);
            this.cb_TenSH.TabIndex = 8;
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Location = new System.Drawing.Point(500, 41);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(100, 26);
            this.txt_soLuong.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số lượng";
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
            this.menuStrip1.Size = new System.Drawing.Size(780, 29);
            this.menuStrip1.TabIndex = 87;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thêmToolStripMenuItem.Image = global::Doan.Properties.Resources._1;
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(106, 25);
            this.thêmToolStripMenuItem.Text = "Nhập kho";
            // 
            // cnkToolStripMenuItem
            // 
            this.cnkToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnkToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cnkToolStripMenuItem.Image")));
            this.cnkToolStripMenuItem.Name = "cnkToolStripMenuItem";
            this.cnkToolStripMenuItem.Size = new System.Drawing.Size(134, 25);
            this.cnkToolStripMenuItem.Text = "Cập nhập kho";
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xoaToolStripMenuItem.Image")));
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.xoaToolStripMenuItem.Text = "Xóa";
            // 
            // hủyToolStripMenuItem1
            // 
            this.hủyToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hủyToolStripMenuItem1.Image = global::Doan.Properties.Resources.fileclose1;
            this.hủyToolStripMenuItem1.Name = "hủyToolStripMenuItem1";
            this.hủyToolStripMenuItem1.Size = new System.Drawing.Size(66, 25);
            this.hủyToolStripMenuItem1.Text = "Hủy";
            // 
            // Form_Kho2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 487);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Tho);
            this.Controls.Add(this.btn_suasl);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_luusl);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoasl);
            this.Controls.Add(this.btn_themsl);
            this.Controls.Add(this.dtgv_kho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Kho2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Kho2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Kho2_FormClosing);
            this.Load += new System.EventHandler(this.Form_Kho2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_kho)).EndInit();
            this.Tho.ResumeLayout(false);
            this.Tho.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_kho;
        private System.Windows.Forms.Button btn_suasl;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_luusl;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoasl;
        private System.Windows.Forms.Button btn_themsl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.GroupBox Tho;
        private System.Windows.Forms.ComboBox cb_TenSH;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cnkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hủyToolStripMenuItem1;
    }
}