using PRINT_INVOICE.DAL;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PRINT_INVOICE
{
    public partial class FrmCustAndVend : Form
    {
        DBContext db = new DBContext();
        DAL.CustAndVend CustAndVend;
        PartType type;
        int ID;
        public FrmCustAndVend(PartType Type)
        {
            InitializeComponent();
            this.type = Type;
            FillDGV();
        }

        void FillDGV()
        {
            dgvCustAndVend.DataSource = Util.CustAndVends.Where(t => t.PartType == type).ToList();
            dgvCustAndVend.Columns["ID"].Visible = false;
            dgvCustAndVend.Columns["Name"].HeaderText = "الاسم";
            dgvCustAndVend.Columns["Phone"].HeaderText = "الهاتف";
            dgvCustAndVend.Columns["Address"].HeaderText = "العنوان";
            dgvCustAndVend.Columns["PartType"].Visible = false;
        }
        private void FrmCustAndVend_Load(object sender, EventArgs e)
        {
            dgvCustAndVend.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddCustOrVend frm = new FrmAddCustOrVend(type);
            frm.ShowDialog();
            dgvCustAndVend.DataSource = Util.CustAndVends.Where(t => t.PartType == type).ToList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCustAndVend.SelectedRows.Count ==1)
            {
                ID = (int)dgvCustAndVend.CurrentRow.Cells[0].Value;
                FrmAddCustOrVend frm = new FrmAddCustOrVend(ID);
                frm.ShowDialog();
                dgvCustAndVend.DataSource = Util.CustAndVends.Where(t => t.PartType == type).ToList();
            }
            else
            {
                MessageBox.Show("اختر احد المتعاملين لتعديله", "تنبيه", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustAndVend.SelectedRows.Count == 1 && CustAndVend != null)
            {
                DialogResult result = MessageBox.Show($"هل تريد حذف {CustAndVend.Name} ؟", "حذف", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        db.CustAndVends.Remove(db.CustAndVends.Find(CustAndVend.ID));
                        db.SaveChanges();
                        Util.CustAndVends.Remove(CustAndVend);
                        dgvCustAndVend.DataSource = Util.CustAndVends.Where(t => t.PartType == type).ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("اختر احد المتعاملين لحذفه", "تنبيه", MessageBoxButtons.OK);
            }
        }

        private void dgvCustAndVend_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCustAndVend.CurrentRow != null)
            {
                ID = (int)dgvCustAndVend.CurrentRow.Cells[0].Value;
                if (Application.OpenForms[nameof(FrmInvoice)] != null) 
                {
                    ((FrmInvoice)Application.OpenForms[nameof(FrmInvoice)]).CustomerID = ID;
                    this.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
                dgvCustAndVend.DataSource = Util.CustAndVends.Where(t => t.PartType == type && t.Name.Contains(textBox1.Text)).ToList();
        }

        private void dgvCustAndVend_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustAndVend.SelectedRows.Count > 0) 
            {
                CustAndVend = dgvCustAndVend.SelectedRows[0].DataBoundItem as CustAndVend;
            }            
        }
    }
}
