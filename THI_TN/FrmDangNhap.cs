using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TN_CSDLPT;

namespace THI_TN
{
    public partial class frmDangNhap : Form
    {
        internal static int co = 1 ;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            string chuoiketnoi = "Data Source=DESKTOP-GNVB183\\SERVER1;Initial Catalog=THI_TN;Integrated Security=True";
            Program.conn.ConnectionString = chuoiketnoi;
            Program.conn.Open();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM V_DS_PHANMANH");
            Program.bds_dspm.DataSource = dt;
            cmbCS.DataSource = dt;
            cmbCS.DisplayMember = "TENCS";
            cmbCS.ValueMember = "TENSERVER";
            cmbCS.SelectedIndex = -1;
        }
        
        private void cmbCS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbCS.SelectedValue.ToString();

            }
            catch (Exception) { };
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = txtLogin.Text; Program.password = txtPass.Text;
            if (Program.KetNoi() == 0) return;

            Program.mCoso = cmbCS.SelectedIndex;

            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();


            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);

            if (Program.mGroup.Equals("SinhVien"))
            {
                co = 0;
                FormChuanBiThi f1 = new FormChuanBiThi();
                f1.FormClosed += new FormClosedEventHandler(f_formClosed);
                f1.Show();
                this.Hide();
                Program.myReader.Close();
                Program.conn.Close();
                MessageBox.Show("Nhan vien - Nhom : " + Program.mHoten + " - " + Program.mGroup, "", MessageBoxButtons.OK);


            }
            else
            {
                frmMain f = new frmMain();
                f.FormClosed += new FormClosedEventHandler(f_formClosed);
                f.Show();
                this.Hide();


                Program.myReader.Close();
                Program.conn.Close();
                MessageBox.Show("Nhan vien - Nhom : " + Program.mHoten + " - " + Program.mGroup, "", MessageBoxButtons.OK);


            }


        }

        private void f_formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
