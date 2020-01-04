using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using THI_TN;

namespace TN_CSDLPT
{
    public partial class FormBatDauThi : Form
    {
        int i = 0;
        public FormBatDauThi()
        {
            InitializeComponent();
        }

        System.Timers.Timer t;
        int m, s;
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
                    btnDungLai.PerformClick();

                }
                txtTime.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }

        private void FormBatDauThi_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000; //1000 = 1s
            t.Elapsed += OntimeEvert;
            m = FormChuanBiThi.m - 1;
            s = 59;
            t.Start();
            labSoCauHoi.Text = "Câu " + (i + 1);
            labNoiDung.Text = FormChuanBiThi.ds[0].NoiDung.ToString();
            radA.Text = FormChuanBiThi.ds[0].A.ToString();
            radB.Text = FormChuanBiThi.ds[0].B.ToString();
            radC.Text = FormChuanBiThi.ds[0].C.ToString();
            radD.Text = FormChuanBiThi.ds[0].D.ToString();

            for (int i = 0; i < FormChuanBiThi.socauhoi; i++)

            {
                int t = i + 1;
                dgvHoiTraLoi.Rows.Add(t + "", "");
            }
            if (frmDangNhap.co == 0)
            {
                lbMSV.Text = Program.username;
                lbHoTen.Text = Program.mHoten;
                lbLop.Text = Program.mTenLop;
            }
            else if (frmDangNhap.co == 1)
            {
                lbMSV.Text = Program.username;
                lbHoTen.Text = Program.mHoten;
                lbLop.Text = FormChuanBiThi.tenLop;
            }
            lbMonThi.Text = FormChuanBiThi.tenMH;
            lbLan.Text = FormChuanBiThi.lan + "";
        }

        private void btnKeTiep_Click(object sender, EventArgs e)
        {
            resetText();
            if (i == FormChuanBiThi.socauhoi - 1)
            {
                i = -1;
            }
            i++;
            labNoiDung.Text = FormChuanBiThi.ds[i].NoiDung.ToString();
            radA.Text = FormChuanBiThi.ds[i].A.ToString();
            radB.Text = FormChuanBiThi.ds[i].B.ToString();
            radC.Text = FormChuanBiThi.ds[i].C.ToString();
            radD.Text = FormChuanBiThi.ds[i].D.ToString();
            radA.Checked = false;
            radB.Checked = false;
            radC.Checked = false;
            radD.Checked = false;
            labSoCauHoi.Text = "Câu " + (i + 1);

            if (FormChuanBiThi.ds[i].Chon != "")
            {
                if (FormChuanBiThi.ds[i].Chon == "A")
                {
                    radA.Checked = true;

                }
                else if (FormChuanBiThi.ds[i].Chon == "B")
                {
                    radB.Checked = true;

                }
                else if (FormChuanBiThi.ds[i].Chon == "C")
                {
                    radC.Checked = true;

                }
                else if (FormChuanBiThi.ds[i].Chon == "D")
                {
                    radD.Checked = true;

                }
            }
        }

        private void btnLuiLai_Click(object sender, EventArgs e)
        {
            resetText();
            if (i == 0)
            {
                i = FormChuanBiThi.socauhoi;
            }
            i--;
            labSoCauHoi.Text = "Câu " + (i + 1);
            labNoiDung.Text = FormChuanBiThi.ds[i].NoiDung.ToString();
            radA.Text = FormChuanBiThi.ds[i].A.ToString();
            radB.Text = FormChuanBiThi.ds[i].B.ToString();
            radC.Text = FormChuanBiThi.ds[i].C.ToString();
            radD.Text = FormChuanBiThi.ds[i].D.ToString();
            radA.Checked = false;
            radB.Checked = false;
            radC.Checked = false;
            radD.Checked = false;


            if (FormChuanBiThi.ds[i].Chon != "")
            {
                if (FormChuanBiThi.ds[i].Chon == "A")
                {
                    radA.Checked = true;

                }
                else if (FormChuanBiThi.ds[i].Chon == "B")
                {
                    radB.Checked = true;

                }
                else if (FormChuanBiThi.ds[i].Chon == "C")
                {
                    radC.Checked = true;

                }
                else if (FormChuanBiThi.ds[i].Chon == "D")
                {
                    radD.Checked = true;

                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            t.Stop();
            this.Close();
        }

        private void radA_CheckedChanged(object sender, EventArgs e)
        {
            if (radA.Checked)
            {
                FormChuanBiThi.ds[i].Chon = "A";

                dgvHoiTraLoi.Rows[i].Cells[1].Value = FormChuanBiThi.ds[i].Chon;
                //   MessageBox.Show(frmChuanBiThi.ds[i].Chon.ToString(), i + "_");
            }
        }

        private void radB_CheckedChanged(object sender, EventArgs e)
        {
            if (radB.Checked)
            {
                FormChuanBiThi.ds[i].Chon = "B";
                //dgvHoiTraLoi.Rows.Add(i + "", frmChuanBiThi.ds[i].Chon);
                dgvHoiTraLoi.Rows[i].Cells[1].Value = FormChuanBiThi.ds[i].Chon;
                // MessageBox.Show(frmChuanBiThi.ds[i].Chon.ToString(), i + "_");
            }
        }

        private void radC_CheckedChanged(object sender, EventArgs e)
        {

            if (radC.Checked)
            {
                FormChuanBiThi.ds[i].Chon = "C";

                dgvHoiTraLoi.Rows[i].Cells[1].Value = FormChuanBiThi.ds[i].Chon;
                //  MessageBox.Show(frmChuanBiThi.ds[i].Chon.ToString(), i + "_");
            }
        }

        private void radD_CheckedChanged(object sender, EventArgs e)
        {
            if (radD.Checked)
            {
                FormChuanBiThi.ds[i].Chon = "D";

                dgvHoiTraLoi.Rows[i].Cells[1].Value = FormChuanBiThi.ds[i].Chon;
                //  MessageBox.Show(frmChuanBiThi.ds[i].Chon.ToString(), i + "_");
            }
        }

        private void dgvHoiTraLoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            i = index;
            labNoiDung.Text = FormChuanBiThi.ds[i].NoiDung.ToString();
            radA.Text = FormChuanBiThi.ds[i].A.ToString();
            radB.Text = FormChuanBiThi.ds[i].B.ToString();
            radC.Text = FormChuanBiThi.ds[i].C.ToString();
            radD.Text = FormChuanBiThi.ds[i].D.ToString();
            radA.Checked = false;
            radB.Checked = false;
            radC.Checked = false;
            radD.Checked = false;
            labSoCauHoi.Text = "Câu " + (index + 1);
            if (FormChuanBiThi.ds[i].Chon != "")
            {
                if (FormChuanBiThi.ds[i].Chon == "A")
                {
                    radA.Checked = true;

                }
                else if (FormChuanBiThi.ds[i].Chon == "B")
                {
                    radB.Checked = true;

                }
                else if (FormChuanBiThi.ds[i].Chon == "C")
                {
                    radC.Checked = true;

                }
                else if (FormChuanBiThi.ds[i].Chon == "D")
                {
                    radD.Checked = true;

                }
            }
        }

        private void btnDungLai_Click(object sender, EventArgs e)
        {
            t.Stop();
            btnDungLai.Visible = false;
            this.Close();
            float diem = 0;
            float cauDung = 10 / FormChuanBiThi.socauhoi;
            for (int i = 0; i < FormChuanBiThi.socauhoi; i++)
            {
                if (FormChuanBiThi.ds[i].Chon.Equals(FormChuanBiThi.ds[i].DAPAN))
                    diem += cauDung;
            }
            MessageBox.Show("Điểm: " + diem);
            if (frmDangNhap.co == 0)
            {
                String strLenh = "EXEC SP_ThemDiem '" + Program.username + "','"+ FormChuanBiThi.MaMH + "'," + FormChuanBiThi.lan + ",'" + FormChuanBiThi.ngay + "'," + diem + ",null";
                SqlDataReader a;
                a = Program.ExecSqlDataReader(strLenh);
                a.Close();
                for (int i = 0; i < FormChuanBiThi.socauhoi; i++)
                {
                    if (frmDangNhap.co == 0)
                    {
                        strLenh = "EXEC SP_ThemCTBT '" + Program.username + "','" + FormChuanBiThi.MaMH + "'," + FormChuanBiThi.ds[i].CauHoi + "," + FormChuanBiThi.lan + ",'" + FormChuanBiThi.ds[i].Chon + "',null";
                        a = Program.ExecSqlDataReader(strLenh);
                        a.Close();
                    }
                }
            }
            

        }

        public void resetText()
        {
            labSoCauHoi.Text = "";
            labNoiDung.Text = "";
            radA.Text = "";
            radB.Text = "";
            radC.Text = "";
            radD.Text = "";
        }


    }
}
