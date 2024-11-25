using PRINT_INVOICE.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PRINT_INVOICE
{
    public partial class FrmFactList : Form
    {
        private List<dataType> query;
        DBContext db= new DBContext();
        public FrmFactList()
        {
            InitializeComponent();
        }

        private void FrmFactList_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new List<InvoiceType>() { InvoiceType.Sales, InvoiceType.purchase, };
            InitializeTreeGridView();
        }

        // إعداد DataGridView لعرض الشجرة
        private void InitializeTreeGridView()
        {
            // إعدادات عامة للـ DataGridView
            DgvFactList.AllowUserToAddRows = false; // منع إضافة صفوف يدويًا
            DgvFactList.RowHeadersVisible = false; // إخفاء الأعمدة الجانبية
            DgvFactList.AllowUserToResizeRows = false; // منع تغيير حجم الصفوف
            DgvFactList.EditMode = DataGridViewEditMode.EditProgrammatically; // منع التحرير اليدوي
            DgvFactList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // ملء الأعمدة تلقائيًا

            // إنشاء أعمدة DataGridView
            DgvFactList.Columns.Clear();
            // عمود لعرض أسماء الشاشات
            DgvFactList.Columns.Add("ID", "ID");
            DgvFactList.Columns.Add("Nu", "الرقم");
            DgvFactList.Columns.Add("Net", "الصافي");
            DgvFactList.Columns.Add("Paid", "المدفوع");
            DgvFactList.Columns.Add("Remain", "المتبقي");
            DgvFactList.Columns.Add("Name", "الاسم");
            DgvFactList.Columns.Add("Type", "النوع");
            DgvFactList.Columns.Add("Date", "التاريخ");
            DgvFactList.Columns.Add("Total", "المجموع");
            DgvFactList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // ضبط محاذاة النص
            DgvFactList.Columns[0].Visible = false;

            // تحميل البيانات الأولية للشجرة
            FillDgv();
            PopulateTreeData(query.Where(t => t.Type == (InvoiceType)comboBox1.SelectedItem).ToList());
        }

        // ملء الشجرة بالبيانات
        private void PopulateTreeData(List<dataType> data)
        {
            // تفريغ الصفوف الحالية
            DgvFactList.Rows.Clear();

            // إضافة العقد الرئيسية للشجرة
            foreach (var node in data)
            {
                AddHeaderNode(node);
            }
        }

        private void AddHeaderNode(dataType node)
        {
            // إنشاء صف جديد
            int rowIndex = DgvFactList.Rows.Add(node.ID, node.Nu, node.Net, node.Paid, node.Remain, node.Name, node.Type, node.Date.ToString("dd-MM-yyyy"), node.Total);
            DgvFactList.Rows[rowIndex].DefaultCellStyle.BackColor = rowIndex % 2 == 1 ? Color.WhiteSmoke : Color.LightGray;
            DgvFactList.Rows[rowIndex].DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold); // تغيير الخط للعقد الرئيسية
            var row = DgvFactList.Rows[rowIndex];
            row.Tag = node; // تخزين بيانات العقدة في الصف
        }


        void FillDgv()
        {
            var headers = (from hed in db.Invoice_Header
                           from cust in db.CustAndVends
                               .Where(x => x.ID == hed.Customer_ID).DefaultIfEmpty()
                           select new
                           {
                               ID = hed.ID,
                               Nu = hed.Invoice_Nu,
                               Date = hed.Invoice_Date,
                               Name = cust.Name,
                               Total = hed.Invoice_Total,
                               Discount = hed.Invoice_Discount,
                               Tax = hed.Invoice_Tax,
                               Net = hed.Invoice_Net,
                               Paid = hed.Invoice_Paid,
                               Remain = hed.Invoice_remain,
                               Type = hed.Invoice_Type,
                               Note = hed.invoice_Note,
                           }).ToList();

            var details = (from d in db.Invoice_Det
                           from p in db.products
                               .Where(x => x.code == d.Item_Code).DefaultIfEmpty()
                           select new
                           {
                               d.ID,
                               p.productName,
                               d.Item_Qty,
                               d.Item_Price,
                               d.total_Price,
                               d.InvoiceID,
                           }).ToList();

            // ربط البيانات
            query = headers.Select(h => 
                         new dataType
            {
                ID = h.ID,
                Nu = h.Nu,
                Date = h.Date,
                Name = h.Name,
                Total= h.Total,
                Discount = h.Discount,
                Tax = h.Tax,
                Net = h.Net,
                Paid = h.Paid,
                Remain = h.Remain,
                Type = h.Type,
                Note = h.Note,
                Details = details.Where(d => d.InvoiceID == h.ID).Select(d => 
                          new Details
                {
                    Item_Code = d.productName,
                    Item_Qty = d.Item_Qty,
                    Item_Price = d.Item_Price,
                    total_Price = d.total_Price
                }).ToList(),
            }).ToList();

            headers.Clear();
            details.Clear();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (query != null)
            {
                var filteredData = query.Where(t => t.Type == (InvoiceType)comboBox1.SelectedItem).ToList();
                PopulateTreeData(filteredData);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DgvFactList.SelectedRows[0].Cells[0].Value);
            if (IsHeader())
            {
                FrmInvoice frm = new FrmInvoice(id);
                frm.Show();
            }
            else
            {
                MessageBox.Show("اختر رأس الفاتورة لتعديلها", "خطأ", MessageBoxButtons.OK);
            }
        }

        private bool IsHeader()
        {
            if (DgvFactList.SelectedRows[0].Tag != null)
                return true;
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var contexte = new DBContext())
            {
                if (DgvFactList.SelectedRows.Count >= 0 && IsHeader())
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
                                int index = DgvFactList.SelectedRows[0].Index;

                                for (int i = index + ((dataType)DgvFactList.SelectedRows[0].Tag).Details.Count + 1; i >= index; i--)
                                    DgvFactList.Rows.RemoveAt(i);

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
                    MessageBox.Show("اختر رأس الفاتورة لحذفها", "خطأ", MessageBoxButtons.OK);
                }
            }
        }

        private void DgvFactList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1) // النقر على العمود المخصص للتوسيع
            {
                var row = DgvFactList.Rows[e.RowIndex];
                var node = row.Tag as dataType;

                if (node != null && node.Details != null)
                {
                    node.IsExpanded = !node.IsExpanded;

                    if (node.IsExpanded)
                    {
                        DgvFactList.Rows.Insert(e.RowIndex + 1, null, null, null, null, "Item", "Qty", "Price", "SupTotal");
                        DgvFactList.Rows[e.RowIndex + 1].DefaultCellStyle.BackColor = Color.LightGreen;
                        DgvFactList.Rows[e.RowIndex + 1].DefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Bold); // تغيير الخط للعقد الرئيسية

                        // أضف الصفوف الفرعية للعقدة
                        foreach (var child in node.Details)
                        {
                            AddDetailNode(child, e.RowIndex + 2);
                        }
                    }
                    else
                    {
                        // احذف الصفوف الفرعية
                        for (int i = e.RowIndex + node.Details.Count + 1; i > e.RowIndex; i--)
                        {
                            DgvFactList.Rows.RemoveAt(i);
                        }
                    }
                }
            }
        }
        // إضافة عقدة فرعية (Detailes) إلى DataGridView
        private void AddDetailNode(Details node, int insertIndex)
        {
            DgvFactList.Rows.Insert(insertIndex, null, null, null, null, node.Item_Code, node.Item_Qty, node.Item_Price, node.total_Price);
            DgvFactList.Rows[insertIndex].DefaultCellStyle.BackColor = Color.White;
        }
    }
    class dataType 
    {
        public bool IsExpanded { get; set; } = false; // حالة التوسيع
        public int ID { get; set; }
        public string Nu { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal Net { get; set; }
        public decimal Paid { get; set; }
        public decimal Remain { get; set; }
        public InvoiceType Type { get; set; }
        public string Note { get; set; }
        public List<Details> Details { get; set; }
    }
    class Details
    {
        public string Item_Code { get; set; }
        public int Item_Qty { get; set; }
        public decimal Item_Price { get; set; }
        public decimal total_Price { get; set; }
    }
}
