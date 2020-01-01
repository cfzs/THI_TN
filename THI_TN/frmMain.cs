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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnGiaoVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGiaoVien f = new frmGiaoVien();
            f.FormClosed += new FormClosedEventHandler(f_formClosed);
            f.Show();
            this.Hide();
            //Form frm = this.CheckExists(typeof(frmGiaoVien));
            //if (frm != null) frm.Activate();
            //else
            //{
            //    frmGiaoVien f = new frmGiaoVien();
            //    f.MdiParent = this;
            //    f.Show();
            //}
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhoa f = new frmKhoa();
            f.FormClosed += new FormClosedEventHandler(f_formClosed);
            f.Show();
            this.Hide();

        }

        private void f_formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLop f = new frmLop();
            f.FormClosed += new FormClosedEventHandler(f_formClosed);
            f.Show();
            this.Hide();

        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMonHoc f = new frmMonHoc();
            f.FormClosed += new FormClosedEventHandler(f_formClosed);
            f.Show();
            this.Hide();

        }

        private void btnNhapDe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhapDe f = new frmNhapDe();
            f.FormClosed += new FormClosedEventHandler(f_formClosed);
            f.Show();
            this.Hide();
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSV f = new frmSV();
            f.FormClosed += new FormClosedEventHandler(f_formClosed);
            f.Show();
            this.Hide();
        }
    }
}
