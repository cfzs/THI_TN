using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using TN_CSDLPT;

namespace THI_TN
{
    public partial class frmThi : Form
    {
        public frmThi()
        {
            InitializeComponent();
        }

        System.Timers.Timer t;
        int m = 3, s = 59;
        private void OntimeEvert(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() => {
                s -= 1;
                if (s == 0)
                {
                    s = 59;
                    m -= 1;

                }
                else if (m == 0 && s == 1)
                {
                    t.Stop();
                    cmbTenMH.Enabled = false;

                }
                txtTime.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }

        private void frmThi_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.DSLOP' table. You can move, or remove it, as needed.
            this.dSLOPTableAdapter.Fill(this.dS.DSLOP);
            // TODO: This line of code loads data into the 'dS.GETDSMH' table. You can move, or remove it, as needed.
            this.gETDSMHTableAdapter.Fill(this.dS.GETDSMH);
            // TODO: This line of code loads data into the 'dS.DS_SV' table. You can move, or remove it, as needed.
            this.dS_SVTableAdapter.Fill(this.dS.DS_SV);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            //dS.EnforceConstraints = true;

            t = new System.Timers.Timer();
            t.Interval = 1000; //1000 = 1s
            t.Elapsed += OntimeEvert;
            m = FormChuanBiThi.m - 1;
            t.Start();

        }

        private void mAMHComboBox_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //dt = Program.ExecSqlDataTable("SELECT * FROM KHOA");

            //Set tay
            Program.conn.ConnectionString = "Data Source=Quang-PC\\SRV2;Initial Catalog=THI_TN;Persist Security Info=True;User ID=KieuThien;Password=123456";
            Program.conn.Open();
            dt = Program.ExecSqlDataTable("SELECT MAMH, TENMH FROM MONHOC WHERE MALOP = '" + cmbMaLop.SelectedValue +"'");

            cmbTenMH.DataSource = dt;
            cmbTenMH.ValueMember = "MAMH";
            cmbTenMH.DisplayMember = "TENMH";

        }
    }
}
