﻿namespace QLKTX
{
    partial class FormTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanvien1 = new qlktxserver.Nhanvien();
            this.hoadon1 = new qlktxserver.Hoadon();
            this.sinhvien1 = new qlktxserver.Sinhvien();
            this.danhsachphongo1 = new qlktxserver.Danhsachphongo();
            this.chat1 = new qlktxserver.chat();
            this.tkb1 = new qLKTX.Control_UI.TKB();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.805293F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.19471F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1116, 602);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1116, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(114, 36);
            this.toolStripButton1.Text = "Trang chủ";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(109, 36);
            this.toolStripButton3.Text = "Đăng ký";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(94, 36);
            this.toolStripButton4.Text = "Hỗ trợ";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.16942F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.83058F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 556F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1110, 556);
            this.tableLayoutPanel2.TabIndex = 3;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tkb1);
            this.panel1.Controls.Add(this.nhanvien1);
            this.panel1.Controls.Add(this.hoadon1);
            this.panel1.Controls.Add(this.sinhvien1);
            this.panel1.Controls.Add(this.danhsachphongo1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(304, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 550);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.chat1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.ForeColor = System.Drawing.Color.Red;
            this.tableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(295, 550);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.sinhViênToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.toolStripMenuItem3,
            this.trợGiupToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(141, 230);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.hệThốngToolStripMenuItem.Text = "Phòng Ở";
            this.hệThốngToolStripMenuItem.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click);
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.sinhViênToolStripMenuItem.Text = "Sinh Viên";
            this.sinhViênToolStripMenuItem.Click += new System.EventHandler(this.sinhViênToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItem3.Text = "Quản Lý Vật Tư";
            // 
            // trợGiupToolStripMenuItem
            // 
            this.trợGiupToolStripMenuItem.Name = "trợGiupToolStripMenuItem";
            this.trợGiupToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.trợGiupToolStripMenuItem.Text = "Thông Báo";
            this.trợGiupToolStripMenuItem.Click += new System.EventHandler(this.trợGiupToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItem4.Text = "Thuê Phòng";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(66, 22);
            this.toolStripMenuItem5.Text = "Thoát";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // nhanvien1
            // 
            this.nhanvien1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nhanvien1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nhanvien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanvien1.Location = new System.Drawing.Point(0, 0);
            this.nhanvien1.Name = "nhanvien1";
            this.nhanvien1.Size = new System.Drawing.Size(803, 550);
            this.nhanvien1.TabIndex = 3;
            // 
            // hoadon1
            // 
            this.hoadon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.hoadon1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hoadon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoadon1.Location = new System.Drawing.Point(0, 0);
            this.hoadon1.Name = "hoadon1";
            this.hoadon1.Size = new System.Drawing.Size(803, 550);
            this.hoadon1.TabIndex = 2;
            // 
            // sinhvien1
            // 
            this.sinhvien1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sinhvien1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sinhvien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sinhvien1.Location = new System.Drawing.Point(0, 0);
            this.sinhvien1.Name = "sinhvien1";
            this.sinhvien1.Size = new System.Drawing.Size(803, 550);
            this.sinhvien1.TabIndex = 1;
            // 
            // danhsachphongo1
            // 
            this.danhsachphongo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.danhsachphongo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.danhsachphongo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.danhsachphongo1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhsachphongo1.Location = new System.Drawing.Point(0, 0);
            this.danhsachphongo1.Name = "danhsachphongo1";
            this.danhsachphongo1.Size = new System.Drawing.Size(803, 550);
            this.danhsachphongo1.TabIndex = 0;
            this.danhsachphongo1.Load += new System.EventHandler(this.danhsachphongo1_Load);
            // 
            // chat1
            // 
            this.chat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chat1.Location = new System.Drawing.Point(3, 233);
            this.chat1.Name = "chat1";
            this.chat1.Size = new System.Drawing.Size(255, 314);
            this.chat1.TabIndex = 3;
            this.chat1.Load += new System.EventHandler(this.chat1_Load);
            // 
            // tkb1
            // 
            this.tkb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tkb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tkb1.Location = new System.Drawing.Point(0, 0);
            this.tkb1.Name = "tkb1";
            this.tkb1.Size = new System.Drawing.Size(803, 550);
            this.tkb1.TabIndex = 4;
            // 
            // FormTrangChu
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1116, 602);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTrangChu";
            this.Text = "QLKTX";
            this.Load += new System.EventHandler(this.FormTrangChu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCơBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmHồSơSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchTrườngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchLàmLạiThẻToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem thuêPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xếpPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chụpHìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchSửChuyểnPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuPhíNộiTrúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchThuBHYTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thiếtLậpHọcKìToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýVậtTưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýYTếToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuKhámBệnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private qlktxserver.chat chat1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem trợGiupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private qlktxserver.Nhanvien nhanvien1;
        private qlktxserver.Hoadon hoadon1;
        private qlktxserver.Sinhvien sinhvien1;
        private qlktxserver.Danhsachphongo danhsachphongo1;
        private qLKTX.Control_UI.TKB tkb1;
    }
}