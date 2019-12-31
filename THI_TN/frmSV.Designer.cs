namespace THI_TN
{
    partial class frmSV
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
            this.mALOPLabel = new System.Windows.Forms.Label();
            this.tENLOPLabel = new System.Windows.Forms.Label();
            this.mAKHLabel1 = new System.Windows.Forms.Label();
            this.mASVLabel = new System.Windows.Forms.Label();
            this.hOLabel = new System.Windows.Forms.Label();
            this.tENLabel = new System.Windows.Forms.Label();
            this.nGAYSINHLabel = new System.Windows.Forms.Label();
            this.dIACHILabel = new System.Windows.Forms.Label();
            this.mALOPLabel1 = new System.Windows.Forms.Label();
            this.mACSLabel = new System.Windows.Forms.Label();
            this.tENLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
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
            this.btnDSNV = new DevExpress.XtraBars.BarButtonItem();
            this.dS = new THI_TN.DS();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new THI_TN.DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new THI_TN.DSTableAdapters.TableAdapterManager();
            this.lOPTableAdapter = new THI_TN.DSTableAdapters.LOPTableAdapter();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.gcLOP = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtMASV = new DevExpress.XtraEditors.TextEdit();
            this.cbbTEN = new System.Windows.Forms.ComboBox();
            this.bdsDS_SV = new System.Windows.Forms.BindingSource(this.components);
            this.bdsSINHVIEN = new System.Windows.Forms.BindingSource(this.components);
            this.txtML = new DevExpress.XtraEditors.TextEdit();
            this.txtTL = new DevExpress.XtraEditors.TextEdit();
            this.txtMK = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.sINHVIENDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sINHVIENTableAdapter = new THI_TN.DSTableAdapters.SINHVIENTableAdapter();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.txtMASV1 = new DevExpress.XtraEditors.TextEdit();
            this.txtHO = new DevExpress.XtraEditors.TextEdit();
            this.txtTEN = new DevExpress.XtraEditors.TextEdit();
            this.txtNS = new DevExpress.XtraEditors.DateEdit();
            this.txtDC = new DevExpress.XtraEditors.TextEdit();
            this.txtML1 = new DevExpress.XtraEditors.TextEdit();
            this.bdsCOSO = new System.Windows.Forms.BindingSource(this.components);
            this.cOSOTableAdapter = new THI_TN.DSTableAdapters.COSOTableAdapter();
            this.mACSComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dS_SVTableAdapter = new THI_TN.DSTableAdapters.DS_SVTableAdapter();
            this.contex = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnX = new System.Windows.Forms.ToolStripMenuItem();
            this.btnG = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDS_SV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSINHVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtML.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASV1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNS.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtML1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCOSO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACSComboBoxEdit.Properties)).BeginInit();
            this.contex.SuspendLayout();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            this.mALOPLabel.AutoSize = true;
            this.mALOPLabel.Location = new System.Drawing.Point(2, 8);
            this.mALOPLabel.Name = "mALOPLabel";
            this.mALOPLabel.Size = new System.Drawing.Size(45, 13);
            this.mALOPLabel.TabIndex = 0;
            this.mALOPLabel.Text = "MALOP:";
            // 
            // tENLOPLabel
            // 
            this.tENLOPLabel.AutoSize = true;
            this.tENLOPLabel.Location = new System.Drawing.Point(2, 34);
            this.tENLOPLabel.Name = "tENLOPLabel";
            this.tENLOPLabel.Size = new System.Drawing.Size(49, 13);
            this.tENLOPLabel.TabIndex = 2;
            this.tENLOPLabel.Text = "TENLOP:";
            // 
            // mAKHLabel1
            // 
            this.mAKHLabel1.AutoSize = true;
            this.mAKHLabel1.Location = new System.Drawing.Point(2, 60);
            this.mAKHLabel1.Name = "mAKHLabel1";
            this.mAKHLabel1.Size = new System.Drawing.Size(39, 13);
            this.mAKHLabel1.TabIndex = 4;
            this.mAKHLabel1.Text = "MAKH:";
            // 
            // mASVLabel
            // 
            this.mASVLabel.AutoSize = true;
            this.mASVLabel.Location = new System.Drawing.Point(5, 22);
            this.mASVLabel.Name = "mASVLabel";
            this.mASVLabel.Size = new System.Drawing.Size(38, 13);
            this.mASVLabel.TabIndex = 0;
            this.mASVLabel.Text = "MASV:";
            // 
            // hOLabel
            // 
            this.hOLabel.AutoSize = true;
            this.hOLabel.Location = new System.Drawing.Point(5, 48);
            this.hOLabel.Name = "hOLabel";
            this.hOLabel.Size = new System.Drawing.Size(26, 13);
            this.hOLabel.TabIndex = 2;
            this.hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            this.tENLabel.AutoSize = true;
            this.tENLabel.Location = new System.Drawing.Point(5, 74);
            this.tENLabel.Name = "tENLabel";
            this.tENLabel.Size = new System.Drawing.Size(30, 13);
            this.tENLabel.TabIndex = 4;
            this.tENLabel.Text = "TEN:";
            // 
            // nGAYSINHLabel
            // 
            this.nGAYSINHLabel.AutoSize = true;
            this.nGAYSINHLabel.Location = new System.Drawing.Point(5, 100);
            this.nGAYSINHLabel.Name = "nGAYSINHLabel";
            this.nGAYSINHLabel.Size = new System.Drawing.Size(62, 13);
            this.nGAYSINHLabel.TabIndex = 6;
            this.nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // dIACHILabel
            // 
            this.dIACHILabel.AutoSize = true;
            this.dIACHILabel.Location = new System.Drawing.Point(5, 126);
            this.dIACHILabel.Name = "dIACHILabel";
            this.dIACHILabel.Size = new System.Drawing.Size(47, 13);
            this.dIACHILabel.TabIndex = 8;
            this.dIACHILabel.Text = "DIACHI:";
            // 
            // mALOPLabel1
            // 
            this.mALOPLabel1.AutoSize = true;
            this.mALOPLabel1.Location = new System.Drawing.Point(5, 152);
            this.mALOPLabel1.Name = "mALOPLabel1";
            this.mALOPLabel1.Size = new System.Drawing.Size(45, 13);
            this.mALOPLabel1.TabIndex = 10;
            this.mALOPLabel1.Text = "MALOP:";
            // 
            // mACSLabel
            // 
            this.mACSLabel.AutoSize = true;
            this.mACSLabel.Location = new System.Drawing.Point(492, 26);
            this.mACSLabel.Name = "mACSLabel";
            this.mACSLabel.Size = new System.Drawing.Size(40, 13);
            this.mACSLabel.TabIndex = 14;
            this.mACSLabel.Text = "MACS:";
            // 
            // tENLabel1
            // 
            this.tENLabel1.AutoSize = true;
            this.tENLabel1.Location = new System.Drawing.Point(209, 7);
            this.tENLabel1.Name = "tENLabel1";
            this.tENLabel1.Size = new System.Drawing.Size(30, 13);
            this.tENLabel1.TabIndex = 9;
            this.tENLabel1.Text = "TEN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "MASV:";
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 9;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 10;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 11;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 12;
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 13;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 15;
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
            this.barDockControlTop.Size = new System.Drawing.Size(996, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 583);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(996, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 561);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(996, 22);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 561);
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
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.dS;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CTBTTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THI_TN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.dS;
            // 
            // gcLOP
            // 
            this.gcLOP.DataSource = this.bdsLOP;
            this.gcLOP.Location = new System.Drawing.Point(6, 42);
            this.gcLOP.MainView = this.gridView1;
            this.gcLOP.MenuManager = this.barManager1;
            this.gcLOP.Name = "gcLOP";
            this.gcLOP.Size = new System.Drawing.Size(978, 198);
            this.gcLOP.TabIndex = 11;
            this.gcLOP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH});
            this.gridView1.GridControl = this.gcLOP;
            this.gridView1.Name = "gridView1";
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txtMASV);
            this.panelControl1.Controls.Add(this.tENLabel1);
            this.panelControl1.Controls.Add(this.cbbTEN);
            this.panelControl1.Controls.Add(this.mALOPLabel);
            this.panelControl1.Controls.Add(this.txtML);
            this.panelControl1.Controls.Add(this.tENLOPLabel);
            this.panelControl1.Controls.Add(this.txtTL);
            this.panelControl1.Controls.Add(this.mAKHLabel1);
            this.panelControl1.Controls.Add(this.txtMK);
            this.panelControl1.Location = new System.Drawing.Point(13, 253);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(366, 117);
            this.panelControl1.TabIndex = 12;
            // 
            // txtMASV
            // 
            this.txtMASV.Location = new System.Drawing.Point(242, 31);
            this.txtMASV.Name = "txtMASV";
            this.txtMASV.Size = new System.Drawing.Size(121, 20);
            this.txtMASV.TabIndex = 11;
            // 
            // cbbTEN
            // 
            this.cbbTEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDS_SV, "TEN", true));
            this.cbbTEN.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsSINHVIEN, "MASV", true));
            this.cbbTEN.DataSource = this.bdsDS_SV;
            this.cbbTEN.DisplayMember = "TEN";
            this.cbbTEN.FormattingEnabled = true;
            this.cbbTEN.Location = new System.Drawing.Point(242, 4);
            this.cbbTEN.Name = "cbbTEN";
            this.cbbTEN.Size = new System.Drawing.Size(121, 21);
            this.cbbTEN.TabIndex = 10;
            this.cbbTEN.ValueMember = "MASV";
            this.cbbTEN.SelectedIndexChanged += new System.EventHandler(this.tENComboBox_SelectedIndexChanged);
            // 
            // bdsDS_SV
            // 
            this.bdsDS_SV.DataMember = "DS_SV";
            this.bdsDS_SV.DataSource = this.dS;
            // 
            // bdsSINHVIEN
            // 
            this.bdsSINHVIEN.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSINHVIEN.DataSource = this.bdsLOP;
            // 
            // txtML
            // 
            this.txtML.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "MALOP", true));
            this.txtML.Location = new System.Drawing.Point(73, 1);
            this.txtML.MenuManager = this.barManager1;
            this.txtML.Name = "txtML";
            this.txtML.Size = new System.Drawing.Size(100, 20);
            this.txtML.TabIndex = 1;
            // 
            // txtTL
            // 
            this.txtTL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "TENLOP", true));
            this.txtTL.Location = new System.Drawing.Point(73, 27);
            this.txtTL.MenuManager = this.barManager1;
            this.txtTL.Name = "txtTL";
            this.txtTL.Size = new System.Drawing.Size(100, 20);
            this.txtTL.TabIndex = 3;
            // 
            // txtMK
            // 
            this.txtMK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "MAKH", true));
            this.txtMK.Location = new System.Drawing.Point(73, 57);
            this.txtMK.MenuManager = this.barManager1;
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(100, 20);
            this.txtMK.TabIndex = 5;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.sINHVIENDataGridView);
            this.panelControl2.Location = new System.Drawing.Point(385, 253);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(599, 314);
            this.panelControl2.TabIndex = 13;
            // 
            // sINHVIENDataGridView
            // 
            this.sINHVIENDataGridView.AutoGenerateColumns = false;
            this.sINHVIENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sINHVIENDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.sINHVIENDataGridView.DataSource = this.bdsSINHVIEN;
            this.sINHVIENDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sINHVIENDataGridView.Location = new System.Drawing.Point(2, 2);
            this.sINHVIENDataGridView.Name = "sINHVIENDataGridView";
            this.sINHVIENDataGridView.Size = new System.Drawing.Size(595, 310);
            this.sINHVIENDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MASV";
            this.dataGridViewTextBoxColumn1.HeaderText = "MASV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HO";
            this.dataGridViewTextBoxColumn2.HeaderText = "HO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TEN";
            this.dataGridViewTextBoxColumn3.HeaderText = "TEN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NGAYSINH";
            this.dataGridViewTextBoxColumn4.HeaderText = "NGAYSINH";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn5.HeaderText = "DIACHI";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MALOP";
            this.dataGridViewTextBoxColumn6.HeaderText = "MALOP";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.mASVLabel);
            this.panelControl3.Controls.Add(this.txtMASV1);
            this.panelControl3.Controls.Add(this.hOLabel);
            this.panelControl3.Controls.Add(this.txtHO);
            this.panelControl3.Controls.Add(this.tENLabel);
            this.panelControl3.Controls.Add(this.txtTEN);
            this.panelControl3.Controls.Add(this.nGAYSINHLabel);
            this.panelControl3.Controls.Add(this.txtNS);
            this.panelControl3.Controls.Add(this.dIACHILabel);
            this.panelControl3.Controls.Add(this.txtDC);
            this.panelControl3.Controls.Add(this.mALOPLabel1);
            this.panelControl3.Controls.Add(this.txtML1);
            this.panelControl3.Location = new System.Drawing.Point(13, 376);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(366, 185);
            this.panelControl3.TabIndex = 14;
            // 
            // txtMASV1
            // 
            this.txtMASV1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSINHVIEN, "MASV", true));
            this.txtMASV1.Location = new System.Drawing.Point(73, 19);
            this.txtMASV1.MenuManager = this.barManager1;
            this.txtMASV1.Name = "txtMASV1";
            this.txtMASV1.Size = new System.Drawing.Size(100, 20);
            this.txtMASV1.TabIndex = 1;
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSINHVIEN, "HO", true));
            this.txtHO.Location = new System.Drawing.Point(73, 45);
            this.txtHO.MenuManager = this.barManager1;
            this.txtHO.Name = "txtHO";
            this.txtHO.Size = new System.Drawing.Size(100, 20);
            this.txtHO.TabIndex = 3;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSINHVIEN, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(73, 71);
            this.txtTEN.MenuManager = this.barManager1;
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(100, 20);
            this.txtTEN.TabIndex = 5;
            // 
            // txtNS
            // 
            this.txtNS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSINHVIEN, "NGAYSINH", true));
            this.txtNS.EditValue = null;
            this.txtNS.Location = new System.Drawing.Point(73, 97);
            this.txtNS.MenuManager = this.barManager1;
            this.txtNS.Name = "txtNS";
            this.txtNS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNS.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNS.Size = new System.Drawing.Size(100, 20);
            this.txtNS.TabIndex = 7;
            // 
            // txtDC
            // 
            this.txtDC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSINHVIEN, "DIACHI", true));
            this.txtDC.Location = new System.Drawing.Point(73, 123);
            this.txtDC.MenuManager = this.barManager1;
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(100, 20);
            this.txtDC.TabIndex = 9;
            // 
            // txtML1
            // 
            this.txtML1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSINHVIEN, "MALOP", true));
            this.txtML1.Location = new System.Drawing.Point(73, 149);
            this.txtML1.MenuManager = this.barManager1;
            this.txtML1.Name = "txtML1";
            this.txtML1.Size = new System.Drawing.Size(100, 20);
            this.txtML1.TabIndex = 11;
            // 
            // bdsCOSO
            // 
            this.bdsCOSO.DataMember = "COSO";
            this.bdsCOSO.DataSource = this.dS;
            // 
            // cOSOTableAdapter
            // 
            this.cOSOTableAdapter.ClearBeforeFill = true;
            // 
            // mACSComboBoxEdit
            // 
            this.mACSComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCOSO, "MACS", true));
            this.mACSComboBoxEdit.Location = new System.Drawing.Point(538, 23);
            this.mACSComboBoxEdit.MenuManager = this.barManager1;
            this.mACSComboBoxEdit.Name = "mACSComboBoxEdit";
            this.mACSComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mACSComboBoxEdit.Size = new System.Drawing.Size(260, 20);
            this.mACSComboBoxEdit.TabIndex = 15;
            // 
            // dS_SVTableAdapter
            // 
            this.dS_SVTableAdapter.ClearBeforeFill = true;
            // 
            // contex
            // 
            this.contex.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnT,
            this.btnX,
            this.btnG});
            this.contex.Name = "contex";
            this.contex.Size = new System.Drawing.Size(105, 70);
            // 
            // btnT
            // 
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(104, 22);
            this.btnT.Text = "Thêm";
            this.btnT.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // btnX
            // 
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(104, 22);
            this.btnX.Text = "Xóa";
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnG
            // 
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(104, 22);
            this.btnG.Text = "Ghi";
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // frmSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 606);
            this.ContextMenuStrip = this.contex;
            this.Controls.Add(this.mACSLabel);
            this.Controls.Add(this.mACSComboBoxEdit);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcLOP);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmSV";
            this.Text = "frmSV";
            this.Load += new System.EventHandler(this.frmSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDS_SV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSINHVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtML.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASV1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNS.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtML1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCOSO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACSComboBoxEdit.Properties)).EndInit();
            this.contex.ResumeLayout(false);
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
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private DS dS;
        private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtML;
        private DevExpress.XtraEditors.TextEdit txtTL;
        private DevExpress.XtraEditors.TextEdit txtMK;
        private DevExpress.XtraGrid.GridControl gcLOP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private System.Windows.Forms.BindingSource bdsSINHVIEN;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.TextEdit txtMASV1;
        private DevExpress.XtraEditors.TextEdit txtHO;
        private DevExpress.XtraEditors.TextEdit txtTEN;
        private DevExpress.XtraEditors.DateEdit txtNS;
        private DevExpress.XtraEditors.TextEdit txtDC;
        private DevExpress.XtraEditors.TextEdit txtML1;
        private System.Windows.Forms.BindingSource bdsCOSO;
        private DSTableAdapters.COSOTableAdapter cOSOTableAdapter;
        private DevExpress.XtraEditors.ComboBoxEdit mACSComboBoxEdit;
        private System.Windows.Forms.BindingSource bdsDS_SV;
        private DSTableAdapters.DS_SVTableAdapter dS_SVTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtMASV;
        private System.Windows.Forms.ComboBox cbbTEN;
        private System.Windows.Forms.Label mALOPLabel;
        private System.Windows.Forms.Label tENLOPLabel;
        private System.Windows.Forms.Label mAKHLabel1;
        private System.Windows.Forms.Label mASVLabel;
        private System.Windows.Forms.Label hOLabel;
        private System.Windows.Forms.Label tENLabel;
        private System.Windows.Forms.Label nGAYSINHLabel;
        private System.Windows.Forms.Label dIACHILabel;
        private System.Windows.Forms.Label mALOPLabel1;
        private System.Windows.Forms.Label mACSLabel;
        private System.Windows.Forms.Label tENLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contex;
        private System.Windows.Forms.ToolStripMenuItem btnT;
        private System.Windows.Forms.ToolStripMenuItem btnX;
        private System.Windows.Forms.ToolStripMenuItem btnG;
        private System.Windows.Forms.DataGridView sINHVIENDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}