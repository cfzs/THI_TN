﻿namespace THI_TN
{
    partial class frmThi
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label mAMHLabel1;
            System.Windows.Forms.Label mALOPLabel1;
            this.dS = new THI_TN.DS();
            this.tableAdapterManager = new THI_TN.DSTableAdapters.TableAdapterManager();
            this.mASVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bdsDSSV = new System.Windows.Forms.BindingSource(this.components);
            this.hOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new THI_TN.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.nGAYTHIDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.lANComboBox = new System.Windows.Forms.ComboBox();
            this.bdsL = new System.Windows.Forms.BindingSource(this.components);
            this.dS_SVTableAdapter = new THI_TN.DSTableAdapters.DS_SVTableAdapter();
            this.mAMHComboBox = new System.Windows.Forms.ComboBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.gETDSMHTableAdapter = new THI_TN.DSTableAdapters.GETDSMHTableAdapter();
            this.mAMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dSLOPTableAdapter = new THI_TN.DSTableAdapters.DSLOPTableAdapter();
            this.mALOPTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.tENLOPComboBox = new System.Windows.Forms.ComboBox();
            mASVLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            mAMHLabel1 = new System.Windows.Forms.Label();
            mALOPLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            mASVLabel.Location = new System.Drawing.Point(52, 143);
            mASVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(53, 17);
            mASVLabel.TabIndex = 1;
            mASVLabel.Text = "Mã SV:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            mALOPLabel.Location = new System.Drawing.Point(43, 192);
            mALOPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(56, 17);
            mALOPLabel.TabIndex = 3;
            mALOPLabel.Text = "Tên lớp:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            hOLabel.Location = new System.Drawing.Point(49, 92);
            hOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(51, 17);
            hOLabel.TabIndex = 5;
            hOLabel.Text = "Họ tên:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            mAMHLabel.Location = new System.Drawing.Point(15, 241);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(88, 17);
            mAMHLabel.TabIndex = 6;
            mAMHLabel.Text = "Tên môn học:";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            nGAYTHILabel.Location = new System.Drawing.Point(35, 282);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(61, 17);
            nGAYTHILabel.TabIndex = 8;
            nGAYTHILabel.Text = "Ngày thi:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lANLabel.Location = new System.Drawing.Point(62, 324);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(34, 17);
            lANLabel.TabIndex = 10;
            lANLabel.Text = "Lần:";
            // 
            // mAMHLabel1
            // 
            mAMHLabel1.AutoSize = true;
            mAMHLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            mAMHLabel1.Location = new System.Drawing.Point(265, 242);
            mAMHLabel1.Name = "mAMHLabel1";
            mAMHLabel1.Size = new System.Drawing.Size(85, 17);
            mAMHLabel1.TabIndex = 15;
            mAMHLabel1.Text = "Mã môn học:";
            // 
            // mALOPLabel1
            // 
            mALOPLabel1.AutoSize = true;
            mALOPLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            mALOPLabel1.Location = new System.Drawing.Point(297, 192);
            mALOPLabel1.Name = "mALOPLabel1";
            mALOPLabel1.Size = new System.Drawing.Size(53, 17);
            mALOPLabel1.TabIndex = 16;
            mALOPLabel1.Text = "Mã lớp:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // mASVTextEdit
            // 
            this.mASVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSSV, "MASV", true));
            this.mASVTextEdit.Enabled = false;
            this.mASVTextEdit.Location = new System.Drawing.Point(113, 139);
            this.mASVTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.mASVTextEdit.Name = "mASVTextEdit";
            this.mASVTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mASVTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mASVTextEdit.Size = new System.Drawing.Size(133, 24);
            this.mASVTextEdit.TabIndex = 2;
            // 
            // bdsDSSV
            // 
            this.bdsDSSV.DataMember = "DS_SV";
            this.bdsDSSV.DataSource = this.dS;
            // 
            // hOTextEdit
            // 
            this.hOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSSV, "TEN", true));
            this.hOTextEdit.Enabled = false;
            this.hOTextEdit.Location = new System.Drawing.Point(113, 88);
            this.hOTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.hOTextEdit.Name = "hOTextEdit";
            this.hOTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hOTextEdit.Properties.Appearance.Options.UseFont = true;
            this.hOTextEdit.Size = new System.Drawing.Size(340, 24);
            this.hOTextEdit.TabIndex = 6;
            // 
            // bdsGVDK
            // 
            this.bdsGVDK.DataMember = "GIAOVIEN_DANGKY";
            this.bdsGVDK.DataSource = this.dS;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // nGAYTHIDateEdit
            // 
            this.nGAYTHIDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGVDK, "NGAYTHI", true));
            this.nGAYTHIDateEdit.EditValue = null;
            this.nGAYTHIDateEdit.Location = new System.Drawing.Point(113, 279);
            this.nGAYTHIDateEdit.Name = "nGAYTHIDateEdit";
            this.nGAYTHIDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nGAYTHIDateEdit.Properties.Appearance.Options.UseFont = true;
            this.nGAYTHIDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYTHIDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYTHIDateEdit.Size = new System.Drawing.Size(100, 24);
            this.nGAYTHIDateEdit.TabIndex = 9;
            // 
            // lANComboBox
            // 
            this.lANComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGVDK, "LAN", true));
            this.lANComboBox.DataSource = this.bdsGVDK;
            this.lANComboBox.DisplayMember = "LAN";
            this.lANComboBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lANComboBox.FormattingEnabled = true;
            this.lANComboBox.Location = new System.Drawing.Point(113, 321);
            this.lANComboBox.Name = "lANComboBox";
            this.lANComboBox.Size = new System.Drawing.Size(121, 25);
            this.lANComboBox.TabIndex = 11;
            this.lANComboBox.ValueMember = "LAN";
            // 
            // bdsL
            // 
            this.bdsL.DataMember = "DSLOP";
            this.bdsL.DataSource = this.dS;
            // 
            // dS_SVTableAdapter
            // 
            this.dS_SVTableAdapter.ClearBeforeFill = true;
            // 
            // mAMHComboBox
            // 
            this.mAMHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGVDK, "MAMH", true));
            this.mAMHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsGVDK, "MAMH", true));
            this.mAMHComboBox.DataSource = this.bdsMH;
            this.mAMHComboBox.DisplayMember = "TENMH";
            this.mAMHComboBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mAMHComboBox.FormattingEnabled = true;
            this.mAMHComboBox.Location = new System.Drawing.Point(113, 238);
            this.mAMHComboBox.Name = "mAMHComboBox";
            this.mAMHComboBox.Size = new System.Drawing.Size(121, 25);
            this.mAMHComboBox.TabIndex = 15;
            this.mAMHComboBox.ValueMember = "MAMH";
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "GETDSMH";
            this.bdsMH.DataSource = this.dS;
            // 
            // gETDSMHTableAdapter
            // 
            this.gETDSMHTableAdapter.ClearBeforeFill = true;
            // 
            // mAMHTextEdit
            // 
            this.mAMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMH, "MAMH", true));
            this.mAMHTextEdit.Enabled = false;
            this.mAMHTextEdit.Location = new System.Drawing.Point(353, 239);
            this.mAMHTextEdit.Name = "mAMHTextEdit";
            this.mAMHTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mAMHTextEdit.Properties.Appearance.Options.UseFont = true;
            this.mAMHTextEdit.Size = new System.Drawing.Size(100, 24);
            this.mAMHTextEdit.TabIndex = 16;
            // 
            // dSLOPTableAdapter
            // 
            this.dSLOPTableAdapter.ClearBeforeFill = true;
            // 
            // mALOPTextEdit1
            // 
            this.mALOPTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsL, "MALOP", true));
            this.mALOPTextEdit1.Enabled = false;
            this.mALOPTextEdit1.Location = new System.Drawing.Point(367, 189);
            this.mALOPTextEdit1.Name = "mALOPTextEdit1";
            this.mALOPTextEdit1.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mALOPTextEdit1.Properties.Appearance.Options.UseFont = true;
            this.mALOPTextEdit1.Size = new System.Drawing.Size(100, 24);
            this.mALOPTextEdit1.TabIndex = 17;
            // 
            // tENLOPComboBox
            // 
            this.tENLOPComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsL, "TENLOP", true));
            this.tENLOPComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsGVDK, "MALOP", true));
            this.tENLOPComboBox.DataSource = this.bdsL;
            this.tENLOPComboBox.DisplayMember = "TENLOP";
            this.tENLOPComboBox.Enabled = false;
            this.tENLOPComboBox.FormattingEnabled = true;
            this.tENLOPComboBox.Location = new System.Drawing.Point(113, 189);
            this.tENLOPComboBox.Name = "tENLOPComboBox";
            this.tENLOPComboBox.Size = new System.Drawing.Size(164, 25);
            this.tENLOPComboBox.TabIndex = 18;
            this.tENLOPComboBox.ValueMember = "MALOP";
            // 
            // frmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.tENLOPComboBox);
            this.Controls.Add(mALOPLabel1);
            this.Controls.Add(this.mALOPTextEdit1);
            this.Controls.Add(mAMHLabel1);
            this.Controls.Add(this.mAMHTextEdit);
            this.Controls.Add(this.mAMHComboBox);
            this.Controls.Add(lANLabel);
            this.Controls.Add(this.lANComboBox);
            this.Controls.Add(nGAYTHILabel);
            this.Controls.Add(this.nGAYTHIDateEdit);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(hOLabel);
            this.Controls.Add(this.hOTextEdit);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(mASVLabel);
            this.Controls.Add(this.mASVTextEdit);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThi";
            this.Text = "frmThi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTHIDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOPTextEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit mASVTextEdit;
        private DevExpress.XtraEditors.TextEdit hOTextEdit;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private DevExpress.XtraEditors.DateEdit nGAYTHIDateEdit;
        private System.Windows.Forms.ComboBox lANComboBox;
        private System.Windows.Forms.BindingSource bdsDSSV;
        private DSTableAdapters.DS_SVTableAdapter dS_SVTableAdapter;
        private System.Windows.Forms.ComboBox mAMHComboBox;
        private System.Windows.Forms.BindingSource bdsMH;
        private DSTableAdapters.GETDSMHTableAdapter gETDSMHTableAdapter;
        private DevExpress.XtraEditors.TextEdit mAMHTextEdit;
        private System.Windows.Forms.BindingSource bdsL;
        private DSTableAdapters.DSLOPTableAdapter dSLOPTableAdapter;
        private DevExpress.XtraEditors.TextEdit mALOPTextEdit1;
        private System.Windows.Forms.ComboBox tENLOPComboBox;
    }
}