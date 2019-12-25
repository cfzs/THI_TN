using System;
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
    public partial class frmMonHoc : Form
    {
        private int viTri = 0;

        public frmMonHoc()
        {
            InitializeComponent();
        }


        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            //this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            //this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);
            dS.EnforceConstraints = true;
            btnGhi.Enabled = false;
            btnPhucHoi.Enabled = false;
            groupBox1.Enabled = false;
            //btnPhucHoi.Enabled = false;
            if (bdsMH.Count == 0)
                btnXoa.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsMH.Position;
            groupBox1.Enabled = true;
            gcMH.Enabled = false;
            bdsMH.AddNew();
            btnThem.Enabled = false; btnSua.Enabled = false; btnXoa.Enabled = false;
            btnInDSMH.Enabled = false; btnThoat.Enabled = false;
            btnGhi.Enabled = true; btnPhucHoi.Enabled = true; btnRefresh.Enabled = true;
            txtMaMH.Focus();

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = false; btnSua.Enabled = false; btnXoa.Enabled = false;
            btnInDSMH.Enabled = false; btnThoat.Enabled = false;
            btnGhi.Enabled = true; btnPhucHoi.Enabled = true; btnRefresh.Enabled = true;
            groupBox1.Enabled = true;
            gcMH.Enabled = false;
            viTri = bdsMH.Position;

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống mã môn học.", "", MessageBoxButtons.OK);
                txtMaMH.Focus();
            }

            else if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống tên môn học.", "", MessageBoxButtons.OK);
                txtTenMH.Focus();
            }

            else
            {
                try
                {
                    bdsMH.EndEdit();
                    bdsMH.ResetCurrentItem();
                    if (dS.HasChanges())
                    {
                        this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("already present") || ex.Message.Contains("PRIMARY"))
                    {
                        MessageBox.Show("Mã môn học bị trùng.", "", MessageBoxButtons.OK);
                        txtMaMH.Focus();
                        btnPhucHoi.Enabled = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi ghi môn học. Bạn kiểm tra lại thông tin môn học trước khi ghi.", "", MessageBoxButtons.OK);
                        btnPhucHoi.Enabled = false;
                        return;
                    }

                }
                btnGhi.Enabled = false; btnPhucHoi.Enabled = false; groupBox1.Enabled = false;
                btnThem.Enabled = true; btnSua.Enabled = true; btnXoa.Enabled = true;
                btnRefresh.Enabled = true;
                btnInDSMH.Enabled = true; btnThoat.Enabled = true; gcMH.Enabled = true;

            }

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsBD.Count > 0)
            {
                MessageBox.Show("Môn học đã có bộ đề.", "", MessageBoxButtons.OK);
                return;
            }
            else if (MessageBox.Show("Bạn có thật sự muốn xóa môn học này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsMH.RemoveCurrent();
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi xóa môn học.", "", MessageBoxButtons.OK);

                }
            }
            btnThem.Enabled = true;
            btnPhucHoi.Enabled = false;
            if (bdsMH.Count == 0)
                btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMH.CancelEdit();
            bdsMH.Position = viTri;
            gcMH.Enabled = true;
            groupBox1.Enabled = false;
            btnGhi.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = false;
            btnInDSMH.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = true; btnSua.Enabled = true; btnXoa.Enabled = true;
            btnInDSMH.Enabled = true; btnThoat.Enabled = true;
            btnGhi.Enabled = false; btnPhucHoi.Enabled = false; btnRefresh.Enabled = true;
            gcMH.Enabled = true; groupBox1.Enabled = false;
            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.bODETableAdapter.Fill(this.dS.BODE);
            dS.EnforceConstraints = true;


        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}