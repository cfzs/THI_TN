using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.ComponentModel.DataAnnotations;

namespace THI_TN
{
    public partial class frmKhoa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int viTri = 0;
        
        public frmKhoa()
        {
            InitializeComponent();
         //   gridControl.DataSource = GetDataSource();
            BindingList<Customer> dataSource = GetDataSource();
         //   gridControl.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
         //   gridControl.ShowRibbonPrintPreview();
        }
        public BindingList<Customer> GetDataSource()
        {
            BindingList<Customer> result = new BindingList<Customer>();
            result.Add(new Customer()
            {
                ID = 1,
                Name = "ACME",
                Address = "2525 E El Segundo Blvd",
                City = "El Segundo",
                State = "CA",
                ZipCode = "90245",
                Phone = "(310) 536-0611"
            });
            result.Add(new Customer()
            {
                ID = 2,
                Name = "Electronics Depot",
                Address = "2455 Paces Ferry Road NW",
                City = "Atlanta",
                State = "GA",
                ZipCode = "30339",
                Phone = "(800) 595-3232"
            });
            return result;
        }
        public class Customer
        {
            [Key, Display(AutoGenerateField = false)]
            public int ID { get; set; }
            [Required]
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            [Display(Name = "Zip Code")]
            public string ZipCode { get; set; }
            public string Phone { get; set; }
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKHOA.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.COSO' table. You can move, or remove it, as needed.
            this.cOSOTableAdapter.Fill(this.dS.COSO);
            Program.mCoso = 1;
            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.dS.KHOA);

        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            // txtMCS.Enabled = true;
            
            txtTK.Enabled = true;
            txtMK.Enabled = true;
            
            viTri = bdsKHOA.Position;
            gcKHOA.Enabled = false;
            bdsKHOA.AddNew();

            this.txtMCS.Text = "CS1";
            btnThem.Enabled = false; btnSua.Enabled = false; btnXoa.Enabled = false;
             btnThoat.Enabled = false;
            btnGhi.Enabled = true; btnPhucHoi.Enabled = true; btnPhucHoi.Enabled = true;
            txtMCS.Focus();

        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnThem.Enabled = false; btnSua.Enabled = false; btnXoa.Enabled = false;
             btnThoat.Enabled = false;
            btnGhi.Enabled = true; btnPhucHoi.Enabled = true; btnPhucHoi.Enabled = true;
            txtMK.Enabled = true;
            txtTK.Enabled = true;

            gcKHOA.Enabled = false;
            viTri = bdsKHOA.Position;
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa khoa này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsKHOA.RemoveCurrent();
                    this.kHOATableAdapter.Update(this.dS.KHOA);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi xóa khoa.", "", MessageBoxButtons.OK);

                }
            }
            if (bdsKHOA.Count == 0)
                btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtTK.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống tên khoa.", "", MessageBoxButtons.OK);
                txtTK.Focus();
            }

            if (txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống mã khoa.", "", MessageBoxButtons.OK);
                txtMK.Focus();
            }
            try
            {
                bdsKHOA.EndEdit();//đẩy về csdl
                bdsKHOA.ResetCurrentItem();
                if (dS.HasChanges())
                {
                    this.kHOATableAdapter.Update(this.dS.KHOA);//đẩy về sql
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY"))
                {
                    MessageBox.Show("Mã khoa bị trùng.", "", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Lỗi ghi khoa. Bạn kiểm tra lại thông tin trước khi ghi.", "", MessageBoxButtons.OK);

            }
            btnGhi.Enabled = false; btnPhucHoi.Enabled = false; 
            btnThem.Enabled = true; btnSua.Enabled = true; btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnThoat.Enabled = true; gcKHOA.Enabled = true;

        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            bdsKHOA.CancelEdit();
            bdsKHOA.Position = viTri;
            gcKHOA.Enabled = true;
           // groupBox1.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
           // btnInDSMH.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            bdsKHOA.CancelEdit();
            bdsKHOA.Position = viTri;
            gcKHOA.Enabled = true;
            // groupBox1.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            // btnInDSMH.Enabled = true;
            btnThoat.Enabled = true;
        }
    }
}