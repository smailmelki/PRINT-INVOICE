using PRINT_INVOICE.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRINT_INVOICE
{
    public partial class FrmFactList : Form
    {
        DBContext db= new DBContext();
        public FrmFactList()
        {
            InitializeComponent();
        }

        List<dataType> query;
        List<dataType> FillDgv()
        {
            query = (from hed in db.Invoice_Header
                    from cust in db.CustAndVends.
                    Where(x => x.ID == hed.Customer_ID).
                    DefaultIfEmpty()
                    select new dataType
                    {
                        ID = hed.ID,
                        Nu = hed.Invoice_Nu,
                        Net = hed.Invoice_Net,
                        Paid = hed.Invoice_Paid,
                        Remain = hed.Invoice_remain,
                        Name = cust.Name,
                        Type = hed.Invoice_Type,
                        Date = hed.Invoice_Date
                    }).ToList();
            return query;
        }

        private void FrmFactList_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new List<InvoiceType>()
            {
                InvoiceType.Sales,
                InvoiceType.purchase,
            };

            query = FillDgv();
            DgvFactList.DataSource = query.Where(t => t.Type == (InvoiceType)comboBox1.SelectedIndex).ToList();
            DgvFactList.Columns["ID"].Visible = false;
            DgvFactList.Columns["Type"].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (query != null)
                DgvFactList.DataSource = query.Where(t => t.Type == (InvoiceType)comboBox1.SelectedIndex).ToList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DgvFactList.SelectedRows[0].Cells["ID"].Value);
            FrmInvoice frm = new FrmInvoice(id);
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var contexte = new DBContext())
            {
                if (DgvFactList.SelectedRows.Count >= 0)
                {
                    var result = MessageBox.Show("هل انت متأكد من حذف هذه الفاتورة", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(DgvFactList.SelectedRows[0].Cells["ID"].Value);
                        using (var transaction = contexte.Database.BeginTransaction())
                        {
                            try
                            {
                                var invoiceDet = contexte.Invoice_Det.Where(d => d.InvoiceID == id);
                                if (invoiceDet.Any())
                                    contexte.Invoice_Det.RemoveRange(invoiceDet);
                                var invoice = contexte.Invoice_Header.SingleOrDefault(h => h.ID == id);
                                if (invoice != null)
                                    contexte.Invoice_Header.Remove(invoice);
                                contexte.SaveChanges();
                                /////////////////////////////////
                                query.Remove(query.Where(r => r.ID == id).SingleOrDefault());
                                DgvFactList.DataSource = query.Where(t => t.Type == (InvoiceType)comboBox1.SelectedIndex).ToList();
                                /////////////////////////////////
                                transaction.Commit();
                                MessageBox.Show("تم حذف الفاتورة المحددة بنجاح", "حذف", MessageBoxButtons.OK);
                            }
                            catch (Exception)
                            {
                                transaction.Rollback();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("اختر فاتورة لحذفها", "خطأ", MessageBoxButtons.OK);
                }
            }
        }

    }
    class dataType
    {
        public int ID { get; set; }
        public string Nu { get; set; }
        public decimal Net { get; set; }
        public decimal Paid { get; set; }
        public decimal Remain { get; set; }
        public string Name { get; set; }
        public InvoiceType Type { get; set; }
        public DateTime Date { get; set; }
    }
}
