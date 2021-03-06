﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THI_TN
{
    public partial class frmGiaoVien : Form
    {
        private int viTri = 0;

        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            //this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            //this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            //dS.EnforceConstraints = true;

            btnGhi.Enabled = false;
            btnPhucHoi.Enabled = false;
            groupBox1.Enabled = false;
            btnThemBD.Enabled = true; btnGhiBD.Enabled = false; btnXoaBD.Enabled = true;
            //btnPhucHoi.Enabled = false;
            if (bdsGV.Count == 0)
                btnXoa.Enabled = false;


        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsGV.Position;
            groupBox1.Enabled = true;
            gcGV.Enabled = false;
            bdsGV.AddNew();
            btnThem.Enabled = false; btnSua.Enabled = false; btnXoa.Enabled = false;
            btnCTBD.Enabled = false; btnThoat.Enabled = false;
            btnGhi.Enabled = true; btnPhucHoi.Enabled = true; btnRefresh.Enabled = true;
            txtMaGV.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = false; btnSua.Enabled = false; btnXoa.Enabled = false;
            btnCTBD.Enabled = false; btnThoat.Enabled = false;
            btnGhi.Enabled = true; btnPhucHoi.Enabled = true; btnRefresh.Enabled = true;
            groupBox1.Enabled = true;
            gcGV.Enabled = false;
            viTri = bdsGV.Position;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống mã giáo viên.", "", MessageBoxButtons.OK);
                txtMaGV.Focus();
            }

            else if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống họ giáo viên.", "", MessageBoxButtons.OK);
                txtHo.Focus();
            }

            else if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống tên giáo viên.", "", MessageBoxButtons.OK);
                txtTen.Focus();
            }

            else if (txtHocVi.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống học vị.", "", MessageBoxButtons.OK);
                txtHocVi.Focus();
            }

            else if (cmbMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống mã khoa.", "", MessageBoxButtons.OK);
                cmbMaKhoa.Focus();
            }

            else
            {
                try
                {
                    bdsGV.EndEdit();
                    bdsGV.ResetCurrentItem();
                    if (dS.HasChanges())
                    {
                        this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("already present")||ex.Message.Contains("PRIMARY"))
                    {
                        MessageBox.Show("Mã giáo viên bị trùng.", "", MessageBoxButtons.OK);
                        btnPhucHoi.Enabled = false;
                        txtMaGV.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi ghi giáo viên. Bạn kiểm tra lại thông tin giáo viên trước khi ghi.", "", MessageBoxButtons.OK);
                        btnPhucHoi.Enabled = false;
                        return;
                    }

                }
                btnGhi.Enabled = false; btnPhucHoi.Enabled = false; groupBox1.Enabled = false;
                btnThem.Enabled = true; btnSua.Enabled = true; btnXoa.Enabled = true;
                btnRefresh.Enabled = true;
                btnCTBD.Enabled = true; btnThoat.Enabled = true; gcGV.Enabled = true;
            }


        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsBD.Count > 0)
            {
                MessageBox.Show("Môn học đã có bộ đề.", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa giáo viên này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsGV.RemoveCurrent();
                    this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi xóa giáo viên.", "", MessageBoxButtons.OK);

                }
            }
            btnThem.Enabled = true;
            btnPhucHoi.Enabled = false;
            if (bdsGV.Count == 0)
                btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGV.CancelEdit();
            bdsBD.CancelEdit();
            bdsGV.Position = viTri;
            gcGV.Enabled = true;
            groupBox1.Enabled = false;
            btnGhi.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = false;
            btnCTBD.Enabled = true;
            btnThoat.Enabled = true;
            bdsBD.CancelEdit();
            btnThemBD.Enabled = true;
            btnGhiBD.Enabled = false;
            btnXoaBD.Enabled = true;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = true; btnSua.Enabled = true; btnXoa.Enabled = true;
            btnCTBD.Enabled = true; btnThoat.Enabled = true;
            btnGhi.Enabled = false; btnPhucHoi.Enabled = false; btnRefresh.Enabled = true;
            gcGV.Enabled = true; groupBox1.Enabled = false;
            btnThemBD.Enabled = true; btnGhiBD.Enabled = false;  btnXoaBD.Enabled = true;
            dS.EnforceConstraints = false;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
            this.bODETableAdapter.Fill(this.dS.BODE);
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            //dS.EnforceConstraints = true;
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void mAKHComboBox_DropDown(object sender, EventArgs e)
        {
            int maKhoa = cmbMaKhoa.SelectedIndex;
            DataTable dt = new DataTable();
            //dt = Program.ExecSqlDataTable("SELECT * FROM KHOA");

            //Set tay
            Program.conn.ConnectionString = "Data Source=Quang-PC\\SRV2;Initial Catalog=THI_TN;Persist Security Info=True;User ID=KieuThien;Password=123456";
            Program.conn.Open();
            dt = Program.ExecSqlDataTable("SELECT MAKH FROM KHOA");

            cmbMaKhoa.DataSource = dt;
            cmbMaKhoa.ValueMember = "MAKH";

            cmbMaKhoa.SelectedIndex = maKhoa;
        }

        private void btnThemBD_Click(object sender, EventArgs e)
        {
            viTri = bdsGV.Position;
            groupBox1.Enabled = false;
            gcGV.Enabled = false;
            bdsBD.AddNew();
            object maxCauHoi;
            maxCauHoi = dS.BODE.Compute("Max(CAUHOI)", "");
            //txtCauHoi.Selected = (int.Parse(maxCauHoi.ToString()) + 1).ToString();
            dgvBD.CurrentRow.SetValues((int.Parse(maxCauHoi.ToString()) + 1).ToString());
            btnThem.Enabled = false; btnSua.Enabled = false; btnXoa.Enabled = false;
            btnCTBD.Enabled = false; btnThoat.Enabled = false;
            btnGhi.Enabled = false; btnPhucHoi.Enabled = true; btnRefresh.Enabled = true;
            btnThemBD.Enabled = false;
            btnGhiBD.Enabled = true;
            btnXoaBD.Enabled = false;
        }

        private void btnGhiBD_Click(object sender, EventArgs e)
        {
            if (cmbTenMH.Selected.ToString().Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống tên môn học.", "", MessageBoxButtons.OK);
            }

            else if (txtNoiDung.ToString().Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống nội dung.", "", MessageBoxButtons.OK);
            }
            else if (txtA.ToString().Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống câu trả lời.", "", MessageBoxButtons.OK);
            }
            else if (txtB.ToString().Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống câu trả lời.", "", MessageBoxButtons.OK);
            }
            else if (txtC.ToString().Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống câu trả lời.", "", MessageBoxButtons.OK);
            }
            else if (txtD.ToString().Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống câu trả lời.", "", MessageBoxButtons.OK);
            }

            else if (cmbDapAn.ToString().Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống đáp án.", "", MessageBoxButtons.OK);
            }

            else
            {
                try
                {
                    bdsBD.EndEdit();
                    bdsBD.ResetCurrentItem();
                    if (dS.HasChanges())
                    {
                        this.bODETableAdapter.Update(this.dS.BODE);
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("already present") || ex.Message.Contains("PRIMARY"))
                    {
                        MessageBox.Show("Mã lớp bị trùng.", "", MessageBoxButtons.OK);
                        btnPhucHoi.Enabled = false;
                        return;
                    }
                    else if (ex.Message.Contains("String or binary"))
                    {
                        MessageBox.Show("Trình độ và đáp án chỉ được nhập 1 kí tự.", "", MessageBoxButtons.OK);
                        btnPhucHoi.Enabled = false;
                        //if (cmbTrinhDo.Selected.ToString().Length > 1)
                        //    cmbTrinhDo.Focus();
                        //if (cmbDapAn.Selected.ToString().Length > 1)
                        //    cmbDapAn.Focus();
                        return;
                    }
                    else if (ex.Message.Contains("CHECK"))
                    {
                        MessageBox.Show("Trình độ chỉ được nhập 1 kí tự (A,B,C)." +
                            "\nĐáp án chỉ được nhập 1 kí tự (A,B,C,D)", "", MessageBoxButtons.OK);
                        btnPhucHoi.Enabled = false;
                        //if (cmbTrinhDo.SelectedValue.ToString().Length > 1)
                        //    cmbTrinhDo.Focus();
                        //if (cmbDapAn.SelectedValue.ToString().Length > 1)
                        //    cmbDapAn.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);

                        MessageBox.Show("Lỗi ghi câu hỏi. Bạn kiểm tra lại thông tin lớp trước khi ghi.", "", MessageBoxButtons.OK);
                        btnPhucHoi.Enabled = false;
                        return;
                    }

                }
                btnGhiBD.Enabled = false; 
                btnThemBD.Enabled = true;
                btnXoaBD.Enabled = true;
               
            }
        }

        private void btnXoaBD_Click(object sender, EventArgs e)
        {
            if (bdsCTBT.Count > 0)
            {
                MessageBox.Show("Câu hỏi đã có trong đề thi.", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa câu hỏi này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsBD.RemoveCurrent();
                    this.bODETableAdapter.Update(this.dS.BODE);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi xóa câu hỏi.", "", MessageBoxButtons.OK);

                }
            }
            btnThemBD.Enabled = true;
            btnPhucHoi.Enabled = false;
            if (bdsBD.Count == 0)
                btnXoaBD.Enabled = false;
        }
    }
}
