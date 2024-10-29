using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace PRINT_INVOICE
{
    public partial class FrmProduct : Form
    {
        DAL.DBContext db = new DAL.DBContext();
        DAL.products product;
        public FrmProduct()
        {
            InitializeComponent();
            product = new DAL.products();
        }
        public FrmProduct(DAL.products product)
        {
            InitializeComponent();
            this.product = product;
            getdata();
        }
        private void FrmProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                setdata();
                db.products.AddOrUpdate(product);
                db.SaveChanges();
                Util.products.Remove(Util.products.Where(p => p.id == product.id).FirstOrDefault());
                Util.products.Add(product);
                MessageBox.Show("تمت حفظ العنصر بنجاح");
            }
            catch (Exception)
            {
            }

        }
        void setdata()
        {
            product.code = txtCode.Text;
            product.productName = txtName.Text;
            product.BuyPrice = Convert.ToDecimal(txtBuy.Text);
            product.SalePrice = Convert.ToDecimal(txtSale.Text);
            product.IsActive = chkIsActive.Checked;
        }
        void getdata()
        {
            txtCode.Text = product.code;
            txtName.Text = product.productName;
            txtBuy.Text = product.BuyPrice.ToString();
            txtSale.Text = product.SalePrice.ToString();
            chkIsActive.Checked = product.IsActive;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
