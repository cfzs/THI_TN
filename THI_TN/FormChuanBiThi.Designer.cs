namespace TN_CSDLPT
{
    partial class FormChuanBiThi
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
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.lbLop = new System.Windows.Forms.Label();
            this.cbMaMH = new System.Windows.Forms.ComboBox();
            this.lbMaMH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboLan = new System.Windows.Forms.ComboBox();
            this.cbTrinhDo = new System.Windows.Forms.ComboBox();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.labelThongBao = new System.Windows.Forms.Label();
            this.labelLanThi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(147, 59);
            this.cbLop.Margin = new System.Windows.Forms.Padding(4);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(180, 27);
            this.cbLop.TabIndex = 0;
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Location = new System.Drawing.Point(31, 65);
            this.lbLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(34, 19);
            this.lbLop.TabIndex = 1;
            this.lbLop.Text = "Lớp";
            // 
            // cbMaMH
            // 
            this.cbMaMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaMH.FormattingEnabled = true;
            this.cbMaMH.Location = new System.Drawing.Point(147, 127);
            this.cbMaMH.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaMH.Name = "cbMaMH";
            this.cbMaMH.Size = new System.Drawing.Size(180, 27);
            this.cbMaMH.TabIndex = 2;
            this.cbMaMH.SelectedIndexChanged += new System.EventHandler(this.cbMaMH_SelectedIndexChanged);
            // 
            // lbMaMH
            // 
            this.lbMaMH.AutoSize = true;
            this.lbMaMH.Location = new System.Drawing.Point(31, 130);
            this.lbMaMH.Name = "lbMaMH";
            this.lbMaMH.Size = new System.Drawing.Size(63, 19);
            this.lbMaMH.TabIndex = 3;
            this.lbMaMH.Text = " Mã MH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trình độ";
            // 
            // comboLan
            // 
            this.comboLan.DisplayMember = "1";
            this.comboLan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLan.FormattingEnabled = true;
            this.comboLan.Location = new System.Drawing.Point(147, 191);
            this.comboLan.Name = "comboLan";
            this.comboLan.Size = new System.Drawing.Size(180, 27);
            this.comboLan.TabIndex = 6;
            this.comboLan.SelectedIndexChanged += new System.EventHandler(this.comboLan_SelectedIndexChanged);
            // 
            // cbTrinhDo
            // 
            this.cbTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrinhDo.FormattingEnabled = true;
            this.cbTrinhDo.Location = new System.Drawing.Point(147, 258);
            this.cbTrinhDo.Name = "cbTrinhDo";
            this.cbTrinhDo.Size = new System.Drawing.Size(180, 27);
            this.cbTrinhDo.TabIndex = 7;
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(147, 315);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(180, 55);
            this.btnBatDau.TabIndex = 8;
            this.btnBatDau.Text = "Bắt Đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // labelThongBao
            // 
            this.labelThongBao.AutoSize = true;
            this.labelThongBao.Location = new System.Drawing.Point(186, 23);
            this.labelThongBao.Name = "labelThongBao";
            this.labelThongBao.Size = new System.Drawing.Size(101, 19);
            this.labelThongBao.TabIndex = 9;
            this.labelThongBao.Text = "THÔNG BÁO";
            // 
            // labelLanThi
            // 
            this.labelLanThi.AutoSize = true;
            this.labelLanThi.Location = new System.Drawing.Point(209, 379);
            this.labelLanThi.Name = "labelLanThi";
            this.labelLanThi.Size = new System.Drawing.Size(0, 19);
            this.labelLanThi.TabIndex = 10;
            // 
            // FormChuanBiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 407);
            this.Controls.Add(this.labelLanThi);
            this.Controls.Add(this.labelThongBao);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.cbTrinhDo);
            this.Controls.Add(this.comboLan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMaMH);
            this.Controls.Add(this.cbMaMH);
            this.Controls.Add(this.lbLop);
            this.Controls.Add(this.cbLop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormChuanBiThi";
            this.Text = "FormChuanBiThi";
            this.Load += new System.EventHandler(this.FormChuanBiThi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.ComboBox cbMaMH;
        private System.Windows.Forms.Label lbMaMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboLan;
        private System.Windows.Forms.ComboBox cbTrinhDo;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Label labelThongBao;
        private System.Windows.Forms.Label labelLanThi;
    }
}