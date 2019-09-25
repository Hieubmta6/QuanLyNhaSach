namespace Doan
{
    partial class Form_main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnTrịHệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangxuatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnTrịHệThốngToolStripMenuItem,
            this.quảnLýNghiệpVụToolStripMenuItem,
            this.dangxuatToolStripMenuItem1,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnTrịHệThốngToolStripMenuItem
            // 
            this.quảnTrịHệThốngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnTrịHệThốngToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.quảnTrịHệThốngToolStripMenuItem.Image = global::Doan.Properties.Resources.person_4_128;
            this.quảnTrịHệThốngToolStripMenuItem.Name = "quảnTrịHệThốngToolStripMenuItem";
            this.quảnTrịHệThốngToolStripMenuItem.Size = new System.Drawing.Size(190, 29);
            this.quảnTrịHệThốngToolStripMenuItem.Text = "Quản trị hệ thống";
            this.quảnTrịHệThốngToolStripMenuItem.Click += new System.EventHandler(this.quảnTrịHệThốngToolStripMenuItem_Click);
            // 
            // quảnLýNghiệpVụToolStripMenuItem
            // 
            this.quảnLýNghiệpVụToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýNghiệpVụToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.quảnLýNghiệpVụToolStripMenuItem.Image = global::Doan.Properties.Resources.Business_graph_monitor_report_128;
            this.quảnLýNghiệpVụToolStripMenuItem.Name = "quảnLýNghiệpVụToolStripMenuItem";
            this.quảnLýNghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(194, 29);
            this.quảnLýNghiệpVụToolStripMenuItem.Text = "Quản lý nghiệp vụ";
            this.quảnLýNghiệpVụToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNghiệpVụToolStripMenuItem_Click);
            // 
            // dangxuatToolStripMenuItem1
            // 
            this.dangxuatToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangxuatToolStripMenuItem1.ForeColor = System.Drawing.Color.OrangeRed;
            this.dangxuatToolStripMenuItem1.Image = global::Doan.Properties.Resources.logout_128;
            this.dangxuatToolStripMenuItem1.Name = "dangxuatToolStripMenuItem1";
            this.dangxuatToolStripMenuItem1.Size = new System.Drawing.Size(126, 29);
            this.dangxuatToolStripMenuItem1.Text = "Đăng xuất";
            this.dangxuatToolStripMenuItem1.Click += new System.EventHandler(this.dangxuatToolStripMenuItem1_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trợGiúpToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.trợGiúpToolStripMenuItem.Image = global::Doan.Properties.Resources.Help1;
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Doan.Properties.Resources.Sach_go_trang_tri_7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 445);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_main";
            this.Text = "Form_main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnTrịHệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNghiệpVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangxuatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
    }
}