using DevExpress.XtraReports.UI;
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
    public partial class frm_GT_KetQuaThi : Form
    {
        public frm_GT_KetQuaThi()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIEN_DANGKYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frm_GT_KetQuaThi_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.DS_SV' table. You can move, or remove it, as needed.
            this.dS_SVTableAdapter.Fill(this.dS.DS_SV);
            // TODO: This line of code loads data into the 'dS.GETDSMH' table. You can move, or remove it, as needed.
            this.gETDSMHTableAdapter.Fill(this.dS.GETDSMH);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

        }

        private void btnXULY_Click(object sender, EventArgs e)
        {
            string malop =txtML.Text.Trim();
            string mamh = txtMMH.Text.Trim();
            string masv = txtMSV.Text.Trim();
            string TD = txtTD.Text.Trim();

            frmKetQuaThi rpt = new frmKetQuaThi(malop, mamh, masv, TD);

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
