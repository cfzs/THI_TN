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
                    MessageBox.Show("Lỗi ghi sinh viên. Bạn kiểm tra lại thông tin trước khi ghi.", "", MessageBoxButtons.OK);

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
            bdsSINHVIEN.CancelEdit();
            bdsSINHVIEN.Position = viTri;
            gcLOP.Enabled = true;
            // groupBox1.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            // btnInDSMH.Enabled = true;
            btnThoat.Enabled = true;
        }
    }
}
