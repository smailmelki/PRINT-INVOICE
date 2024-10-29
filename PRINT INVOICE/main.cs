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
        }

        private void main_Load(object sender, EventArgs e)
        {
            Util.products = db.products.ToList();
            Util.CustAndVends = db.CustAndVends.ToList();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            FrmProductList frm = new FrmProductList();
            frm.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            FrmInvoice frm = new FrmInvoice(InvoiceType.Sales);
            frm.Show();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            FrmInvoice frm = new FrmInvoice(InvoiceType.purchase);
            frm.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FrmCustAndVend frm = new FrmCustAndVend(PartType.Customer);
            frm.Show();
        }

        private void btnbtnVendor_Click(object sender, EventArgs e)
        {
            FrmCustAndVend frm = new FrmCustAndVend(PartType.Vendor);
            frm.Show();
        }

        private void btnbelList_Click(object sender, EventArgs e)
        {
            FrmFactList frm = new FrmFactList();
            frm.Show();
        }
    }
}
