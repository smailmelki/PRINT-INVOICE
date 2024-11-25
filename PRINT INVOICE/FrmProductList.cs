using System;
using System.Linq;
using System.Windows.Forms;

namespace PRINT_INVOICE
{
    public partial class FrmProductList : Form
    {
        public FrmProductList()
        {
            InitializeComponent();
        }
        DAL.DBContext db = new DAL.DBContext();
        DAL.products product;
        private void FrmProductList_Load(object sender, EventArgs e)
        {
            FillData();
            dataGridView1.Columns[nameof(product.id)].Visible = false;
            dataGridView1.Columns[nameof(product.code)].HeaderText = "كود الصنف";
            dataGridView1.Columns[nameof(product.productName)].HeaderText = "اسم الصنف";
            dataGridView1.Columns[nameof(product.BuyPrice)].Visible = false;
            dataGridView1.Columns[nameof(product.SalePrice)].HeaderText = "سعر الصنف";
            dataGridView1.Columns[nameof(product.IsActive)].HeaderText = "متوفر";
        }
        public void FillData()
        {
            dataGridView1.DataSource = Util.products.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmProduct frm = new FrmProduct();
            frm.ShowDialog();
            FillData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                FrmProduct frm = new FrmProduct(product);
                frm.ShowDialog();
                dataGridView1.DataSource = Util.products.ToList();
            }
            else
            {
                MessageBox.Show("اختر عنصرا لتعديله");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1 && product != null)
            {
                DialogResult result = MessageBox.Show($"هل تريد حذف {product.productName} ؟", "حذف", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    db.products.Remove(db.products.Find(product.id));
                    db.SaveChanges();
                    Util.products.Remove(product);
                    dataGridView1.DataSource = Util.products.ToList();
                }
            }
            else
            {
                MessageBox.Show("اختر احد العناصر لحذفه", "تنبيه", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                product = dataGridView1.CurrentRow.DataBoundItem as DAL.products;
            }
        }
    }
}
