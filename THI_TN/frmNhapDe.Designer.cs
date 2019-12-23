namespace THI_TN
{
    partial class frmNhapDe
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
            System.Windows.Forms.Label cAUHOILabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nOIDUNGLabel;
            System.Windows.Forms.Label aLabel;
            System.Windows.Forms.Label bLabel;
            System.Windows.Forms.Label cLabel;
            System.Windows.Forms.Label dLabel;
            System.Windows.Forms.Label dAP_ANLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapDe));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDSMH = new DevExpress.XtraBars.BarButtonItem();
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
            this.dS = new THI_TN.DS();
            this.bdsBD = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new THI_TN.DSTableAdapters.BODETableAdapter();
            this.tableAdapterManager = new THI_TN.DSTableAdapters.TableAdapterManager();
            this.gcBD = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cAUHOISpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.mAMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tRINHDOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nOIDUNGTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.aTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dAP_ANTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mAGVComboBox = new System.Windows.Forms.ComboBox();
            cAUHOILabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nOIDUNGLabel = new System.Windows.Forms.Label();
            aLabel = new System.Windows.Forms.Label();
            bLabel = new System.Windows.Forms.Label();
            cLabel = new System.Windows.Forms.Label();
            dLabel = new System.Windows.Forms.Label();
            dAP_ANLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cAUHOISpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRINHDOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOIDUNGTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAP_ANTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cAUHOILabel
            // 
            cAUHOILabel.AutoSize = true;
            cAUHOILabel.Location = new System.Drawing.Point(52, 88);
            cAUHOILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cAUHOILabel.Name = "cAUHOILabel";
            cAUHOILabel.Size = new System.Drawing.Size(70, 17);
            cAUHOILabel.TabIndex = 0;
            cAUHOILabel.Text = "CAUHOI:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(52, 122);
            mAMHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(59, 17);
            mAMHLabel.TabIndex = 2;
            mAMHLabel.Text = "MAMH:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(52, 156);
            tRINHDOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(79, 17);
            tRINHDOLabel.TabIndex = 4;
            tRINHDOLabel.Text = "TRINHDO:";
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.Location = new System.Drawing.Point(52, 190);
            nOIDUNGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(81, 17);
            nOIDUNGLabel.TabIndex = 6;
            nOIDUNGLabel.Text = "NOIDUNG:";
            // 
            // aLabel
            // 
            aLabel.AutoSize = true;
            aLabel.Location = new System.Drawing.Point(52, 224);
            aLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            aLabel.Name = "aLabel";
            aLabel.Size = new System.Drawing.Size(22, 17);
            aLabel.TabIndex = 8;
            aLabel.Text = "A:";
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Location = new System.Drawing.Point(52, 258);
            bLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bLabel.Name = "bLabel";
            bLabel.Size = new System.Drawing.Size(21, 17);
            bLabel.TabIndex = 10;
            bLabel.Text = "B:";
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.Location = new System.Drawing.Point(52, 292);
            cLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cLabel.Name = "cLabel";
            cLabel.Size = new System.Drawing.Size(21, 17);
            cLabel.TabIndex = 12;
            cLabel.Text = "C:";
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.Location = new System.Drawing.Point(52, 326);
            dLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dLabel.Name = "dLabel";
            dLabel.Size = new System.Drawing.Size(22, 17);
            dLabel.TabIndex = 14;
            dLabel.Text = "D:";
            // 
            // dAP_ANLabel
            // 
            dAP_ANLabel.AutoSize = true;
            dAP_ANLabel.Location = new System.Drawing.Point(52, 360);
            dAP_ANLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dAP_ANLabel.Name = "dAP_ANLabel";
            dAP_ANLabel.Size = new System.Drawing.Size(66, 17);
            dAP_ANLabel.TabIndex = 16;
            dAP_ANLabel.Text = "DAP AN:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(52, 398);
            mAGVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(55, 17);
            mAGVLabel.TabIndex = 18;
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
            this.btnInDSMH,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInDSMH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 8;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 9;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 11;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 10;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 12;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 13;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.Name = "btnRefresh";
            // 
            // btnInDSMH
            // 
            this.btnInDSMH.Caption = "In danh sách môn học";
            this.btnInDSMH.Id = 14;
            this.btnInDSMH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInDSMH.ImageOptions.SvgImage")));
            this.btnInDSMH.Name = "btnInDSMH";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 15;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.barDockControlTop.Size = new System.Drawing.Size(1067, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 726);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.barDockControlBottom.Size = new System.Drawing.Size(1067, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 702);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1067, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 702);
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
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsBD
            // 
            this.bdsBD.DataMember = "BODE";
            this.bdsBD.DataSource = this.dS;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.bODETableAdapter;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CTBTTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THI_TN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcBD
            // 
            this.gcBD.DataSource = this.bdsBD;
            this.gcBD.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBD.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcBD.Location = new System.Drawing.Point(0, 24);
            this.gcBD.MainView = this.gridView1;
            this.gcBD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcBD.MenuManager = this.barManager1;
            this.gcBD.Name = "gcBD";
            this.gcBD.Size = new System.Drawing.Size(1067, 288);
            this.gcBD.TabIndex = 5;
            this.gcBD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCAUHOI,
            this.colMAMH,
            this.colTRINHDO,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAP_AN,
            this.colMAGV});
            this.gridView1.DetailHeight = 458;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.gcBD;
            this.gridView1.Name = "gridView1";
            // 
            // colCAUHOI
            // 
            this.colCAUHOI.Caption = "Câu hỏi";
            this.colCAUHOI.FieldName = "CAUHOI";
            this.colCAUHOI.MinWidth = 27;
            this.colCAUHOI.Name = "colCAUHOI";
            this.colCAUHOI.Visible = true;
            this.colCAUHOI.VisibleIndex = 0;
            this.colCAUHOI.Width = 100;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã câu hỏi";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 27;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            this.colMAMH.Width = 100;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.Caption = "Trình độ";
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 27;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 2;
            this.colTRINHDO.Width = 100;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.Caption = "Nội dung";
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.MinWidth = 27;
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 3;
            this.colNOIDUNG.Width = 100;
            // 
            // colA
            // 
            this.colA.Caption = "A";
            this.colA.FieldName = "A";
            this.colA.MinWidth = 27;
            this.colA.Name = "colA";
            this.colA.Visible = true;
            this.colA.VisibleIndex = 4;
            this.colA.Width = 100;
            // 
            // colB
            // 
            this.colB.Caption = "B";
            this.colB.FieldName = "B";
            this.colB.MinWidth = 27;
            this.colB.Name = "colB";
            this.colB.Visible = true;
            this.colB.VisibleIndex = 5;
            this.colB.Width = 100;
            // 
            // colC
            // 
            this.colC.Caption = "C";
            this.colC.FieldName = "C";
            this.colC.MinWidth = 27;
            this.colC.Name = "colC";
            this.colC.Visible = true;
            this.colC.VisibleIndex = 6;
            this.colC.Width = 100;
            // 
            // colD
            // 
            this.colD.Caption = "D";
            this.colD.FieldName = "D";
            this.colD.MinWidth = 27;
            this.colD.Name = "colD";
            this.colD.Visible = true;
            this.colD.VisibleIndex = 7;
            this.colD.Width = 100;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.Caption = "Đáp án";
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.MinWidth = 27;
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 8;
            this.colDAP_AN.Width = 100;
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "Mã GV";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 27;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 9;
            this.colMAGV.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(cAUHOILabel);
            this.groupBox1.Controls.Add(this.cAUHOISpinEdit);
            this.groupBox1.Controls.Add(mAMHLabel);
            this.groupBox1.Controls.Add(this.mAMHTextEdit);
            this.groupBox1.Controls.Add(tRINHDOLabel);
            this.groupBox1.Controls.Add(this.tRINHDOTextEdit);
            this.groupBox1.Controls.Add(nOIDUNGLabel);
            this.groupBox1.Controls.Add(this.nOIDUNGTextEdit);
            this.groupBox1.Controls.Add(aLabel);
            this.groupBox1.Controls.Add(this.aTextEdit);
            this.groupBox1.Controls.Add(bLabel);
            this.groupBox1.Controls.Add(this.bTextEdit);
            this.groupBox1.Controls.Add(cLabel);
            this.groupBox1.Controls.Add(this.cTextEdit);
            this.groupBox1.Controls.Add(dLabel);
            this.groupBox1.Controls.Add(this.dTextEdit);
            this.groupBox1.Controls.Add(dAP_ANLabel);
            this.groupBox1.Controls.Add(this.dAP_ANTextEdit);
            this.groupBox1.Controls.Add(mAGVLabel);
            this.groupBox1.Controls.Add(this.mAGVComboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 312);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1067, 414);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cAUHOISpinEdit
            // 
            this.cAUHOISpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBD, "CAUHOI", true));
            this.cAUHOISpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cAUHOISpinEdit.Location = new System.Drawing.Point(141, 84);
            this.cAUHOISpinEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cAUHOISpinEdit.MenuManager = this.barManager1;
            this.cAUHOISpinEdit.Name = "cAUHOISpinEdit";
            this.cAUHOISpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cAUHOISpinEdit.Size = new System.Drawing.Size(161, 20);
            this.cAUHOISpinEdit.TabIndex = 1;
            // 
            // mAMHTextEdit
            // 
            this.mAMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBD, "MAMH", true));
            this.mAMHTextEdit.Location = new System.Drawing.Point(141, 118);
            this.mAMHTextEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mAMHTextEdit.MenuManager = this.barManager1;
            this.mAMHTextEdit.Name = "mAMHTextEdit";
            this.mAMHTextEdit.Size = new System.Drawing.Size(161, 20);
            this.mAMHTextEdit.TabIndex = 3;
            // 
            // tRINHDOTextEdit
            // 
            this.tRINHDOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBD, "TRINHDO", true));
            this.tRINHDOTextEdit.Location = new System.Drawing.Point(141, 152);
            this.tRINHDOTextEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tRINHDOTextEdit.MenuManager = this.barManager1;
            this.tRINHDOTextEdit.Name = "tRINHDOTextEdit";
            this.tRINHDOTextEdit.Size = new System.Drawing.Size(161, 20);
            this.tRINHDOTextEdit.TabIndex = 5;
            // 
            // nOIDUNGTextEdit
            // 
            this.nOIDUNGTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBD, "NOIDUNG", true));
            this.nOIDUNGTextEdit.Location = new System.Drawing.Point(141, 186);
            this.nOIDUNGTextEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nOIDUNGTextEdit.MenuManager = this.barManager1;
            this.nOIDUNGTextEdit.Name = "nOIDUNGTextEdit";
            this.nOIDUNGTextEdit.Size = new System.Drawing.Size(161, 20);
            this.nOIDUNGTextEdit.TabIndex = 7;
            // 
            // aTextEdit
            // 
            this.aTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBD, "A", true));
            this.aTextEdit.Location = new System.Drawing.Point(141, 220);
            this.aTextEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aTextEdit.MenuManager = this.barManager1;
            this.aTextEdit.Name = "aTextEdit";
            this.aTextEdit.Size = new System.Drawing.Size(161, 20);
            this.aTextEdit.TabIndex = 9;
            // 
            // bTextEdit
            // 
            this.bTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBD, "B", true));
            this.bTextEdit.Location = new System.Drawing.Point(141, 254);
            this.bTextEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bTextEdit.MenuManager = this.barManager1;
            this.bTextEdit.Name = "bTextEdit";
            this.bTextEdit.Size = new System.Drawing.Size(161, 20);
            this.bTextEdit.TabIndex = 11;
            // 
            // cTextEdit
            // 
            this.cTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBD, "C", true));
            this.cTextEdit.Location = new System.Drawing.Point(141, 288);
            this.cTextEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cTextEdit.MenuManager = this.barManager1;
            this.cTextEdit.Name = "cTextEdit";
            this.cTextEdit.Size = new System.Drawing.Size(161, 20);
            this.cTextEdit.TabIndex = 13;
            // 
            // dTextEdit
            // 
            this.dTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBD, "D", true));
            this.dTextEdit.Location = new System.Drawing.Point(141, 322);
            this.dTextEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dTextEdit.MenuManager = this.barManager1;
            this.dTextEdit.Name = "dTextEdit";
            this.dTextEdit.Size = new System.Drawing.Size(161, 20);
            this.dTextEdit.TabIndex = 15;
            // 
            // dAP_ANTextEdit
            // 
            this.dAP_ANTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBD, "DAP_AN", true));
            this.dAP_ANTextEdit.Location = new System.Drawing.Point(141, 356);
            this.dAP_ANTextEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dAP_ANTextEdit.MenuManager = this.barManager1;
            this.dAP_ANTextEdit.Name = "dAP_ANTextEdit";
            this.dAP_ANTextEdit.Size = new System.Drawing.Size(161, 20);
            this.dAP_ANTextEdit.TabIndex = 17;
            // 
            // mAGVComboBox
            // 
            this.mAGVComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBD, "MAGV", true));
            this.mAGVComboBox.FormattingEnabled = true;
            this.mAGVComboBox.Location = new System.Drawing.Point(141, 394);
            this.mAGVComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mAGVComboBox.Name = "mAGVComboBox";
            this.mAGVComboBox.Size = new System.Drawing.Size(160, 25);
            this.mAGVComboBox.TabIndex = 19;
            // 
            // frmNhapDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcBD);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNhapDe";
            this.Text = "frmNhapDe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhapDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cAUHOISpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRINHDOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOIDUNGTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAP_ANTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnInDSMH;
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
        private System.Windows.Forms.BindingSource bdsBD;
        private DS dS;
        private DSTableAdapters.BODETableAdapter bODETableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gcBD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraEditors.SpinEdit cAUHOISpinEdit;
        private DevExpress.XtraEditors.TextEdit mAMHTextEdit;
        private DevExpress.XtraEditors.TextEdit tRINHDOTextEdit;
        private DevExpress.XtraEditors.TextEdit nOIDUNGTextEdit;
        private DevExpress.XtraEditors.TextEdit aTextEdit;
        private DevExpress.XtraEditors.TextEdit bTextEdit;
        private DevExpress.XtraEditors.TextEdit cTextEdit;
        private DevExpress.XtraEditors.TextEdit dTextEdit;
        private DevExpress.XtraEditors.TextEdit dAP_ANTextEdit;
        private System.Windows.Forms.ComboBox mAGVComboBox;
    }
}