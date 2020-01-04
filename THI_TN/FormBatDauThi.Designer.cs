namespace TN_CSDLPT
{
    partial class FormBatDauThi
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
            this.dgvHoiTraLoi = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKeTiep = new System.Windows.Forms.Button();
            this.btnLuiLai = new System.Windows.Forms.Button();
            this.radD = new System.Windows.Forms.RadioButton();
            this.radC = new System.Windows.Forms.RadioButton();
            this.radB = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labNoiDung = new System.Windows.Forms.Label();
            this.labSoCauHoi = new System.Windows.Forms.Label();
            this.radA = new System.Windows.Forms.RadioButton();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDungLai = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbLan = new System.Windows.Forms.Label();
            this.lbMonThi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbLop = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbMSV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoiTraLoi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoiTraLoi
            // 
            this.dgvHoiTraLoi.AllowUserToAddRows = false;
            this.dgvHoiTraLoi.AllowUserToDeleteRows = false;
            this.dgvHoiTraLoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoiTraLoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvHoiTraLoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvHoiTraLoi.Location = new System.Drawing.Point(0, 0);
            this.dgvHoiTraLoi.Name = "dgvHoiTraLoi";
            this.dgvHoiTraLoi.ReadOnly = true;
            this.dgvHoiTraLoi.Size = new System.Drawing.Size(218, 519);
            this.dgvHoiTraLoi.TabIndex = 0;
            this.dgvHoiTraLoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoiTraLoi_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "cauHoi";
            this.Column1.HeaderText = "Câu hỏi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "traLoi";
            this.Column2.HeaderText = "Trả lời";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKeTiep);
            this.groupBox1.Controls.Add(this.btnLuiLai);
            this.groupBox1.Controls.Add(this.radD);
            this.groupBox1.Controls.Add(this.radC);
            this.groupBox1.Controls.Add(this.radB);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.radA);
            this.groupBox1.Controls.Add(this.labelControl12);
            this.groupBox1.Controls.Add(this.labelControl11);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(218, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 519);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Câu hỏi";
            // 
            // btnKeTiep
            // 
            this.btnKeTiep.Location = new System.Drawing.Point(206, 465);
            this.btnKeTiep.Name = "btnKeTiep";
            this.btnKeTiep.Size = new System.Drawing.Size(75, 23);
            this.btnKeTiep.TabIndex = 51;
            this.btnKeTiep.Text = ">>";
            this.btnKeTiep.UseVisualStyleBackColor = true;
            this.btnKeTiep.Click += new System.EventHandler(this.btnKeTiep_Click);
            // 
            // btnLuiLai
            // 
            this.btnLuiLai.Location = new System.Drawing.Point(101, 465);
            this.btnLuiLai.Name = "btnLuiLai";
            this.btnLuiLai.Size = new System.Drawing.Size(75, 23);
            this.btnLuiLai.TabIndex = 50;
            this.btnLuiLai.Text = "<<";
            this.btnLuiLai.UseVisualStyleBackColor = true;
            this.btnLuiLai.Click += new System.EventHandler(this.btnLuiLai_Click);
            // 
            // radD
            // 
            this.radD.AutoSize = true;
            this.radD.Location = new System.Drawing.Point(155, 390);
            this.radD.Name = "radD";
            this.radD.Size = new System.Drawing.Size(107, 23);
            this.radD.TabIndex = 49;
            this.radD.TabStop = true;
            this.radD.Text = "Phương án D";
            this.radD.UseVisualStyleBackColor = true;
            this.radD.CheckedChanged += new System.EventHandler(this.radD_CheckedChanged);
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.Location = new System.Drawing.Point(155, 329);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(107, 23);
            this.radC.TabIndex = 48;
            this.radC.TabStop = true;
            this.radC.Text = "Phương án C";
            this.radC.UseVisualStyleBackColor = true;
            this.radC.CheckedChanged += new System.EventHandler(this.radC_CheckedChanged);
            // 
            // radB
            // 
            this.radB.AutoSize = true;
            this.radB.Location = new System.Drawing.Point(155, 273);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(106, 23);
            this.radB.TabIndex = 47;
            this.radB.TabStop = true;
            this.radB.Text = "Phương án B";
            this.radB.UseVisualStyleBackColor = true;
            this.radB.CheckedChanged += new System.EventHandler(this.radB_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.labNoiDung);
            this.panel1.Controls.Add(this.labSoCauHoi);
            this.panel1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Location = new System.Drawing.Point(6, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 116);
            this.panel1.TabIndex = 1;
            // 
            // labNoiDung
            // 
            this.labNoiDung.AutoSize = true;
            this.labNoiDung.Location = new System.Drawing.Point(70, 9);
            this.labNoiDung.Name = "labNoiDung";
            this.labNoiDung.Size = new System.Drawing.Size(68, 19);
            this.labNoiDung.TabIndex = 1;
            this.labNoiDung.Text = "Nội Dung";
            // 
            // labSoCauHoi
            // 
            this.labSoCauHoi.AutoSize = true;
            this.labSoCauHoi.Location = new System.Drawing.Point(15, 9);
            this.labSoCauHoi.Name = "labSoCauHoi";
            this.labSoCauHoi.Size = new System.Drawing.Size(49, 19);
            this.labSoCauHoi.TabIndex = 0;
            this.labSoCauHoi.Text = "Câu 1:";
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.Location = new System.Drawing.Point(155, 212);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(106, 23);
            this.radA.TabIndex = 46;
            this.radA.TabStop = true;
            this.radA.Text = "Phương án A";
            this.radA.UseVisualStyleBackColor = true;
            this.radA.CheckedChanged += new System.EventHandler(this.radA_CheckedChanged);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(118, 390);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(12, 19);
            this.labelControl12.TabIndex = 45;
            this.labelControl12.Text = "D";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(118, 330);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(11, 19);
            this.labelControl11.TabIndex = 44;
            this.labelControl11.Text = "C";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(119, 273);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(11, 19);
            this.labelControl10.TabIndex = 43;
            this.labelControl10.Text = "B";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(119, 213);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(12, 19);
            this.labelControl9.TabIndex = 42;
            this.labelControl9.Text = "A";
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(206, 12);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(116, 29);
            this.txtTime.TabIndex = 0;
            this.txtTime.Text = "00:00";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnDungLai);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(737, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 519);
            this.panel2.TabIndex = 50;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(30, 386);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 48);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDungLai
            // 
            this.btnDungLai.Location = new System.Drawing.Point(30, 302);
            this.btnDungLai.Name = "btnDungLai";
            this.btnDungLai.Size = new System.Drawing.Size(140, 47);
            this.btnDungLai.TabIndex = 2;
            this.btnDungLai.Text = "Nộp Bài";
            this.btnDungLai.UseVisualStyleBackColor = true;
            this.btnDungLai.Click += new System.EventHandler(this.btnDungLai_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbLan);
            this.groupBox3.Controls.Add(this.lbMonThi);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin đề thi";
            // 
            // lbLan
            // 
            this.lbLan.AutoSize = true;
            this.lbLan.Location = new System.Drawing.Point(64, 66);
            this.lbLan.Name = "lbLan";
            this.lbLan.Size = new System.Drawing.Size(45, 19);
            this.lbLan.TabIndex = 3;
            this.lbLan.Text = "label6";
            // 
            // lbMonThi
            // 
            this.lbMonThi.AutoSize = true;
            this.lbMonThi.Location = new System.Drawing.Point(64, 33);
            this.lbMonThi.Name = "lbMonThi";
            this.lbMonThi.Size = new System.Drawing.Size(45, 19);
            this.lbMonThi.TabIndex = 2;
            this.lbMonThi.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lần thi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Môn thi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbLop);
            this.groupBox2.Controls.Add(this.lbHoTen);
            this.groupBox2.Controls.Add(this.lbMSV);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 127);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sinh viên";
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Location = new System.Drawing.Point(64, 95);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(45, 19);
            this.lbLop.TabIndex = 5;
            this.lbLop.Text = "label6";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(64, 58);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(45, 19);
            this.lbHoTen.TabIndex = 4;
            this.lbHoTen.Text = "label5";
            // 
            // lbMSV
            // 
            this.lbMSV.AutoSize = true;
            this.lbMSV.Location = new System.Drawing.Point(64, 22);
            this.lbMSV.Name = "lbMSV";
            this.lbMSV.Size = new System.Drawing.Size(45, 19);
            this.lbMSV.TabIndex = 3;
            this.lbMSV.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // FormBatDauThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHoiTraLoi);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormBatDauThi";
            this.Text = "FormBatDauThi";
            this.Load += new System.EventHandler(this.FormBatDauThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoiTraLoi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoiTraLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radD;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.RadioButton radA;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labNoiDung;
        private System.Windows.Forms.Label labSoCauHoi;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbLan;
        private System.Windows.Forms.Label lbMonThi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbMSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKeTiep;
        private System.Windows.Forms.Button btnLuiLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDungLai;
    }
}