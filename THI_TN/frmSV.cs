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
    public partial class frmSV : Form
    {
        private int viTri = 0;
        public frmSV()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmSV_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.DS_SV' table. You can move, or remove it, as needed.
            ////this.dS_SVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dS_SVTableAdapter.Fill(this.dS.DS_SV);
            // TODO: This line of code loads data into the 'dS.COSO' table. You can move, or remove it, as needed.
            //this.cOSOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cOSOTableAdapter.Fill(this.dS.COSO);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
           // this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
           // this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
           // this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);

        }

        private void mAKHLabel_Click(object sender, EventArgs e)
        {

        }

        private void mAKHTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void kHOABindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void sINHVIENDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tENComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               // txtMASV.Text = .SelectedValue.ToString();
            }catch(Exception ) { }
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //không cho nhập vào các ô này
            txtMASV.Enabled = false;
            txtMK.Enabled = false;
            txtTL.Enabled = false;
            cbbTEN.Enabled = false;
            txtML.Enabled = false;
            txtML1.Enabled = false;
            //những ô được phép nhập
            txtMASV1.Enabled = true;
            txtHO.Enabled = true;
            txtTEN.Enabled = true;
            txtNS.Enabled = true;
            txtDC.Enabled = true;


            viTri = bdsSINHVIEN.Position;
            gcLOP.Enabled = false;
            bdsSINHVIEN.AddNew();

            btnThem.Enabled = false; btnSua.Enabled = false; btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = true; btnPhucHoi.Enabled = true; btnPhucHoi.Enabled = true;
            txtMASV1.Focus();

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsSINHVIEN.RemoveCurrent();
                    this.kHOATableAdapter.Update(this.dS.KHOA);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi xóa khoa.", "", MessageBoxButtons.OK);

                }
            }
            if (bdsSINHVIEN.Count == 0)
                btnXoa.Enabled = false;
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            if (txtMASV1.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống mã sinh viên.", "", MessageBoxButtons.OK);
                txtMASV1.Focus();
            }

            if (txtHO.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống họ sinh viên.", "", MessageBoxButtons.OK);
                txtHO.Focus();
            }
            if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống tên sinh viên.", "", MessageBoxButtons.OK);
                txtTEN.Focus();
            }
            if (txtNS.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống ngày sinh sinh viên.", "", MessageBoxButtons.OK);
                txtNS.Focus();
            }
            if (txtDC.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống địa chỉ sinh viên.", "", MessageBoxButtons.OK);
                txtDC.Focus();
            }
            try
            {
                bdsSINHVIEN.EndEdit();//đẩy về csdl
                bdsSINHVIEN.ResetCurrentItem();
                if (dS.HasChanges())
                {
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);//đẩy về sql
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY"))
                {
                    MessageBox.Show("Mã sinh viên bị trùng.", "", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Lỗi ghi sinh viên. Bạn kiểm tra lại thông tin trước khi ghi." + ex.Message, "", MessageBoxButtons.OK);

            }
            btnGhi.Enabled = false; btnPhucHoi.Enabled = false;
            btnThem.Enabled = true; btnSua.Enabled = true; btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnThoat.Enabled = true; gcLOP.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLOP.CancelEdit();
            bdsLOP.Position = viTri;
            gcLOP.Enabled = true;
           
            btnGhi.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = false;
            btnThoat.Enabled = true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsLOP.Position;
            
            gcLOP.Enabled = false;
            bdsLOP.AddNew();
            btnThem.Enabled = false; btnSua.Enabled = false; btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = true; btnPhucHoi.Enabled = true; btnRefresh.Enabled = true;
            txtML.Focus();

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = false; btnSua.Enabled = false; btnXoa.Enabled = false;
            btnThoat.Enabled = false;
            btnGhi.Enabled = true; btnPhucHoi.Enabled = true; btnRefresh.Enabled = true;
            gcLOP.Enabled = false;
            viTri = bdsLOP.Position;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtML.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống mã lớp.", "", MessageBoxButtons.OK);
                txtML.Focus();
            }

            else if (txtTL.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống tên lớp.", "", MessageBoxButtons.OK);
                txtTL.Focus();
            }

            else if (txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống mã khoa.", "", MessageBoxButtons.OK);
                txtMK.Focus();
            }

            else
            {
                try
                {
                    bdsLOP.EndEdit();
                    bdsLOP.ResetCurrentItem();
                    if (dS.HasChanges())
                    {
                        this.lOPTableAdapter.Update(this.dS.LOP);
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("already present") || ex.Message.Contains("PRIMARY"))
                    {
                        MessageBox.Show("Mã lớp bị trùng.", "", MessageBoxButtons.OK);
                        btnPhucHoi.Enabled = false;
                        txtML.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi ghi lớp. Bạn kiểm tra lại thông tin lớp trước khi ghi." + ex.Message, "", MessageBoxButtons.OK);
                        btnPhucHoi.Enabled = false;
                        return;
                    }

                }
                btnGhi.Enabled = false; btnPhucHoi.Enabled = false;
                btnThem.Enabled = true; btnSua.Enabled = true; btnXoa.Enabled = true;
                btnRefresh.Enabled = true;
                btnThoat.Enabled = true; gcLOP.Enabled = true;
            }

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSINHVIEN.Count > 0)
            {
                MessageBox.Show("Lớp đã có sinh viên không thể xóa.", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsLOP.RemoveCurrent();
                    this.lOPTableAdapter.Update(this.dS.LOP);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi xóa lớp.", "", MessageBoxButtons.OK);

                }
            }
            btnThem.Enabled = true;
            btnPhucHoi.Enabled = false;
            if (bdsLOP.Count == 0)
                btnXoa.Enabled = false;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = true; btnSua.Enabled = true; btnXoa.Enabled = true;
            btnThoat.Enabled = true;
            btnGhi.Enabled = false; btnPhucHoi.Enabled = false; btnRefresh.Enabled = true;
            gcLOP.Enabled = true;
            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
        }
    }
}
