using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using THI_TN;

namespace TN_CSDLPT
{
    public partial class FormChuanBiThi : Form
    {
        public static DateTime ngay;
        public static List<DSCauHoi> ds;
        public static int socauhoi, thoigian, lan, m, diem = 0, lanthi;
        String TrinhDo;
        public static String tenMH, tenLop, MaMH;


        public List<DSCauHoi> DsCauHoi(int socauthi, String Trinhdo, String MaMH)
        {
            var a = new List<DSCauHoi>();
            DataTable dt;

            String strLenh = "EXEC SP_LAYCAUHOI '" + socauthi + "','" + Trinhdo + "','" + MaMH + "'";
            dt = Program.ExecSqlDataTable(strLenh);
            if (dt == null) return null;

            List<DSCauHoi> listCauHoi = dt.AsEnumerable().Select(m => new DSCauHoi()
            {
                CauHoi = m.Field<int>("CAUHOI"),
                MaMH = m.Field<string>("MAMH"),
                TrinhDo = m.Field<string>("TRINHDO"),
                NoiDung = m.Field<string>("NOIDUNG"),
                A = m.Field<string>("A"),
                B = m.Field<string>("B"),
                C = m.Field<string>("C"),
                D = m.Field<string>("D"),
                DAPAN = m.Field<string>("DAP_AN"),
                MAGV = m.Field<string>("MAGV"),
            }).ToList();
            return listCauHoi;
        }
        private void cbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (frmDangNhap.co == 0)
            {
                btnBatDau.Visible = false;
                SqlDataReader a;
                SqlDataReader myReader;
                
                SqlDataAdapter da = new SqlDataAdapter("select MONHOC.MAMH,MONHOC.TENMH from MONHOC,GIAOVIEN_DANGKY where GIAOVIEN_DANGKY.MALOP = '" + Program.mLop + "' and MONHOC.MAMH = GIAOVIEN_DANGKY.MAMH ", Program.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbMaMH.DataSource = dt;
                cbMaMH.ValueMember = "MAMH";
                cbMaMH.DisplayMember = "TENMH";
                

                String strLenh = "EXEC SP_KIEMTRATHI '" + Program.mLop.Trim() + "','" + cbMaMH.SelectedValue.ToString().Trim() + "','" + Program.username.Trim() + "'";
                a = Program.ExecSqlDataReader(strLenh);
                a.Read();
                int kq = a.GetInt32(0);
                a.Close();
                lanthi = kq;
                if (kq == 0)
                {
                    btnBatDau.Visible = false;
                    // labelLanThi.Text = "Môn " + cbMaMH.Text.ToString().Trim() + " không có tổ chức thi";
                    comboLan.Visible = false;
                }
                else if (kq == 1)
                {
                    // labelLanThi.Visible = false;
                    comboLan.Visible = true;
                    comboLan.Items.Clear();
                    comboLan.Items.Add(1);
                }
                else if (kq == 2)
                {
                    comboLan.Items.Clear();
                    //labelLanThi.Text = "Bạn đã thi xong môn " + cbMaMH.Text.ToString().Trim();
                }
                else if (kq == 3)
                {
                    // labelLanThi.Visible = false;
                    comboLan.Visible = true;
                    comboLan.Items.Clear();
                    comboLan.Items.Add(2);
                }
                else if (kq == 4)
                {
                    comboLan.Items.Clear();
                    //labelLanThi.Text = "Bạn đã thi xong môn " + cbMaMH.Text.ToString().Trim();
                }
                else
                {
                    comboLan.Items.Clear();
                    comboLan.Items.Add(1);
                }
            }
        }

        private void comboLan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (frmDangNhap.co == 0)
            {
                SqlDataAdapter da = new SqlDataAdapter("select LAN from GIAOVIEN_DANGKY where GIAOVIEN_DANGKY.MALOP = '" + Program.mLop + "'", Program.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboLan.DataSource = dt;
                comboLan.ValueMember = "LAN";
                //cbMaMH.DisplayMember = "TENMH";
                //MessageBox.Show(cbMaMH.SelectedValue.ToString().Trim() + "->Toi Day");


                SqlDataReader myReader;
                tenMH = cbMaMH.Text.ToString().Trim();
                String strLenh = "select NGAYTHI, TRINHDO from GIAOVIEN_DANGKY where MALOP = '" + Program.mLop + "'  and LAN = '" + comboLan.SelectedValue.ToString().Trim() + "' and MAMH = '" + cbMaMH.SelectedValue.ToString().Trim() + "'";
                myReader = Program.ExecSqlDataReader(strLenh);
                myReader.Read();
                ngay = myReader.GetDateTime(0);
                TrinhDo = myReader.GetString(1);
                DateTime time = DateTime.Now;
                String t1 = ngay.ToString("MM/dd/yyyy");
                String t2 = time.ToString("MM/dd/yyyy");
                ngay = DateTime.Parse(t1);
                time = DateTime.Parse(t2);
                Program.conn.Close();
                if (DateTime.Compare(time, ngay) < 0)
                {
                    btnBatDau.Visible = false;
                    labelThongBao.Text = "(Chưa tới ngày thi)";
                }
                else if (DateTime.Compare(time, ngay) > 0)
                {
                    btnBatDau.Visible = false;
                    labelThongBao.Text = "(Đã qua ngày thi)";
                }
                else
                {
                    btnBatDau.Visible = true;
                    labelThongBao.Text = "";
                }
            }
        }
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            SqlDataReader myReader;
            String strLenh;

            if (frmDangNhap.co == 0)
            {
                tenMH = cbMaMH.Text.ToString().Trim();
                strLenh = "select SOCAUTHI,TRINHDO,MAMH,THOIGIAN,LAN,NGAYTHI from GIAOVIEN_DANGKY where MALOP = '" + Program.mLop.Trim() + "'  and LAN = '" + comboLan.SelectedValue.ToString().Trim() + "' and TRINHDO = '" + TrinhDo + "' and MAMH = '" + cbMaMH.SelectedValue.ToString().Trim() + "'";
                myReader = Program.ExecSqlDataReader(strLenh);
                myReader.Read();
                socauhoi = myReader.GetInt16(0);
                TrinhDo = myReader.GetString(1);
                MaMH = myReader.GetString(2);
                thoigian = myReader.GetInt16(3);
                lan = myReader.GetInt16(4);
                ngay = myReader.GetDateTime(5);
                Program.conn.Close();
                m = thoigian;
            }
            else if (frmDangNhap.co == 1)
            {
                tenMH = cbMaMH.Text.ToString().Trim();
                tenLop = cbLop.Text.ToString().Trim();
                strLenh = "select SOCAUTHI,TRINHDO,MAMH,THOIGIAN,LAN from GIAOVIEN_DANGKY where MALOP = '" + cbLop.SelectedValue.ToString().Trim() + "'and MAGV ='" + Program.username + "'and LAN = '" + comboLan.Text.ToString().Trim() + "'and MAMH = '" + cbMaMH.SelectedValue.ToString().Trim() + "' and TRINHDO = '" + cbTrinhDo.Text.Trim() + "'";
                myReader = Program.ExecSqlDataReader(strLenh);
                myReader.Read();
                socauhoi = myReader.GetInt16(0);
                TrinhDo = myReader.GetString(1);
                MaMH = myReader.GetString(2);
                thoigian = myReader.GetInt16(3);
                lan = myReader.GetInt16(4);

                Program.conn.Close();
                m = thoigian;
            }




            ds = new List<DSCauHoi>();
            ds = DsCauHoi(socauhoi, TrinhDo, MaMH);
            //this.Close();
            FormBatDauThi f = new FormBatDauThi();
            if (frmDangNhap.co == 0)
            {
                f.Show();
            }
            else 
                f.ShowDialog();
           
        }

        public FormChuanBiThi()
        {
            InitializeComponent();
        }

        
        
        public void LoadDataToComboBoxLop()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select MALOP,TENLOP from LOP", Program.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbLop.DataSource = dt;
                cbLop.ValueMember = "MALOP";
                cbLop.DisplayMember = "TENLOP";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void LoadDataToComboBoxMon()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select MAMH,TENMH from MONHOC", Program.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbMaMH.DataSource = dt;
                cbMaMH.ValueMember = "MAMH";
                cbMaMH.DisplayMember = "TENMH";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void LoadDataToComBoxMonThi()
        {
            try
            {


                SqlDataAdapter da = new SqlDataAdapter("select MONHOC.MAMH,MONHOC.TENMH from MONHOC,GIAOVIEN_DANGKY where GIAOVIEN_DANGKY.MALOP = '" + Program.mLop + "' and MONHOC.MAMH = GIAOVIEN_DANGKY.MAMH ", Program.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbMaMH.DataSource = dt;
                cbMaMH.ValueMember = "MAMH";
                cbMaMH.DisplayMember = "TENMH";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void LoadDataToComboBoxLan()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select DISTINCT LAN from GIAOVIEN_DANGKY", Program.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboLan.DataSource = dt;
                cbMaMH.ValueMember = "MAMH";
                comboLan.DisplayMember = "LAN";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void LoadDataToComboBoxTrinhDo()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select DISTINCT TRINHDO from GIAOVIEN_DANGKY", Program.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbTrinhDo.DataSource = dt;
                cbMaMH.ValueMember = "MAMH";
                cbTrinhDo.DisplayMember = "TRINHDO";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void FormChuanBiThi_Load(object sender, EventArgs e)
        {
            //Set tay
            //Program.conn.ConnectionString = "Data Source=Quang-PC\\SRV2;Initial Catalog=THI_TN;Persist Security Info=True;User ID=KieuThien;Password=123456";
            //Program.conn.Open();
            // LoadDataToComboBoxLop();
            //LoadDataToComboBoxMon();
            // LoadDataToComboBoxLan();
            //LoadDataToComboBoxTrinhDo();
            int i= frmDangNhap.co;
            MessageBox.Show("KQ = " + i);
            if (frmDangNhap.co == 0)
            {
                LoadDataToComboBoxLop();
                LoadDataToComBoxMonThi();
                //LoadDataToComboBoxMon();
                LoadDataToComboBoxLan();
                LoadDataToComboBoxTrinhDo();
                //comboLan.Visible = false;
                cbTrinhDo.Visible = false;
                label3.Visible = false;
                labelLanThi.Visible = true;
                lbLop.Visible = false;
                cbLop.Visible = false;

            }
            else if (frmDangNhap.co == 1)
            {
                LoadDataToComboBoxLop();
                LoadDataToComboBoxMon();
                LoadDataToComboBoxLan();
                LoadDataToComboBoxTrinhDo();
                comboLan.Visible = true;
                labelLanThi.Visible = false;
                lbLop.Visible = true;
                cbLop.Visible = true;

            }
        }

                           
    }
}
