using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace THI_TN
{
    public partial class frmKetQuaThi : DevExpress.XtraReports.UI.XtraReport
    {
        public frmKetQuaThi(string malop ,string mamh ,string masv,string TD )
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_REPORT1TableAdapter.Fill(ds1.SP_REPORT1, malop, mamh, masv, TD);
        }

    }
}
