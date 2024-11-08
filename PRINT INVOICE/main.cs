using PRINT_INVOICE.DAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PRINT_INVOICE
{
    public partial class main : Form
    {
        DBContext db = new DBContext();
        public main()
        {
            InitializeComponent();
            lblUserName.Text = Util.UserName;
            this.Cursor = Cursors.Default;
        }

        private void main_Load(object sender, EventArgs e)
        {
            Util.products = db.products.ToList();
            Util.CustAndVends = db.CustAndVends.ToList();
        }

        void OpenFormes(Form frm)
        {
            pnlContainer.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            pnlContainer.Controls.Add(frm);
        }
        private void btnItem_Click(object sender, EventArgs e)
        {
            FrmProductList frm = new FrmProductList();
            OpenFormes(frm);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            FrmInvoice frm = new FrmInvoice(InvoiceType.Sales);
            OpenFormes(frm);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            FrmInvoice frm = new FrmInvoice(InvoiceType.purchase);
            OpenFormes(frm);
        }


        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[nameof(FrmCustAndVend)] == null)
            {
                FrmCustAndVend frm = new FrmCustAndVend(PartType.Customer, this);
                frm.Show();
            }
        }

        private void btnbtnVendor_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[nameof(FrmCustAndVend)] == null)
            {
                FrmCustAndVend frm = new FrmCustAndVend(PartType.Vendor, this);
                frm.Show();
            }
        }

        private void btnbelList_Click(object sender, EventArgs e)
        {
            FrmFactList frm = new FrmFactList();
            OpenFormes(frm);
        }

        private void btnCollebs_Click(object sender, EventArgs e)
        {
            if (PnlMainIcon.Width > 200)
            {
                PnlMainIcon.Width = 80;
                lblUserName.Visible= false;
                LogoPictor.Visible = false;
            }
            else
            {
                PnlMainIcon.Width = 230;
                lblUserName.Visible = true;
                LogoPictor.Visible = true;
            }
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
