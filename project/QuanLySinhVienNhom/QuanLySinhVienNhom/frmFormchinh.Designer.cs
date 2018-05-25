namespace QuanLySinhVienNhom
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.mnsFormchinh = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhVien_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemĐiểmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giangVien_Menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.xemLớpGiảngDạyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemLỊchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.input_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânCôngGiảngDạyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.mnsFormchinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsFormchinh
            // 
            this.mnsFormchinh.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsFormchinh.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsFormchinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.view_Menu,
            this.input_Menu});
            this.mnsFormchinh.Location = new System.Drawing.Point(0, 0);
            this.mnsFormchinh.Name = "mnsFormchinh";
            this.mnsFormchinh.Padding = new System.Windows.Forms.Padding(8, 5, 0, 2);
            this.mnsFormchinh.Size = new System.Drawing.Size(866, 34);
            this.mnsFormchinh.TabIndex = 0;
            this.mnsFormchinh.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.hOMEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hOMEToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hOMEToolStripMenuItem.Image")));
            this.hOMEToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(102, 27);
            this.hOMEToolStripMenuItem.Text = "Home";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngNhậpToolStripMenuItem.Image")));
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.ShortcutKeyDisplayString = "Crtl + L";
            this.đăngNhậpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(255, 28);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(255, 28);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // view_Menu
            // 
            this.view_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhVien_Menu_Item,
            this.giangVien_Menu_item});
            this.view_Menu.Image = ((System.Drawing.Image)(resources.GetObject("view_Menu.Image")));
            this.view_Menu.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.view_Menu.Name = "view_Menu";
            this.view_Menu.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.view_Menu.Size = new System.Drawing.Size(92, 27);
            this.view_Menu.Text = "View";
            // 
            // sinhVien_Menu_Item
            // 
            this.sinhVien_Menu_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhViênToolStripMenuItem,
            this.xemMônHọcToolStripMenuItem,
            this.xemĐiểmToolStripMenuItem1,
            this.đăngKýMônHọcToolStripMenuItem});
            this.sinhVien_Menu_Item.Image = ((System.Drawing.Image)(resources.GetObject("sinhVien_Menu_Item.Image")));
            this.sinhVien_Menu_Item.Name = "sinhVien_Menu_Item";
            this.sinhVien_Menu_Item.Size = new System.Drawing.Size(181, 28);
            this.sinhVien_Menu_Item.Text = "Sinh Viên";
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sinhViênToolStripMenuItem.Image")));
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(250, 28);
            this.sinhViênToolStripMenuItem.Text = "Thông Tin Cá Nhân";
            this.sinhViênToolStripMenuItem.Click += new System.EventHandler(this.sinhViênToolStripMenuItem_Click);
            // 
            // xemMônHọcToolStripMenuItem
            // 
            this.xemMônHọcToolStripMenuItem.Name = "xemMônHọcToolStripMenuItem";
            this.xemMônHọcToolStripMenuItem.Size = new System.Drawing.Size(250, 28);
            this.xemMônHọcToolStripMenuItem.Text = "Xem Môn Học";
            this.xemMônHọcToolStripMenuItem.Click += new System.EventHandler(this.xemMônHọcToolStripMenuItem_Click);
            // 
            // xemĐiểmToolStripMenuItem1
            // 
            this.xemĐiểmToolStripMenuItem1.Name = "xemĐiểmToolStripMenuItem1";
            this.xemĐiểmToolStripMenuItem1.Size = new System.Drawing.Size(250, 28);
            this.xemĐiểmToolStripMenuItem1.Text = "Xem Điểm";
            this.xemĐiểmToolStripMenuItem1.Click += new System.EventHandler(this.xemĐiểmToolStripMenuItem1_Click);
            // 
            // đăngKýMônHọcToolStripMenuItem
            // 
            this.đăngKýMônHọcToolStripMenuItem.Name = "đăngKýMônHọcToolStripMenuItem";
            this.đăngKýMônHọcToolStripMenuItem.Size = new System.Drawing.Size(250, 28);
            this.đăngKýMônHọcToolStripMenuItem.Text = "Đăng Ký Môn Học";
            this.đăngKýMônHọcToolStripMenuItem.Click += new System.EventHandler(this.đăngKýMônHọcToolStripMenuItem_Click);
            // 
            // giangVien_Menu_item
            // 
            this.giangVien_Menu_item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem2,
            this.xemLớpGiảngDạyToolStripMenuItem,
            this.xemLỊchToolStripMenuItem});
            this.giangVien_Menu_item.Image = ((System.Drawing.Image)(resources.GetObject("giangVien_Menu_item.Image")));
            this.giangVien_Menu_item.Name = "giangVien_Menu_item";
            this.giangVien_Menu_item.Size = new System.Drawing.Size(181, 28);
            this.giangVien_Menu_item.Text = "Giảng Viên";
            // 
            // thôngTinCáNhânToolStripMenuItem2
            // 
            this.thôngTinCáNhânToolStripMenuItem2.Name = "thôngTinCáNhânToolStripMenuItem2";
            this.thôngTinCáNhânToolStripMenuItem2.Size = new System.Drawing.Size(252, 28);
            this.thôngTinCáNhânToolStripMenuItem2.Text = "Thông Tin Cá Nhân";
            this.thôngTinCáNhânToolStripMenuItem2.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem2_Click);
            // 
            // xemLớpGiảngDạyToolStripMenuItem
            // 
            this.xemLớpGiảngDạyToolStripMenuItem.Name = "xemLớpGiảngDạyToolStripMenuItem";
            this.xemLớpGiảngDạyToolStripMenuItem.Size = new System.Drawing.Size(252, 28);
            this.xemLớpGiảngDạyToolStripMenuItem.Text = "Xem Lớp Giảng Dạy";
            // 
            // xemLỊchToolStripMenuItem
            // 
            this.xemLỊchToolStripMenuItem.Name = "xemLỊchToolStripMenuItem";
            this.xemLỊchToolStripMenuItem.Size = new System.Drawing.Size(252, 28);
            this.xemLỊchToolStripMenuItem.Text = "Xem Lịch ";
            // 
            // input_Menu
            // 
            this.input_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.nhậpKhoaToolStripMenuItem,
            this.phânCôngGiảngDạyToolStripMenuItem,
            this.nhậpLớpHọcToolStripMenuItem,
            this.nhậpĐiểmToolStripMenuItem});
            this.input_Menu.Image = global::QuanLySinhVienNhom.Properties.Resources.if_admin_87402;
            this.input_Menu.Name = "input_Menu";
            this.input_Menu.Padding = new System.Windows.Forms.Padding(4, 0, 15, 0);
            this.input_Menu.Size = new System.Drawing.Size(99, 27);
            this.input_Menu.Text = "Input";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(294, 28);
            this.accountToolStripMenuItem.Text = "Account ";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // nhậpKhoaToolStripMenuItem
            // 
            this.nhậpKhoaToolStripMenuItem.Name = "nhậpKhoaToolStripMenuItem";
            this.nhậpKhoaToolStripMenuItem.Size = new System.Drawing.Size(294, 28);
            this.nhậpKhoaToolStripMenuItem.Text = "Khoa / Ngành / Môn học";
            this.nhậpKhoaToolStripMenuItem.Click += new System.EventHandler(this.nhậpKhoaToolStripMenuItem_Click);
            // 
            // phânCôngGiảngDạyToolStripMenuItem
            // 
            this.phânCôngGiảngDạyToolStripMenuItem.Name = "phânCôngGiảngDạyToolStripMenuItem";
            this.phânCôngGiảngDạyToolStripMenuItem.Size = new System.Drawing.Size(294, 28);
            this.phânCôngGiảngDạyToolStripMenuItem.Text = "Phân Công Giảng Dạy";
            this.phânCôngGiảngDạyToolStripMenuItem.Click += new System.EventHandler(this.phânCôngGiảngDạyToolStripMenuItem_Click);
            // 
            // nhậpLớpHọcToolStripMenuItem
            // 
            this.nhậpLớpHọcToolStripMenuItem.Name = "nhậpLớpHọcToolStripMenuItem";
            this.nhậpLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(294, 28);
            this.nhậpLớpHọcToolStripMenuItem.Text = "Nhập Lớp Học ";
            this.nhậpLớpHọcToolStripMenuItem.Click += new System.EventHandler(this.nhậpLớpHọcToolStripMenuItem_Click);
            // 
            // nhậpĐiểmToolStripMenuItem
            // 
            this.nhậpĐiểmToolStripMenuItem.Name = "nhậpĐiểmToolStripMenuItem";
            this.nhậpĐiểmToolStripMenuItem.Size = new System.Drawing.Size(294, 28);
            this.nhậpĐiểmToolStripMenuItem.Text = "Điểm";
            this.nhậpĐiểmToolStripMenuItem.Click += new System.EventHandler(this.nhậpĐiểmToolStripMenuItem_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(766, 9);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(0, 17);
            this.lblDisplay.TabIndex = 2;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::QuanLySinhVienNhom.Properties.Resources.books_BKG_cropped1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 369);
            this.ControlBox = false;
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.mnsFormchinh);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsFormchinh;
            this.MinimizeBox = false;
            this.Name = "frmHome";
            this.Text = "     SCHOOL MANAGER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.mnsFormchinh.ResumeLayout(false);
            this.mnsFormchinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsFormchinh;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_Menu;
        private System.Windows.Forms.ToolStripMenuItem sinhVien_Menu_Item;
        private System.Windows.Forms.ToolStripMenuItem giangVien_Menu_item;
        private System.Windows.Forms.ToolStripMenuItem input_Menu;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemĐiểmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem xemLớpGiảngDạyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemLỊchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemMônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpLớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânCôngGiảngDạyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpKhoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýMônHọcToolStripMenuItem;
        private System.Windows.Forms.Label lblDisplay;
    }
}

