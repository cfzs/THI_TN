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
        public frmNhapDe()
        {
            InitializeComponent();
        }

        private void frmNhapDe_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Fill(this.dS.BODE);
            //dS.EnforceConstraints = true;

        }


    }
}
