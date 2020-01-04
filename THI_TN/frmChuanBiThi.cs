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
    public partial class frmChuanBiThi : Form
    {
        private int vitri = 0;
        public frmChuanBiThi()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGIAOVIEN_DANGKY.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmChuanBiThi_Load(object sender, EventArgs e)
        {
            Program.conn.ConnectionString = "Data Source=DESKTOP-GNVB183\\SERVER2;Initial Catalog=THI_TN;Persist Security Info=True;User ID=KieuThien;Password=123";
            Program.conn.Open();
            dS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.DSLOP' table. You can move, or remove it, as needed.
            this.dSLOPTableAdapter.Fill(this.dS.DSLOP);
            //dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.GETDSMH' table. You can move, or remove it, as needed.
            this.gETDSMHTableAdapter.Fill(this.dS.GETDSMH);
            // TODO: This line of code loads data into the 'dS.GETDSGV' table. You can move, or remove it, as needed.
            this.gETDSGVTableAdapter.Fill(this.dS.GETDSGV);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cbbMGV.Enabled   = false;
            cbbHT.Enabled = true;
            cbbMMH.Enabled = false;
            cbbTMH.Enabled = true;

            txtL.Enabled = true;
            cbbML.Enabled = false;
            txtNT.Enabled = true;
            txtSCT.Enabled = true;
            txtTD.Enabled = true;
            txtTG.Enabled = true;

            vitri = bdsGIAOVIEN_DANGKY.Position;
            gcGIAOVIEN_DANGKY.Enabled = false;
            bdsGIAOVIEN_DANGKY.AddNew();

            btnThem.Enabled = false; btnSua.Enabled = false; barButtonItem1.Enabled = false;
            btnThoat.Enabled = false;btnGS.Enabled = false;
            btnGhi.Enabled = true; btnPhucHoi.Enabled = true;
            cbbML.Focus();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            //kiểm tra các điều kiện trong sql 
            string tgian = "EXEC sp_KiemTraThoiGianThi " + txtTG.Text.ToString();
            string khoachinh = "EXEC sp_KhoaChinhDangKiThi '" + cbbML.SelectedValue.ToString() + "' ,'" + cbbMMH.SelectedValue.ToString() + "' , " + txtL.Text.ToString();
            string socauthi = "EXEC sp_SoCauThi " + txtSCT.Text.ToString();
            string lanthi = "EXEC sp_LanThi "+txtL.Text.ToString();
            string trinhdo = "EXEC sp_TrinhDo '" + txtTD.Text.ToString()+"'";

            //tgian thi
            Program.myReader = Program.ExecSqlDataReader(tgian);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            int kq1 = Int32.Parse(Program.myReader.GetInt32(0).ToString());
            Program.myReader.Close();

            //khóa chính
            Program.myReader = Program.ExecSqlDataReader(khoachinh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            int kq2 = Int32.Parse(Program.myReader.GetInt32(0).ToString());
            Program.myReader.Close();

            //số câu thi
            Program.myReader = Program.ExecSqlDataReader(socauthi);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            int kq3 = Int32.Parse(Program.myReader.GetInt32(0).ToString());
            Program.myReader.Close();

            //lần thi
            Program.myReader = Program.ExecSqlDataReader(lanthi);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            int kq4 = Int32.Parse(Program.myReader.GetInt32(0).ToString());
            Program.myReader.Close();

            //trinh độ
            Program.myReader = Program.ExecSqlDataReader(trinhdo);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            int kq5 = Int32.Parse(Program.myReader.GetInt32(0).ToString());
            Program.myReader.Close();

            // kt ngày của hệ thống
            DateTime now = DateTime.Now;
            DateTime iDate;
            iDate = txtNT.Value;

            if (cbbML.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống mã lớp.", "", MessageBoxButtons.OK);
                cbbML.Focus();
            }
          else  if (txtTD.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống trình độ.", "", MessageBoxButtons.OK);
                txtTD.Focus();
            }
           else if (txtNT.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống ngày thi .", "", MessageBoxButtons.OK);
                txtNT.Focus();
            }
            else if (DateTime.Compare(now, iDate)==1)
            {
                MessageBox.Show("Ngày chọn thi phải nhỏ hơn ngày hiện tại .", "", MessageBoxButtons.OK);
                txtNT.Focus();
            }
            else if (txtL.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống lần thi.", "", MessageBoxButtons.OK);
                txtL.Focus();
            }
           else if (txtSCT.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống số lượng câu thi.", "", MessageBoxButtons.OK);
                txtSCT.Focus();
            }
           else if (txtTG.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống thời gian thi.", "", MessageBoxButtons.OK);
                txtTG.Focus();
            }

            else if (kq1 ==0)
            {
                MessageBox.Show("Thời gian thi phải lớn hơn 0 hoặc nhỏ hơn bằng 60p");
                txtTG.Focus();
            }
            else if(kq2 ==0)
            {
                MessageBox.Show("Cặp 3 khóa chính bị trùng .Kiểm tra lại.");
                cbbHT.Focus();

            }
            else if (kq3 ==0)
            {
                MessageBox.Show("Số câu thi phải lớn hơn 10 nhỏ hơn 100.");
                txtSCT.Focus();
            }
            else if(kq4 == 0)
            {
                MessageBox.Show("Lần thi chỉ có 1 hoặc 2.", "", MessageBoxButtons.OK);
                txtL.Focus();
            }
            else if(kq5 == 0)
            {
                MessageBox.Show("Chỉ ghi trình độ A(Đại học) hoặc B(Cao đẳng) hoăc C(Trung cấp).", "", MessageBoxButtons.OK);
                txtTD.Focus();
            }
            else
            {
                try
                {
                    bdsGIAOVIEN_DANGKY.EndEdit();
                    bdsGIAOVIEN_DANGKY.ResetCurrentItem();
                    if (dS.HasChanges())
                    {
                        this.gIAOVIEN_DANGKYTableAdapter.Update(this.dS.GIAOVIEN_DANGKY);//đẩy về sql
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("PRIMARY"))
                    {
                        MessageBox.Show("Mã mà cặp 3 khóa chính bị trùng.", "", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Lỗi ghi đăng kí thi. Bạn kiểm tra lại thông tin trước khi ghi." + ex.Message, "", MessageBoxButtons.OK);

                }
            }
          
            btnGhi.Enabled = false; btnPhucHoi.Enabled = false;
            btnThem.Enabled = true;
            btnThoat.Enabled = true; gcGIAOVIEN_DANGKY.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            btnThem.Enabled = true; barButtonItem1.Enabled = true;
            btnThoat.Enabled = true;
            btnGhi.Enabled = false; btnPhucHoi.Enabled = false; btnRefresh.Enabled = true;
            gcGIAOVIEN_DANGKY.Enabled = true; 
            dS.EnforceConstraints = false;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            //this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // kt ngày của hệ thống
            DateTime now = DateTime.Now;
            DateTime iDate;
            iDate = txtNT.Value;
            if (DateTime.Compare(now, iDate) >= 0)
            {
                MessageBox.Show("Đã thi không được sửa .", "", MessageBoxButtons.OK);
                return;
            }
            else {
                btnThem.Enabled = false; btnSua.Enabled = false;
                btnThoat.Enabled = false;
                btnGhi.Enabled = true; btnRefresh.Enabled = true;
                btnGS.Enabled = true;
                gcGIAOVIEN_DANGKY.Enabled = true;
                vitri = bdsGIAOVIEN_DANGKY.Position;
            }
           
        }

        private void dSLOPBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtL_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
               // bdsGIAOVIEN_DANGKY.RemoveCurrent();
                bdsGIAOVIEN_DANGKY.EndEdit();
                bdsGIAOVIEN_DANGKY.ResetCurrentItem();
                if (dS.HasChanges())
                {
                    this.gIAOVIEN_DANGKYTableAdapter.Update(this.dS.GIAOVIEN_DANGKY);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đăng kí thi. Bạn kiểm tra lại thông tin trước khi ghi." + ex.Message, "", MessageBoxButtons.OK);
            }

         
        }
    }
 }

