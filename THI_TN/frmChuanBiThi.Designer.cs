﻿namespace THI_TN
{
    partial class frmChuanBiThi
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
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label sOCAUTHILabel;
            System.Windows.Forms.Label tHOIGIANLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuanBiThi));
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSNV = new DevExpress.XtraBars.BarButtonItem();
            this.dS = new THI_TN.DS();
            this.bdsGIAOVIEN_DANGKY = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new THI_TN.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new THI_TN.DSTableAdapters.TableAdapterManager();
            this.gcGIAOVIEN_DANGKY = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTD = new DevExpress.XtraEditors.TextEdit();
            this.txtL = new DevExpress.XtraEditors.SpinEdit();
            this.txtSCT = new DevExpress.XtraEditors.SpinEdit();
            this.txtTG = new DevExpress.XtraEditors.SpinEdit();
            this.bdsGETDSGV = new System.Windows.Forms.BindingSource(this.components);
            this.gETDSGVTableAdapter = new THI_TN.DSTableAdapters.GETDSGVTableAdapter();
            this.txtHT = new DevExpress.XtraEditors.TextEdit();
            this.bdsGETDSMH = new System.Windows.Forms.BindingSource(this.components);
            this.gETDSMHTableAdapter = new THI_TN.DSTableAdapters.GETDSMHTableAdapter();
            this.txtTMH = new DevExpress.XtraEditors.TextEdit();
            this.txtMMH = new System.Windows.Forms.ComboBox();
            this.txtMGV = new System.Windows.Forms.ComboBox();
            this.txtNgay = new System.Windows.Forms.DateTimePicker();
            this.dSLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSLOPTableAdapter = new THI_TN.DSTableAdapters.DSLOPTableAdapter();
            this.txtML = new System.Windows.Forms.ComboBox();
            this.txtTenLop = new System.Windows.Forms.ComboBox();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGIAOVIEN_DANGKY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGIAOVIEN_DANGKY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGETDSGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGETDSMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(24, 349);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(60, 13);
            tRINHDOLabel.TabIndex = 11;
            tRINHDOLabel.Text = "TRINHDO:";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Location = new System.Drawing.Point(24, 375);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(58, 13);
            nGAYTHILabel.TabIndex = 13;
            nGAYTHILabel.Text = "NGAYTHI:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(24, 401);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(31, 13);
            lANLabel.TabIndex = 15;
            lANLabel.Text = "LAN:";
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.Location = new System.Drawing.Point(24, 427);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(65, 13);
            sOCAUTHILabel.TabIndex = 17;
            sOCAUTHILabel.Text = "SOCAUTHI:";
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Location = new System.Drawing.Point(24, 453);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(62, 13);
            tHOIGIANLabel.TabIndex = 19;
            tHOIGIANLabel.Text = "THOIGIAN:";
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(232, 269);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(46, 13);
            hoTenLabel.TabIndex = 23;
            hoTenLabel.Text = "Ho Ten:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(229, 301);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(49, 13);
            tENMHLabel.TabIndex = 26;
            tENMHLabel.Text = "TENMH:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(24, 296);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(43, 13);
            mAMHLabel.TabIndex = 31;
            mAMHLabel.Text = "MAMH:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(30, 267);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(41, 13);
            mAGVLabel.TabIndex = 32;
            mAGVLabel.Text = "MAGV:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.btnThem,
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnRefresh,
            this.btnDSNV,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 16;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 8;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 10;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 13;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 15;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 514);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 490);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 490);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "barButtonItem8";
            this.barButtonItem8.Id = 7;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 9;
            this.btnSua.Name = "btnSua";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 11;
            this.btnXoa.Name = "btnXoa";
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 12;
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // btnDSNV
            // 
            this.btnDSNV.Caption = "Danh sách sinh viên";
            this.btnDSNV.Id = 14;
            this.btnDSNV.Name = "btnDSNV";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGIAOVIEN_DANGKY
            // 
            this.bdsGIAOVIEN_DANGKY.DataMember = "GIAOVIEN_DANGKY";
            this.bdsGIAOVIEN_DANGKY.DataSource = this.dS;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CTBTTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THI_TN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcGIAOVIEN_DANGKY
            // 
            this.gcGIAOVIEN_DANGKY.DataSource = this.bdsGIAOVIEN_DANGKY;
            this.gcGIAOVIEN_DANGKY.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcGIAOVIEN_DANGKY.Location = new System.Drawing.Point(0, 24);
            this.gcGIAOVIEN_DANGKY.MainView = this.gridView1;
            this.gcGIAOVIEN_DANGKY.MenuManager = this.barManager1;
            this.gcGIAOVIEN_DANGKY.Name = "gcGIAOVIEN_DANGKY";
            this.gcGIAOVIEN_DANGKY.Size = new System.Drawing.Size(800, 220);
            this.gcGIAOVIEN_DANGKY.TabIndex = 5;
            this.gcGIAOVIEN_DANGKY.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colMAMH,
            this.colMALOP,
            this.colTRINHDO,
            this.colNGAYTHI,
            this.colLAN,
            this.colSOCAUTHI,
            this.colTHOIGIAN});
            this.gridView1.GridControl = this.gcGIAOVIEN_DANGKY;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 2;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 3;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 4;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 5;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 6;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 7;
            // 
            // txtTD
            // 
            this.txtTD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGIAOVIEN_DANGKY, "TRINHDO", true));
            this.txtTD.Location = new System.Drawing.Point(95, 346);
            this.txtTD.MenuManager = this.barManager1;
            this.txtTD.Name = "txtTD";
            this.txtTD.Size = new System.Drawing.Size(121, 20);
            this.txtTD.TabIndex = 12;
            // 
            // txtL
            // 
            this.txtL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGIAOVIEN_DANGKY, "LAN", true));
            this.txtL.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtL.Location = new System.Drawing.Point(95, 398);
            this.txtL.MenuManager = this.barManager1;
            this.txtL.Name = "txtL";
            this.txtL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtL.Size = new System.Drawing.Size(121, 20);
            this.txtL.TabIndex = 16;
            // 
            // txtSCT
            // 
            this.txtSCT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGIAOVIEN_DANGKY, "SOCAUTHI", true));
            this.txtSCT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSCT.Location = new System.Drawing.Point(95, 424);
            this.txtSCT.MenuManager = this.barManager1;
            this.txtSCT.Name = "txtSCT";
            this.txtSCT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSCT.Size = new System.Drawing.Size(121, 20);
            this.txtSCT.TabIndex = 18;
            // 
            // txtTG
            // 
            this.txtTG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGIAOVIEN_DANGKY, "THOIGIAN", true));
            this.txtTG.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTG.Location = new System.Drawing.Point(95, 450);
            this.txtTG.MenuManager = this.barManager1;
            this.txtTG.Name = "txtTG";
            this.txtTG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTG.Size = new System.Drawing.Size(121, 20);
            this.txtTG.TabIndex = 20;
            // 
            // bdsGETDSGV
            // 
            this.bdsGETDSGV.DataMember = "GETDSGV";
            this.bdsGETDSGV.DataSource = this.dS;
            // 
            // gETDSGVTableAdapter
            // 
            this.gETDSGVTableAdapter.ClearBeforeFill = true;
            // 
            // txtHT
            // 
            this.txtHT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGETDSGV, "HoTen", true));
            this.txtHT.Location = new System.Drawing.Point(302, 266);
            this.txtHT.MenuManager = this.barManager1;
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(125, 20);
            this.txtHT.TabIndex = 24;
            // 
            // bdsGETDSMH
            // 
            this.bdsGETDSMH.DataMember = "GETDSMH";
            this.bdsGETDSMH.DataSource = this.dS;
            // 
            // gETDSMHTableAdapter
            // 
            this.gETDSMHTableAdapter.ClearBeforeFill = true;
            // 
            // txtTMH
            // 
            this.txtTMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGETDSMH, "TENMH", true));
            this.txtTMH.Location = new System.Drawing.Point(302, 298);
            this.txtTMH.MenuManager = this.barManager1;
            this.txtTMH.Name = "txtTMH";
            this.txtTMH.Size = new System.Drawing.Size(125, 20);
            this.txtTMH.TabIndex = 27;
            // 
            // txtMMH
            // 
            this.txtMMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGETDSMH, "MAMH", true));
            this.txtMMH.DataSource = this.bdsGETDSMH;
            this.txtMMH.DisplayMember = "MAMH";
            this.txtMMH.FormattingEnabled = true;
            this.txtMMH.Location = new System.Drawing.Point(95, 293);
            this.txtMMH.Name = "txtMMH";
            this.txtMMH.Size = new System.Drawing.Size(121, 21);
            this.txtMMH.TabIndex = 32;
            this.txtMMH.ValueMember = "TENMH";
            // 
            // txtMGV
            // 
            this.txtMGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGETDSGV, "MAGV", true));
            this.txtMGV.DataSource = this.bdsGETDSGV;
            this.txtMGV.DisplayMember = "MAGV";
            this.txtMGV.FormattingEnabled = true;
            this.txtMGV.Location = new System.Drawing.Point(95, 264);
            this.txtMGV.Name = "txtMGV";
            this.txtMGV.Size = new System.Drawing.Size(121, 21);
            this.txtMGV.TabIndex = 33;
            this.txtMGV.ValueMember = "HoTen";
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(95, 372);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(121, 20);
            this.txtNgay.TabIndex = 39;
            // 
            // dSLOPBindingSource
            // 
            this.dSLOPBindingSource.DataMember = "DSLOP";
            this.dSLOPBindingSource.DataSource = this.dS;
            // 
            // dSLOPTableAdapter
            // 
            this.dSLOPTableAdapter.ClearBeforeFill = true;
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(24, 323);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(47, 13);
            mALOPLabel.TabIndex = 48;
            mALOPLabel.Text = "MALOP:";
            // 
            // txtML
            // 
            this.txtML.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSLOPBindingSource, "MALOP", true));
            this.txtML.DataSource = this.dSLOPBindingSource;
            this.txtML.DisplayMember = "MALOP";
            this.txtML.FormattingEnabled = true;
            this.txtML.Location = new System.Drawing.Point(95, 320);
            this.txtML.Name = "txtML";
            this.txtML.Size = new System.Drawing.Size(121, 21);
            this.txtML.TabIndex = 49;
            this.txtML.ValueMember = "TENLOP";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(245, 328);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(53, 13);
            tENLOPLabel.TabIndex = 49;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dSLOPBindingSource, "TENLOP", true));
            this.txtTenLop.FormattingEnabled = true;
            this.txtTenLop.Location = new System.Drawing.Point(304, 325);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(121, 21);
            this.txtTenLop.TabIndex = 50;
            // 
            // frmChuanBiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.txtML);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(mAGVLabel);
            this.Controls.Add(this.txtMGV);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.txtMMH);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.txtTMH);
            this.Controls.Add(hoTenLabel);
            this.Controls.Add(this.txtHT);
            this.Controls.Add(tRINHDOLabel);
            this.Controls.Add(this.txtTD);
            this.Controls.Add(nGAYTHILabel);
            this.Controls.Add(lANLabel);
            this.Controls.Add(this.txtL);
            this.Controls.Add(sOCAUTHILabel);
            this.Controls.Add(this.txtSCT);
            this.Controls.Add(tHOIGIANLabel);
            this.Controls.Add(this.txtTG);
            this.Controls.Add(this.gcGIAOVIEN_DANGKY);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmChuanBiThi";
            this.Text = "frmChuanBiThi";
            this.Load += new System.EventHandler(this.frmChuanBiThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGIAOVIEN_DANGKY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGIAOVIEN_DANGKY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGETDSGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGETDSMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLOPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnDSNV;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private System.Windows.Forms.BindingSource bdsGIAOVIEN_DANGKY;
        private DS dS;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit txtTD;
        private DevExpress.XtraEditors.SpinEdit txtL;
        private DevExpress.XtraEditors.SpinEdit txtSCT;
        private DevExpress.XtraEditors.SpinEdit txtTG;
        private DevExpress.XtraGrid.GridControl gcGIAOVIEN_DANGKY;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bdsGETDSGV;
        private DSTableAdapters.GETDSGVTableAdapter gETDSGVTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtHT;
        private System.Windows.Forms.BindingSource bdsGETDSMH;
        private DSTableAdapters.GETDSMHTableAdapter gETDSMHTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtTMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private System.Windows.Forms.ComboBox txtMGV;
        private System.Windows.Forms.ComboBox txtMMH;
        private System.Windows.Forms.DateTimePicker txtNgay;
        private System.Windows.Forms.BindingSource dSLOPBindingSource;
        private DSTableAdapters.DSLOPTableAdapter dSLOPTableAdapter;
        private System.Windows.Forms.ComboBox txtTenLop;
        private System.Windows.Forms.ComboBox txtML;
    }
}