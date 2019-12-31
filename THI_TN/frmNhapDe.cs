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
    public partial class frmNhapDe : Form
    {
        private int viTri = 0;

        public frmNhapDe()
        {
            InitializeComponent();
        }

        private void frmNhapDe_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.bODETableAdapter.Fill(this.dS.BODE);
            this.cTBTTableAdapter.Fill(this.dS.CTBT);
            this.gETDSGVTableAdapter.Fill(this.dS.GETDSGV);
            this.gETDSMHTableAdapter.Fill(this.dS.GETDSMH);
            //dS.EnforceConstraints = true;

            btnGhi.Enabled = false;
            btnPhucHoi.Enabled = false;
            groupBox1.Enabled = false;
            //btnPhucHoi.Enabled = false;
            if (bdsBD.Count == 0)
                btnXoa.Enabled = false;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsBD.Position;
            groupBox1.Enabled = true;
            gcBD.Enabled = false;
            bdsBD.AddNew();
            object maxCauHoi;
            maxCauHoi = dS.BODE.Compute("Max(CAUHOI)", "");
            txtCauHoi.Text = (int.Parse(maxCauHoi.ToString()) + 1).ToString();
            btnThem.Enabled = false; btnSua.Enabled = false; btnXoa.Enabled = false;
            btnInDSBD.Enabled = false; btnThoat.Enabled = false;
            btnGhi.Enabled = true; btnPhucHoi.Enabled = true; btnRefresh.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = false; btnSua.Enabled = false; btnXoa.Enabled = false;
            btnInDSBD.Enabled = false; btnThoat.Enabled = false;
            btnGhi.Enabled = true; btnPhucHoi.Enabled = true; btnRefresh.Enabled = true;
            groupBox1.Enabled = true;
           gcBD.Enabled = false;
            viTri = bdsBD.Position;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTBT.Count > 0)
            {
                MessageBox.Show("Môn học đã có bộ đề.", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsBD.RemoveCurrent();
                    this.bODETableAdapter.Update(this.dS.BODE);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi xóa lớp.", "", MessageBoxButtons.OK);

                }
            }
            btnThem.Enabled = true;
            btnPhucHoi.Enabled = false;
            if (bdsBD.Count == 0)
                btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cmbTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống tên môn học.", "", MessageBoxButtons.OK);
                cmbTenMH.Focus();
            }

            else if (txtNoiDung.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống nội dung.", "", MessageBoxButtons.OK);
                txtNoiDung.Focus();
            }
            else if (txtA.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống câu trả lời.", "", MessageBoxButtons.OK);
                txtA.Focus();
            }
            else if (txtB.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống câu trả lời.", "", MessageBoxButtons.OK);
                txtB.Focus();
            }
            else if (txtC.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống câu trả lời.", "", MessageBoxButtons.OK);
                txtC.Focus();
            }
            else if (txtD.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống câu trả lời.", "", MessageBoxButtons.OK);
                txtD.Focus();
            }

            else if (cmbDapAn.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống đáp án.", "", MessageBoxButtons.OK);
                cmbDapAn.Focus();
            }
            else if (cmbTenGV.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống tên giáo viên.", "", MessageBoxButtons.OK);
                cmbTenGV.Focus();
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
                        cmbTenMH.Focus();
                        return;
                    }
                    else if(ex.Message.Contains("String or binary"))
                    {
                        MessageBox.Show("Trình độ và đáp án chỉ được nhập 1 kí tự.", "", MessageBoxButtons.OK);
                        btnPhucHoi.Enabled = false;
                        if (cmbTrinhDo.SelectedValue.ToString().Length > 1)
                            cmbTrinhDo.Focus();
                        if (cmbDapAn.SelectedValue.ToString().Length > 1)
                            cmbDapAn.Focus();
                        return;
                    }
                    else if (ex.Message.Contains("CHECK"))
                    {
                        MessageBox.Show("Trình độ chỉ được nhập 1 kí tự (A,B,C)." +
                            "\nĐáp án chỉ được nhập 1 kí tự (A,B,C,D)", "", MessageBoxButtons.OK);
                        btnPhucHoi.Enabled = false;
                        if (cmbTrinhDo.SelectedValue.ToString().Length > 1)
                            cmbTrinhDo.Focus();
                        if (cmbDapAn.SelectedValue.ToString().Length > 1)
                            cmbDapAn.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);

                        MessageBox.Show("Lỗi ghi lớp. Bạn kiểm tra lại thông tin lớp trước khi ghi.", "", MessageBoxButtons.OK);
                        btnPhucHoi.Enabled = false;
                        return;
                    }

                }
                btnGhi.Enabled = false; btnPhucHoi.Enabled = false; groupBox1.Enabled = false;
                btnThem.Enabled = true; btnSua.Enabled = true; btnXoa.Enabled = true;
                btnRefresh.Enabled = true;
                btnInDSBD.Enabled = true; btnThoat.Enabled = true;gcBD.Enabled = true;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsBD.CancelEdit();
            bdsBD.Position = viTri;
           gcBD.Enabled = true;
            groupBox1.Enabled = false;
            btnGhi.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = false;
            btnInDSBD.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = true; btnSua.Enabled = true; btnXoa.Enabled = true;
            btnInDSBD.Enabled = true; btnThoat.Enabled = true;
            btnGhi.Enabled = false; btnPhucHoi.Enabled = false; btnRefresh.Enabled = true;
           gcBD.Enabled = true; groupBox1.Enabled = false;
            dS.EnforceConstraints = false;
            this.bODETableAdapter.Fill(this.dS.BODE);
            this.cTBTTableAdapter.Fill(this.dS.CTBT);
            //dS.EnforceConstraints = true;
        }

        private void btnInDSBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cmbTrinhDo_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //dt = Program.ExecSqlDataTable("SELECT * FROM KHOA");

            //Set tay
            Program.conn.ConnectionString = "Data Source=Quang-PC\\SRV2;Initial Catalog=THI_TN;Persist Security Info=True;User ID=KieuThien;Password=123456";
            Program.conn.Open();
            dt = Program.ExecSqlDataTable("SELECT DISTINCT TRINHDO FROM BODE");

            cmbTrinhDo.DataSource = dt;
            cmbTrinhDo.ValueMember = "TRINHDO";
        }

        private void cmbDapAn_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //dt = Program.ExecSqlDataTable("SELECT * FROM KHOA");

            //Set tay
            Program.conn.ConnectionString = "Data Source=Quang-PC\\SRV2;Initial Catalog=THI_TN;Persist Security Info=True;User ID=KieuThien;Password=123456";
            Program.conn.Open();
            dt = Program.ExecSqlDataTable("SELECT DISTINCT DAP_AN FROM BODE");

            cmbDapAn.DataSource = dt;
            cmbDapAn.ValueMember = "DAP_AN";

        }

       
    }
}
