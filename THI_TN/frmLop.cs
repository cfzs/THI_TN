using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THI_TN
{
    public partial class frmLop : Form
    {
        private int viTri = 0;

        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            //this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            //this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            //dS.EnforceConstraints = true;


            btnGhi.Enabled = false;
            btnPhucHoi.Enabled = false;
            groupBox1.Enabled = false;
            //btnPhucHoi.Enabled = false;
            if (bdsL.Count == 0)
                btnXoa.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsL.Position;
            groupBox1.Enabled = true;
            gcL.Enabled = false;
            bdsL.AddNew();
            btnThem.Enabled = false; btnSua.Enabled = false; btnXoa.Enabled = false;
            btnInDSMH.Enabled = false; btnThoat.Enabled = false;
            btnGhi.Enabled = true; btnPhucHoi.Enabled = true; btnRefresh.Enabled = true;
            txtMaLop.Focus();
            
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = false; btnSua.Enabled = false; btnXoa.Enabled = false;
            btnInDSMH.Enabled = false; btnThoat.Enabled = false;
            btnGhi.Enabled = true; btnPhucHoi.Enabled = true; btnRefresh.Enabled = true;
            groupBox1.Enabled = true;
            gcL.Enabled = false;
            viTri = bdsL.Position;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSV.Count > 0)
            {
                MessageBox.Show("Môn học đã có bộ đề.", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsL.RemoveCurrent();
                    this.lOPTableAdapter.Update(this.dS.LOP);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi xóa lớp.", "", MessageBoxButtons.OK);

                }
            }
            btnThem.Enabled = true;
            btnPhucHoi.Enabled = false;
            if (bdsL.Count == 0)
                btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống mã lớp.", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
            }

            else if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống tên lớp.", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
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
                bdsL.EndEdit();
                bdsL.ResetCurrentItem();
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
                        txtMaLop.Focus();
                        return;
                    }
                else
                    {
                        MessageBox.Show("Lỗi ghi lớp. Bạn kiểm tra lại thông tin lớp trước khi ghi.", "", MessageBoxButtons.OK);
                        btnPhucHoi.Enabled = false;
                        return;
                    }

                }
            btnGhi.Enabled = false; btnPhucHoi.Enabled = false; groupBox1.Enabled = false;
            btnThem.Enabled = true; btnSua.Enabled = true; btnXoa.Enabled = true;
            btnRefresh.Enabled = true;
            btnInDSMH.Enabled = true; btnThoat.Enabled = true; gcL.Enabled = true;
            }

            
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsL.CancelEdit();
            bdsL.Position = viTri;
            gcL.Enabled = true;
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
            gcL.Enabled = true; groupBox1.Enabled = false;
            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            //dS.EnforceConstraints = true;



        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }

        private void cmbMaKhoa_DropDown(object sender, EventArgs e)
        {
            int maKhoa = cmbMaKhoa.SelectedIndex;
            DataTable dt = new DataTable();

            //Set tay
            //Program.conn.ConnectionString = "Data Source=Quang-PC\\SRV2;Initial Catalog=THI_TN;Persist Security Info=True;User ID=KieuThien;Password=123456";
            //Program.conn.Open();

            dt = Program.ExecSqlDataTable("SELECT MAKH FROM KHOA");

            cmbMaKhoa.DataSource = dt;
            cmbMaKhoa.ValueMember = "MAKH";

            cmbMaKhoa.SelectedIndex = maKhoa;
        }

        
    }
}
