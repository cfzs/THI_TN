namespace THI_TN
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnBoMon = new DevExpress.XtraBars.BarButtonItem();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiaoVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnHocVi = new DevExpress.XtraBars.BarButtonItem();
            this.btnChucVu = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.DanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ToChuc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.GiangVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.CapNhat = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.CauHinh = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.HeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnKhoa,
            this.btnBoMon,
            this.btnLop,
            this.btnMonHoc,
            this.btnGiaoVien,
            this.btnHocVi,
            this.btnChucVu,
            this.btnDangNhap,
            this.btnDangXuat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.CauHinh});
            this.ribbonControl1.Size = new System.Drawing.Size(1011, 143);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Caption = "Khoa";
            this.btnKhoa.Id = 2;
            this.btnKhoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKhoa.ImageOptions.SvgImage")));
            this.btnKhoa.Name = "btnKhoa";
            // 
            // btnBoMon
            // 
            this.btnBoMon.Caption = "Bộ môn";
            this.btnBoMon.Id = 4;
            this.btnBoMon.Name = "btnBoMon";
            // 
            // btnLop
            // 
            this.btnLop.Caption = "Lớp";
            this.btnLop.Id = 5;
            this.btnLop.Name = "btnLop";
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "Môn học";
            this.btnMonHoc.Id = 6;
            this.btnMonHoc.Name = "btnMonHoc";
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Caption = "Giáo viên";
            this.btnGiaoVien.Id = 7;
            this.btnGiaoVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGiangVien.ImageOptions.SvgImage")));
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiaoVien_ItemClick);
            // 
            // btnHocVi
            // 
            this.btnHocVi.Caption = "Học vị";
            this.btnHocVi.Id = 8;
            this.btnHocVi.Name = "btnHocVi";
            // 
            // btnChucVu
            // 
            this.btnChucVu.Caption = "Chức vụ";
            this.btnChucVu.Id = 9;
            this.btnChucVu.Name = "btnChucVu";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 11;
            this.btnDangNhap.Name = "btnDangNhap";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 12;
            this.btnDangXuat.Name = "btnDangXuat";
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.DanhMuc,
            this.CapNhat,
            this.BaoCao});
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // DanhMuc
            // 
            this.DanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ToChuc,
            this.GiangVien});
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.Text = "Danh mục";
            // 
            // ToChuc
            // 
            this.ToChuc.ItemLinks.Add(this.btnKhoa);
            this.ToChuc.ItemLinks.Add(this.btnBoMon);
            this.ToChuc.ItemLinks.Add(this.btnLop);
            this.ToChuc.ItemLinks.Add(this.btnMonHoc);
            this.ToChuc.Name = "ToChuc";
            this.ToChuc.Text = "Tổ chức";
            // 
            // GiangVien
            // 
            this.GiangVien.ItemLinks.Add(this.btnGiaoVien);
            this.GiangVien.ItemLinks.Add(this.btnHocVi);
            this.GiangVien.ItemLinks.Add(this.btnChucVu);
            this.GiangVien.Name = "GiangVien";
            this.GiangVien.Text = "Giảng viên";
            // 
            // CapNhat
            // 
            this.CapNhat.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.CapNhat.Name = "CapNhat";
            this.CapNhat.Text = "Cập nhật";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // BaoCao
            // 
            this.BaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.BaoCao.Name = "BaoCao";
            this.BaoCao.Text = "Báo cáo";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // CauHinh
            // 
            this.CauHinh.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.HeThong});
            this.CauHinh.Name = "CauHinh";
            this.CauHinh.Text = "Cấu hình";
            // 
            // HeThong
            // 
            this.HeThong.ItemLinks.Add(this.btnDangNhap);
            this.HeThong.ItemLinks.Add(this.btnDangXuat);
            this.HeThong.Name = "HeThong";
            this.HeThong.Text = "ribbonPageGroup1";
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 143);
            this.wizardControl1.Margin = new System.Windows.Forms.Padding(4);
            this.wizardControl1.MinimumSize = new System.Drawing.Size(133, 131);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.completionWizardPage1});
            this.wizardControl1.Size = new System.Drawing.Size(1011, 328);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.Margin = new System.Windows.Forms.Padding(4);
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(794, 195);
            // 
            // wizardPage1
            // 
            this.wizardPage1.Margin = new System.Windows.Forms.Padding(4);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(979, 183);
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Margin = new System.Windows.Forms.Padding(4);
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(794, 195);
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "ribbonPage4";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "ribbonPage6";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 471);
            this.Controls.Add(this.wizardControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage CauHinh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup HeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPage DanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ToChuc;
        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraBars.BarButtonItem btnKhoa;
        private DevExpress.XtraBars.BarButtonItem btnBoMon;
        private DevExpress.XtraBars.BarButtonItem btnLop;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup GiangVien;
        private DevExpress.XtraBars.Ribbon.RibbonPage CapNhat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage BaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.BarButtonItem btnGiaoVien;
        private DevExpress.XtraBars.BarButtonItem btnHocVi;
        private DevExpress.XtraBars.BarButtonItem btnChucVu;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

