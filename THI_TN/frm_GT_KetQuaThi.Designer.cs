namespace THI_TN
{
    partial class frm_GT_KetQuaThi
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            this.dS = new THI_TN.DS();
            this.gIAOVIEN_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new THI_TN.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new THI_TN.DSTableAdapters.TableAdapterManager();
            this.txtML = new System.Windows.Forms.ComboBox();
            this.gETDSMHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gETDSMHTableAdapter = new THI_TN.DSTableAdapters.GETDSMHTableAdapter();
            this.tENMHComboBox = new System.Windows.Forms.ComboBox();
            this.txtMMH = new DevExpress.XtraEditors.TextEdit();
            this.dS_SVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_SVTableAdapter = new THI_TN.DSTableAdapters.DS_SVTableAdapter();
            this.tENComboBox = new System.Windows.Forms.ComboBox();
            this.txtMSV = new DevExpress.XtraEditors.TextEdit();
            this.txtTD = new System.Windows.Forms.ComboBox();
            this.btnXULY = new System.Windows.Forms.Button();
            mALOPLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETDSMHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIAOVIEN_DANGKYBindingSource
            // 
            this.gIAOVIEN_DANGKYBindingSource.DataMember = "GIAOVIEN_DANGKY";
            this.gIAOVIEN_DANGKYBindingSource.DataSource = this.dS;
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
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(2, 58);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(47, 13);
            mALOPLabel.TabIndex = 1;
            mALOPLabel.Text = "MALOP:";
            // 
            // txtML
            // 
            this.txtML.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIEN_DANGKYBindingSource, "MALOP", true));
            this.txtML.DataSource = this.gIAOVIEN_DANGKYBindingSource;
            this.txtML.DisplayMember = "MALOP";
            this.txtML.FormattingEnabled = true;
            this.txtML.Location = new System.Drawing.Point(69, 55);
            this.txtML.Name = "txtML";
            this.txtML.Size = new System.Drawing.Size(121, 21);
            this.txtML.TabIndex = 2;
            this.txtML.ValueMember = "MALOP";
            // 
            // gETDSMHBindingSource
            // 
            this.gETDSMHBindingSource.DataMember = "GETDSMH";
            this.gETDSMHBindingSource.DataSource = this.dS;
            // 
            // gETDSMHTableAdapter
            // 
            this.gETDSMHTableAdapter.ClearBeforeFill = true;
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(0, 101);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(49, 13);
            tENMHLabel.TabIndex = 3;
            tENMHLabel.Text = "TENMH:";
            // 
            // tENMHComboBox
            // 
            this.tENMHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gETDSMHBindingSource, "TENMH", true));
            this.tENMHComboBox.DataSource = this.gETDSMHBindingSource;
            this.tENMHComboBox.DisplayMember = "TENMH";
            this.tENMHComboBox.FormattingEnabled = true;
            this.tENMHComboBox.Location = new System.Drawing.Point(69, 93);
            this.tENMHComboBox.Name = "tENMHComboBox";
            this.tENMHComboBox.Size = new System.Drawing.Size(121, 21);
            this.tENMHComboBox.TabIndex = 4;
            this.tENMHComboBox.ValueMember = "MAMH";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(212, 102);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(43, 13);
            mAMHLabel.TabIndex = 5;
            mAMHLabel.Text = "MAMH:";
            // 
            // txtMMH
            // 
            this.txtMMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gETDSMHBindingSource, "MAMH", true));
            this.txtMMH.Location = new System.Drawing.Point(261, 99);
            this.txtMMH.Name = "txtMMH";
            this.txtMMH.Size = new System.Drawing.Size(100, 20);
            this.txtMMH.TabIndex = 6;
            // 
            // dS_SVBindingSource
            // 
            this.dS_SVBindingSource.DataMember = "DS_SV";
            this.dS_SVBindingSource.DataSource = this.dS;
            // 
            // dS_SVTableAdapter
            // 
            this.dS_SVTableAdapter.ClearBeforeFill = true;
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(2, 147);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(32, 13);
            tENLabel.TabIndex = 6;
            tENLabel.Text = "TEN:";
            // 
            // tENComboBox
            // 
            this.tENComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dS_SVBindingSource, "TEN", true));
            this.tENComboBox.DataSource = this.dS_SVBindingSource;
            this.tENComboBox.DisplayMember = "TEN";
            this.tENComboBox.FormattingEnabled = true;
            this.tENComboBox.Location = new System.Drawing.Point(69, 138);
            this.tENComboBox.Name = "tENComboBox";
            this.tENComboBox.Size = new System.Drawing.Size(121, 21);
            this.tENComboBox.TabIndex = 7;
            this.tENComboBox.ValueMember = "MASV";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(212, 142);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(40, 13);
            mASVLabel.TabIndex = 8;
            mASVLabel.Text = "MASV:";
            // 
            // txtMSV
            // 
            this.txtMSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dS_SVBindingSource, "MASV", true));
            this.txtMSV.Location = new System.Drawing.Point(258, 139);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(100, 20);
            this.txtMSV.TabIndex = 9;
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(3, 186);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(60, 13);
            tRINHDOLabel.TabIndex = 10;
            tRINHDOLabel.Text = "TRINHDO:";
            // 
            // txtTD
            // 
            this.txtTD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIEN_DANGKYBindingSource, "TRINHDO", true));
            this.txtTD.DataSource = this.gIAOVIEN_DANGKYBindingSource;
            this.txtTD.DisplayMember = "TRINHDO";
            this.txtTD.FormattingEnabled = true;
            this.txtTD.Location = new System.Drawing.Point(69, 183);
            this.txtTD.Name = "txtTD";
            this.txtTD.Size = new System.Drawing.Size(121, 21);
            this.txtTD.TabIndex = 11;
            this.txtTD.ValueMember = "TRINHDO";
            // 
            // btnXULY
            // 
            this.btnXULY.Location = new System.Drawing.Point(69, 250);
            this.btnXULY.Name = "btnXULY";
            this.btnXULY.Size = new System.Drawing.Size(183, 23);
            this.btnXULY.TabIndex = 12;
            this.btnXULY.Text = "Xem kết quả";
            this.btnXULY.UseVisualStyleBackColor = true;
            this.btnXULY.Click += new System.EventHandler(this.btnXULY_Click);
            // 
            // frm_GT_KetQuaThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXULY);
            this.Controls.Add(tRINHDOLabel);
            this.Controls.Add(this.txtTD);
            this.Controls.Add(mASVLabel);
            this.Controls.Add(this.txtMSV);
            this.Controls.Add(tENLabel);
            this.Controls.Add(this.tENComboBox);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.txtMMH);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.tENMHComboBox);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.txtML);
            this.Name = "frm_GT_KetQuaThi";
            this.Text = "frm_GT_KetQuaThi";
            this.Load += new System.EventHandler(this.frm_GT_KetQuaThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gETDSMHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource gIAOVIEN_DANGKYBindingSource;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox txtML;
        private System.Windows.Forms.BindingSource gETDSMHBindingSource;
        private DSTableAdapters.GETDSMHTableAdapter gETDSMHTableAdapter;
        private System.Windows.Forms.ComboBox tENMHComboBox;
        private DevExpress.XtraEditors.TextEdit txtMMH;
        private System.Windows.Forms.BindingSource dS_SVBindingSource;
        private DSTableAdapters.DS_SVTableAdapter dS_SVTableAdapter;
        private System.Windows.Forms.ComboBox tENComboBox;
        private DevExpress.XtraEditors.TextEdit txtMSV;
        private System.Windows.Forms.ComboBox txtTD;
        private System.Windows.Forms.Button btnXULY;
    }
}